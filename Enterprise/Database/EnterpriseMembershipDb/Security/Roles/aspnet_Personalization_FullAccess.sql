CREATE ROLE [aspnet_Personalization_FullAccess]
AUTHORIZATION [dbo]
EXEC sp_addrolemember N'aspnet_Personalization_FullAccess', N'ISS\iisuser'

GO
