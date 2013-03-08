CREATE ROLE [aspnet_Profile_ReportingAccess]
AUTHORIZATION [dbo]
EXEC sp_addrolemember N'aspnet_Profile_ReportingAccess', N'ISS\iisuser'

GO
EXEC sp_addrolemember N'aspnet_Profile_ReportingAccess', N'aspnet_Profile_FullAccess'
GO
