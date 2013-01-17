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
           [StatusID]
    FROM   [dbo].[User]
    WHERE  [UserID] = @OrganizationID

GO