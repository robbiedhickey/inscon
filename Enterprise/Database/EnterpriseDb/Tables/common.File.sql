CREATE TABLE [common].[File]
(
[FileID] [int] NOT NULL IDENTITY(1, 1),
[ParentID] [int] NOT NULL,
[EntityID] [smallint] NOT NULL,
[ParentFolder] [varchar] (100) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Size] [decimal] (18, 2) NULL,
[TypeID] [int] NULL,
[Caption] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[DateInserted] [datetime] NULL CONSTRAINT [DF_File_DateInserted] DEFAULT (getdate())
) ON [PRIMARY]
GO
ALTER TABLE [common].[File] ADD CONSTRAINT [PK_File] PRIMARY KEY CLUSTERED  ([FileID]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'Name when sending to others', 'SCHEMA', N'common', 'TABLE', N'File', 'COLUMN', N'Caption'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'common', 'TABLE', N'File', 'COLUMN', N'FileID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'File Name', 'SCHEMA', N'common', 'TABLE', N'File', 'COLUMN', N'Name'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Parent Folder', 'SCHEMA', N'common', 'TABLE', N'File', 'COLUMN', N'ParentFolder'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Size (KB)', 'SCHEMA', N'common', 'TABLE', N'File', 'COLUMN', N'Size'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Size: (.doc, .jpg, .pdf)', 'SCHEMA', N'common', 'TABLE', N'File', 'COLUMN', N'TypeID'
GO
