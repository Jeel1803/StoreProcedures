using System;
using System.Collections.Generic;

namespace PartB_StoreProcedures.Models.DB
{
    public partial class TruckPersonPb
    {
        public int PersonId { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Telephone { get; set; } = null!;
    }
}
