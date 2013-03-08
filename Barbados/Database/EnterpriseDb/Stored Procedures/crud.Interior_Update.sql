SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Interior_Update]
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

    UPDATE [inspection].[Interior]
    SET    [WorkOrderID] = @WorkOrderID,
           [InteriorStatusID] = @InteriorStatusID,
           [HeatSourceID] = @HeatSourceID,
           [PropaneVolumeID] = @PropaneVolumeID,
           [ContactName] = @ContactName,
           [ContactNumber] = @ContactNumber,
           [MaintainedID] = @MaintainedID
    WHERE  [WorkOrderID] = @WorkOrderID

GO
