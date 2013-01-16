SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[WorkOrderItem_Update]
  @WorkOrderItemID INT,
  @WorkOrderID     INT,
  @ProductID       INT,
  @Quantity        DECIMAL(18, 2),
  @Rate            DECIMAL(18, 2),
  @DateInserted    DATETIME
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [dbo].[WorkOrderItem]
    SET    [WorkOrderID] = @WorkOrderID,
           [ProductID] = @ProductID,
           [Quantity] = @Quantity,
           [Rate] = @Rate,
           [DateInserted] = @DateInserted
    WHERE  [WorkOrderItemID] = @WorkOrderItemID

GO
