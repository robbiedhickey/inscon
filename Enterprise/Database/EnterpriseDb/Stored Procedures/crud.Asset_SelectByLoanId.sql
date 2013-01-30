SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Asset_SelectByLoanId]
  @LoanID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [AssetID],
           [OrganizationID],
           [TypeID],
           [LoanID],
           [AssetNumber]
    FROM   [dbo].[Asset]
    WHERE  [LoanID] = @LoanID

GO
