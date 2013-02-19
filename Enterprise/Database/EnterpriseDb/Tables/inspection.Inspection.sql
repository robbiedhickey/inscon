CREATE TABLE [inspection].[Inspection]
(
[WorkOrderID] [int] NOT NULL,
[DateInserted] [datetime] NULL CONSTRAINT [DF_Inspection_DateInserted] DEFAULT (getdate()),
[TypeID] [int] NOT NULL,
[UserIDCompletedBy] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [inspection].[Inspection] ADD CONSTRAINT [PK_Inspection_1] PRIMARY KEY CLUSTERED  ([WorkOrderID]) ON [PRIMARY]
GO
ALTER TABLE [inspection].[Inspection] ADD CONSTRAINT [FK_Inspection_WorkOrder] FOREIGN KEY ([WorkOrderID]) REFERENCES [dbo].[WorkOrder] ([WorkOrderID]) ON DELETE CASCADE ON UPDATE CASCADE
GO
EXEC sp_addextendedproperty N'MS_Description', N'DateInserted', 'SCHEMA', N'inspection', 'TABLE', N'Inspection', 'COLUMN', N'DateInserted'
GO
EXEC sp_addextendedproperty N'MS_Description', N'User Inspection Completed By', 'SCHEMA', N'inspection', 'TABLE', N'Inspection', 'COLUMN', N'UserIDCompletedBy'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'inspection', 'TABLE', N'Inspection', 'COLUMN', N'WorkOrderID'
GO
