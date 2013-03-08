
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[UserNotification_Insert]
  @UserID     INT,
  @DatePosted DATETIME,
  @DateRead   DATETIME
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [organization].[UserNotification]
    (
      [UserID],
      [DatePosted],
      [DateRead]
    )
    VALUES
    (
      @UserID,
      @DatePosted,
      @DateRead
    )
    -- Begin Return Select <- do not remove
    SELECT [UserNotificationID],
           [UserID],
           [DatePosted],
           [DateRead]
    FROM   [organization].[UserNotification]
    WHERE  [UserNotificationID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove
GO
