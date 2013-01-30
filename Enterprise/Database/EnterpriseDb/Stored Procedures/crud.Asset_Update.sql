SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Asset_Update]
  @AssetID        INT,
  @OrganizationID INT,
  @TypeID         INT,
  @LoanID         INT,
  @AssetNumber    VARCHAR(20)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [dbo].[Asset]
    SET    [OrganizationID] = @OrganizationID,
           [TypeID] = @TypeID,
           [LoanID] = @LoanID,
           [AssetNumber] = @AssetNumber
    WHERE  [AssetID] = @AssetID

GO
