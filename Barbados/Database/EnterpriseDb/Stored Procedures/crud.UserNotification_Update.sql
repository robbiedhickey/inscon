
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[UserNotification_Update]
  @UserNotificationID INT,
  @UserID             INT,
  @DatePosted         DATETIME,
  @DateRead           DATETIME
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [organization].[UserNotification]
    SET    [UserID] = @UserID,
           [DatePosted] = @DatePosted,
           [DateRead] = @DateRead
    WHERE  [UserNotificationID] = @UserNotificationID
GO
