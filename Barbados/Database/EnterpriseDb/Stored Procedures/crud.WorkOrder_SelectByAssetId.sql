
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[WorkOrder_SelectByAssetId]
  @AssetID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [WorkOrderID],
           [RequestID],
           [AssetID],
           [DateInserted]
          
    FROM   [request].[WorkOrder]
    WHERE  [AssetID] = @AssetID
GO
