// ***********************************************************************
// Assembly         : Enterprise.DAL.Core
// Author           : Michael Roof
// Created          : 01-26-2013
//
// Last Modified By : Michael Roof
// Last Modified On : 01-26-2013
// ***********************************************************************
// <copyright file="Procedure.cs" company="Mortgage Specialist International, LLC">
//     Copyright (c) Mortgage Specialist International, LLC. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
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
        public const String Address_SelectAll = @"[crud].[Address_SelectAll]";
        public const String Address_SelectById = @"[crud].[Address_SelectById]";
        public const String Address_SelectByParentIdAndEntityId = @"[crud].[Address_SelectByParentIdAndEntityId]";
        public const String Address_Update = @"[crud].[Address_Update]";
        // AddressLocation
        public const String AddressLocation_Delete = @"[crud].[AddressLocation_Delete]";
        public const String AddressLocation_Insert = @"[crud].[AddressLocation_Insert]";
        public const String AddressLocation_SelectAll = @"[crud].[AddressLocation_SelectAll]";
        public const String AddressLocation_SelectById = @"[crud].[AddressLocation_SelectById]";
        public const String AddressLocation_Update = @"[crud].[AddressLocation_Update]";
        // AddressUse
        public const String AddressUse_Delete = @"[crud].[AddressUse_Delete]";
        public const String AddressUse_Insert = @"[crud].[AddressUse_Insert]";
        public const String AddressUse_SelectAll = @"[crud].[AddressUse_SelectAll]";
        public const String AddressUse_SelectByAddressId = @"[crud].[AddressUse_SelectByAddressId]";
        public const String AddressUse_SelectByAddressIdAndTypeId = @"[crud].[AddressUse_SelectByAddressIdAndTypeId]";
        public const String AddressUse_SelectById = @"[crud].[AddressUse_SelectById]";
        public const String AddressUse_Update = @"[crud].[AddressUse_Update]";
        // Asset
        public const String Asset_Delete = @"[crud].[Asset_Delete]";
        public const String Asset_Insert = @"[crud].[Asset_Insert]";
        public const String Asset_SelectAll = @"[crud].[Asset_SelectAll]";
        public const String Asset_SelectById = @"[crud].[Asset_SelectById]";
        public const String Asset_SelectByLoanId = @"[crud].[Asset_SelectByLoanId]";
        public const String Asset_SelectByOrganizationId = @"[crud].[Asset_SelectByOrganizationId]";
        public const String Asset_Update = @"[crud].[Asset_Update]";
        // Comment
        public const String Comment_Delete = @"[crud].[Comment_Delete]";
        public const String Comment_Insert = @"[crud].[Comment_Insert]";
        public const String Comment_SelectAll = @"[crud].[Comment_SelectAll]";
        public const String Comment_SelectById = @"[crud].[Comment_SelectById]";
        public const String Comment_SelectByParentIdAndEntityId = @"[crud].[Comment_SelectByParentIdAndEntityId]";
        public const String Comment_Update = @"[crud].[Comment_Update]";
        // Entity
        public const String Entity_Delete = @"[crud].[Entity_Delete]";
        public const String Entity_Insert = @"[crud].[Entity_Insert]";
        public const String Entity_SelectAll = @"[crud].[Entity_SelectAll]";
        public const String Entity_SelectById = @"[crud].[Entity_SelectById]";
        public const String Entity_SelectByName = @"[crud].[Entity_SelectByName]";
        public const String Entity_Update = @"[crud].[Entity_Update]";
        // Event
        public const String Event_Delete = @"[crud].[Event_Delete]";
        public const String Event_Insert = @"[crud].[Event_Insert]";
        public const String Event_SelectAll = @"[crud].[Event_SelectAll]";
        public const String Event_SelectById = @"[crud].[Event_SelectById]";
        public const String Event_SelectByParentIdAndEntityId = @"[crud].[Event_SelectByParentIdAndEntityId]";
        public const String Event_Update = @"[crud].[Event_Update]";
        // File
        public const String File_Delete = @"[crud].[File_Delete]";
        public const String File_Insert = @"[crud].[File_Insert]";
        public const String File_SelectAll = @"[crud].[File_SelectAll]";
        public const String File_SelectById = @"[crud].[File_SelectById]";
        public const String File_SelectByParentIdAndEntityId = @"[crud].[File_SelectByParentIdAndEntityId]";
        public const String File_Update = @"[crud].[File_Update]";
        // Loan
        public const String Loan_Delete = @"[crud].[Loan_Delete]";
        public const String Loan_Insert = @"[crud].[Loan_Insert]";
        public const String Loan_SelectAll = @"[crud].[Loan_SelectAll]";
        public const String Loan_SelectById = @"[crud].[Loan_SelectById]";
        public const String Loan_Update = @"[crud].[Loan_Update]";
        // Location
        public const String Location_Delete = @"[crud].[Location_Delete]";
        public const String Location_Insert = @"[crud].[Location_Insert]";
        public const String Location_SelectAll = @"[crud].[Location_SelectAll]";
        public const String Location_SelectById = @"[crud].[Location_SelectById]";
        public const String Location_SelectByOrganizationId = @"[crud].[Location_SelectByOrganizationId]";
        public const String Location_SelectByOrganizationIdAndTypeId = @"[crud].[Location_SelectByOrganizationIdAndTypeId]";
        public const String Location_Update = @"[crud].[Location_Update]";
        // Lookup
        public const String Lookup_Delete = @"[crud].[Lookup_Delete]";
        public const String Lookup_Insert = @"[crud].[Lookup_Insert]";
        public const String Lookup_SelectAll = @"[crud].[Lookup_SelectAll]";
        public const String Lookup_SelectByGroupId = @"[crud].[Lookup_SelectByGroupId]";
        public const String Lookup_SelectById = @"[crud].[Lookup_SelectById]";
        public const String Lookup_Update = @"[crud].[Lookup_Update]";
        // LookupGroup
        public const String LookupGroup_Delete = @"[crud].[LookupGroup_Delete]";
        public const String LookupGroup_Insert = @"[crud].[LookupGroup_Insert]";
        public const String LookupGroup_SelectAll = @"[crud].[LookupGroup_SelectAll]";
        public const String LookupGroup_SelectById = @"[crud].[LookupGroup_SelectById]";
        public const String LookupGroup_Update = @"[crud].[LookupGroup_Update]";
        // Mortgagor
        public const String Mortgagor_Delete = @"[crud].[Mortgagor_Delete]";
        public const String Mortgagor_Insert = @"[crud].[Mortgagor_Insert]";
        public const String Mortgagor_SelectAll = @"[crud].[Mortgagor_SelectAll]";
        public const String Mortgagor_SelectById = @"[crud].[Mortgagor_SelectById]";
        public const String Mortgagor_SelectByLoanId = @"[crud].[Mortgagor_SelectByLoanId]";
        public const String Mortgagor_SelectByLoanIdAndTypeId = @"[crud].[Mortgagor_SelectByLoanIdAndTypeId]";
        public const String Mortgagor_Update = @"[crud].[Mortgagor_Update]";
        // Organization
        public const String Organization_Delete = @"[crud].[Organization_Delete]";
        public const String Organization_Insert = @"[crud].[Organization_Insert]";
        public const String Organization_SelectAll = @"[crud].[Organization_SelectAll]";
        public const String Organization_SelectById = @"[crud].[Organization_SelectById]";
        public const String Organization_SelectByTypeId = @"[crud].[Organization_SelectByTypeId]";
        public const String Organization_Update = @"[crud].[Organization_Update]";
        // Product
        public const String Product_Delete = @"[crud].[Product_Delete]";
        public const String Product_Insert = @"[crud].[Product_Insert]";
        public const String Product_SelectAll = @"[crud].[Product_SelectAll]";
        public const String Product_SelectByCategoryId = @"[crud].[Product_SelectByCategoryId]";
        public const String Product_SelectById = @"[crud].[Product_SelectById]";
        public const String Product_Update = @"[crud].[Product_Update]";
        // ProductCategory
        public const String ProductCategory_Delete = @"[crud].[ProductCategory_Delete]";
        public const String ProductCategory_Insert = @"[crud].[ProductCategory_Insert]";
        public const String ProductCategory_SelectAll = @"[crud].[ProductCategory_SelectAll]";
        public const String ProductCategory_SelectById = @"[crud].[ProductCategory_SelectById]";
        public const String ProductCategory_Update = @"[crud].[ProductCategory_Update]";
        // Request
        public const String Request_Delete = @"[crud].[Request_Delete]";
        public const String Request_Insert = @"[crud].[Request_Insert]";
        public const String Request_SelectAll = @"[crud].[Request_SelectAll]";
        public const String Request_SelectById = @"[crud].[Request_SelectById]";
        public const String Request_Update = @"[crud].[Request_Update]";
        // User
        public const String User_Delete = @"[crud].[User_Delete]";
        public const String User_Insert = @"[crud].[User_Insert]";
        public const String User_SelectAll = @"[crud].[User_SelectAll]";
        public const String User_SelectById = @"[crud].[User_SelectById]";
        public const String User_SelectByOrganizationId = @"[crud].[User_SelectByOrganizationId]";
        public const String User_SelectByOrganizationIdAndStatusId = @"[crud].[User_SelectByOrganizationIdAndStatusId]";
        public const String User_Update = @"[crud].[User_Update]";
        // UserAreaCoverage
        public const String UserAreaCoverage_Delete = @"[crud].[UserAreaCoverage_Delete]";
        public const String UserAreaCoverage_Insert = @"[crud].[UserAreaCoverage_Insert]";
        public const String UserAreaCoverage_SelectAll = @"[crud].[UserAreaCoverage_SelectAll]";
        public const String UserAreaCoverage_SelectById = @"[crud].[UserAreaCoverage_SelectById]";
        public const String UserAreaCoverage_SelectByUserIdAndServiceId = @"[crud].[UserAreaCoverage_SelectByUserIdAndServiceId]";
        public const String UserAreaCoverage_Update = @"[crud].[UserAreaCoverage_Update]";
        // UserContact
        public const String UserContact_Delete = @"[crud].[UserContact_Delete]";
        public const String UserContact_Insert = @"[crud].[UserContact_Insert]";
        public const String UserContact_SelectAll = @"[crud].[UserContact_SelectAll]";
        public const String UserContact_SelectById = @"[crud].[UserContact_SelectById]";
        public const String UserContact_SelectByUserId = @"[crud].[UserContact_SelectByUserId]";
        public const String UserContact_SelectByUserIdAndTypeId = @"[crud].[UserContact_SelectByUserIdAndTypeId]";
        public const String UserContact_Update = @"[crud].[UserContact_Update]";
        // UserNotification
        public const String UserNotification_Delete = @"[crud].[UserNotification_Delete]";
        public const String UserNotification_Insert = @"[crud].[UserNotification_Insert]";
        public const String UserNotification_SelectAll = @"[crud].[UserNotification_SelectAll]";
        public const String UserNotification_SelectById = @"[crud].[UserNotification_SelectById]";
        public const String UserNotification_SelectByUserId = @"[crud].[UserNotification_SelectByUserId]";
        public const String UserNotification_Update = @"[crud].[UserNotification_Update]";
        // WorkOrder
        public const String WorkOrder_Delete = @"[crud].[WorkOrder_Delete]";
        public const String WorkOrder_Insert = @"[crud].[WorkOrder_Insert]";
        public const String WorkOrder_SelectAll = @"[crud].[WorkOrder_SelectAll]";
        public const String WorkOrder_SelectByAssetId = @"[crud].[WorkOrder_SelectByAssetId]";
        public const String WorkOrder_SelectById = @"[crud].[WorkOrder_SelectById]";
        public const String WorkOrder_SelectByRequestId = @"[crud].[WorkOrder_SelectByRequestId]";
        public const String WorkOrder_Update = @"[crud].[WorkOrder_Update]";
        // WorkOrderAssignment
        public const String WorkOrderAssignment_Delete = @"[crud].[WorkOrderAssignment_Delete]";
        public const String WorkOrderAssignment_Insert = @"[crud].[WorkOrderAssignment_Insert]";
        public const String WorkOrderAssignment_SelectAll = @"[crud].[WorkOrderAssignment_SelectAll]";
        public const String WorkOrderAssignment_SelectById = @"[crud].[WorkOrderAssignment_SelectById]";
        public const String WorkOrderAssignment_SelectByWorkOrderId = @"[crud].[WorkOrderAssignment_SelectByWorkOrderId]";
        public const String WorkOrderAssignment_Update = @"[crud].[WorkOrderAssignment_Update]";
        // WorkOrderItem
        public const String WorkOrderItem_Delete = @"[crud].[WorkOrderItem_Delete]";
        public const String WorkOrderItem_Insert = @"[crud].[WorkOrderItem_Insert]";
        public const String WorkOrderItem_SelectAll = @"[crud].[WorkOrderItem_SelectAll]";
        public const String WorkOrderItem_SelectById = @"[crud].[WorkOrderItem_SelectById]";
        public const String WorkOrderItem_SelectByWorkorderId = @"[crud].[WorkOrderItem_SelectByWorkorderId]";
        public const String WorkOrderItem_Update = @"[crud].[WorkOrderItem_Update]";

        #endregion
    }
}