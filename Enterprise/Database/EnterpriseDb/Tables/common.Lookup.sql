CREATE TABLE [common].[Lookup]
(
[LookupID] [int] NOT NULL IDENTITY(1, 1),
[LookupGroupID] [int] NOT NULL,
[Value] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[OldID] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [common].[Lookup] ADD CONSTRAINT [PK_Lookup] PRIMARY KEY CLUSTERED  ([LookupID]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'Parent RecordID', 'SCHEMA', N'common', 'TABLE', N'Lookup', 'COLUMN', N'LookupGroupID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'common', 'TABLE', N'Lookup', 'COLUMN', N'LookupID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Caption', 'SCHEMA', N'common', 'TABLE', N'Lookup', 'COLUMN', N'Value'
GO
