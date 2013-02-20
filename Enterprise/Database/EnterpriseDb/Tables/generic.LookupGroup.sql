CREATE TABLE [generic].[LookupGroup]
(
[LookupGroupID] [int] NOT NULL IDENTITY(1, 1),
[Name] [varchar] (75) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[OldID] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [generic].[LookupGroup] ADD CONSTRAINT [PK_LookupGroup] PRIMARY KEY CLUSTERED  ([LookupGroupID]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'generic', 'TABLE', N'LookupGroup', 'COLUMN', N'LookupGroupID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Group Name', 'SCHEMA', N'generic', 'TABLE', N'LookupGroup', 'COLUMN', N'Name'
GO
