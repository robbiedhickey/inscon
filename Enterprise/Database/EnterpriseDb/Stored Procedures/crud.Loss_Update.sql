SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Loss_Update]
  @WorkOrderID             INT,
  @LossType                VARCHAR(68),
  @PercentageCompleted     DECIMAL(3, 0),
  @OwnerSatisfactionID     INT,
  @OwnerSatisfactionNotes  VARCHAR(MAX),
  @AdditionalRepairsNeeded VARCHAR(MAX),
  @EstimatedCompletionDate DATETIME
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [inspection].[Loss]
    SET    [WorkOrderID] = @WorkOrderID,
           [LossType] = @LossType,
           [PercentageCompleted] = @PercentageCompleted,
           [OwnerSatisfactionID] = @OwnerSatisfactionID,
           [OwnerSatisfactionNotes] = @OwnerSatisfactionNotes,
           [AdditionalRepairsNeeded] = @AdditionalRepairsNeeded,
           [EstimatedCompletionDate] = @EstimatedCompletionDate
    WHERE  [WorkOrderID] = @WorkOrderID

GO
