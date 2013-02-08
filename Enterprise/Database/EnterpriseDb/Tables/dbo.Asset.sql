CREATE TABLE [dbo].[Asset]
(
[AssetID] [int] NOT NULL IDENTITY(1, 1),
[OrganizationID] [int] NOT NULL,
[TypeID] [int] NOT NULL,
[AssetNumber] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS SPARSE NULL,
[LoanNumber] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[LoanTypeID] [int] NULL,
[MortgagorName] [varchar] (38) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[MortgagorPhone] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[HudCaseNumber] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS SPARSE NULL,
[LoanID] [int] NULL
) ON [PRIMARY]
ALTER TABLE [dbo].[Asset] ADD 
CONSTRAINT [PK_Asset] PRIMARY KEY CLUSTERED  ([AssetID]) ON [PRIMARY]
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
