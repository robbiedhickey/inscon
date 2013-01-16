CREATE TABLE [generic].[AddressLocation]
(
[AddressID] [int] NOT NULL,
[BuildingNumber] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[StreetName] [varchar] (60) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[City] [varchar] (38) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[State] [varchar] (2) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Zip] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[GeoCode] [sys].[geography] NOT NULL,
[Lattitude] [float] NOT NULL,
[Longitude] [float] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [generic].[AddressLocation] ADD CONSTRAINT [PK_AddressLocation_1] PRIMARY KEY CLUSTERED  ([AddressID]) ON [PRIMARY]
GO
ALTER TABLE [generic].[AddressLocation] ADD CONSTRAINT [FK_AddressLocation_Address] FOREIGN KEY ([AddressID]) REFERENCES [generic].[Address] ([AddressID]) ON DELETE CASCADE ON UPDATE CASCADE
GO
EXEC sp_addextendedproperty N'MS_Description', N'City', 'SCHEMA', N'generic', 'TABLE', N'AddressLocation', 'COLUMN', N'City'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Geography Infomration', 'SCHEMA', N'generic', 'TABLE', N'AddressLocation', 'COLUMN', N'GeoCode'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lattitude', 'SCHEMA', N'generic', 'TABLE', N'AddressLocation', 'COLUMN', N'Lattitude'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Longitude', 'SCHEMA', N'generic', 'TABLE', N'AddressLocation', 'COLUMN', N'Longitude'
GO
EXEC sp_addextendedproperty N'MS_Description', N'State', 'SCHEMA', N'generic', 'TABLE', N'AddressLocation', 'COLUMN', N'State'
GO
EXEC sp_addextendedproperty N'MS_Description', N'StreetName', 'SCHEMA', N'generic', 'TABLE', N'AddressLocation', 'COLUMN', N'StreetName'
GO
EXEC sp_addextendedproperty N'MS_Description', N'ZipCode', 'SCHEMA', N'generic', 'TABLE', N'AddressLocation', 'COLUMN', N'Zip'
GO
