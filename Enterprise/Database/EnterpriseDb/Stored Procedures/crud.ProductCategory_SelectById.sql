SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[ProductCategory_SelectById]
  @ProductCategoryID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [ProductCategoryID],
           [Name],
           [Code]
    FROM   [dbo].[ProductCategory]
    WHERE  [ProductCategoryID] = @ProductCategoryID

GO
