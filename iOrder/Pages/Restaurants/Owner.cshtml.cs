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
    public class OwnerModel : PageModel
    {
        private readonly iOrder.Models.IOrderDbContext _context;

        public OwnerModel(iOrder.Models.IOrderDbContext context)
        {
            _context = context;
        }

        public IList<Restaurant> Restaurant { get; set; } = default!;
        public IList<User> Users { get; set; } = default!;
        public IList<Owner> Owners { get; set; }

        public async Task OnGetAsync()
        {
            if (_context.Restaurants != null && _context.Users != null)
            {
                Owners = await (from u in _context.Users
                        join e in _context.Restaurants
                        on u.UserId equals e.UserId
                        where u.Role == 3
                        select new Owner {
                            UserId = u.UserId,
                            FirstName = u.FirstName,
                            LastName = u.LastName,
                            Name = e.Name,
                            RestaurantId = e.RestaurantId
                        }).ToListAsync();
            }
        }
    }
}