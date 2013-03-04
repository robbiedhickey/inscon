using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            // Primary Key
            this.HasKey(t => t.CommentID);

            // Properties
            this.Property(t => t.Value)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("Comment", "common");
            this.Property(t => t.CommentID).HasColumnName("CommentID");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.EntityID).HasColumnName("EntityID");
            this.Property(t => t.UserID).HasColumnName("UserID");
            this.Property(t => t.TypeID).HasColumnName("TypeID");
            this.Property(t => t.Value).HasColumnName("Value");
            this.Property(t => t.DateInserted).HasColumnName("DateInserted");
        }
    }
}
