CREATE TABLE [request].[WorkOrderItem]
(
[WorkOrderItemID] [int] NOT NULL IDENTITY(1, 1),
[WorkOrderID] [int] NOT NULL,
[ProductID] [int] NOT NULL,
[Quantity] [decimal] (18, 2) NOT NULL CONSTRAINT [DF_WorkOrderItem_Quantity] DEFAULT ((1)),
[Rate] [decimal] (18, 2) NOT NULL CONSTRAINT [DF_WorkOrderItem_Rate] DEFAULT ((0)),
[DateInserted] [datetime] NULL CONSTRAINT [DF_WorkOrderItem_DateInserted] DEFAULT (getdate())
) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'Quantity', 'SCHEMA', N'request', 'TABLE', N'WorkOrderItem', 'COLUMN', N'Quantity'
GO

ALTER TABLE [request].[WorkOrderItem] ADD
CONSTRAINT [FK_WorkOrderItem_WorkOrder] FOREIGN KEY ([WorkOrderID]) REFERENCES [request].[WorkOrder] ([WorkOrderID]) ON DELETE CASCADE ON UPDATE CASCADE
GO
ALTER TABLE [request].[WorkOrderItem] ADD CONSTRAINT [PK_WorkOrderItem] PRIMARY KEY CLUSTERED  ([WorkOrderItemID]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'Date Inserted', 'SCHEMA', N'request', 'TABLE', N'WorkOrderItem', 'COLUMN', N'DateInserted'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Product RecordID', 'SCHEMA', N'request', 'TABLE', N'WorkOrderItem', 'COLUMN', N'ProductID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Rate', 'SCHEMA', N'request', 'TABLE', N'WorkOrderItem', 'COLUMN', N'Rate'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Parent RecordID', 'SCHEMA', N'request', 'TABLE', N'WorkOrderItem', 'COLUMN', N'WorkOrderID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'request', 'TABLE', N'WorkOrderItem', 'COLUMN', N'WorkOrderItemID'
GO
