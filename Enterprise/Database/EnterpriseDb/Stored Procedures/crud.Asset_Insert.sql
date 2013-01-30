SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Asset_Insert]
  @OrganizationID INT,
  @TypeID         INT,
  @LoanID         INT,
  @AssetNumber    VARCHAR(20)
 
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [dbo].[Asset]
    (
      [OrganizationID],
      [TypeID],
      [LoanID],
      [AssetNumber]
    )
    VALUES
    (
      @OrganizationID,
      @TypeID,
      @LoanID,
      @AssetNumber
    )
    -- Begin Return Select <- do not remove
    SELECT [AssetID],
           [OrganizationID],
           [TypeID],
           [LoanID],
           [AssetNumber]
    FROM   [dbo].[Asset]
    WHERE  [AssetID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove

GO
