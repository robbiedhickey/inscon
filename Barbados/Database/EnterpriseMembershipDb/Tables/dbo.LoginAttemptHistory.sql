CREATE TABLE [dbo].[LoginAttemptHistory]
(
[LoginAttemptHistoryId] [int] NOT NULL IDENTITY(1, 1),
[UserId] [uniqueidentifier] NOT NULL,
[WasSuccessful] [bit] NOT NULL,
[ApplicationName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[DateCreated] [datetime] NOT NULL CONSTRAINT [DF__LoginAtte__DateC__1DB06A4F] DEFAULT (getdate())
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LoginAttemptHistory] ADD CONSTRAINT [PK__LoginAtt__670065061AD3FDA4] PRIMARY KEY CLUSTERED  ([LoginAttemptHistoryId]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[LoginAttemptHistory] ADD CONSTRAINT [FK__LoginAtte__UserI__1CBC4616] FOREIGN KEY ([UserId]) REFERENCES [dbo].[aspnet_Users] ([UserId])
GO
