SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Maintenance_Delete]
  @WorkOrderID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [inspection].[Maintenance]
    WHERE  [WorkOrderID] = @WorkOrderID

GO
