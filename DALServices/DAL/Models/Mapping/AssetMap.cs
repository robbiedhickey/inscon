using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class AssetMap : EntityTypeConfiguration<Asset>
    {
        public AssetMap()
        {
            // Primary Key
            this.HasKey(t => t.AssetID);

            // Properties
            this.Property(t => t.AssetNumber)
                .HasMaxLength(20);

            this.Property(t => t.LoanNumber)
                .HasMaxLength(30);

            this.Property(t => t.MortgagorName)
                .HasMaxLength(40);

            this.Property(t => t.MortgagorPhone)
                .HasMaxLength(15);

            this.Property(t => t.HudCaseNumber)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Asset", "organization");
            this.Property(t => t.AssetID).HasColumnName("AssetID");
            this.Property(t => t.OrganizationID).HasColumnName("OrganizationID");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.AssetNumber).HasColumnName("AssetNumber");
            this.Property(t => t.LoanNumber).HasColumnName("LoanNumber");
            this.Property(t => t.LoanTypeID).HasColumnName("LoanTypeID");
            this.Property(t => t.MortgagorName).HasColumnName("MortgagorName");
            this.Property(t => t.MortgagorPhone).HasColumnName("MortgagorPhone");
            this.Property(t => t.HudCaseNumber).HasColumnName("HudCaseNumber");
            this.Property(t => t.ConveyanceDate).HasColumnName("ConveyanceDate");
            this.Property(t => t.FirstTimeVacantDate).HasColumnName("FirstTimeVacantDate");
            this.Property(t => t.InBankruptcyProtection).HasColumnName("InBankruptcyProtection");

            // Relationships
            this.HasRequired(t => t.Organization)
                .WithMany(t => t.Assets)
                .HasForeignKey(d => d.OrganizationID);

        }
    }
}
