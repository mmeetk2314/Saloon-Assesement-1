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

namespace Saloon_Assesement_1.Pages.Parlours
{
    public class EditModel : PageModel
    {
        private readonly Saloon_Assesement_1.Data.Saloon_Assesement_1Context _context;

        public EditModel(Saloon_Assesement_1.Data.Saloon_Assesement_1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Parlour Parlour { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Parlour = await _context.Parlour.FirstOrDefaultAsync(m => m.Parlour_ID == id);

            if (Parlour == null)
            {
                return NotFound();
            }
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

            _context.Attach(Parlour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ParlourExists(Parlour.Parlour_ID))
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

        private bool ParlourExists(int id)
        {
            return _context.Parlour.Any(e => e.Parlour_ID == id);
        }
    }
}
