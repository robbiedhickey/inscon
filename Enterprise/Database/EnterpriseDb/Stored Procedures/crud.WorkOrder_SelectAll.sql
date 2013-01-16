SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[WorkOrder_SelectAll]

AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [WorkOrderID],
           [RequestID],
           [LoanID],
           [DateInserted]
          
    FROM   [dbo].[WorkOrder]
   

GO
