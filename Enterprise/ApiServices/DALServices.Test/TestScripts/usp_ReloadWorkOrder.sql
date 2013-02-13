USE [EnterpriseDbTest]

-- Disable all constraints so we can load data
ALTER TABLE [dbo].[WorkOrder] NOCHECK CONSTRAINT ALL

-- Delete all data from tables
DELETE FROM [dbo].[WorkOrder]

-- Reseed the identity column starting values
DBCC CHECKIDENT('[dbo].[WorkOrder]', RESEED, 0)

-- Insert the test data
INSERT INTO [dbo].[WorkOrder]([RequestID] ,[AssetID] ,[DateInserted])VALUES(1, 1, DATEADD(DAY, -2,  GETDATE()))
INSERT INTO [dbo].[WorkOrder]([RequestID] ,[AssetID] ,[DateInserted])VALUES(2, 2, DATEADD(DAY, -3,  GETDATE()))
INSERT INTO [dbo].[WorkOrder]([RequestID] ,[AssetID] ,[DateInserted])VALUES(3, 3, DATEADD(DAY, -4,  GETDATE()))
INSERT INTO [dbo].[WorkOrder]([RequestID] ,[AssetID] ,[DateInserted])VALUES(4, 4, DATEADD(DAY, -5,  GETDATE()))
INSERT INTO [dbo].[WorkOrder]([RequestID] ,[AssetID] ,[DateInserted])VALUES(5, 5, DATEADD(DAY, -6,  GETDATE()))
INSERT INTO [dbo].[WorkOrder]([RequestID] ,[AssetID] ,[DateInserted])VALUES(6, 6, DATEADD(DAY, -7,  GETDATE()))
INSERT INTO [dbo].[WorkOrder]([RequestID] ,[AssetID] ,[DateInserted])VALUES(7, 7, DATEADD(DAY, -8,  GETDATE()))
INSERT INTO [dbo].[WorkOrder]([RequestID] ,[AssetID] ,[DateInserted])VALUES(8, 8, DATEADD(DAY, -9,  GETDATE()))
INSERT INTO [dbo].[WorkOrder]([RequestID] ,[AssetID] ,[DateInserted])VALUES(9, 9, DATEADD(DAY, -10, GETDATE()))

-- Enable all constraints
ALTER TABLE [dbo].[WorkOrder] WITH CHECK CHECK CONSTRAINT ALL
