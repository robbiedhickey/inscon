CREATE TABLE [dbo].[Asset]
(
[AssetID] [int] NOT NULL IDENTITY(1, 1),
[OrganizationID] [int] NOT NULL,
[TypeID] [int] NOT NULL,
[AssetNumber] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS SPARSE NULL,
[LoanNumber] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[LoanTypeID] [int] NULL,
[MortgagorName] [varchar] (40) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[MortgagorPhone] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[HudCaseNumber] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS SPARSE NULL,
[ConveyanceDate] [datetime] NULL,
[FirstTimeVacantDate] [datetime] NULL,
[InBankruptcyProtection] [bit] NULL
) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'Conveyance Date', 'SCHEMA', N'dbo', 'TABLE', N'Asset', 'COLUMN', N'ConveyanceDate'
GO

EXEC sp_addextendedproperty N'MS_Description', N'First Time Vacant Date', 'SCHEMA', N'dbo', 'TABLE', N'Asset', 'COLUMN', N'FirstTimeVacantDate'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Hud Case Number', 'SCHEMA', N'dbo', 'TABLE', N'Asset', 'COLUMN', N'HudCaseNumber'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Loan Number', 'SCHEMA', N'dbo', 'TABLE', N'Asset', 'COLUMN', N'LoanNumber'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - LoanType', 'SCHEMA', N'dbo', 'TABLE', N'Asset', 'COLUMN', N'LoanTypeID'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Mortgagor Name', 'SCHEMA', N'dbo', 'TABLE', N'Asset', 'COLUMN', N'MortgagorName'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Mortgagor Phone', 'SCHEMA', N'dbo', 'TABLE', N'Asset', 'COLUMN', N'MortgagorPhone'
GO

ALTER TABLE [dbo].[Asset] ADD 
CONSTRAINT [PK_Asset] PRIMARY KEY CLUSTERED  ([AssetID]) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Asset] ADD CONSTRAINT [FK_Asset_Organization] FOREIGN KEY ([OrganizationID]) REFERENCES [dbo].[Organization] ([OrganizationID])
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'dbo', 'TABLE', N'Asset', 'COLUMN', N'AssetID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Customer Assigned Asset Number', 'SCHEMA', N'dbo', 'TABLE', N'Asset', 'COLUMN', N'AssetNumber'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Parent RecordID', 'SCHEMA', N'dbo', 'TABLE', N'Asset', 'COLUMN', N'OrganizationID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Asset Type Lookup (House, Car, Boat, Motorcycle, Other)', 'SCHEMA', N'dbo', 'TABLE', N'Asset', 'COLUMN', N'TypeID'
GO
