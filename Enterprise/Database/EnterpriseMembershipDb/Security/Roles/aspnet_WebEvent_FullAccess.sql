CREATE ROLE [aspnet_WebEvent_FullAccess]
AUTHORIZATION [dbo]
EXEC sp_addrolemember N'aspnet_WebEvent_FullAccess', N'ISS\iisuser'

GO
