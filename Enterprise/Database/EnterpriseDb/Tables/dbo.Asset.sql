CREATE TABLE [dbo].[Asset]
(
[AssetID] [int] NOT NULL IDENTITY(1, 1),
[OrganizationID] [int] NOT NULL,
[TypeID] [int] NOT NULL,
[LoanID] [int] NULL,
[AssetNumber] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Asset] ADD CONSTRAINT [FK_Asset_Loan] FOREIGN KEY ([LoanID]) REFERENCES [dbo].[Loan] ([LoanID])
GO
ALTER TABLE [dbo].[Asset] ADD CONSTRAINT [FK_Asset_Organization] FOREIGN KEY ([OrganizationID]) REFERENCES [dbo].[Organization] ([OrganizationID])
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'dbo', 'TABLE', N'Asset', 'COLUMN', N'AssetID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Customer Assigned Asset Number', 'SCHEMA', N'dbo', 'TABLE', N'Asset', 'COLUMN', N'AssetNumber'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID of loan associated', 'SCHEMA', N'dbo', 'TABLE', N'Asset', 'COLUMN', N'LoanID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Parent RecordID', 'SCHEMA', N'dbo', 'TABLE', N'Asset', 'COLUMN', N'OrganizationID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Asset Type Lookup (House, Car, Boat, Motorcycle, Other)', 'SCHEMA', N'dbo', 'TABLE', N'Asset', 'COLUMN', N'TypeID'
GO
