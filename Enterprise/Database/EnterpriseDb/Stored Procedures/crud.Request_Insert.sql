
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Request_Insert]
  @OrganizationID    INT,
  @DateInserted      DATETIME,
  @CustomerRequestID VARCHAR(30)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [dbo].[Request]
    (
      [OrganizationID],
      [DateInserted],
      [CustomerRequestID]
    )
    VALUES
    (
      @OrganizationID,
      IsNull(@DateInserted, GETDATE()),
      @CustomerRequestID
    )
    -- Begin Return Select <- do not remove
    SELECT [RequestID],
           [OrganizationID],
           [DateInserted],
           [CustomerRequestID]
    FROM   [dbo].[Request]
    WHERE  [RequestID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove

GO
