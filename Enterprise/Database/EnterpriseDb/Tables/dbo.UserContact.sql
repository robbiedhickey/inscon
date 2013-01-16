CREATE TABLE [dbo].[UserContact]
(
[UserContactID] [int] NOT NULL IDENTITY(1, 1),
[UserID] [int] NOT NULL,
[Value] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[TypeID] [int] NOT NULL,
[IsPrimary] [bit] NOT NULL CONSTRAINT [DF_UserContact_IsPrimary_1] DEFAULT ((0))
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[UserContact] ADD CONSTRAINT [PK_UserContact] PRIMARY KEY CLUSTERED  ([UserContactID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[UserContact] ADD CONSTRAINT [FK_UserContact_User] FOREIGN KEY ([UserID]) REFERENCES [dbo].[User] ([UserID]) ON DELETE CASCADE ON UPDATE CASCADE
GO
EXEC sp_addextendedproperty N'MS_Description', N'True\False', 'SCHEMA', N'dbo', 'TABLE', N'UserContact', 'COLUMN', N'IsPrimary'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Type (Phone, Fax, Email)', 'SCHEMA', N'dbo', 'TABLE', N'UserContact', 'COLUMN', N'TypeID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'dbo', 'TABLE', N'UserContact', 'COLUMN', N'UserContactID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Parent RecordID', 'SCHEMA', N'dbo', 'TABLE', N'UserContact', 'COLUMN', N'UserID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Contact Value', 'SCHEMA', N'dbo', 'TABLE', N'UserContact', 'COLUMN', N'Value'
GO
