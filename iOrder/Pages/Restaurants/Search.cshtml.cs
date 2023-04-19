using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using iOrder.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace iOrder.Pages.Restaurants
{
    public class SearchModel : PageModel
    {
        private readonly iOrder.Models.IOrderDbContext _context;

        public SearchModel(iOrder.Models.IOrderDbContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(String? Filter, String? Keyword)
        {
            if (_context.Restaurants == null)
            {
                return NotFound();
            }

            IQueryable<Restaurant> restaurantsQuery = _context.Restaurants.AsQueryable();

            if (!string.IsNullOrEmpty(Filter) && !string.IsNullOrEmpty(Keyword))
            {
                switch (Filter.ToLower())
                {
                    case "name":
                        restaurantsQuery = restaurantsQuery.Where(r => r.Name.Contains(Keyword));
                        break;
                    case "address":
                        restaurantsQuery = restaurantsQuery.Where(r => r.Address.Contains(Keyword));
                        break;
                    //case "price":
                    //    restaurantsQuery = restaurantsQuery.Where(r => r.Price.Contains(Keyword));
                    //    break;
                    //case "category":
                    //    restaurantsQuery = restaurantsQuery.Where(r => r.Category.Contains(Keyword));
                    //    break;
                    default:
                        break;
                }
            }

            Restaurant = await restaurantsQuery.ToListAsync();

            ViewData["Filter"] = Filter;
            ViewData["Keyword"] = Keyword;

            if (Restaurant == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
