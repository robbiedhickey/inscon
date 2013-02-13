USE [EnterpriseDbTest]

-- Disable all constraints so we can load data
ALTER TABLE [dbo].[ProductCategory] NOCHECK CONSTRAINT ALL

-- Delete all data from tables
DELETE FROM [dbo].[ProductCategory]

-- Reseed the identity column starting values
DBCC CHECKIDENT('[dbo].[ProductCategory]', RESEED, 0)

-- Insert the test data
INSERT INTO [dbo].[ProductCategory]([Name] ,[Code])VALUES('Maintenance', 'MANT')
INSERT INTO [dbo].[ProductCategory]([Name] ,[Code])VALUES('Inspection',  'INSP')

-- Enable all constraints
ALTER TABLE [dbo].[ProductCategory] WITH CHECK CHECK CONSTRAINT ALL
