USE [EnterpriseDbTest]

-- Disable all constraints so we can load data
ALTER TABLE [dbo].[Request] NOCHECK CONSTRAINT ALL

-- Delete all data from tables
DELETE FROM [dbo].[Request]

-- Reseed the identity column starting values
DBCC CHECKIDENT('[dbo].[Request]', RESEED, 0)

-- Insert the test data
INSERT INTO [dbo].[Request]([DateInserted] ,[CustomerRequestID])VALUES(DATEADD(DAY, -2,  GETDATE()), 'BOGE-Req01')
INSERT INTO [dbo].[Request]([DateInserted] ,[CustomerRequestID])VALUES(DATEADD(DAY, -3,  GETDATE()), 'BOGE-Req02')
INSERT INTO [dbo].[Request]([DateInserted] ,[CustomerRequestID])VALUES(DATEADD(DAY, -4,  GETDATE()), 'BOGE-Req03')
INSERT INTO [dbo].[Request]([DateInserted] ,[CustomerRequestID])VALUES(DATEADD(DAY, -5,  GETDATE()), 'OCSL-Req01')
INSERT INTO [dbo].[Request]([DateInserted] ,[CustomerRequestID])VALUES(DATEADD(DAY, -6,  GETDATE()), 'OCSL-Req02')
INSERT INTO [dbo].[Request]([DateInserted] ,[CustomerRequestID])VALUES(DATEADD(DAY, -7,  GETDATE()), 'OCSL-Req03')
INSERT INTO [dbo].[Request]([DateInserted] ,[CustomerRequestID])VALUES(DATEADD(DAY, -8,  GETDATE()), 'RTME-Req01')
INSERT INTO [dbo].[Request]([DateInserted] ,[CustomerRequestID])VALUES(DATEADD(DAY, -9,  GETDATE()), 'RTME-Req02')
INSERT INTO [dbo].[Request]([DateInserted] ,[CustomerRequestID])VALUES(DATEADD(DAY, -10, GETDATE()), 'RTME-Req03')

-- Enable all constraints
ALTER TABLE [dbo].[Request] WITH CHECK CHECK CONSTRAINT ALL
