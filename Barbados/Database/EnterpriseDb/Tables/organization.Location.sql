CREATE TABLE [organization].[Location]
(
[LocationID] [int] NOT NULL IDENTITY(1, 1),
[OrganizationID] [int] NOT NULL,
[Name] [varchar] (75) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Code] [varchar] (8) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[TypeID] [int] NOT NULL
) ON [PRIMARY]
ALTER TABLE [organization].[Location] ADD
CONSTRAINT [FK_Location_Organization1] FOREIGN KEY ([OrganizationID]) REFERENCES [organization].[Organization] ([OrganizationID]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [organization].[Location] ADD CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED  ([LocationID]) ON [PRIMARY]
GO

EXEC sp_addextendedproperty N'MS_Description', N'Location Code', 'SCHEMA', N'organization', 'TABLE', N'Location', 'COLUMN', N'Code'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'organization', 'TABLE', N'Location', 'COLUMN', N'LocationID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Location Name', 'SCHEMA', N'organization', 'TABLE', N'Location', 'COLUMN', N'Name'
GO
EXEC sp_addextendedproperty N'MS_Description', N'ParentID', 'SCHEMA', N'organization', 'TABLE', N'Location', 'COLUMN', N'OrganizationID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Branch, Department, Staff Grouping', 'SCHEMA', N'organization', 'TABLE', N'Location', 'COLUMN', N'TypeID'
GO
