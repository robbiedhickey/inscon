CREATE ROLE [aspnet_Roles_ReportingAccess]
AUTHORIZATION [dbo]
EXEC sp_addrolemember N'aspnet_Roles_ReportingAccess', N'ISS\iisuser'

GO
EXEC sp_addrolemember N'aspnet_Roles_ReportingAccess', N'aspnet_Roles_FullAccess'
GO
