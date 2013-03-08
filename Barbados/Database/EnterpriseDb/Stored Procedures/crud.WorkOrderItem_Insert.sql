
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[WorkOrderItem_Insert]
  @WorkOrderID  INT,
  @ProductID    INT,
  @Quantity     DECIMAL(18, 2),
  @Rate         DECIMAL(18, 2),
  @DateInserted DATETIME
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [request].[WorkOrderItem]
    (
      [WorkOrderID],
      [ProductID],
      [Quantity],
      [Rate],
      [DateInserted]
    )
    VALUES
    (
      @WorkOrderID,
      @ProductID,
      @Quantity,
      @Rate,
      @DateInserted
    )
    -- Begin Return Select <- do not remove
    SELECT [WorkOrderItemID],
           [WorkOrderID],
           [ProductID],
           [Quantity],
           [Rate],
           [DateInserted]
    FROM   [request].[WorkOrderItem]
    WHERE  [WorkOrderItemID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove
GO
