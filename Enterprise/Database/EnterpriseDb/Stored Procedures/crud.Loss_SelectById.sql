SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Loss_SelectById]
  @WorkOrderID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [WorkOrderID],
           [LossType],
           [PercentageCompleted],
           [OwnerSatisfactionID],
           [OwnerSatisfactionNotes],
           [AdditionalRepairsNeeded],
           [EstimatedCompletionDate]
    FROM   [inspection].[Loss]
    WHERE  [WorkOrderID] = @WorkOrderID

GO
