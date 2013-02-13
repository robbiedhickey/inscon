USE [EnterpriseDbTest]

-- Disable all constraints so we can load data
ALTER TABLE [dbo].[UserContact] NOCHECK CONSTRAINT all

-- Delete all data from tables
DELETE FROM [dbo].[UserContact]

-- Reseed the identity column starting values
DBCC CHECKIDENT('[dbo].[UserContact]', RESEED, 0)

-- Insert the test data
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(1, '8172681301',          30, 1)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(1, '8172681302',          31, 0)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(1, 'JCarter@barsoom.com', 32, 0)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(2, '8172681303',          30, 1)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(2, '8172681304',          31, 0)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(2, 'KKan@barsoom.com',    32, 0)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(3, '8172681305',          30, 1)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(3, '8172681306',          31, 0)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(3, 'MKajak@barsoom.com',  32, 0)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(4, '8172681307',          30, 1)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(4, '8172681308',          31, 0)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(4, 'SAgnew@imnac.com',    32, 0)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(5, '8172681309',          30, 1)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(5, '8172681310',          31, 0)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(5, 'DRumsfeld@imnac.com', 32, 0)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(6, '8172681311',          30, 1)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(6, '8172681312',          31, 0)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(6, 'RNixon@imnac.com',    32, 0)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(7, '8172681313',          30, 1)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(7, '8172681314',          31, 0)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(7, 'PFry@rtme.com',       32, 0)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(8, '8172681315',          30, 1)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(8, '8172681316',          31, 0)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(8, 'HConrad@rtme.com',    32, 0)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(9, '8172681317',          30, 1)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(9, '8172681318',          31, 0)
INSERT INTO [dbo].[UserContact]([UserID] ,[Value] ,[TypeID] ,[IsPrimary])VALUES(9, 'BRodriguez@rtme.com', 32, 0)

-- Enable all constraints
ALTER TABLE [dbo].[UserContact] WITH CHECK CHECK CONSTRAINT all
