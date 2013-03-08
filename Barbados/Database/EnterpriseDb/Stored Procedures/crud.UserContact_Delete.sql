
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[UserContact_Delete]
  @UserContactID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [organization].[UserContact]
    WHERE  [UserContactID] = @UserContactID
GO
