SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Mortgagor_Insert]
  @LoanID INT,
  @Name   VARCHAR(60),
  @TypeID INT,
  @Phone  VARCHAR(15)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [dbo].[Mortgagor]
    (
      [LoanID],
      [Name],
      [TypeID],
      [Phone]
    )
    VALUES
    (
      @LoanID,
      @Name,
      @TypeID,
      @Phone
    )
    -- Begin Return Select <- do not remove
    SELECT [MortgagorID],
           [LoanID],
           [Name],
           [TypeID],
           [Phone]
    FROM   [dbo].[Mortgagor]
    WHERE  [MortgagorID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove

GO
