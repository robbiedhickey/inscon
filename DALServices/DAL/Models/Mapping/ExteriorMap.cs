using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class ExteriorMap : EntityTypeConfiguration<Exterior>
    {
        public ExteriorMap()
        {
            // Primary Key
            this.HasKey(t => t.WorkOrderID);

            // Properties
            this.Property(t => t.WorkOrderID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HowLongVacant)
                .HasMaxLength(15);

            this.Property(t => t.PersonInterviewed)
                .HasMaxLength(30);

            this.Property(t => t.ManagingCompany)
                .HasMaxLength(36);

            // Table & Column Mappings
            this.ToTable("Exterior", "inspection");
            this.Property(t => t.WorkOrderID).HasColumnName("WorkOrderID");
            this.Property(t => t.ConstructionTypeID).HasColumnName("ConstructionTypeID");
            this.Property(t => t.BuildingTypeID).HasColumnName("BuildingTypeID");
            this.Property(t => t.StoriesID).HasColumnName("StoriesID");
            this.Property(t => t.PrimaryColorID).HasColumnName("PrimaryColorID");
            this.Property(t => t.RoofTypeID).HasColumnName("RoofTypeID");
            this.Property(t => t.PoolOnSiteID).HasColumnName("PoolOnSiteID");
            this.Property(t => t.PoolSecuredID).HasColumnName("PoolSecuredID");
            this.Property(t => t.PoolDrainedID).HasColumnName("PoolDrainedID");
            this.Property(t => t.DoorTagStatusID).HasColumnName("DoorTagStatusID");
            this.Property(t => t.ContactMade).HasColumnName("ContactMade");
            this.Property(t => t.OccupancyID).HasColumnName("OccupancyID");
            this.Property(t => t.OccupancyVerifiedByID).HasColumnName("OccupancyVerifiedByID");
            this.Property(t => t.PropertyConditionID).HasColumnName("PropertyConditionID");
            this.Property(t => t.NeighborhoodConditionID).HasColumnName("NeighborhoodConditionID");
            this.Property(t => t.EMVID).HasColumnName("EMVID");
            this.Property(t => t.ElectricID).HasColumnName("ElectricID");
            this.Property(t => t.WaterID).HasColumnName("WaterID");
            this.Property(t => t.GasID).HasColumnName("GasID");
            this.Property(t => t.PersonalPropertyOnSiteID).HasColumnName("PersonalPropertyOnSiteID");
            this.Property(t => t.IsWinterizedID).HasColumnName("IsWinterizedID");
            this.Property(t => t.WinterizedByID).HasColumnName("WinterizedByID");
            this.Property(t => t.WinterizedDate).HasColumnName("WinterizedDate");
            this.Property(t => t.HowLongVacant).HasColumnName("HowLongVacant");
            this.Property(t => t.HazardsExist).HasColumnName("HazardsExist");
            this.Property(t => t.PersonInterviewed).HasColumnName("PersonInterviewed");
            this.Property(t => t.ManagingCompany).HasColumnName("ManagingCompany");

            // Relationships
            this.HasRequired(t => t.WorkOrder)
                .WithOptional(t => t.Exterior);

        }
    }
}
