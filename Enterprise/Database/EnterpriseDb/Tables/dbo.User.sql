CREATE TABLE [dbo].[User]
(
[UserID] [int] NOT NULL IDENTITY(1, 1),
[OrganizationID] [int] NOT NULL,
[FirstName] [varchar] (28) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[LastName] [varchar] (28) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Title] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[StatusID] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[User] ADD CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED  ([UserID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[User] ADD CONSTRAINT [FK_User_Organization] FOREIGN KEY ([OrganizationID]) REFERENCES [dbo].[Organization] ([OrganizationID]) ON DELETE CASCADE ON UPDATE CASCADE
GO
EXEC sp_addextendedproperty N'MS_Description', N'User First Name', 'SCHEMA', N'dbo', 'TABLE', N'User', 'COLUMN', N'FirstName'
GO
EXEC sp_addextendedproperty N'MS_Description', N'User Last Name', 'SCHEMA', N'dbo', 'TABLE', N'User', 'COLUMN', N'LastName'
GO
EXEC sp_addextendedproperty N'MS_Description', N'ParentID', 'SCHEMA', N'dbo', 'TABLE', N'User', 'COLUMN', N'OrganizationID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Enabled, Disabled', 'SCHEMA', N'dbo', 'TABLE', N'User', 'COLUMN', N'StatusID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'User Title', 'SCHEMA', N'dbo', 'TABLE', N'User', 'COLUMN', N'Title'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'dbo', 'TABLE', N'User', 'COLUMN', N'UserID'
GO
