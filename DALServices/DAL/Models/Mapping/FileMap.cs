using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class FileMap : EntityTypeConfiguration<File>
    {
        public FileMap()
        {
            // Primary Key
            this.HasKey(t => t.FileID);

            // Properties
            this.Property(t => t.ParentFolder)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Caption)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("File", "common");
            this.Property(t => t.FileID).HasColumnName("FileID");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.EntityID).HasColumnName("EntityID");
            this.Property(t => t.ParentFolder).HasColumnName("ParentFolder");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Size).HasColumnName("Size");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.Caption).HasColumnName("Caption");
            this.Property(t => t.DateInserted).HasColumnName("DateInserted");
        }
    }
}
