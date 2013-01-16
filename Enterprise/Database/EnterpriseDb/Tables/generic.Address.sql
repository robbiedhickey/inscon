CREATE TABLE [generic].[Address]
(
[AddressID] [int] NOT NULL IDENTITY(1, 1),
[ParentID] [int] NOT NULL,
[EntityID] [smallint] NOT NULL,
[Street] [varchar] (60) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Suite] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[City] [varchar] (38) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[State] [varchar] (2) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Zip] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [generic].[Address] ADD CONSTRAINT [PK_LocationAddress] PRIMARY KEY CLUSTERED  ([AddressID]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'generic', 'TABLE', N'Address', 'COLUMN', N'AddressID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Location City', 'SCHEMA', N'generic', 'TABLE', N'Address', 'COLUMN', N'City'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Location State', 'SCHEMA', N'generic', 'TABLE', N'Address', 'COLUMN', N'State'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Location Street', 'SCHEMA', N'generic', 'TABLE', N'Address', 'COLUMN', N'Street'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Suite', 'SCHEMA', N'generic', 'TABLE', N'Address', 'COLUMN', N'Suite'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Location Zipcode', 'SCHEMA', N'generic', 'TABLE', N'Address', 'COLUMN', N'Zip'
GO
