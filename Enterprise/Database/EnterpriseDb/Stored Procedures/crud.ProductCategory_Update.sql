SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[ProductCategory_Update]
  @ProductCategoryID INT,
  @Name              VARCHAR(50),
  @Code              VARCHAR(8)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [dbo].[ProductCategory]
    SET    [Name] = @Name,
           [Code] = @Code
    WHERE  [ProductCategoryID] = @ProductCategoryID

GO
