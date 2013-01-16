SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[User_Insert]
  @OrganizationID INT,
  @FirstName      VARCHAR(28),
  @LastName       VARCHAR(28),
  @Title          VARCHAR(50),
  @StatusID       INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [dbo].[User]
    (
      [OrganizationID],
      [FirstName],
      [LastName],
      [Title],
      [StatusID]
    )
    VALUES
    (
      @OrganizationID,
      @FirstName,
      @LastName,
      @Title,
      @StatusID
    )
    -- Begin Return Select <- do not remove
    SELECT [UserID],
           [OrganizationID],
           [FirstName],
           [LastName],
           [Title],
           [StatusID]
    FROM   [dbo].[User]
    WHERE  [UserID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove

GO
