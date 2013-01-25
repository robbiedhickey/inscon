
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[User_SelectByOrganizationId]
  @OrganizationID INT
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
    FROM   [dbo].[User]
    WHERE  [OrganizationID] = @OrganizationID

GO
