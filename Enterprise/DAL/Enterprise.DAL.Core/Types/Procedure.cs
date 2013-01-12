using System;

namespace Enterprise.DAL.Core.Types
{
    /// <summary>
    ///     Static values that point to Stored Procedures
    ///     To update this list run the procedure named: sp_CoreProcs
    /// </summary>
    public static class Procedure
    {
        #region public variables

        // Address
        public const String Address_Delete = @"[crud].[Address_Delete]";
        public const String Address_Insert = @"[crud].[Address_Insert]";
        public const String Address_Select = @"[crud].[Address_Select]";
        public const String Address_SelectById = @"[crud].[Address_SelectById]";
        public const String Address_Update = @"[crud].[Address_Update]";
        // AddressLocation
        public const String AddressLocation_Delete = @"[crud].[AddressLocation_Delete]";
        public const String AddressLocation_Insert = @"[crud].[AddressLocation_Insert]";
        public const String AddressLocation_Select = @"[crud].[AddressLocation_Select]";
        public const String AddressLocation_SelectById = @"[crud].[AddressLocation_SelectById]";
        public const String AddressLocation_Update = @"[crud].[AddressLocation_Update]";
        // AddressUse
        // Comment
        public const String Comment_Delete = @"[crud].[Comment_Delete]";
        public const String Comment_Insert = @"[crud].[Comment_Insert]";
        public const String Comment_Select = @"[crud].[Comment_Select]";
        public const String Comment_SelectById = @"[crud].[Comment_SelectById]";
        public const String Comment_Update = @"[crud].[Comment_Update]";
        // Event
        public const String Event_Delete = @"[crud].[Event_Delete]";
        public const String Event_Insert = @"[crud].[Event_Insert]";
        public const String Event_Select = @"[crud].[Event_Select]";
        public const String Event_SelectById = @"[crud].[Event_SelectById]";
        public const String Event_Update = @"[crud].[Event_Update]";
        // File
        public const String File_Delete = @"[crud].[File_Delete]";
        public const String File_Insert = @"[crud].[File_Insert]";
        public const String File_Select = @"[crud].[File_Select]";
        public const String File_SelectById = @"[crud].[File_SelectById]";
        public const String File_Update = @"[crud].[File_Update]";
        // Loan
        public const String Loan_Delete = @"[crud].[Loan_Delete]";
        public const String Loan_Insert = @"[crud].[Loan_Insert]";
        public const String Loan_Select = @"[crud].[Loan_Select]";
        public const String Loan_SelectById = @"[crud].[Loan_SelectById]";
        public const String Loan_Update = @"[crud].[Loan_Update]";
        // Location
        public const String Location_Delete = @"[crud].[Location_Delete]";
        public const String Location_Insert = @"[crud].[Location_Insert]";
        public const String Location_Select = @"[crud].[Location_Select]";
        public const String Location_SelectById = @"[crud].[Location_SelectById]";
        public const String Location_Update = @"[crud].[Location_Update]";
        // Lookup
        public const String Lookup_Delete = @"[crud].[Lookup_Delete]";
        public const String Lookup_Insert = @"[crud].[Lookup_Insert]";
        public const String Lookup_Select = @"[crud].[Lookup_Select]";
        public const String Lookup_SelectByGroupId = @"[crud].[Lookup_SelectByGroupId]";
        public const String Lookup_SelectById = @"[crud].[Lookup_SelectById]";
        public const String Lookup_Update = @"[crud].[Lookup_Update]";
        // LookupGroup
        public const String LookupGroup_Delete = @"[crud].[LookupGroup_Delete]";
        public const String LookupGroup_Insert = @"[crud].[LookupGroup_Insert]";
        public const String LookupGroup_Select = @"[crud].[LookupGroup_Select]";
        public const String LookupGroup_SelectById = @"[crud].[LookupGroup_SelectById]";
        public const String LookupGroup_Update = @"[crud].[LookupGroup_Update]";
        // Mortgagor
        public const String Mortgagor_Delete = @"[crud].[Mortgagor_Delete]";
        public const String Mortgagor_Insert = @"[crud].[Mortgagor_Insert]";
        public const String Mortgagor_Select = @"[crud].[Mortgagor_Select]";
        public const String Mortgagor_SelectById = @"[crud].[Mortgagor_SelectById]";
        public const String Mortgagor_Update = @"[crud].[Mortgagor_Update]";
        // Organization
        public const String Organization_Delete = @"[crud].[Organization_Delete]";
        public const String Organization_Insert = @"[crud].[Organization_Insert]";
        public const String Organization_Select = @"[crud].[Organization_Select]";
        public const String Organization_SelectById = @"[crud].[Organization_SelectById]";
        public const String Organization_SelectByTypeId = @"[crud].[Organization_SelectByTypeId]";
        public const String Organization_Update = @"[crud].[Organization_Update]";
        // Product
        public const String Product_Delete = @"[crud].[Product_Delete]";
        public const String Product_Insert = @"[crud].[Product_Insert]";
        public const String Product_Select = @"[crud].[Product_Select]";
        public const String Product_SelectAll = @"[crud].[Product_SelectAll]";
        public const String Product_SelectById = @"[crud].[Product_SelectById]";
        public const String Product_Update = @"[crud].[Product_Update]";
        // ProductCategory
        public const String ProductCategory_Delete = @"[crud].[ProductCategory_Delete]";
        public const String ProductCategory_Insert = @"[crud].[ProductCategory_Insert]";
        public const String ProductCategory_Select = @"[crud].[ProductCategory_Select]";
        public const String ProductCategory_SelectById = @"[crud].[ProductCategory_SelectById]";
        public const String ProductCategory_Update = @"[crud].[ProductCategory_Update]";
        // Request
        public const String Request_Delete = @"[crud].[Request_Delete]";
        public const String Request_Insert = @"[crud].[Request_Insert]";
        public const String Request_Select = @"[crud].[Request_Select]";
        public const String Request_SelectById = @"[crud].[Request_SelectById]";
        public const String Request_Update = @"[crud].[Request_Update]";
        // User
        public const String User_Delete = @"[crud].[User_Delete]";
        public const String User_Insert = @"[crud].[User_Insert]";
        public const String User_Select = @"[crud].[User_Select]";
        public const String User_SelectById = @"[crud].[User_SelectById]";
        public const String User_SelectByOrganizationId = @"[crud].[User_SelectByOrganizationId]";
        public const String User_SelectByOrganizationIdAndStatusId = @"[crud].[User_SelectByOrganizationIdAndStatusId]";
        public const String User_Update = @"[crud].[User_Update]";
        // UserAreaCoverage
        public const String UserAreaCoverage_Delete = @"[crud].[UserAreaCoverage_Delete]";
        public const String UserAreaCoverage_Insert = @"[crud].[UserAreaCoverage_Insert]";
        public const String UserAreaCoverage_Select = @"[crud].[UserAreaCoverage_Select]";
        public const String UserAreaCoverage_SelectById = @"[crud].[UserAreaCoverage_SelectById]";
        public const String UserAreaCoverage_Update = @"[crud].[UserAreaCoverage_Update]";
        // UserContact
        public const String UserContact_Delete = @"[crud].[UserContact_Delete]";
        public const String UserContact_Insert = @"[crud].[UserContact_Insert]";
        public const String UserContact_Select = @"[crud].[UserContact_Select]";
        public const String UserContact_SelectById = @"[crud].[UserContact_SelectById]";
        public const String UserContact_Update = @"[crud].[UserContact_Update]";
        // UserNotification
        public const String UserNotification_Delete = @"[crud].[UserNotification_Delete]";
        public const String UserNotification_Insert = @"[crud].[UserNotification_Insert]";
        public const String UserNotification_Select = @"[crud].[UserNotification_Select]";
        public const String UserNotification_SelectById = @"[crud].[UserNotification_SelectById]";
        public const String UserNotification_Update = @"[crud].[UserNotification_Update]";
        // WorkOrder
        public const String WorkOrder_Delete = @"[crud].[WorkOrder_Delete]";
        public const String WorkOrder_Insert = @"[crud].[WorkOrder_Insert]";
        public const String WorkOrder_Select = @"[crud].[WorkOrder_Select]";
        public const String WorkOrder_SelectById = @"[crud].[WorkOrder_SelectById]";
        public const String WorkOrder_Update = @"[crud].[WorkOrder_Update]";
        // WorkOrderAssignment
        public const String WorkOrderAssignment_Delete = @"[crud].[WorkOrderAssignment_Delete]";
        public const String WorkOrderAssignment_Insert = @"[crud].[WorkOrderAssignment_Insert]";
        public const String WorkOrderAssignment_Select = @"[crud].[WorkOrderAssignment_Select]";
        public const String WorkOrderAssignment_SelectById = @"[crud].[WorkOrderAssignment_SelectById]";
        public const String WorkOrderAssignment_Update = @"[crud].[WorkOrderAssignment_Update]";
        // WorkOrderItem
        public const String WorkOrderItem_Delete = @"[crud].[WorkOrderItem_Delete]";
        public const String WorkOrderItem_Insert = @"[crud].[WorkOrderItem_Insert]";
        public const String WorkOrderItem_Select = @"[crud].[WorkOrderItem_Select]";
        public const String WorkOrderItem_SelectById = @"[crud].[WorkOrderItem_SelectById]";
        public const String WorkOrderItem_Update = @"[crud].[WorkOrderItem_Update]";
        // WorkOrderItemDetail
        public const String WorkOrderItemDetail_Delete = @"[crud].[WorkOrderItemDetail_Delete]";
        public const String WorkOrderItemDetail_Insert = @"[crud].[WorkOrderItemDetail_Insert]";
        public const String WorkOrderItemDetail_Select = @"[crud].[WorkOrderItemDetail_Select]";
        public const String WorkOrderItemDetail_SelectById = @"[crud].[WorkOrderItemDetail_SelectById]";
        public const String WorkOrderItemDetail_Update = @"[crud].[WorkOrderItemDetail_Update]";
        
        #endregion
    }
}