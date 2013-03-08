IF NOT EXISTS (SELECT * FROM master.dbo.syslogins WHERE loginname = N'ISS\SQLDevelopers')
CREATE LOGIN [ISS\SQLDevelopers] FROM WINDOWS
GO
CREATE USER [ISS\SQLDevelopers] FOR LOGIN [ISS\SQLDevelopers]
GO
