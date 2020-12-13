using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Saloon_Assesement_1.Data;
using Saloon_Assesement_1.Models;

namespace Saloon_Assesement_1.Pages.Beauticians
{
    public class DeleteModel : PageModel
    {
        private readonly Saloon_Assesement_1.Data.Saloon_Assesement_1Context _context;

        public DeleteModel(Saloon_Assesement_1.Data.Saloon_Assesement_1Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Beautician Beautician { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Beautician = await _context.Beautician
                .Include(b => b.Parlour_obj).FirstOrDefaultAsync(m => m.Beautician_ID == id);

            if (Beautician == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Beautician = await _context.Beautician.FindAsync(id);

            if (Beautician != null)
            {
                _context.Beautician.Remove(Beautician);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
