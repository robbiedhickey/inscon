SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Loan_SelectAll]

AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [LoanID],
           [OrganizationID],
           [TypeID],
           [LoanNumber],
           [HudCaseNumber]
    FROM   [dbo].[Loan]   

GO
