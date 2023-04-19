using iOrder.Data;
using iOrder.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.Elfie.Diagnostics;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace iOrder.Pages
{
    public class foodPageModel : PageModel
    {
        private readonly iOrder.Models.IOrderDbContext _context;

        public foodPageModel(iOrder.Models.IOrderDbContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Restaurants != null)
            {
                // Only want specific data, so selecting only name, phonenumber, and address
                Restaurant = await _context.Restaurants.Select(p => new Restaurant
                {
                    RestaurantId = p.RestaurantId,
                    Image = p.Image,
                    Name = p.Name,
                    PhoneNumber = p.PhoneNumber,
                    Address = p.Address
                    // should also add a condition to see if the res. is open for today!
                }).Where(p => p.PhoneNumber.Contains("934")).ToListAsync();
            }
        }
    }
}
