USE [EnterpriseDbTest]

-- Disable all constraints so we can load data
ALTER TABLE [dbo].[Location] NOCHECK CONSTRAINT all

-- Delete all data from tables
DELETE FROM [dbo].[Location]

-- Reseed the identity column starting values
DBCC CHECKIDENT('[dbo].[Location]', RESEED, 0)

-- Insert the test data
INSERT INTO [EnterpriseDbTest].[dbo].[Location]([OrganizationID] ,[Name] ,[Code] ,[TypeID])VALUES(1, 'Bank of the Outer Galactic Empire', 'BOGE01', 11)
INSERT INTO [EnterpriseDbTest].[dbo].[Location]([OrganizationID] ,[Name] ,[Code] ,[TypeID])VALUES(1, 'Greater Helium Branch',             'BOGE02', 12)
INSERT INTO [EnterpriseDbTest].[dbo].[Location]([OrganizationID] ,[Name] ,[Code] ,[TypeID])VALUES(1, 'Wastelands Branch',                 'BOGE03', 12)
INSERT INTO [EnterpriseDbTest].[dbo].[Location]([OrganizationID] ,[Name] ,[Code] ,[TypeID])VALUES(2, 'Oort Cloud Savings and Loan',       'OCSL01', 11)
INSERT INTO [EnterpriseDbTest].[dbo].[Location]([OrganizationID] ,[Name] ,[Code] ,[TypeID])VALUES(2, 'Lower Hades Mercury Branch',        'OCSL02', 12)
INSERT INTO [EnterpriseDbTest].[dbo].[Location]([OrganizationID] ,[Name] ,[Code] ,[TypeID])VALUES(2, 'Rings of Saturn Branch',            'OCSL03', 12)
INSERT INTO [EnterpriseDbTest].[dbo].[Location]([OrganizationID] ,[Name] ,[Code] ,[TypeID])VALUES(3, 'Ronaks Thrifty Mortgage Emporium',  'RTME01', 11)
INSERT INTO [EnterpriseDbTest].[dbo].[Location]([OrganizationID] ,[Name] ,[Code] ,[TypeID])VALUES(3, 'Arlen South Branch',                'RTME02', 12)
INSERT INTO [EnterpriseDbTest].[dbo].[Location]([OrganizationID] ,[Name] ,[Code] ,[TypeID])VALUES(3, 'North Arlen Branch',                'RTME03', 12)

-- Enable all constraints
ALTER TABLE [dbo].[Location] WITH CHECK CHECK CONSTRAINT all
