SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[UserNotification_SelectById]
  @UserNotificationID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [UserNotificationID],
           [UserID],
           [DatePosted],
           [DateRead]
    FROM   [dbo].[UserNotification]
    WHERE  [UserNotificationID] = @UserNotificationID

GO
