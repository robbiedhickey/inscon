SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[UserContact_SelectById]
  @UserContactID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [UserContactID],
           [UserID],
           [Value],
           [TypeID],
           [IsPrimary]
    FROM   [dbo].[UserContact]
    WHERE  [UserContactID] = @UserContactID

GO
