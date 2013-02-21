CREATE TABLE [inspection].[Loss]
(
[WorkOrderID] [int] NOT NULL,
[LossType] [varchar] (68) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[PercentageCompleted] [decimal] (3, 0) NULL,
[OwnerSatisfactionID] [int] NULL,
[OwnerSatisfactionNotes] [varchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[AdditionalRepairsNeeded] [varchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[EstimatedCompletionDate] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Is Owner satisfied with repairs?', 'SCHEMA', N'inspection', 'TABLE', N'Loss', 'COLUMN', N'OwnerSatisfactionID'
GO

EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Percentage of Completion', 'SCHEMA', N'inspection', 'TABLE', N'Loss', 'COLUMN', N'PercentageCompleted'
GO

ALTER TABLE [inspection].[Loss] ADD CONSTRAINT [PK_Loss] PRIMARY KEY CLUSTERED  ([WorkOrderID]) ON [PRIMARY]
GO
ALTER TABLE [inspection].[Loss] ADD CONSTRAINT [FK_Loss_WorkOrder] FOREIGN KEY ([WorkOrderID]) REFERENCES [dbo].[WorkOrder] ([WorkOrderID]) ON DELETE CASCADE ON UPDATE CASCADE
GO
EXEC sp_addextendedproperty N'MS_Description', N'Describe all additional repairs that are needed', 'SCHEMA', N'inspection', 'TABLE', N'Loss', 'COLUMN', N'AdditionalRepairsNeeded'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Type of Loss', 'SCHEMA', N'inspection', 'TABLE', N'Loss', 'COLUMN', N'LossType'
GO

EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'inspection', 'TABLE', N'Loss', 'COLUMN', N'WorkOrderID'
GO
