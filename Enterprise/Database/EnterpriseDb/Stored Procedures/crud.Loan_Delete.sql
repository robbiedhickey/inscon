SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Loan_Delete]
  @LoanID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [dbo].[Loan]
    WHERE  [LoanID] = @LoanID

GO
