USE [EnterpriseDbTest]

-- Disable all constraints so we can load data
ALTER TABLE [dbo].[WorkOrder] NOCHECK CONSTRAINT all
ALTER TABLE [dbo].[Asset] NOCHECK CONSTRAINT all

-- Delete all data from tables
DELETE FROM [dbo].[Asset]

-- Reseed the identity column starting values
DBCC CHECKIDENT('[dbo].[Asset]', RESEED, 0)

-- Insert the test data
INSERT INTO [dbo].[Asset]([OrganizationID] ,[TypeID] ,[AssetNumber] ,[LoanNumber] ,[LoanTypeID] ,[MortgagorName] ,[MortgagorPhone] ,[HudCaseNumber] ,[ConveyanceDate] ,[FirstTimeVacantDate])VALUES(1, 30, '000001', '123456', 18, 'Amy Wong',          '2143453001', NULL, NULL, NULL)
INSERT INTO [dbo].[Asset]([OrganizationID] ,[TypeID] ,[AssetNumber] ,[LoanNumber] ,[LoanTypeID] ,[MortgagorName] ,[MortgagorPhone] ,[HudCaseNumber] ,[ConveyanceDate] ,[FirstTimeVacantDate])VALUES(1, 30, '000002', '234567', 18, 'Hubert Farnsworth', '2143453002', NULL, NULL, NULL)
INSERT INTO [dbo].[Asset]([OrganizationID] ,[TypeID] ,[AssetNumber] ,[LoanNumber] ,[LoanTypeID] ,[MortgagorName] ,[MortgagorPhone] ,[HudCaseNumber] ,[ConveyanceDate] ,[FirstTimeVacantDate])VALUES(1, 30, '000003', '345678', 18, 'Joe Melman',        '2143453003', NULL, NULL, NULL)
INSERT INTO [dbo].[Asset]([OrganizationID] ,[TypeID] ,[AssetNumber] ,[LoanNumber] ,[LoanTypeID] ,[MortgagorName] ,[MortgagorPhone] ,[HudCaseNumber] ,[ConveyanceDate] ,[FirstTimeVacantDate])VALUES(2, 30, '000004', '456789', 18, 'Barbados Slim',     '2143453004', NULL, NULL, NULL)
INSERT INTO [dbo].[Asset]([OrganizationID] ,[TypeID] ,[AssetNumber] ,[LoanNumber] ,[LoanTypeID] ,[MortgagorName] ,[MortgagorPhone] ,[HudCaseNumber] ,[ConveyanceDate] ,[FirstTimeVacantDate])VALUES(2, 30, '000005', '567890', 18, 'Jettro Heller',     '2143453005', NULL, NULL, NULL)
INSERT INTO [dbo].[Asset]([OrganizationID] ,[TypeID] ,[AssetNumber] ,[LoanNumber] ,[LoanTypeID] ,[MortgagorName] ,[MortgagorPhone] ,[HudCaseNumber] ,[ConveyanceDate] ,[FirstTimeVacantDate])VALUES(2, 30, '000006', '678901', 18, 'Pepper Potts',      '2143453006', NULL, NULL, NULL)
INSERT INTO [dbo].[Asset]([OrganizationID] ,[TypeID] ,[AssetNumber] ,[LoanNumber] ,[LoanTypeID] ,[MortgagorName] ,[MortgagorPhone] ,[HudCaseNumber] ,[ConveyanceDate] ,[FirstTimeVacantDate])VALUES(3, 30, '000007', '789012', 18, 'Leo Wong',          '2143453007', NULL, NULL, NULL)
INSERT INTO [dbo].[Asset]([OrganizationID] ,[TypeID] ,[AssetNumber] ,[LoanNumber] ,[LoanTypeID] ,[MortgagorName] ,[MortgagorPhone] ,[HudCaseNumber] ,[ConveyanceDate] ,[FirstTimeVacantDate])VALUES(3, 30, '000008', '890123', 18, 'Inez Wong',         '2143453008', NULL, NULL, NULL)
INSERT INTO [dbo].[Asset]([OrganizationID] ,[TypeID] ,[AssetNumber] ,[LoanNumber] ,[LoanTypeID] ,[MortgagorName] ,[MortgagorPhone] ,[HudCaseNumber] ,[ConveyanceDate] ,[FirstTimeVacantDate])VALUES(3, 30, '000009', '901234', 18, 'Zapp Brannigan',    '2143453009', NULL, NULL, NULL)

-- Enable all constraints
ALTER TABLE [dbo].[Asset] WITH CHECK CHECK CONSTRAINT all
ALTER TABLE [dbo].[WorkOrder] WITH CHECK CHECK CONSTRAINT all
