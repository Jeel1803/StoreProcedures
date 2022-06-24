﻿using System;
using System.Collections.Generic;

namespace PartB_StoreProcedures.Models.DB
{
    public partial class TruckFeature
    {
        public TruckFeature()
        {
            Trucks = new HashSet<IndividualTruck>();
        }

        public int FeatureId { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<IndividualTruck> Trucks { get; set; }
    }
}
