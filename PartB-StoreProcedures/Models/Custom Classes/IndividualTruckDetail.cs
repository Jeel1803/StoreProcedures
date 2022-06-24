using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB_StoreProcedures.Models.Custom_Classes
{
    public class IndividualTruckDetail
    {
        [Key]
        public int TruckID { get; set; }
        public string Colour { get; set; }
        public string RegistrationNumber { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string FuelType { get; set; } = null!;
        public string Transmission { get; set; } = null!;
        public int Times_Rented { get; set; }

    }
}
