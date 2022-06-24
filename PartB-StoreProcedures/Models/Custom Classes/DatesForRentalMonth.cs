using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB_StoreProcedures.Models.Custom_Classes
{
    public class DatesForRentalMonth
    {
        [Key]
       public int Month { get; set; }
       public int Year { get; set; }
       public decimal TotalRental { get; set; }
    }
}
