CREATE ROLE [aspnet_Personalization_BasicAccess]
AUTHORIZATION [dbo]
EXEC sp_addrolemember N'aspnet_Personalization_BasicAccess', N'ISS\iisuser'

GO
EXEC sp_addrolemember N'aspnet_Personalization_BasicAccess', N'aspnet_Personalization_FullAccess'
GO
