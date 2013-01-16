SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[WorkOrderItem_Delete]
  @WorkOrderItemID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [dbo].[WorkOrderItem]
    WHERE  [WorkOrderItemID] = @WorkOrderItemID

GO
