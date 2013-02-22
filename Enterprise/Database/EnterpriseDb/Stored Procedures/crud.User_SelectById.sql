
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[User_SelectById]
  @UserID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [UserID],
           [OrganizationID],
           [FirstName],
           [LastName],
           [Title],
           [StatusID],
           [AuthenticationID]
    FROM   [organization].[User]
    WHERE  [UserID] = @UserID
GO
