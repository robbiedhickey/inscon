SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Product_Update]
  @ProductID         INT,
  @ProductCategoryID INT,
  @Caption           VARCHAR(50),
  @Code              VARCHAR(8),
  @SKU               VARCHAR(20),
  @Rate              DECIMAL(18, 2),
  @Cost              DECIMAL(18, 2)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [dbo].[Product]
    SET    [ProductCategoryID] = @ProductCategoryID,
           [Caption] = @Caption,
           [Code] = @Code,
           [SKU] = @SKU,
           [Rate] = @Rate,
           [Cost] = @Cost
    WHERE  [ProductID] = @ProductID

GO
