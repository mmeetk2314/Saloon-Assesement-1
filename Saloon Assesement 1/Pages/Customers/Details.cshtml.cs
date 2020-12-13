using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Saloon_Assesement_1.Data;
using Saloon_Assesement_1.Models;

namespace Saloon_Assesement_1.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        private readonly Saloon_Assesement_1.Data.Saloon_Assesement_1Context _context;

        public DetailsModel(Saloon_Assesement_1.Data.Saloon_Assesement_1Context context)
        {
            _context = context;
        }

        public Customer Customer { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Customer = await _context.Customer
                .Include(c => c.Parlour_obj).FirstOrDefaultAsync(m => m.Customer_ID == id);

            if (Customer == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
