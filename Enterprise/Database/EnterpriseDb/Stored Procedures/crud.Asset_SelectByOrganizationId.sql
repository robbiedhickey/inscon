
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Asset_SelectByOrganizationId]
  @OrganizationID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [AssetID],
           [OrganizationID],
           [TypeID],
           [AssetNumber],
           [LoanNumber],
           [LoanTypeID],
           [MortgagorName],
           [MortgagorPhone],
           [HudCaseNumber],
           [ConveyanceDate],
           [FirstTimeVacantDate]
    FROM   [dbo].[Asset]
    WHERE  [OrganizationID] = @OrganizationID

GO
