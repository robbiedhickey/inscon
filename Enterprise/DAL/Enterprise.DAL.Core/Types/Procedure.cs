namespace Enterprise.DAL.Core.Types
{

    /// <summary>
    /// Static values that point to Stored Procedures
    /// To update this list run the procedure named: sp_CoreProcs
    /// </summary>
    public static class Procedure
    {
        #region public variables

        // Address
        public const string AddressDelete = @"[dbo].[cspAddress_Delete]";
        public const string AddressInsert = @"[dbo].[cspAddress_Insert]";
        public const string AddressSelect = @"[dbo].[cspAddress_Select]";
        public const string AddressSelectById = @"[dbo].[cspAddress_Select_ById]";
        public const string AddressUpdate = @"[dbo].[cspAddress_Update]";
        // AddressUse
        public const string AddressUseDelete = @"[dbo].[cspAddressUse_Delete]";
        public const string AddressUseInsert = @"[dbo].[cspAddressUse_Insert]";
        public const string AddressUseSelect = @"[dbo].[cspAddressUse_Select]";
        public const string AddressUseSelectById = @"[dbo].[cspAddressUse_Select_ById]";
        public const string AddressUseSelectByAddressId = @"[dbo].[cspAddressUse_SelectByAddressId]";
        public const string AddressUseSelectByAddressIdAndType = @"[dbo].[cspAddressUse_SelectByAddressIdAndType]";
        public const string AddressUseUpdate = @"[dbo].[cspAddressUse_Update]";
        // Comment
        public const string CommentDelete = @"[dbo].[cspComment_Delete]";
        public const string CommentInsert = @"[dbo].[cspComment_Insert]";
        public const string CommentSelect = @"[dbo].[cspComment_Select]";
        public const string CommentSelectById = @"[dbo].[cspComment_Select_ById]";
        public const string CommentUpdate = @"[dbo].[cspComment_Update]";
        // CommentUse
        public const string CommentUseDelete = @"[dbo].[cspCommentUse_Delete]";
        public const string CommentUseInsert = @"[dbo].[cspCommentUse_Insert]";
        public const string CommentUseSelect = @"[dbo].[cspCommentUse_Select]";
        public const string CommentUseSelectById = @"[dbo].[cspCommentUse_Select_ById]";
        public const string CommentUseUpdate = @"[dbo].[cspCommentUse_Update]";
        // Country
        public const string CountryDelete = @"[dbo].[cspCountry_Delete]";
        public const string CountryInsert = @"[dbo].[cspCountry_Insert]";
        public const string CountrySelect = @"[dbo].[cspCountry_Select]";
        public const string CountrySelectById = @"[dbo].[cspCountry_Select_ById]";
        public const string CountryUpdate = @"[dbo].[cspCountry_Update]";
        // Loan
        public const string LoanDelete = @"[dbo].[cspLoan_Delete]";
        public const string LoanInsert = @"[dbo].[cspLoan_Insert]";
        public const string LoanSelect = @"[dbo].[cspLoan_Select]";
        public const string LoanSelectById = @"[dbo].[cspLoan_Select_ById]";
        public const string LoanUpdate = @"[dbo].[cspLoan_Update]";
        // LoanMortgagor
        public const string LoanMortgagorDelete = @"[dbo].[cspLoanMortgagor_Delete]";
        public const string LoanMortgagorInsert = @"[dbo].[cspLoanMortgagor_Insert]";
        public const string LoanMortgagorSelect = @"[dbo].[cspLoanMortgagor_Select]";
        public const string LoanMortgagorSelectById = @"[dbo].[cspLoanMortgagor_Select_ById]";
        public const string LoanMortgagorUpdate = @"[dbo].[cspLoanMortgagor_Update]";
        // Lookup
        public const string LookupDelete = @"[dbo].[cspLookup_Delete]";
        public const string LookupInsert = @"[dbo].[cspLookup_Insert]";
        public const string LookupSelect = @"[dbo].[cspLookup_Select]";
        public const string LookupSelectById = @"[dbo].[cspLookup_Select_ById]";
        public const string LookupSelectByGroupId = @"[dbo].[cspLookup_SelectByGroupId]";
        public const string LookupUpdate = @"[dbo].[cspLookup_Update]";
        // LookupGroup
        public const string LookupGroupDelete = @"[dbo].[cspLookupGroup_Delete]";
        public const string LookupGroupInsert = @"[dbo].[cspLookupGroup_Insert]";
        public const string LookupGroupSelect = @"[dbo].[cspLookupGroup_Select]";
        public const string LookupGroupSelectById = @"[dbo].[cspLookupGroup_Select_ById]";
        public const string LookupGroupUpdate = @"[dbo].[cspLookupGroup_Update]";
        // Organization
        public const string OrganizationDelete = @"[dbo].[cspOrganization_Delete]";
        public const string OrganizationInsert = @"[dbo].[cspOrganization_Insert]";
        public const string OrganizationSelect = @"[dbo].[cspOrganization_Select]";
        public const string OrganizationSelectById = @"[dbo].[cspOrganization_Select_ById]";
        public const string OrganizationSelectByTypeId = @"[dbo].[cspOrganization_SelectByTypeId]";
        public const string OrganizationUpdate = @"[dbo].[cspOrganization_Update]";
        // OrganizationLocation
        public const string OrganizationLocationDelete = @"[dbo].[cspOrganizationLocation_Delete]";
        public const string OrganizationLocationInsert = @"[dbo].[cspOrganizationLocation_Insert]";
        public const string OrganizationLocationSelect = @"[dbo].[cspOrganizationLocation_Select]";
        public const string OrganizationLocationSelectById = @"[dbo].[cspOrganizationLocation_Select_ById]";
        public const string OrganizationLocationSelectByOrganizationId = @"[dbo].[cspOrganizationLocation_SelectByOrganizationId]";
        public const string OrganizationLocationUpdate = @"[dbo].[cspOrganizationLocation_Update]";
        // OrganizationLocationSetting
        public const string OrganizationLocationSettingDelete = @"[dbo].[cspOrganizationLocationSetting_Delete]";
        public const string OrganizationLocationSettingInsert = @"[dbo].[cspOrganizationLocationSetting_Insert]";
        public const string OrganizationLocationSettingSelect = @"[dbo].[cspOrganizationLocationSetting_Select]";
        public const string OrganizationLocationSettingSelectById = @"[dbo].[cspOrganizationLocationSetting_Select_ById]";
        public const string OrganizationLocationSettingUpdate = @"[dbo].[cspOrganizationLocationSetting_Update]";
        // OrganizationProduct
        public const string OrganizationProductDelete = @"[dbo].[cspOrganizationProduct_Delete]";
        public const string OrganizationProductInsert = @"[dbo].[cspOrganizationProduct_Insert]";
        public const string OrganizationProductSelect = @"[dbo].[cspOrganizationProduct_Select]";
        public const string OrganizationProductSelectById = @"[dbo].[cspOrganizationProduct_Select_ById]";
        public const string OrganizationProductUpdate = @"[dbo].[cspOrganizationProduct_Update]";
        // OrganizationSetting
        public const string OrganizationSettingDelete = @"[dbo].[cspOrganizationSetting_Delete]";
        public const string OrganizationSettingInsert = @"[dbo].[cspOrganizationSetting_Insert]";
        public const string OrganizationSettingSelect = @"[dbo].[cspOrganizationSetting_Select]";
        public const string OrganizationSettingSelectById = @"[dbo].[cspOrganizationSetting_Select_ById]";
        public const string OrganizationSettingSelectByOrganizationId = @"[dbo].[cspOrganizationSetting_SelectByOrganizationId]";
        public const string OrganizationSettingUpdate = @"[dbo].[cspOrganizationSetting_Update]";
        // Product
        public const string ProductDelete = @"[dbo].[cspProduct_Delete]";
        public const string ProductInsert = @"[dbo].[cspProduct_Insert]";
        public const string ProductSelect = @"[dbo].[cspProduct_Select]";
        public const string ProductSelectById = @"[dbo].[cspProduct_Select_ById]";
        public const string ProductUpdate = @"[dbo].[cspProduct_Update]";
        // User
        public const string UserDelete = @"[dbo].[cspUser_Delete]";
        public const string UserInsert = @"[dbo].[cspUser_Insert]";
        public const string UserSelect = @"[dbo].[cspUser_Select]";
        public const string UserSelectById = @"[dbo].[cspUser_Select_ById]";
        public const string UserSelectByOrganizationId = @"[dbo].[cspUser_SelectByOrganizationId]";
        public const string UserSelectByOrganizationIdAndIsActive = @"[dbo].[cspUser_SelectByOrganizationIdAndIsActive]";
        public const string UserUpdate = @"[dbo].[cspUser_Update]";
        // UserArea
        public const string UserAreaDelete = @"[dbo].[cspUserArea_Delete]";
        public const string UserAreaInsert = @"[dbo].[cspUserArea_Insert]";
        public const string UserAreaSelect = @"[dbo].[cspUserArea_Select]";
        public const string UserAreaSelectById = @"[dbo].[cspUserArea_Select_ById]";
        public const string UserAreaUpdate = @"[dbo].[cspUserArea_Update]";
        // UserContact
        public const string UserContactDelete = @"[dbo].[cspUserContact_Delete]";
        public const string UserContactInsert = @"[dbo].[cspUserContact_Insert]";
        public const string UserContactSelect = @"[dbo].[cspUserContact_Select]";
        public const string UserContactSelectById = @"[dbo].[cspUserContact_Select_ById]";
        public const string UserContactUpdate = @"[dbo].[cspUserContact_Update]";
        // UserDocument
        public const string UserDocumentDelete = @"[dbo].[cspUserDocument_Delete]";
        public const string UserDocumentInsert = @"[dbo].[cspUserDocument_Insert]";
        public const string UserDocumentSelect = @"[dbo].[cspUserDocument_Select]";
        public const string UserDocumentSelectById = @"[dbo].[cspUserDocument_Select_ById]";
        public const string UserDocumentUpdate = @"[dbo].[cspUserDocument_Update]";
        // UserDocumentNotification
        public const string UserDocumentNotificationDelete = @"[dbo].[cspUserDocumentNotification_Delete]";
        public const string UserDocumentNotificationInsert = @"[dbo].[cspUserDocumentNotification_Insert]";
        public const string UserDocumentNotificationSelect = @"[dbo].[cspUserDocumentNotification_Select]";
        public const string UserDocumentNotificationSelectById = @"[dbo].[cspUserDocumentNotification_Select_ById]";
        public const string UserDocumentNotificationUpdate = @"[dbo].[cspUserDocumentNotification_Update]";
        // UserEmail
        public const string UserEmailDelete = @"[dbo].[cspUserEmail_Delete]";
        public const string UserEmailInsert = @"[dbo].[cspUserEmail_Insert]";
        public const string UserEmailSelect = @"[dbo].[cspUserEmail_Select]";
        public const string UserEmailSelectById = @"[dbo].[cspUserEmail_Select_ById]";
        public const string UserEmailSelectByUserId = @"[dbo].[cspUserEmail_SelectByUserId]";
        public const string UserEmailUpdate = @"[dbo].[cspUserEmail_Update]";
        // UserEvent
        public const string UserEventDelete = @"[dbo].[cspUserEvent_Delete]";
        public const string UserEventInsert = @"[dbo].[cspUserEvent_Insert]";
        public const string UserEventSelect = @"[dbo].[cspUserEvent_Select]";
        public const string UserEventSelectById = @"[dbo].[cspUserEvent_Select_ById]";
        public const string UserEventSelectByUserId = @"[dbo].[cspUserEvent_SelectByUserId]";
        public const string UserEventSelectByUserIdAndTableId = @"[dbo].[cspUserEvent_SelectByUserIdAndTableId]";
        public const string UserEventUpdate = @"[dbo].[cspUserEvent_Update]";
        // UserIdentifier
        public const string UserIdentifierDelete = @"[dbo].[cspUserIdentifier_Delete]";
        public const string UserIdentifierInsert = @"[dbo].[cspUserIdentifier_Insert]";
        public const string UserIdentifierSelect = @"[dbo].[cspUserIdentifier_Select]";
        public const string UserIdentifierSelectById = @"[dbo].[cspUserIdentifier_Select_ById]";
        public const string UserIdentifierSelectByUserId = @"[dbo].[cspUserIdentifier_SelectByUserId]";
        public const string UserIdentifierSelectByUserIdAndTypeId = @"[dbo].[cspUserIdentifier_SelectByUserIdAndTypeId]";
        public const string UserIdentifierUpdate = @"[dbo].[cspUserIdentifier_Update]";
        // UserLocation
        public const string UserLocationDelete = @"[dbo].[cspUserLocation_Delete]";
        public const string UserLocationInsert = @"[dbo].[cspUserLocation_Insert]";
        public const string UserLocationSelect = @"[dbo].[cspUserLocation_Select]";
        public const string UserLocationSelectById = @"[dbo].[cspUserLocation_Select_ById]";
        public const string UserLocationUpdate = @"[dbo].[cspUserLocation_Update]";
        // WorkOrder
        public const string WorkOrderDelete = @"[dbo].[cspWorkOrder_Delete]";
        public const string WorkOrderInsert = @"[dbo].[cspWorkOrder_Insert]";
        public const string WorkOrderSelect = @"[dbo].[cspWorkOrder_Select]";
        public const string WorkOrderSelectById = @"[dbo].[cspWorkOrder_Select_ById]";
        public const string WorkOrderUpdate = @"[dbo].[cspWorkOrder_Update]";

        #endregion
    }
}