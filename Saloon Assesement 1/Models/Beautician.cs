using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Saloon_Assesement_1.Models
{
    public class Beautician
    {       
        [Key]

        public int Beautician_ID { get; set; }
        public string Beautician_Name { get; set; }
        public int Contact_Number { get; set; }
        [DataType(DataType.Date)]
        public DateTime Joining_Date { get; set; }
        public int Salary { get; set; }
        //Foreign Key
        public int ParlourID { get; set; }
        public Parlour Parlour_obj { get; set; }
    }
}
