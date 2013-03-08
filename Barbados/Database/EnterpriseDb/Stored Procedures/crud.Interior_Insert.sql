SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Interior_Insert]
  @WorkOrderID      INT,
  @InteriorStatusID INT,
  @HeatSourceID     INT,
  @PropaneVolumeID  INT,
  @ContactName      VARCHAR(50),
  @ContactNumber    VARCHAR(10),
  @MaintainedID     INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [inspection].[Interior]
    (
      [WorkOrderID],
      [InteriorStatusID],
      [HeatSourceID],
      [PropaneVolumeID],
      [ContactName],
      [ContactNumber],
      [MaintainedID]
    )
    VALUES
    (
      @WorkOrderID,
      @InteriorStatusID,
      @HeatSourceID,
      @PropaneVolumeID,
      @ContactName,
      @ContactNumber,
      @MaintainedID
    )
    -- Begin Return Select <- do not remove
    SELECT [WorkOrderID],
           [InteriorStatusID],
           [HeatSourceID],
           [PropaneVolumeID],
           [ContactName],
           [ContactNumber],
           [MaintainedID]
    FROM   [inspection].[Interior]
    WHERE  [WorkOrderID] = @WorkOrderID

-- End Return Select <- do not remove

GO
