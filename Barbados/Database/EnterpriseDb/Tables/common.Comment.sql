CREATE TABLE [common].[Comment]
(
[CommentID] [int] NOT NULL IDENTITY(1, 1),
[ParentID] [int] NOT NULL,
[EntityID] [smallint] NOT NULL,
[UserID] [int] NULL,
[TypeID] [int] NOT NULL,
[Value] [varchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[DateInserted] [datetime] NULL CONSTRAINT [DF_Comment_DateInserted] DEFAULT (getdate())
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [common].[Comment] ADD CONSTRAINT [PK_Comment] PRIMARY KEY CLUSTERED  ([CommentID]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'common', 'TABLE', N'Comment', 'COLUMN', N'CommentID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Type (User, Manager, Executive, Auditor)', 'SCHEMA', N'common', 'TABLE', N'Comment', 'COLUMN', N'TypeID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID of user inserting record', 'SCHEMA', N'common', 'TABLE', N'Comment', 'COLUMN', N'UserID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Comment', 'SCHEMA', N'common', 'TABLE', N'Comment', 'COLUMN', N'Value'
GO
