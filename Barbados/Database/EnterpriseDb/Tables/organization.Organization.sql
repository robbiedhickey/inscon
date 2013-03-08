CREATE TABLE [organization].[Organization]
(
[OrganizationID] [int] NOT NULL IDENTITY(1, 1),
[Name] [varchar] (75) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Code] [varchar] (8) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[TypeID] [int] NOT NULL,
[StatusID] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [organization].[Organization] ADD CONSTRAINT [PK_Organization] PRIMARY KEY CLUSTERED  ([OrganizationID]) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX [UX_CodeTypeID] ON [organization].[Organization] ([Code], [TypeID]) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX [UX_NameTypeID] ON [organization].[Organization] ([Name], [TypeID]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'Organization Code', 'SCHEMA', N'organization', 'TABLE', N'Organization', 'COLUMN', N'Code'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Organization Name', 'SCHEMA', N'organization', 'TABLE', N'Organization', 'COLUMN', N'Name'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'organization', 'TABLE', N'Organization', 'COLUMN', N'OrganizationID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup value - Enabled, Disabled', 'SCHEMA', N'organization', 'TABLE', N'Organization', 'COLUMN', N'StatusID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Customer, Contractor, Employer', 'SCHEMA', N'organization', 'TABLE', N'Organization', 'COLUMN', N'TypeID'
GO
