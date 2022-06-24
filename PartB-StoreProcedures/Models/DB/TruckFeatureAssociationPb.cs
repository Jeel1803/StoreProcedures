using System;
using System.Collections.Generic;

namespace PartB_StoreProcedures.Models.DB
{
    public partial class TruckFeatureAssociationPb
    {
        public int TruckId { get; set; }
        public int FeatureId { get; set; }
    }
}
