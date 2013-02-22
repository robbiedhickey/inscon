CREATE ROLE [aspnet_Profile_FullAccess]
AUTHORIZATION [dbo]
EXEC sp_addrolemember N'aspnet_Profile_FullAccess', N'ISS\iisuser'

GO
