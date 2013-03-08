CREATE TABLE [dbo].[PasswordHistory]
(
[PasswordHistoryId] [int] NOT NULL IDENTITY(1, 1),
[UserId] [uniqueidentifier] NOT NULL,
[Password] [nvarchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[PasswordSalt] [nvarchar] (128) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[DateCreated] [datetime] NULL CONSTRAINT [DF__PasswordH__DateC__07C12930] DEFAULT (getdate())
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PasswordHistory] ADD CONSTRAINT [PK__Password__0A9DD31D05D8E0BE] PRIMARY KEY CLUSTERED  ([PasswordHistoryId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PasswordHistory] ADD CONSTRAINT [FK_PasswordHistory_aspnet_Users_UserId] FOREIGN KEY ([UserId]) REFERENCES [dbo].[aspnet_Users] ([UserId])
GO
