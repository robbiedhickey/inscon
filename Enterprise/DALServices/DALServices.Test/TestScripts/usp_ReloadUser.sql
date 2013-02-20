USE [EnterpriseDbTest]

-- Disable all constraints so we can load data
ALTER TABLE [dbo].[User] NOCHECK CONSTRAINT all

-- Delete all data from tables
DELETE FROM [dbo].[User]

-- Reseed the identity column starting values
DBCC CHECKIDENT('[dbo].[User]', RESEED, 0)

-- Insert the test data
INSERT INTO [dbo].[User]([OrganizationID] ,[FirstName] ,[LastName] ,[Title] ,[StatusID] ,[AuthenticationID])VALUES(1, 'John',    'Carter',    NULL, 8, NULL)
INSERT INTO [dbo].[User]([OrganizationID] ,[FirstName] ,[LastName] ,[Title] ,[StatusID] ,[AuthenticationID])VALUES(1, 'Kantos',  'Kan',       NULL, 8, NULL)
INSERT INTO [dbo].[User]([OrganizationID] ,[FirstName] ,[LastName] ,[Title] ,[StatusID] ,[AuthenticationID])VALUES(1, 'Mors',    'Kajak',     NULL, 8, NULL)
INSERT INTO [dbo].[User]([OrganizationID] ,[FirstName] ,[LastName] ,[Title] ,[StatusID] ,[AuthenticationID])VALUES(2, 'Spiro',   'Agnew',     NULL, 8, NULL)
INSERT INTO [dbo].[User]([OrganizationID] ,[FirstName] ,[LastName] ,[Title] ,[StatusID] ,[AuthenticationID])VALUES(2, 'Donald',  'Rumsfeld',  NULL, 8, NULL)
INSERT INTO [dbo].[User]([OrganizationID] ,[FirstName] ,[LastName] ,[Title] ,[StatusID] ,[AuthenticationID])VALUES(2, 'Richard', 'Nixon',     NULL, 8, NULL)
INSERT INTO [dbo].[User]([OrganizationID] ,[FirstName] ,[LastName] ,[Title] ,[StatusID] ,[AuthenticationID])VALUES(3, 'Philip',  'Fry',       NULL, 8, NULL)
INSERT INTO [dbo].[User]([OrganizationID] ,[FirstName] ,[LastName] ,[Title] ,[StatusID] ,[AuthenticationID])VALUES(3, 'Hermes',  'Conrad',    NULL, 8, NULL)
INSERT INTO [dbo].[User]([OrganizationID] ,[FirstName] ,[LastName] ,[Title] ,[StatusID] ,[AuthenticationID])VALUES(3, 'Bender',  'Rodriguez', NULL, 8, NULL)

-- Enable all constraints
ALTER TABLE [dbo].[User] WITH CHECK CHECK CONSTRAINT all
