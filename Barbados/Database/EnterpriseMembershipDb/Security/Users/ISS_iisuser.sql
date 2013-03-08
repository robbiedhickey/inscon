IF NOT EXISTS (SELECT * FROM master.dbo.syslogins WHERE loginname = N'ISS\iisuser')
CREATE LOGIN [ISS\iisuser] FROM WINDOWS
GO
CREATE USER [ISS\iisuser] FOR LOGIN [ISS\iisuser]
GO
