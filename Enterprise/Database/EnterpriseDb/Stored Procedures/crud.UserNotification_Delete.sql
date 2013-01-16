SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[UserNotification_Delete]
  @UserNotificationID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [dbo].[UserNotification]
    WHERE  [UserNotificationID] = @UserNotificationID

GO
