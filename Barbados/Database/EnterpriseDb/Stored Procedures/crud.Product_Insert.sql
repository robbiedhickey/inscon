
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Product_Insert]
  @ProductCategoryID INT,
  @Caption           VARCHAR(50),
  @Code              VARCHAR(8),
  @SKU               VARCHAR(20),
  @Rate              DECIMAL(18, 2),
  @Cost              DECIMAL(18, 2)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [inventory].[Product]
    (
      [ProductCategoryID],
      [Caption],
      [Code],
      [SKU],
      [Rate],
      [Cost]
    )
    VALUES
    (
      @ProductCategoryID,
      @Caption,
      @Code,
      @SKU,
      @Rate,
      @Cost
    )
    -- Begin Return Select <- do not remove
    SELECT [ProductID],
           [ProductCategoryID],
           [Caption],
           [Code],
           [SKU],
           [Rate],
           [Cost]
    FROM   [inventory].[Product]
    WHERE  [ProductID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove
GO
