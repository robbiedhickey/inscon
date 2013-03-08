CREATE TABLE [common].[Event]
(
[EventID] [int] NOT NULL IDENTITY(1, 1),
[ParentID] [int] NOT NULL,
[EntityID] [smallint] NOT NULL,
[TypeID] [int] NOT NULL,
[UserID] [int] NULL,
[EventDate] [datetime] NULL CONSTRAINT [DF_Event_EventDate_1] DEFAULT (getdate())
) ON [PRIMARY]
GO
ALTER TABLE [common].[Event] ADD CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED  ([EventID]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'common', 'TABLE', N'Event', 'COLUMN', N'EventID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Type (Update, Insert, Delete, Assign)', 'SCHEMA', N'common', 'TABLE', N'Event', 'COLUMN', N'TypeID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID of user inserting record', 'SCHEMA', N'common', 'TABLE', N'Event', 'COLUMN', N'UserID'
GO
