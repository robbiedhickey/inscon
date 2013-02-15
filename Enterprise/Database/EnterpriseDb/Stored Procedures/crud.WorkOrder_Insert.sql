
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[WorkOrder_Insert]
  @RequestID    INT,
  @AssetID       INT,
  @DateInserted DATETIME

AS
    SET NOCOUNT ON
    SET XACT_ABORT ON
    
    
    BEGIN TRAN InsertWorkorderTran
    
    
    -- IF REQUESTID IS NULL GET A NEW REQUESTID
    If(@RequestID = null)
    BEGIN
		INSERT INTO [dbo].[Request]([DateInserted], [CustomerRequestID])VALUES(null,null)
		SET @RequestID = SCOPE_IDENTITY()
    END
   
    
    -- INSERT WORK ORDER RECORD
    INSERT INTO [dbo].[WorkOrder]
    (
      [RequestID],
      [AssetID],
      [DateInserted]
      
    )
    VALUES
    (
      @RequestID,
      @AssetID,
      @DateInserted
     
    )
    -- Begin Return Select <- do not remove
    SELECT *           
    FROM   [dbo].[WorkOrder]
    WHERE  [WorkOrderID] = SCOPE_IDENTITY()
    
   
    IF (@@ERROR <> 0) GOTO ERR_HANDLER

	COMMIT TRAN

	RETURN 0

	ERR_HANDLER:	
	ROLLBACK TRAN
	RETURN 1

GO
