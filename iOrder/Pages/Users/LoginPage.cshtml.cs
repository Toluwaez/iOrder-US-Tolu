using iOrder.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace iOrder.Pages.Users
{
    public class LoginPageModel : PageModel
    {
        private readonly ILogger<LoginPageModel> _logger;
        private readonly IOrderDbContext _context;

        public LoginPageModel(ILogger<LoginPageModel> logger, IOrderDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            // Check if the user has been there before by looking for a cookie
            if (Request.Cookies["sessionID"] != null)
            {
                // Redirect the user to the home page if they have already logged in before
                return RedirectToPage("../Index");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {

            // Get user from database
            var user = await _context.Users.SingleOrDefaultAsync(u => u.Username == Username);

            // Validate user credentials
            if (user == null || VerifyPassword(Password, user.Password, user.Salt) == false)
            {
                ModelState.AddModelError("", "Invalid username or password");
                return Page();
            }

            // Create a session ID or Bearer token containing the user's username and role
            string sessionID = $"{user.Username}:{user.Role}";

            // Set a session cookie with the session ID or Bearer token and expiration date
            Response.Cookies.Append("sessionID", sessionID, new CookieOptions { Expires = DateTimeOffset.Now.AddDays(7) });

            // Create user claims
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Role, user.Role.ToString())
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            // Sign in user
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            // Redirect the user to the home page
            return RedirectToPage("../Index");
        }

        private bool VerifyPassword(string password, string hashedPassword, string salt)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 10000, HashAlgorithmName.SHA256))
            {
                byte[] hashBytes = pbkdf2.GetBytes(32);
                string hashString = Convert.ToBase64String(hashBytes);
                return hashString == hashedPassword;
            }
        }
    }
}