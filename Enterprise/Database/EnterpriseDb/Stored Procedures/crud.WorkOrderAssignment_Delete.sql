
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[WorkOrderAssignment_Delete]
  @WorkOrderAssignmentID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [request].[WorkOrderAssignment]
    WHERE  [WorkOrderAssignmentID] = @WorkOrderAssignmentID
GO
