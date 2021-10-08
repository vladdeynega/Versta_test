using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Versta_test.Context;
using Versta_test.Data.Models;

namespace Versta_test.Pages
{
    public class CreateModel : PageModel
    {
        private readonly Versta_test.Context.MyDbContext _context;

        public CreateModel(Versta_test.Context.MyDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {;
            return Page();
        }

        public int LastId()
        {
            return _context.Orders.OrderBy(x => x.id).Last().id + 1;
        }

        [BindProperty]
        public Order Order { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Orders.Add(Order);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
