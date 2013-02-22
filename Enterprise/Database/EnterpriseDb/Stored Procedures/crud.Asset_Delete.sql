
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Asset_Delete]
  @AssetID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [organization].[Asset]
    WHERE  [AssetID] = @AssetID
GO
