SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[PropertyDamage_Delete] 
    @WorkOrderID int
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	DELETE
	FROM   [inspection].[PropertyDamage]
	WHERE  [WorkOrderID] = @WorkOrderID


GO
