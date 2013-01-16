SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Mortgagor_Update]
  @MortgagorID INT,
  @LoanID      INT,
  @Name        VARCHAR(60),
  @TypeID      INT,
  @Phone       VARCHAR(15)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [dbo].[Mortgagor]
    SET    [LoanID] = @LoanID,
           [Name] = @Name,
           [TypeID] = @TypeID,
           [Phone] = @Phone
    WHERE  [MortgagorID] = @MortgagorID

GO
