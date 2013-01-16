SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Location_SelectByOrganizationId]
  @OrganizationID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [LocationID],
           [OrganizationID],
           [Name],
           [Code],
           [TypeID]
    FROM   [dbo].[Location]
    WHERE  [OrganizationID] = @OrganizationID

GO
