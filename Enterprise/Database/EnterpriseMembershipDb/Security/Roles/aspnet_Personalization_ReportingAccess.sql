CREATE ROLE [aspnet_Personalization_ReportingAccess]
AUTHORIZATION [dbo]
EXEC sp_addrolemember N'aspnet_Personalization_ReportingAccess', N'ISS\iisuser'

GO
EXEC sp_addrolemember N'aspnet_Personalization_ReportingAccess', N'aspnet_Personalization_FullAccess'
GO
