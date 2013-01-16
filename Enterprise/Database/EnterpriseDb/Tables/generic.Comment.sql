CREATE TABLE [generic].[Comment]
(
[CommentID] [int] NOT NULL IDENTITY(1, 1),
[ParentID] [int] NOT NULL,
[EntityID] [smallint] NOT NULL,
[UserID] [int] NULL,
[TypeID] [int] NOT NULL,
[Comment] [varchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [generic].[Comment] ADD CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED  ([CommentID]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'Comment', 'SCHEMA', N'generic', 'TABLE', N'Comment', 'COLUMN', N'Comment'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'generic', 'TABLE', N'Comment', 'COLUMN', N'CommentID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Type (User, Manager, Executive, Auditor)', 'SCHEMA', N'generic', 'TABLE', N'Comment', 'COLUMN', N'TypeID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID of user inserting record', 'SCHEMA', N'generic', 'TABLE', N'Comment', 'COLUMN', N'UserID'
GO
