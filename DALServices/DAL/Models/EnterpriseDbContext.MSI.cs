using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Enterprise.DALServices.DAL.Models.Mapping;

namespace Enterprise.DALServices.DAL.Models
{
    public partial class EnterpriseDbContext
    {
        private void MapStoredProcs(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.Address_Update")).Delete(d => d.HasName("crud.Address_Delete")).Insert(i => i.HasName("crud.Address_Insert")));
            modelBuilder.Entity<AddressLocation>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.AddressLocation_Update")).Delete(d => d.HasName("crud.AddressLocation_Delete")).Insert(i => i.HasName("crud.AddressLocation_Insert")));
            modelBuilder.Entity<AddressUse_XREF>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.AddressUse_XREF_Update")).Delete(d => d.HasName("crud.AddressUse_XREF_Delete")).Insert(i => i.HasName("crud.AddressUse_XREF_Insert")));
            modelBuilder.Entity<Comment>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.Comment_Update")).Delete(d => d.HasName("crud.Comment_Delete")).Insert(i => i.HasName("crud.Comment_Insert")));
            modelBuilder.Entity<Event>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.Event_Update")).Delete(d => d.HasName("crud.Event_Delete")).Insert(i => i.HasName("crud.Event_Insert")));
            modelBuilder.Entity<File>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.File_Update")).Delete(d => d.HasName("crud.File_Delete")).Insert(i => i.HasName("crud.File_Insert")));
            modelBuilder.Entity<Lookup>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.Lookup_Update")).Delete(d => d.HasName("crud.Lookup_Delete")).Insert(i => i.HasName("crud.Lookup_Insert")));
            modelBuilder.Entity<LookupGroup>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.LookupGroup_Update")).Delete(d => d.HasName("crud.LookupGroup_Delete")).Insert(i => i.HasName("crud.LookupGroup_Insert")));
            modelBuilder.Entity<Exterior>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.Exterior_Update")).Delete(d => d.HasName("crud.Exterior_Delete")).Insert(i => i.HasName("crud.Exterior_Insert")));
            modelBuilder.Entity<ForSale>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.ForSale_Update")).Delete(d => d.HasName("crud.ForSale_Delete")).Insert(i => i.HasName("crud.ForSale_Insert")));
            modelBuilder.Entity<Interior>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.Interior_Update")).Delete(d => d.HasName("crud.Interior_Delete")).Insert(i => i.HasName("crud.Interior_Insert")));
            modelBuilder.Entity<Loss>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.Loss_Update")).Delete(d => d.HasName("crud.Loss_Delete")).Insert(i => i.HasName("crud.Loss_Insert")));
            modelBuilder.Entity<Maintenance>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.Maintenance_Update")).Delete(d => d.HasName("crud.Maintenance_Delete")).Insert(i => i.HasName("crud.Maintenance_Insert")));
            modelBuilder.Entity<PropertyDamage>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.PropertyDamage_Update")).Delete(d => d.HasName("crud.PropertyDamage_Delete")).Insert(i => i.HasName("crud.PropertyDamage_Insert")));
            modelBuilder.Entity<Renter>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.Renter_Update")).Delete(d => d.HasName("crud.Renter_Delete")).Insert(i => i.HasName("crud.Renter_Insert")));
            modelBuilder.Entity<Product>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.Product_Update")).Delete(d => d.HasName("crud.Product_Delete")).Insert(i => i.HasName("crud.Product_Insert")));
            modelBuilder.Entity<ProductCategory>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.ProductCategory_Update")).Delete(d => d.HasName("crud.ProductCategory_Delete")).Insert(i => i.HasName("crud.ProductCategory_Insert")));
            modelBuilder.Entity<Asset>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.Asset_Update")).Delete(d => d.HasName("crud.Asset_Delete")).Insert(i => i.HasName("crud.Asset_Insert")));
            modelBuilder.Entity<Location>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.Location_Update")).Delete(d => d.HasName("crud.Location_Delete")).Insert(i => i.HasName("crud.Location_Insert")));
            modelBuilder.Entity<Organization>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.Organization_Update")).Delete(d => d.HasName("crud.Organization_Delete")).Insert(i => i.HasName("crud.Organization_Insert")));
            modelBuilder.Entity<User>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.User_Update")).Delete(d => d.HasName("crud.User_Delete")).Insert(i => i.HasName("crud.User_Insert")));
            modelBuilder.Entity<UserAreaCoverage>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.UserAreaCoverage_Update")).Delete(d => d.HasName("crud.UserAreaCoverage_Delete")).Insert(i => i.HasName("crud.UserAreaCoverage_Insert")));
            modelBuilder.Entity<UserContact>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.UserContact_Update")).Delete(d => d.HasName("crud.UserContact_Delete")).Insert(i => i.HasName("crud.UserContact_Insert")));
            modelBuilder.Entity<UserNotification>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.UserNotification_Update")).Delete(d => d.HasName("crud.UserNotification_Delete")).Insert(i => i.HasName("crud.UserNotification_Insert")));
            modelBuilder.Entity<Request>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.Request_Update")).Delete(d => d.HasName("crud.Request_Delete")).Insert(i => i.HasName("crud.Request_Insert")));
            modelBuilder.Entity<WorkOrder>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.WorkOrder_Update")).Delete(d => d.HasName("crud.WorkOrder_Delete")).Insert(i => i.HasName("crud.WorkOrder_Insert")));
            modelBuilder.Entity<WorkOrderAssignment>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.WorkOrderAssignment_Update")).Delete(d => d.HasName("crud.WorkOrderAssignment_Delete")).Insert(i => i.HasName("crud.WorkOrderAssignment_Insert")));
            modelBuilder.Entity<WorkOrderItem>().MapToStoredProcedures(s => s.Update(u => u.HasName("crud.WorkOrderItem_Update")).Delete(d => d.HasName("crud.WorkOrderItem_Delete")).Insert(i => i.HasName("crud.WorkOrderItem_Insert")));
        }
    }
}
