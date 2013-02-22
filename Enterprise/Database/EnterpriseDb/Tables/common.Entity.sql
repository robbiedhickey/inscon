CREATE TABLE [common].[Entity]
(
[EntityID] [smallint] NOT NULL IDENTITY(1, 1),
[Name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [common].[Entity] ADD CONSTRAINT [PK_Entity] PRIMARY KEY CLUSTERED  ([EntityID]) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX [IX_Entity] ON [common].[Entity] ([Name]) ON [PRIMARY]
GO
