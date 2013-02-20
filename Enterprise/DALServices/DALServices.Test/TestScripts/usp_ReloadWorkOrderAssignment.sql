USE [EnterpriseDbTest]

-- Disable all constraints so we can load data
ALTER TABLE [dbo].[WorkOrderAssignment] NOCHECK CONSTRAINT all

-- Delete all data from tables
DELETE FROM [dbo].[WorkOrderAssignment]

-- Reseed the identity column starting values
DBCC CHECKIDENT('[dbo].[WorkOrderAssignment]', RESEED, 0)

-- Note: This table should be exercised from the unit test only


-- Enable all constraints
ALTER TABLE [dbo].[WorkOrderAssignment] WITH CHECK CHECK CONSTRAINT all
