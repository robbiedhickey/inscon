
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Request_Insert]
  @DateInserted      DATETIME,
  @CustomerRequestID VARCHAR(30)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [request].[Request]
    (  
      [DateInserted],
      [CustomerRequestID]
    )
    VALUES
    (   
      IsNull(@DateInserted, GETDATE()),
      @CustomerRequestID
    )
    -- Begin Return Select <- do not remove
    SELECT [RequestID],         
           [DateInserted],
           [CustomerRequestID]
    FROM   [request].[Request]
    WHERE  [RequestID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove
GO
