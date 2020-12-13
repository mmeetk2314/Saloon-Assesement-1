using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Saloon_Assesement_1.Data;
using Saloon_Assesement_1.Models;

namespace Saloon_Assesement_1.Pages.Products
{
    public class EditModel : PageModel
    {
        private readonly Saloon_Assesement_1.Data.Saloon_Assesement_1Context _context;

        public EditModel(Saloon_Assesement_1.Data.Saloon_Assesement_1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Product Product { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Product = await _context.Product
                .Include(p => p.Parlour_obj).FirstOrDefaultAsync(m => m.Product_ID == id);

            if (Product == null)
            {
                return NotFound();
            }
           ViewData["ParlourID"] = new SelectList(_context.Parlour, "Parlour_ID", "Parlour_ID");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(Product.Product_ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProductExists(int id)
        {
            return _context.Product.Any(e => e.Product_ID == id);
        }
    }
}
