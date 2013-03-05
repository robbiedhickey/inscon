using System;
using System.Collections.Generic;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class Exterior
    {
        public int WorkOrderID { get; set; }
        public Nullable<int> ConstructionTypeID { get; set; }
        public Nullable<int> BuildingTypeID { get; set; }
        public Nullable<int> StoriesID { get; set; }
        public Nullable<int> PrimaryColorID { get; set; }
        public Nullable<int> RoofTypeID { get; set; }
        public Nullable<int> PoolOnSiteID { get; set; }
        public Nullable<int> PoolSecuredID { get; set; }
        public Nullable<int> PoolDrainedID { get; set; }
        public Nullable<int> DoorTagStatusID { get; set; }
        public Nullable<bool> ContactMade { get; set; }
        public Nullable<int> OccupancyID { get; set; }
        public Nullable<int> OccupancyVerifiedByID { get; set; }
        public Nullable<int> PropertyConditionID { get; set; }
        public Nullable<int> NeighborhoodConditionID { get; set; }
        public Nullable<int> EMVID { get; set; }
        public Nullable<int> ElectricID { get; set; }
        public Nullable<int> WaterID { get; set; }
        public Nullable<int> GasID { get; set; }
        public Nullable<int> PersonalPropertyOnSiteID { get; set; }
        public Nullable<int> IsWinterizedID { get; set; }
        public Nullable<int> WinterizedByID { get; set; }
        public Nullable<System.DateTime> WinterizedDate { get; set; }
        public string HowLongVacant { get; set; }
        public Nullable<int> HazardsExist { get; set; }
        public string PersonInterviewed { get; set; }
        public string ManagingCompany { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
