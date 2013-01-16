CREATE TABLE [dbo].[Loan]
(
[LoanID] [int] NOT NULL IDENTITY(1, 1),
[OrganizationID] [int] NOT NULL,
[TypeID] [int] NULL,
[LoanNumber] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[HudCaseNumber] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Loan] ADD CONSTRAINT [PK_Loan] PRIMARY KEY CLUSTERED  ([LoanID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Loan] ADD CONSTRAINT [FK_Loan_Organization] FOREIGN KEY ([OrganizationID]) REFERENCES [dbo].[Organization] ([OrganizationID]) ON DELETE CASCADE ON UPDATE CASCADE
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'dbo', 'TABLE', N'Loan', 'COLUMN', N'LoanID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Loan Number', 'SCHEMA', N'dbo', 'TABLE', N'Loan', 'COLUMN', N'LoanNumber'
GO
EXEC sp_addextendedproperty N'MS_Description', N'ParentID', 'SCHEMA', N'dbo', 'TABLE', N'Loan', 'COLUMN', N'OrganizationID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Loan Type (FHA, VA, CONV)', 'SCHEMA', N'dbo', 'TABLE', N'Loan', 'COLUMN', N'TypeID'
GO
