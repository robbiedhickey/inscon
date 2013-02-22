
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[WorkOrderAssignment_SelectByWorkOrderId]
  @WorkOrderID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [WorkOrderAssignmentID],
           [WorkOrderID],
           [UserID],
           [EventDate],
           [StatusID]
    FROM   [request].[WorkOrderAssignment]
    WHERE  [WorkOrderID] = @WorkOrderID
GO
