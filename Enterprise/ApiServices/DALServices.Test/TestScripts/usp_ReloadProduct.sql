USE [EnterpriseDbTest]

-- Disable all constraints so we can load data
ALTER TABLE [dbo].[WorkOrderItem] NOCHECK CONSTRAINT ALL
ALTER TABLE [dbo].[Product] NOCHECK CONSTRAINT ALL

-- Delete all data from tables
DELETE FROM [dbo].[Product]

-- Reseed the identity column starting values
DBCC CHECKIDENT('[dbo].[Product]', RESEED, 0)

-- Insert the test data
INSERT INTO [dbo].[Product]([ProductCategoryID] ,[Caption] ,[Code] ,[SKU] ,[Rate] ,[Cost])VALUES(1, 'Flush Galactic Dust Filtration System',             'MANT01', '123',   150.00,   15.00)
INSERT INTO [dbo].[Product]([ProductCategoryID] ,[Caption] ,[Code] ,[SKU] ,[Rate] ,[Cost])VALUES(1, 'Reseal Outer Shell Seams with Dark Matter Sealant', 'MANT02', '124',  3700.00,  370.00)
INSERT INTO [dbo].[Product]([ProductCategoryID] ,[Caption] ,[Code] ,[SKU] ,[Rate] ,[Cost])VALUES(1, 'Replace Power Core Pellets',                        'MANT03', '125', 15000.00,   35.00)
INSERT INTO [dbo].[Product]([ProductCategoryID] ,[Caption] ,[Code] ,[SKU] ,[Rate] ,[Cost])VALUES(1, 'Resurface Landing Zone',                            'MANT04', '126',   250.00,   25.00)
INSERT INTO [dbo].[Product]([ProductCategoryID] ,[Caption] ,[Code] ,[SKU] ,[Rate] ,[Cost])VALUES(1, 'Change Life Support Core Modules',                  'MANT05', '127',   735.00,  700.00)
INSERT INTO [dbo].[Product]([ProductCategoryID] ,[Caption] ,[Code] ,[SKU] ,[Rate] ,[Cost])VALUES(2, 'Inspect Airlock',                                   'INSP01', '128',    85.00,    5.00)
INSERT INTO [dbo].[Product]([ProductCategoryID] ,[Caption] ,[Code] ,[SKU] ,[Rate] ,[Cost])VALUES(2, 'Check Power Core for Radiation Leakage',            'INSP02', '129',  1500.00, 1200.00)
INSERT INTO [dbo].[Product]([ProductCategoryID] ,[Caption] ,[Code] ,[SKU] ,[Rate] ,[Cost])VALUES(2, 'Inspect Life Support Air Filters',                  'INSP03', '130',    25.00,   15.00)
INSERT INTO [dbo].[Product]([ProductCategoryID] ,[Caption] ,[Code] ,[SKU] ,[Rate] ,[Cost])VALUES(2, 'Inspect BabelFish Tank Filtration System',          'INSP04', '131',   400.00,   40.00)
INSERT INTO [dbo].[Product]([ProductCategoryID] ,[Caption] ,[Code] ,[SKU] ,[Rate] ,[Cost])VALUES(2, 'Inspect Outer Shell for Micro-Black Hole Openings', 'INSP05', '132',   350.00,  300.00)

-- Enable all constraints
ALTER TABLE [dbo].[Product] WITH CHECK CHECK CONSTRAINT ALL
ALTER TABLE [dbo].[WorkOrderItem] WITH CHECK CHECK CONSTRAINT ALL
