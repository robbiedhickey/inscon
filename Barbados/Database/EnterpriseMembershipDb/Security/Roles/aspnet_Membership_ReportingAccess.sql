CREATE ROLE [aspnet_Membership_ReportingAccess]
AUTHORIZATION [dbo]
EXEC sp_addrolemember N'aspnet_Membership_ReportingAccess', N'ISS\iisuser'

GO
EXEC sp_addrolemember N'aspnet_Membership_ReportingAccess', N'aspnet_Membership_FullAccess'
GO
