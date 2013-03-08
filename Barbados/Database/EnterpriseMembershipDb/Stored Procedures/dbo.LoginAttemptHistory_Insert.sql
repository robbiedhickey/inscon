SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO


CREATE PROCEDURE [dbo].[LoginAttemptHistory_Insert] @userName        VARCHAR(256)
                                                    , @wasSuccessful BIT
                                                    , @appName VARCHAR(50)
AS
    DECLARE @userId UNIQUEIDENTIFIER

    SELECT
        @userId = UserId
    FROM   dbo.aspnet_Users
    WHERE
        @userName = UserName

    INSERT INTO [dbo].[LoginAttemptHistory]
    VALUES
    (
        @userId
        , @wasSuccessful
        , @appName
        , GETDATE()
    ) 
GO
