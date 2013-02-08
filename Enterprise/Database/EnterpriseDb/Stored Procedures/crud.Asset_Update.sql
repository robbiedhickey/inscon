
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Asset_Update]
  @AssetID        INT,
  @OrganizationID INT,
  @TypeID         INT,
  @AssetNumber    VARCHAR(20),
  @LoanNumber     VARCHAR(30),
  @LoanTypeID     INT,
  @MortgagorName  VARCHAR(38),
  @MortgagorPhone VARCHAR(15),
  @HudCaseNumber  VARCHAR(20),
  @LoanID         INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [dbo].[Asset]
    SET    [OrganizationID] = @OrganizationID,
           [TypeID] = @TypeID,
           [AssetNumber] = @AssetNumber,
           [LoanNumber] = @LoanNumber,
           [LoanTypeID] = @LoanTypeID,
           [MortgagorName] = @MortgagorName,
           [MortgagorPhone] = @MortgagorPhone,
           [HudCaseNumber] = @HudCaseNumber,
           [LoanID] = @LoanID
    WHERE  [AssetID] = @AssetID

GO
