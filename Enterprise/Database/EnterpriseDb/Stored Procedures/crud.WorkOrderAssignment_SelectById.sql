SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[WorkOrderAssignment_SelectById]
  @WorkOrderAssignmentID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [WorkOrderAssignmentID],
           [WorkOrderID],
           [UserID],
           [EventDate],
           [StatusID]
    FROM   [dbo].[WorkOrderAssignment]
    WHERE  [WorkOrderAssignmentID] = @WorkOrderAssignmentID

GO
