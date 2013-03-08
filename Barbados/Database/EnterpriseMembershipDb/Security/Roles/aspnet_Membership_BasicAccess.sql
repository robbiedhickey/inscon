CREATE ROLE [aspnet_Membership_BasicAccess]
AUTHORIZATION [dbo]
EXEC sp_addrolemember N'aspnet_Membership_BasicAccess', N'ISS\iisuser'

GO
EXEC sp_addrolemember N'aspnet_Membership_BasicAccess', N'aspnet_Membership_FullAccess'
GO
