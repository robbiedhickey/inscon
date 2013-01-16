SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Loan_Insert]
  @OrganizationID INT,
  @TypeID         INT,
  @LoanNumber     VARCHAR(30),
  @HudCaseNumber  VARCHAR(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [dbo].[Loan]
    (
      [OrganizationID],
      [TypeID],
      [LoanNumber],
      [HudCaseNumber]
    )
    VALUES
    (
      @OrganizationID,
      @TypeID,
      @LoanNumber,
      @HudCaseNumber
    )
    -- Begin Return Select <- do not remove
    SELECT [LoanID],
           [OrganizationID],
           [TypeID],
           [LoanNumber],
           [HudCaseNumber]
    FROM   [dbo].[Loan]
    WHERE  [LoanID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove

GO
