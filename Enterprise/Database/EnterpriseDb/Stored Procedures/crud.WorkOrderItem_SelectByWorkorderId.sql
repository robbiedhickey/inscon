SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

create PROC [crud].[WorkOrderItem_SelectByWorkorderId]
  @WorkOrderID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [WorkOrderItemID],
           [WorkOrderID],
           [ProductID],
           [Quantity],
           [Rate],
           [DateInserted]
    FROM   [dbo].[WorkOrderItem]
    WHERE  [WorkOrderID] = @WorkOrderID

GO
