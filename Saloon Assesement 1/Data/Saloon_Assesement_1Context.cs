using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Saloon_Assesement_1.Models;

namespace Saloon_Assesement_1.Data
{
    public class Saloon_Assesement_1Context : DbContext
    {
        public Saloon_Assesement_1Context (DbContextOptions<Saloon_Assesement_1Context> options)
            : base(options)
        {
        }

        public DbSet<Saloon_Assesement_1.Models.Parlour> Parlour { get; set; }

        public DbSet<Saloon_Assesement_1.Models.Beautician> Beautician { get; set; }

        public DbSet<Saloon_Assesement_1.Models.Customer> Customer { get; set; }

        public DbSet<Saloon_Assesement_1.Models.Product> Product { get; set; }
    }
}
