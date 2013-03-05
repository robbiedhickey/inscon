using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class PropertyDamage
    {
        public int WorkOrderID { get; set; }
        public Nullable<bool> Vandalized { get; set; }
        public Nullable<bool> FireDamage { get; set; }
        public Nullable<bool> LiabilityHazard { get; set; }
        public Nullable<bool> StormDamage { get; set; }
        public Nullable<bool> FloodDamage { get; set; }
        public Nullable<bool> FreezeDamage { get; set; }
        public Nullable<bool> RoofLeak { get; set; }
        public Nullable<bool> Neglected { get; set; }
        public Nullable<bool> EarthquakeDamage { get; set; }
        public Nullable<bool> CityViolation { get; set; }
        public Nullable<bool> Mold { get; set; }
        public Nullable<bool> BrokenWindows { get; set; }
        public Nullable<bool> BurstPipes { get; set; }
        public Nullable<bool> StructuralDamage { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
