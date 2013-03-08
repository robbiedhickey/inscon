
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[WorkOrderAssignment_Insert]
  @WorkOrderID INT,
  @UserID      INT,
  @EventDate   DATETIME,
  @StatusID    INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [request].[WorkOrderAssignment]
    (
      [WorkOrderID],
      [UserID],
      [EventDate],
      [StatusID]
    )
    VALUES
    (
      @WorkOrderID,
      @UserID,
      @EventDate,
      @StatusID
    )
    -- Begin Return Select <- do not remove
    SELECT [WorkOrderAssignmentID],
           [WorkOrderID],
           [UserID],
           [EventDate],
           [StatusID]
    FROM   [request].[WorkOrderAssignment]
    WHERE  [WorkOrderAssignmentID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove
GO
