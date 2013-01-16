CREATE TABLE [dbo].[Organization]
(
[OrganizationID] [int] NOT NULL IDENTITY(1, 1),
[Name] [varchar] (75) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Code] [varchar] (8) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[TypeID] [int] NOT NULL,
[StatusID] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Organization] ADD CONSTRAINT [PK_Organization] PRIMARY KEY CLUSTERED  ([OrganizationID]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'Organization Code', 'SCHEMA', N'dbo', 'TABLE', N'Organization', 'COLUMN', N'Code'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Organization Name', 'SCHEMA', N'dbo', 'TABLE', N'Organization', 'COLUMN', N'Name'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'dbo', 'TABLE', N'Organization', 'COLUMN', N'OrganizationID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup value - Enabled, Disabled', 'SCHEMA', N'dbo', 'TABLE', N'Organization', 'COLUMN', N'StatusID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Customer, Contractor, Employer', 'SCHEMA', N'dbo', 'TABLE', N'Organization', 'COLUMN', N'TypeID'
GO
