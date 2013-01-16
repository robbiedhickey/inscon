SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[WorkOrder_Delete]
  @WorkOrderID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [dbo].[WorkOrder]
    WHERE  [WorkOrderID] = @WorkOrderID

GO
