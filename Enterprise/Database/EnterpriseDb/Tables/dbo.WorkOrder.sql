CREATE TABLE [dbo].[WorkOrder]
(
[WorkOrderID] [int] NOT NULL IDENTITY(1, 1),
[RequestID] [int] NOT NULL,
[LoanID] [int] NULL,
[DateInserted] [datetime] NULL CONSTRAINT [DF_WorkOrder_DateInserted] DEFAULT (getdate())
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[WorkOrder] ADD CONSTRAINT [PK_WorkOrder] PRIMARY KEY CLUSTERED  ([WorkOrderID]) ON [PRIMARY]
GO
ALTER TABLE [dbo].[WorkOrder] ADD CONSTRAINT [FK_WorkOrder_Loan] FOREIGN KEY ([LoanID]) REFERENCES [dbo].[Loan] ([LoanID])
GO
ALTER TABLE [dbo].[WorkOrder] ADD CONSTRAINT [FK_WorkOrder_Request] FOREIGN KEY ([RequestID]) REFERENCES [dbo].[Request] ([RequestID]) ON DELETE CASCADE ON UPDATE CASCADE
GO
EXEC sp_addextendedproperty N'MS_Description', N'Date Inserted', 'SCHEMA', N'dbo', 'TABLE', N'WorkOrder', 'COLUMN', N'DateInserted'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Loan RecordID', 'SCHEMA', N'dbo', 'TABLE', N'WorkOrder', 'COLUMN', N'LoanID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Parent RecordID', 'SCHEMA', N'dbo', 'TABLE', N'WorkOrder', 'COLUMN', N'RequestID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'dbo', 'TABLE', N'WorkOrder', 'COLUMN', N'WorkOrderID'
GO
