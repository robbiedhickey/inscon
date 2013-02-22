
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Request_Delete]
  @RequestID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [request].[Request]
    WHERE  [RequestID] = @RequestID
GO
