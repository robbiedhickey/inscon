CREATE ROLE [aspnet_Profile_BasicAccess]
AUTHORIZATION [dbo]
EXEC sp_addrolemember N'aspnet_Profile_BasicAccess', N'ISS\iisuser'

GO
EXEC sp_addrolemember N'aspnet_Profile_BasicAccess', N'aspnet_Profile_FullAccess'
GO
