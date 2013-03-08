
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[WorkOrder_Update]
  @WorkOrderID  INT,
  @RequestID    INT,
  @AssetID       INT,
  @DateInserted DATETIME
  
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [request].[WorkOrder]
    SET    [RequestID] = @RequestID,
           [AssetID] = @AssetID,
           [DateInserted] = @DateInserted
         
    WHERE  [WorkOrderID] = @WorkOrderID
GO
