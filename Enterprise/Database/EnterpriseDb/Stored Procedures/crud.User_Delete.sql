
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[User_Delete]
  @UserID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [organization].[User]
    WHERE  [UserID] = @UserID
GO
