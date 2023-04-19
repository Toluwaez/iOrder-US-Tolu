using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using iOrder.Models;

namespace iOrder.Pages.Menus
{
    public class IndexModel : PageModel
    {
        private readonly iOrder.Models.IOrderDbContext _context;

        public IndexModel(iOrder.Models.IOrderDbContext context)
        {
            _context = context;
        }

        public IList<Menu> Menu { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Menus != null)
            {
                Menu = await _context.Menus
                .Include(m => m.Restaurant).ToListAsync();
            }
        }
    }
}
