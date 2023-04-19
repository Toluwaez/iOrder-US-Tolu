using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using iOrder.Models;
using System.Security.Principal;
using Microsoft.EntityFrameworkCore;

namespace iOrder.Pages.Menus
{
    public class CreateModel : PageModel
    {
        private readonly iOrder.Models.IOrderDbContext _context;

        public CreateModel(iOrder.Models.IOrderDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Menu Menu { get; set; } = new Menu();
        public SelectList Restaurants { get; set; }
        public int RestaurantID { get; set; } = -1;

        public async Task<IActionResult> OnGetAsync()
        {
            await SetRestaurantIDAsync();
            ViewData["PREFAB"] = RestaurantID >= 0;
            if (Convert.ToBoolean(ViewData["PREFAB"]))
            {
                Restaurants = new SelectList(await _context.Restaurants.Where(r => r.RestaurantId == RestaurantID).ToListAsync(), "RestaurantId", "Name", "RestaurantId");
            }
            else
            {
                Restaurants = new SelectList(await _context.Restaurants.ToListAsync(), "RestaurantId", "Name");
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await SetRestaurantIDAsync();
            try
            {
                if (RestaurantID >= 0)
                {
                    Menu.RestaurantId = RestaurantID;
                }
                // Add the menu object to the context and save changes
                _context.Menus.Add(Menu);
                await _context.SaveChangesAsync();

                return RedirectToPage("./Index");
            }
            catch (Exception ex)
            {
                // Log exception details
                Console.Error.WriteLine($"Exception: {ex.Message}");
                Console.Error.WriteLine(ex.StackTrace);
                return Page();
            }
        }

        private async Task SetRestaurantIDAsync()
        {
            if (int.TryParse(Request.Query["RestaurantID"], out int restaurantId) && restaurantId >= 0)
            {
                RestaurantID = restaurantId;
            }
        }
    }
}