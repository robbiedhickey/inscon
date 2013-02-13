USE [EnterpriseDbTest]

-- Disable all constraints so we can load data
ALTER TABLE [dbo].[Organization] NOCHECK CONSTRAINT all

-- Delete all data from tables
DELETE FROM [dbo].[Organization]

-- Reseed the identity column starting values
DBCC CHECKIDENT('[dbo].[Organization]', RESEED, 0)

-- Insert the test data
INSERT INTO [dbo].[Organization]([Name] ,[Code] ,[TypeID] ,[StatusID])VALUES('Bank of the Outer Galactic Empire', 'BOGE', 3, 1)
INSERT INTO [dbo].[Organization]([Name] ,[Code] ,[TypeID] ,[StatusID])VALUES('Oort Cloud Savings and Loan',       'OCSL', 3, 1)
INSERT INTO [dbo].[Organization]([Name] ,[Code] ,[TypeID] ,[StatusID])VALUES('Ronaks Thrifty Mortgage Emporium',  'RTME', 3, 1)

-- Enable all constraints
ALTER TABLE [dbo].[Organization] WITH CHECK CHECK CONSTRAINT all
