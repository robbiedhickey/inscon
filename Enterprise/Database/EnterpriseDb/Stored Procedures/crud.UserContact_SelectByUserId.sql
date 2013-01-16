SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[UserContact_SelectByUserId]
  @UserID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [UserContactID],
           [UserID],
           [Value],
           [TypeID],
           [IsPrimary]
    FROM   [dbo].[UserContact]
    WHERE  [UserID] = @UserID

GO
