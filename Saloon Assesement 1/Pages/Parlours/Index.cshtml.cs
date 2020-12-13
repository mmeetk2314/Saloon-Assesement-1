using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Saloon_Assesement_1.Data;
using Saloon_Assesement_1.Models;

namespace Saloon_Assesement_1.Pages.Parlours
{
    public class IndexModel : PageModel
    {
        private readonly Saloon_Assesement_1.Data.Saloon_Assesement_1Context _context;

        public IndexModel(Saloon_Assesement_1.Data.Saloon_Assesement_1Context context)
        {
            _context = context;
        }

        public IList<Parlour> Parlour { get;set; }

        public async Task OnGetAsync()
        {
            Parlour = await _context.Parlour.ToListAsync();
        }
    }
}
