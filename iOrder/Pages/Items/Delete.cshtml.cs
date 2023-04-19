﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using iOrder.Models;

namespace iOrder.Pages.Items
{
    public class DeleteModel : PageModel
    {
        private readonly iOrder.Models.IOrderDbContext _context;

        public DeleteModel(iOrder.Models.IOrderDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Item Item { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Items == null)
            {
                return NotFound();
            }

            var item = await _context.Items.FirstOrDefaultAsync(m => m.ItemId == id);

            if (item == null)
            {
                return NotFound();
            }
            else 
            {
                Item = item;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Items == null)
            {
                return NotFound();
            }
            var item = await _context.Items.FindAsync(id);

            if (item != null)
            {
                Item = item;
                _context.Items.Remove(Item);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
