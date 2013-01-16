SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[WorkOrder_Update]
  @WorkOrderID  INT,
  @RequestID    INT,
  @LoanID       INT,
  @DateInserted DATETIME
  
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [dbo].[WorkOrder]
    SET    [RequestID] = @RequestID,
           [LoanID] = @LoanID,
           [DateInserted] = @DateInserted
         
    WHERE  [WorkOrderID] = @WorkOrderID

GO
