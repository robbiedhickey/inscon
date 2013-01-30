
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[User_Update]
  @UserID           INT,
  @OrganizationID   INT,
  @FirstName        VARCHAR(28),
  @LastName         VARCHAR(28),
  @Title            VARCHAR(50),
  @StatusID         INT,
  @AuthenticationID [UNIQUEIDENTIFIER]
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [dbo].[User]
    SET    [OrganizationID] = @OrganizationID,
           [FirstName] = @FirstName,
           [LastName] = @LastName,
           [Title] = @Title,
           [StatusID] = @StatusID,
           [AuthenticationID] = @AuthenticationID
    WHERE  [UserID] = @UserID 
GO
