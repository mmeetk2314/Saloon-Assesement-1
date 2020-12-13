using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Saloon_Assesement_1.Models
{
    public class Parlour
    {
        [Key]
        public int Parlour_ID { get; set; }
        public string Parlour_Name { get; set; }
        public string Parlour_Address { get; set; }
        public int Contact_Number { get; set; }
    }
}
