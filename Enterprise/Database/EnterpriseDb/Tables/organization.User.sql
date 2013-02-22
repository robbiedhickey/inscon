CREATE TABLE [organization].[User]
(
[UserID] [int] NOT NULL IDENTITY(1, 1),
[OrganizationID] [int] NOT NULL,
[FirstName] [varchar] (28) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[LastName] [varchar] (28) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Title] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[StatusID] [int] NOT NULL,
[AuthenticationID] [uniqueidentifier] NULL
) ON [PRIMARY]
GO
ALTER TABLE [organization].[User] ADD CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED  ([UserID]) ON [PRIMARY]
GO
ALTER TABLE [organization].[User] ADD CONSTRAINT [FK_User_Organization] FOREIGN KEY ([OrganizationID]) REFERENCES [organization].[Organization] ([OrganizationID]) ON DELETE CASCADE ON UPDATE CASCADE
GO
EXEC sp_addextendedproperty N'MS_Description', N'User First Name', 'SCHEMA', N'organization', 'TABLE', N'User', 'COLUMN', N'FirstName'
GO
EXEC sp_addextendedproperty N'MS_Description', N'User Last Name', 'SCHEMA', N'organization', 'TABLE', N'User', 'COLUMN', N'LastName'
GO
EXEC sp_addextendedproperty N'MS_Description', N'ParentID', 'SCHEMA', N'organization', 'TABLE', N'User', 'COLUMN', N'OrganizationID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Enabled, Disabled', 'SCHEMA', N'organization', 'TABLE', N'User', 'COLUMN', N'StatusID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'User Title', 'SCHEMA', N'organization', 'TABLE', N'User', 'COLUMN', N'Title'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'organization', 'TABLE', N'User', 'COLUMN', N'UserID'
GO
