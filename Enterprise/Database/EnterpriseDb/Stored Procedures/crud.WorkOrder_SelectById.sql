
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[WorkOrder_SelectById]
  @WorkOrderID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [WorkOrderID],
           [RequestID],
           [AssetID],
           [DateInserted]
          
    FROM   [dbo].[WorkOrder]
    WHERE  [WorkOrderID] = @WorkOrderID

GO
