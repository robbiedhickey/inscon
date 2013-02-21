CREATE TABLE [inspection].[Exterior]
(
[WorkOrderID] [int] NOT NULL,
[ConstructionTypeID] [int] NULL,
[BuildingTypeID] [int] NULL,
[StoriesID] [int] NULL,
[PrimaryColorID] [int] NULL,
[RoofTypeID] [int] NULL,
[PoolOnSite] [tinyint] NULL,
[PoolSecured] [tinyint] NULL,
[PoolDrained] [tinyint] NULL,
[DoorTagStatusID] [int] NULL,
[ContactMade] [tinyint] NULL,
[OccupancyID] [int] NULL,
[OccupancyVerifiedByID] [int] NULL,
[PropertyConditionID] [int] NULL,
[NeighborhoodConditionID] [int] NULL,
[EMVID] [int] NULL,
[ElectricID] [int] NULL,
[WaterID] [int] NULL,
[GasID] [int] NULL,
[PersonalPropertyOnSite] [tinyint] NULL,
[IsWinterized] [tinyint] NULL,
[idWinterizedByType] [int] NULL,
[WinterizedDate] [datetime] NULL,
[HowLongVacant] [varchar] (15) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[HazardsExist] [int] NULL,
[PersonInterviewed] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[ManagingCompany] [varchar] (36) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Building Type', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'BuildingTypeID'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Construction Type', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'ConstructionTypeID'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Door Tag Delivery Status', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'DoorTagStatusID'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Is the electricity on?', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'ElectricID'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Estimated Mortgage Value', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'EMVID'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Is the gas on?', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'GasID'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Neighborhood Condition', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'NeighborhoodConditionID'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Occupancy', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'OccupancyID'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - How was occupancy verified', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'OccupancyVerifiedByID'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Primary Color', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'PrimaryColorID'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Property Condition', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'PropertyConditionID'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Roof Type', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'RoofTypeID'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Number of Stories', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'StoriesID'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Is the water on?', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'WaterID'
GO

ALTER TABLE [inspection].[Exterior] ADD CONSTRAINT [PK_Exterior] PRIMARY KEY CLUSTERED  ([WorkOrderID]) ON [PRIMARY]
GO
ALTER TABLE [inspection].[Exterior] ADD CONSTRAINT [FK_Exterior_WorkOrder] FOREIGN KEY ([WorkOrderID]) REFERENCES [dbo].[WorkOrder] ([WorkOrderID]) ON DELETE CASCADE ON UPDATE CASCADE
GO

EXEC sp_addextendedproperty N'MS_Description', N'Y/N - Was contact made', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'ContactMade'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Do hazards exist at the property?', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'HazardsExist'
GO
EXEC sp_addextendedproperty N'MS_Description', N'How long has the property been vacant?', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'HowLongVacant'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Winterization Type', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'idWinterizedByType'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Y/N - Is the property winterized?', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'IsWinterized'
GO
EXEC sp_addextendedproperty N'MS_Description', N'If Security Gate: Who is the Managing company?', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'ManagingCompany'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Y/N - Is there personal property at the property?', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'PersonalPropertyOnSite'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Name of the person that contact was made with', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'PersonInterviewed'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Y/N - Is the pool drained?', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'PoolDrained'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Y/N - Is there a pool on site?', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'PoolOnSite'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Y/N - Is the pool secure?', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'PoolSecured'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Winterization Date', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'WinterizedDate'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'inspection', 'TABLE', N'Exterior', 'COLUMN', N'WorkOrderID'
GO
