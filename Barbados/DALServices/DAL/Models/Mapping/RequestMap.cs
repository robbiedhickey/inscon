using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Enterprise.DALServices.DAL.Models.Mapping
{
    public class RequestMap : EntityTypeConfiguration<Request>
    {
        public RequestMap()
        {
            // Primary Key
            this.HasKey(t => t.RequestID);

            // Properties
            this.Property(t => t.CustomerRequestID)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Request", "request");
            this.Property(t => t.RequestID).HasColumnName("RequestID");
            this.Property(t => t.DateInserted).HasColumnName("DateInserted");
            this.Property(t => t.CustomerRequestID).HasColumnName("CustomerRequestID");
        }
    }
}
