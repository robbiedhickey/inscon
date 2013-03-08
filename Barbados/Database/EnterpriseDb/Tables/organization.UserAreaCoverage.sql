CREATE TABLE [organization].[UserAreaCoverage]
(
[UserAreaCoverageID] [int] NOT NULL IDENTITY(1, 1),
[UserID] [int] NOT NULL,
[ZipCode] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[ServiceID] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [organization].[UserAreaCoverage] ADD CONSTRAINT [PK_UserAreaCoverage] PRIMARY KEY CLUSTERED  ([UserAreaCoverageID]) ON [PRIMARY]
GO
ALTER TABLE [organization].[UserAreaCoverage] ADD CONSTRAINT [FK_UserAreaCoverage_User] FOREIGN KEY ([UserID]) REFERENCES [organization].[User] ([UserID]) ON DELETE CASCADE ON UPDATE CASCADE
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID of Service area is for', 'SCHEMA', N'organization', 'TABLE', N'UserAreaCoverage', 'COLUMN', N'ServiceID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'organization', 'TABLE', N'UserAreaCoverage', 'COLUMN', N'UserAreaCoverageID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Parent RecordID', 'SCHEMA', N'organization', 'TABLE', N'UserAreaCoverage', 'COLUMN', N'UserID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Zip Code', 'SCHEMA', N'organization', 'TABLE', N'UserAreaCoverage', 'COLUMN', N'ZipCode'
GO
