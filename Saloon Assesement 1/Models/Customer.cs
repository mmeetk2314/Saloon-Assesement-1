using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Saloon_Assesement_1.Models
{
    public class Customer
    {
        [Key]
        public int Customer_ID { get; set; }
        public string Customer_Name { get; set; }
        public int Contact_Number { get; set; }
        public int Expenses { get; set; }
        //Foreign Key
        public int ParlourID { get; set; }
        public Parlour Parlour_obj { get; set; }

    }
}
