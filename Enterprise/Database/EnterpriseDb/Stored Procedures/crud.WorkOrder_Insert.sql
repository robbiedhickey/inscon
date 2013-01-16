SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[WorkOrder_Insert]
  @RequestID    INT,
  @LoanID       INT,
  @DateInserted DATETIME

AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [dbo].[WorkOrder]
    (
      [RequestID],
      [LoanID],
      [DateInserted]
      
    )
    VALUES
    (
      @RequestID,
      @LoanID,
      @DateInserted
     
    )
    -- Begin Return Select <- do not remove
    SELECT [WorkOrderID],
           [RequestID],
           [LoanID],
           [DateInserted]
           
    FROM   [dbo].[WorkOrder]
    WHERE  [WorkOrderID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove

GO
