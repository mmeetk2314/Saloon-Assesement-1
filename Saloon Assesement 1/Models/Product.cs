using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Saloon_Assesement_1.Models
{
    public class Product
    {
        [Key]
        public int Product_ID { get; set; }
        public string Product_Name { get; set; }
        [DataType(DataType.Date)]
        public DateTime Expiry_Date { get; set; }
        //Foreign Key
        public int ParlourID { get; set; }
        public Parlour Parlour_obj { get; set; }

    }
}
