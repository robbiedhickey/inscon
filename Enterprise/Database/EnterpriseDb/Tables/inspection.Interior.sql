CREATE TABLE [inspection].[Interior]
(
[WorkOrderID] [int] NOT NULL,
[InteriorStatusID] [int] NULL,
[HeatSourceID] [int] NULL,
[PropaneVolumeID] [int] NULL,
[ContactName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[ContactNumber] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[MaintainedID] [int] NULL
) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Heat Source', 'SCHEMA', N'inspection', 'TABLE', N'Interior', 'COLUMN', N'HeatSourceID'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Interior Status', 'SCHEMA', N'inspection', 'TABLE', N'Interior', 'COLUMN', N'InteriorStatusID'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Is Property Maintained', 'SCHEMA', N'inspection', 'TABLE', N'Interior', 'COLUMN', N'MaintainedID'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Propane Volume', 'SCHEMA', N'inspection', 'TABLE', N'Interior', 'COLUMN', N'PropaneVolumeID'
GO

ALTER TABLE [inspection].[Interior] ADD CONSTRAINT [PK_Interior] PRIMARY KEY CLUSTERED  ([WorkOrderID]) ON [PRIMARY]
GO
ALTER TABLE [inspection].[Interior] ADD CONSTRAINT [FK_Interior_WorkOrder] FOREIGN KEY ([WorkOrderID]) REFERENCES [dbo].[WorkOrder] ([WorkOrderID]) ON DELETE CASCADE ON UPDATE CASCADE
GO
EXEC sp_addextendedproperty N'MS_Description', N'Contact Name - Primary Contact for completing an interior inspection', 'SCHEMA', N'inspection', 'TABLE', N'Interior', 'COLUMN', N'ContactName'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Contact Number - Primary Contact Number for completing an interior inspection', 'SCHEMA', N'inspection', 'TABLE', N'Interior', 'COLUMN', N'ContactNumber'
GO

EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'inspection', 'TABLE', N'Interior', 'COLUMN', N'WorkOrderID'
GO
