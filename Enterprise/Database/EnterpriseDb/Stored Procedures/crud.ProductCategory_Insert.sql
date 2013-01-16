SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[ProductCategory_Insert]
  @Name VARCHAR(50),
  @Code VARCHAR(8)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [dbo].[ProductCategory]
    (
      [Name],
      [Code]
    )
    VALUES
    (
      @Name,
      @Code
    )
    -- Begin Return Select <- do not remove
    SELECT [ProductCategoryID],
           [Name],
           [Code]
    FROM   [dbo].[ProductCategory]
    WHERE  [ProductCategoryID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove

GO
