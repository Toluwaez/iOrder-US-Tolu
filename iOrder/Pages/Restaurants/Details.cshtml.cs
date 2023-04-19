using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using iOrder.Models;
using NuGet.Packaging;

namespace iOrder.Pages.Restaurants
{
    public class DetailsModel : PageModel
    {
        private readonly iOrder.Models.IOrderDbContext _context;

        public DetailsModel(iOrder.Models.IOrderDbContext context)
        {
            _context = context;
        }

        public Restaurant Restaurant { get; set; } = default!;
        public IList<Menu> Menus { get; set; } = default!;
        public IList<MenuItem> MenuItems { get; set; } = new List<MenuItem>();
        public IList<Item> Items { get; set; } = new List<Item>();

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Restaurants == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurants.FirstOrDefaultAsync(m => m.RestaurantId == id);
            var menus = await (from m in _context.Menus
                               join r in _context.Restaurants
                               on m.RestaurantId equals r.RestaurantId
                               where m.RestaurantId == id // add filter to retrieve only the menus for a specific restaurant
                               select new Menu
                               {
                                   MenuId = m.MenuId,
                                   Name = m.Name
                               }).ToListAsync();

            foreach (var menu in menus)
            {
                var menuItems = await _context.MenuItems.Where(m => m.MenuId == menu.MenuId).ToListAsync();
                MenuItems.AddRange(menuItems); // addrange to allow for the whole List to be added

                foreach (var menuItem in menuItems)
                {
                    var items = await _context.Items.Where(i => i.ItemId == menuItem.ItemId).ToListAsync();
                    Items.AddRange(items);
                }
            }

            if (restaurant == null)
            {
                return NotFound();
            }
            else 
            {
                Restaurant = restaurant;
                Menus = menus;
            }
            return Page();
        }
    }
}
