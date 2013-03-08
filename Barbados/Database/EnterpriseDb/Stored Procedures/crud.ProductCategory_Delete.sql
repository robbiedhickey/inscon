
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[ProductCategory_Delete]
  @ProductCategoryID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [inventory].[ProductCategory]
    WHERE  [ProductCategoryID] = @ProductCategoryID
GO
