
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Request_Update]
  @RequestID         INT,  
  @DateInserted      DATETIME,
  @CustomerRequestID VARCHAR(30)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [request].[Request]
        SET    
           [DateInserted] = @DateInserted,
           [CustomerRequestID] = @CustomerRequestID
    WHERE  [RequestID] = @RequestID
GO
