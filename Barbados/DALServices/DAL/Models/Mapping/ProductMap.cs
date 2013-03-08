using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductID);

            // Properties
            this.Property(t => t.Caption)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Code)
                .HasMaxLength(8);

            this.Property(t => t.SKU)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Product", "inventory");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.ProductCategoryID).HasColumnName("ProductCategoryID");
            this.Property(t => t.Caption).HasColumnName("Caption");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.SKU).HasColumnName("SKU");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.Cost).HasColumnName("Cost");

            // Relationships
            this.HasRequired(t => t.ProductCategory)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.ProductCategoryID);

        }
    }
}
