SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Loss_Delete]
  @WorkOrderID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [inspection].[Loss]
    WHERE  [WorkOrderID] = @WorkOrderID

GO
