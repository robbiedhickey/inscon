
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[UserNotification_SelectByUserId]
  @UserID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [UserNotificationID],
           [UserID],
           [DatePosted],
           [DateRead]
    FROM   [organization].[UserNotification]
    WHERE  [UserID] = @UserID
GO
