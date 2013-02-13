USE [EnterpriseDbTest]

-- Disable all constraints so we can load data
ALTER TABLE [dbo].[WorkOrderItem] NOCHECK CONSTRAINT ALL

-- Delete all data from tables
DELETE FROM [dbo].[WorkOrderItem]

-- Reseed the identity column starting values
DBCC CHECKIDENT('[dbo].[WorkOrderItem]', RESEED, 0)

-- Insert the test data
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(1,  1, 1,   150.00, DATEADD(DAY,  -2, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(1,  2, 1,  3700.00, DATEADD(DAY,  -2, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(1,  4, 1,   250.00, DATEADD(DAY,  -2, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(2,  9, 1,   400.00, DATEADD(DAY,  -3, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(2, 10, 1,   350.00, DATEADD(DAY,  -3, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(2,  1, 1,   150.00, DATEADD(DAY,  -3, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(3,  5, 1,   735.00, DATEADD(DAY,  -4, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(3,  6, 1,    85.00, DATEADD(DAY,  -4, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(3,  8, 1,    25.00, DATEADD(DAY,  -4, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(4,  2, 1,  3700.00, DATEADD(DAY,  -5, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(4,  9, 1,   400.00, DATEADD(DAY,  -5, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(4, 10, 1,   350.00, DATEADD(DAY,  -5, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(5,  1, 1,   150.00, DATEADD(DAY,  -6, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(5,  2, 1,  3700.00, DATEADD(DAY,  -6, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(5,  3, 1, 15000.00, DATEADD(DAY,  -6, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(6,  4, 1,   250.00, DATEADD(DAY,  -7, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(6,  5, 1,   735.00, DATEADD(DAY,  -7, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(6,  6, 1,    85.00, DATEADD(DAY,  -7, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(7,  8, 1,    25.00, DATEADD(DAY,  -8, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(7,  9, 1,   400.00, DATEADD(DAY,  -8, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(7, 10, 1,   350.00, DATEADD(DAY,  -8, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(8,  6, 1,    85.00, DATEADD(DAY,  -9, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(8,  7, 1,  1500.00, DATEADD(DAY,  -9, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(8,  8, 1,    25.00, DATEADD(DAY,  -9, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(9,  3, 1, 15000.00, DATEADD(DAY, -10, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(9,  4, 1,   250.00, DATEADD(DAY, -10, GETDATE()))
INSERT INTO [dbo].[WorkOrderItem]([WorkOrderID] ,[ProductID] ,[Quantity] ,[Rate] ,[DateInserted])VALUES(9,  9, 1,   400.00, DATEADD(DAY, -10, GETDATE()))

-- Enable all constraints
ALTER TABLE [dbo].[WorkOrderItem] WITH CHECK CHECK CONSTRAINT ALL
