CREATE TABLE [request].[WorkOrderAssignment]
(
[WorkOrderAssignmentID] [int] NOT NULL IDENTITY(1, 1),
[WorkOrderID] [int] NOT NULL,
[UserID] [int] NOT NULL,
[EventDate] [datetime] NULL CONSTRAINT [DF_WorkOrderAssignment_WhenAssigned] DEFAULT (getdate()),
[StatusID] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [request].[WorkOrderAssignment] ADD CONSTRAINT [PK_WorkOrderAssignment] PRIMARY KEY CLUSTERED  ([WorkOrderAssignmentID]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'DateTime of Change', 'SCHEMA', N'request', 'TABLE', N'WorkOrderAssignment', 'COLUMN', N'EventDate'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Assigend, Unassigned', 'SCHEMA', N'request', 'TABLE', N'WorkOrderAssignment', 'COLUMN', N'StatusID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'idUser of the contractor', 'SCHEMA', N'request', 'TABLE', N'WorkOrderAssignment', 'COLUMN', N'UserID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'request', 'TABLE', N'WorkOrderAssignment', 'COLUMN', N'WorkOrderAssignmentID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Parent RecordID', 'SCHEMA', N'request', 'TABLE', N'WorkOrderAssignment', 'COLUMN', N'WorkOrderID'
GO
