CREATE TABLE [dbo].[Mortgagor]
(
[MortgagorID] [int] NOT NULL IDENTITY(1, 1),
[LoanID] [int] NOT NULL,
[Name] [varchar] (60) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[TypeID] [int] NOT NULL,
[Phone] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Mortgagor] ADD CONSTRAINT [PK_Mortgagor] PRIMARY KEY CLUSTERED  ([MortgagorID]) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Mortgagor] ON [dbo].[Mortgagor] ([LoanID], [TypeID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Mortgagor] ADD CONSTRAINT [FK_Mortgagor_Loan] FOREIGN KEY ([LoanID]) REFERENCES [dbo].[Loan] ([LoanID]) ON DELETE CASCADE ON UPDATE CASCADE
GO
EXEC sp_addextendedproperty N'MS_Description', N'Parent RecordID', 'SCHEMA', N'dbo', 'TABLE', N'Mortgagor', 'COLUMN', N'LoanID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'dbo', 'TABLE', N'Mortgagor', 'COLUMN', N'MortgagorID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Mortgagor Name', 'SCHEMA', N'dbo', 'TABLE', N'Mortgagor', 'COLUMN', N'Name'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Mortgagor Phone', 'SCHEMA', N'dbo', 'TABLE', N'Mortgagor', 'COLUMN', N'Phone'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Parent RecordID - LoanType', 'SCHEMA', N'dbo', 'TABLE', N'Mortgagor', 'COLUMN', N'TypeID'
GO
