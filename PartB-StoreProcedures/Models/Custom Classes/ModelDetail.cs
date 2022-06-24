using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB_StoreProcedures.Models
{
    public class ModelDetail
    {
        [Key]
        public int TruckModelID { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string Size { get; set; }
        public int Seats { get; set; }
        public int Doors { get; set; }
        public int Times_Rented { get; set; }
    }
}
