
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Product_Delete]
  @ProductID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [inventory].[Product]
    WHERE  [ProductID] = @ProductID
GO
