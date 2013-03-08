
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Asset_SelectById]
  @AssetID INT
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
    FROM   [organization].[Asset]
    WHERE  [AssetID] = @AssetID
GO
