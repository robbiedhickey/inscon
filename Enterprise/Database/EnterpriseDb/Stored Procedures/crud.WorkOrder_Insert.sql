
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[WorkOrder_Insert]
  @RequestID    INT,
  @AssetID       INT,
  @DateInserted DATETIME

AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [dbo].[WorkOrder]
    (
      [RequestID],
      [AssetID],
      [DateInserted]
      
    )
    VALUES
    (
      @RequestID,
      @AssetID,
      @DateInserted
     
    )
    -- Begin Return Select <- do not remove
    SELECT [WorkOrderID],
           [RequestID],
           [AssetID],
           [DateInserted]
           
    FROM   [dbo].[WorkOrder]
    WHERE  [WorkOrderID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove

GO
