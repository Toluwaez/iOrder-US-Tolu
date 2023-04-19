using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using iOrder.Models;

namespace iOrder.Pages
{
    public class IndexModel : PageModel
    {
        private readonly iOrder.Models.IOrderDbContext _context;

        public IndexModel(iOrder.Models.IOrderDbContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get; set; } = default!;
        public List<SelectListItem> statusdropdownlistdata { get; set;}

        [BindProperty(SupportsGet = true)]
        public string? Keyword { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? Filter { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            // Get the form data
            var formData = await Request.ReadFormAsync();

            // Update the model with the filter value
            Filter = formData["Filter"];
            Keyword = formData["Keyword"];

            // Redirect to the search results page with the filter and keyword in the URL
            return RedirectToPage("/Restaurants/Search", new { Filter = Filter, Keyword = Keyword });
        }

        public async Task OnGetAsync()
        {
            if (_context.Restaurants != null)
            {
                // Only want specific data, so selecting only name, phonenumber, and address
                Restaurant = await _context.Restaurants.Select(p => new Restaurant{ 
                    RestaurantId = p.RestaurantId,
                     Image = p.Image,
                    Name = p.Name,
                    PhoneNumber = p.PhoneNumber,
                    Address = p.Address
                    // should also add a condition to see if the res. is open for today!
                }).Where(p => p.PhoneNumber.Contains("934")).ToListAsync();
            }
            // 4 search possibilites, create list and append to html via traversal
            List<SelectListItem> dp = new List<SelectListItem>();
            
            SelectListItem one = new SelectListItem("Name", "name", true);
            SelectListItem two = new SelectListItem("Location", "address", false);
            SelectListItem three = new SelectListItem("Price", "price", false, true);
            SelectListItem four = new SelectListItem("Food", "food", false, true);
            SelectListItem five = new SelectListItem("Rating", "rating", false, true);


            dp.Add(one);
            dp.Add(two);
            dp.Add(three);
            dp.Add(four);
            dp.Add(five);

            this.statusdropdownlistdata = dp;
        }
    }
}