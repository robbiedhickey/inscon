SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Loss_Insert]
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

    INSERT INTO [inspection].[Loss]
    (
      [WorkOrderID],
      [LossType],
      [PercentageCompleted],
      [OwnerSatisfactionID],
      [OwnerSatisfactionNotes],
      [AdditionalRepairsNeeded],
      [EstimatedCompletionDate]
    )
    VALUES
    (
      @WorkOrderID,
      @LossType,
      @PercentageCompleted,
      @OwnerSatisfactionID,
      @OwnerSatisfactionNotes,
      @AdditionalRepairsNeeded,
      @EstimatedCompletionDate
    )
    -- Begin Return Select <- do not remove
    SELECT [WorkOrderID],
           [LossType],
           [PercentageCompleted],
           [OwnerSatisfactionID],
           [OwnerSatisfactionNotes],
           [AdditionalRepairsNeeded],
           [EstimatedCompletionDate]
    FROM   [inspection].[Loss]
    WHERE  [WorkOrderID] = @WorkOrderID

-- End Return Select <- do not remove

GO
