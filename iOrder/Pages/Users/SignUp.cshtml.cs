using iOrder.Migrations.iOrderUser;
using iOrder.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace iOrder.Pages.Users
{
    public class SignUpModel : PageModel
    {
        private readonly IOrderDbContext _context;

        public SignUpModel(IOrderDbContext context)
        {
            _context = context;
        }

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
            // Get form data
            string firstName = Request.Form["first_name"];
            string lastName = Request.Form["last_name"];
            string password = Request.Form["password"];
            string username = Request.Form["username"];

            // Generate salt and hash password
            string salt = GenerateSalt();
            string hashedPassword = HashPassword(password, salt);

            if (username == null || firstName == null || lastName == null)
            {
                return Page();
            }

            // Create new user
            var newUser = new Models.User
            {
                Username = username,
                FirstName = firstName,
                LastName = lastName,
                Salt = salt,
                Password = hashedPassword,
                LastLogged = DateTime.UtcNow,
                Role = 1 // 1 : customer, 2 : admin, 3 : res. owner
            };

            // Add new user to database
            _context.Users.Add(newUser);
            await _context.SaveChangesAsync();

            // Create a session ID or Bearer token containing the user's username and role
            string sessionID = $"{newUser.Username}:{newUser.Role}";

            // Set a session cookie with the session ID or Bearer token and expiration date
            Response.Cookies.Append("sessionID", sessionID, new CookieOptions { Expires = DateTimeOffset.Now.AddDays(7) });

            // Create user claims
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, newUser.UserId.ToString()),
                new Claim(ClaimTypes.Name, newUser.Username),
                new Claim(ClaimTypes.Role, newUser.Role.ToString())
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            // Sign in user
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            // Redirect to index page
            return RedirectToPage("/Index");
        }

        private string GenerateSalt()
        {
            byte[] salt = new byte[16];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }
            return Convert.ToBase64String(salt);
        }

        private string HashPassword(string password, string salt)
        {
            byte[] saltBytes = Convert.FromBase64String(salt);
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 10000, HashAlgorithmName.SHA256))
            {
                return Convert.ToBase64String(pbkdf2.GetBytes(32));
            }
        }
    }
}