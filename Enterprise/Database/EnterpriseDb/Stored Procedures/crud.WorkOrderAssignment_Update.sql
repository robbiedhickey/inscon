
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[WorkOrderAssignment_Update]
  @WorkOrderAssignmentID INT,
  @WorkOrderID           INT,
  @UserID                INT,
  @EventDate             DATETIME,
  @StatusID              INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [request].[WorkOrderAssignment]
    SET    [WorkOrderID] = @WorkOrderID,
           [UserID] = @UserID,
           [EventDate] = @EventDate,
           [StatusID] = @StatusID
    WHERE  [WorkOrderAssignmentID] = @WorkOrderAssignmentID
GO
