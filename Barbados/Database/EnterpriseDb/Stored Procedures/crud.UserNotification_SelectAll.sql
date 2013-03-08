
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[UserNotification_SelectAll]
 
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [UserNotificationID],
           [UserID],
           [DatePosted],
           [DateRead]
    FROM   [organization].[UserNotification]
GO
