SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Mortgagor_SelectAll]

AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [MortgagorID],
           [LoanID],
           [Name],
           [TypeID],
           [Phone]
    FROM   [dbo].[Mortgagor]
 

GO
