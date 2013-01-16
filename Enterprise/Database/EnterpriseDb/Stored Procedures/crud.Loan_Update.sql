SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Loan_Update]
  @LoanID         INT,
  @OrganizationID INT,
  @TypeID         INT,
  @LoanNumber     VARCHAR(30),
  @HudCaseNumber  VARCHAR(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [dbo].[Loan]
    SET    [OrganizationID] = @OrganizationID,
           [TypeID] = @TypeID,
           [LoanNumber] = @LoanNumber,
           [HudCaseNumber] = @HudCaseNumber
    WHERE  [LoanID] = @LoanID

GO
