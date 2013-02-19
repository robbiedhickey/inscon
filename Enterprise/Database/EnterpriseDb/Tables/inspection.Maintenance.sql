CREATE TABLE [inspection].[Maintenance]
(
[WorkOrderID] [int] NOT NULL,
[ChangeLocks] [bit] NULL,
[ReplaceGlass] [bit] NULL,
[BoardSecure] [bit] NULL,
[Winterize] [bit] NULL,
[CutGrass] [bit] NULL,
[GrassHeightInches] [int] NULL,
[DrainPool] [bit] NULL,
[RemoveDebris] [bit] NULL,
[RecommendedOther] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [inspection].[Maintenance] ADD CONSTRAINT [pk_maintenance] PRIMARY KEY CLUSTERED  ([WorkOrderID]) ON [PRIMARY]
GO
ALTER TABLE [inspection].[Maintenance] ADD CONSTRAINT [FK_Maintenance_WorkOrder] FOREIGN KEY ([WorkOrderID]) REFERENCES [dbo].[WorkOrder] ([WorkOrderID]) ON DELETE CASCADE ON UPDATE CASCADE
GO
EXEC sp_addextendedproperty N'MS_Description', N'Y\N - Board and Secure', 'SCHEMA', N'inspection', 'TABLE', N'Maintenance', 'COLUMN', N'BoardSecure'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Y\N - Change Locks', 'SCHEMA', N'inspection', 'TABLE', N'Maintenance', 'COLUMN', N'ChangeLocks'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Y\N - Cut Grass', 'SCHEMA', N'inspection', 'TABLE', N'Maintenance', 'COLUMN', N'CutGrass'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Y\N - Drain Pool', 'SCHEMA', N'inspection', 'TABLE', N'Maintenance', 'COLUMN', N'DrainPool'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Grass Height In Inches', 'SCHEMA', N'inspection', 'TABLE', N'Maintenance', 'COLUMN', N'GrassHeightInches'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Recommend Other', 'SCHEMA', N'inspection', 'TABLE', N'Maintenance', 'COLUMN', N'RecommendedOther'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Y\N - Remove Debris', 'SCHEMA', N'inspection', 'TABLE', N'Maintenance', 'COLUMN', N'RemoveDebris'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Y\N - Replace Glass', 'SCHEMA', N'inspection', 'TABLE', N'Maintenance', 'COLUMN', N'ReplaceGlass'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Y\N - Winterize', 'SCHEMA', N'inspection', 'TABLE', N'Maintenance', 'COLUMN', N'Winterize'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'inspection', 'TABLE', N'Maintenance', 'COLUMN', N'WorkOrderID'
GO
