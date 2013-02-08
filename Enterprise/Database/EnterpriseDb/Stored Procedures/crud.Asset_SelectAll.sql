
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Asset_SelectAll]
  
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
           [LoanID]
    FROM   [dbo].[Asset]

GO
