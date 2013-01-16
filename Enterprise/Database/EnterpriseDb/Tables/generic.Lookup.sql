CREATE TABLE [generic].[Lookup]
(
[LookupID] [int] NOT NULL IDENTITY(1, 1),
[LookupGroupID] [smallint] NOT NULL,
[Value] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [generic].[Lookup] ADD CONSTRAINT [PK_Lookup] PRIMARY KEY CLUSTERED  ([LookupID]) ON [PRIMARY]
GO
ALTER TABLE [generic].[Lookup] ADD CONSTRAINT [FK_Lookup_LookupGroup1] FOREIGN KEY ([LookupGroupID]) REFERENCES [generic].[LookupGroup] ([LookupGroupID]) ON DELETE CASCADE ON UPDATE CASCADE
GO
EXEC sp_addextendedproperty N'MS_Description', N'Parent RecordID', 'SCHEMA', N'generic', 'TABLE', N'Lookup', 'COLUMN', N'LookupGroupID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'generic', 'TABLE', N'Lookup', 'COLUMN', N'LookupID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Caption', 'SCHEMA', N'generic', 'TABLE', N'Lookup', 'COLUMN', N'Value'
GO
