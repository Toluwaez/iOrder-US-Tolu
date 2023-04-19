using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using iOrder.Models;

namespace iOrder.Pages.Restaurants
{
    public class HomeModel : PageModel
    {
        private readonly iOrder.Models.IOrderDbContext _context;

        public HomeModel(iOrder.Models.IOrderDbContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Restaurants != null)
            {
                Restaurant = await _context.Restaurants.ToListAsync();
            }
        }
    }
}