USE [EnterpriseDbTest]

-- Disable all constraints so we can load data
ALTER TABLE [dbo].[UserAreaCoverage] NOCHECK CONSTRAINT all

-- Delete all data from tables
DELETE FROM [dbo].[UserAreaCoverage]

-- Reseed the identity column starting values
DBCC CHECKIDENT('[dbo].[UserAreaCoverage]', RESEED, 0)

-- Insert the test data
INSERT INTO [dbo].[UserAreaCoverage]([UserID] ,[ZipCode] ,[ServiceID])VALUES(1, '75656', 0)
INSERT INTO [dbo].[UserAreaCoverage]([UserID] ,[ZipCode] ,[ServiceID])VALUES(2, '76021', 0)
INSERT INTO [dbo].[UserAreaCoverage]([UserID] ,[ZipCode] ,[ServiceID])VALUES(3, '76022', 0)
INSERT INTO [dbo].[UserAreaCoverage]([UserID] ,[ZipCode] ,[ServiceID])VALUES(4, '75287', 0)
INSERT INTO [dbo].[UserAreaCoverage]([UserID] ,[ZipCode] ,[ServiceID])VALUES(5, '75227', 0)
INSERT INTO [dbo].[UserAreaCoverage]([UserID] ,[ZipCode] ,[ServiceID])VALUES(6, '75236', 0)
INSERT INTO [dbo].[UserAreaCoverage]([UserID] ,[ZipCode] ,[ServiceID])VALUES(7, '75212', 0)
INSERT INTO [dbo].[UserAreaCoverage]([UserID] ,[ZipCode] ,[ServiceID])VALUES(8, '75220', 0)
INSERT INTO [dbo].[UserAreaCoverage]([UserID] ,[ZipCode] ,[ServiceID])VALUES(9, '75217', 0)

-- Enable all constraints
ALTER TABLE [dbo].[UserAreaCoverage] WITH CHECK CHECK CONSTRAINT all
