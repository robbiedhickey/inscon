SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[PasswordHistory_SelectRecentByUsername] @userName                            NVARCHAR(256)
                                             , @numberOfRecentPasswordsToRetrieve INT
AS
  BEGIN
      DECLARE @userId UNIQUEIDENTIFIER

      SELECT
          @userId = UserId
      FROM   dbo.aspnet_Users
      WHERE
          UserName = @userName

      SELECT
          TOP(@numberOfRecentPasswordsToRetrieve)
          [Password]
          , PasswordSalt
      FROM   dbo.PasswordHistory
      WHERE
          UserId = @userId
      ORDER  BY
          DateCreated DESC
  END 

GO
