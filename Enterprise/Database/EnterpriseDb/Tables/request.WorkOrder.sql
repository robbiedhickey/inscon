CREATE TABLE [request].[WorkOrder]
(
[WorkOrderID] [int] NOT NULL IDENTITY(1, 1),
[RequestID] [int] NOT NULL,
[AssetID] [int] NOT NULL,
[DateInserted] [datetime] NULL CONSTRAINT [DF_WorkOrder_DateInserted] DEFAULT (getdate())
) ON [PRIMARY]
ALTER TABLE [request].[WorkOrder] ADD
CONSTRAINT [FK_WorkOrder_Asset] FOREIGN KEY ([AssetID]) REFERENCES [organization].[Asset] ([AssetID])
ALTER TABLE [request].[WorkOrder] ADD
CONSTRAINT [FK_WorkOrder_Request] FOREIGN KEY ([RequestID]) REFERENCES [request].[Request] ([RequestID]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [request].[WorkOrder] ADD CONSTRAINT [PK_WorkOrder] PRIMARY KEY CLUSTERED  ([WorkOrderID]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'Asset RecordID', 'SCHEMA', N'request', 'TABLE', N'WorkOrder', 'COLUMN', N'AssetID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Date Inserted', 'SCHEMA', N'request', 'TABLE', N'WorkOrder', 'COLUMN', N'DateInserted'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Parent RecordID', 'SCHEMA', N'request', 'TABLE', N'WorkOrder', 'COLUMN', N'RequestID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'request', 'TABLE', N'WorkOrder', 'COLUMN', N'WorkOrderID'
GO
