SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Interior_SelectById]
  @WorkOrderID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [WorkOrderID],
           [InteriorStatusID],
           [HeatSourceID],
           [PropaneVolumeID],
           [ContactName],
           [ContactNumber],
           [MaintainedID]
    FROM   [inspection].[Interior]
    WHERE  [WorkOrderID] = @WorkOrderID

GO
