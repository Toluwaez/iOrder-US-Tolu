using iOrder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace iOrder.Pages.Items
{
    public class CreateModel : PageModel
    {
        private readonly iOrder.Models.IOrderDbContext _context;

        public CreateModel(iOrder.Models.IOrderDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            if (int.TryParse(Request.Query["RestaurantID"], out int restaurantId)
                && int.TryParse(Request.Query["MenuID"], out int menuId))
            {
                ViewData["PREFAB"] = true; // render JS from this var, here to help allow simplicity for item creation
                Restaurants = new SelectList(await _context.Restaurants.Where(r => r.RestaurantId == restaurantId).ToListAsync(), "RestaurantId", "Name", "RestaurantId");
                Menus = new SelectList(await _context.Menus.Where(m => m.MenuId == menuId && m.RestaurantId == restaurantId).ToListAsync(), "MenuId", "Name");
                this.MenuID = menuId;
            }
            else
            {
                ViewData["PREFAB"] = false;
                Restaurants = new SelectList(await _context.Restaurants.ToListAsync(), "RestaurantId", "Name");
                Menus = new SelectList(new List<SelectListItem>(), "MenuId", "Name");
            }

            return Page();
        }

        public JsonResult OnGetMenus(int restaurantId)
        {
            Menus = new SelectList(_context.Menus.Where(m => m.RestaurantId == restaurantId), "MenuId", "Name");

            return new JsonResult(Menus);
        }

        [BindProperty]
        public Item Item { get; set; } = new Item();
        public SelectList Restaurants { get; set; }
        public SelectList Menus { get; set; }
        public Restaurant Restaurant { get; set; }  
        [BindProperty]
        public Menu Menu { get; set; }
        [BindProperty]
        public int MenuID { get; set; }
        [BindProperty]
        public MenuItem MenuItem { get; set; } = new MenuItem();

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (Menu == null)
            {
                return Page();
            }

            _context.Items.Add(Item);
            await _context.SaveChangesAsync();

            // add menu item to db after item creation, normalization
            MenuItem = new MenuItem
            {
                ItemId = Item.ItemId,
                MenuId = Menu.MenuId
            };

            _context.MenuItems.Add(MenuItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}