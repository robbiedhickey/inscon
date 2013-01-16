SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Request_Update]
  @RequestID         INT,
  @OrganizationID    INT,
  @DateInserted      DATETIME,
  @CustomerRequestID VARCHAR(30)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [dbo].[Request]
    SET    [OrganizationID] = @OrganizationID,
           [DateInserted] = @DateInserted,
           [CustomerRequestID] = @CustomerRequestID
    WHERE  [RequestID] = @RequestID

GO
