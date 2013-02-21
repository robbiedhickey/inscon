SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[ForSale_Insert]
  @WorkOrderID         INT,
  @PropertyForSaleByID INT,
  @RealtorName         VARCHAR(30),
  @RealtorPhone        VARCHAR(10),
  @ActiveListingID     INT,
  @ListPrice           DECIMAL(18, 2),
  @DaysOnMarket        SMALLINT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [inspection].[ForSale]
    (
      [WorkOrderID],
      [PropertyForSaleByID],
      [RealtorName],
      [RealtorPhone],
      [ActiveListingID],
      [ListPrice],
      [DaysOnMarket]
    )
    VALUES
    (
      @WorkOrderID,
      @PropertyForSaleByID,
      @RealtorName,
      @RealtorPhone,
      @ActiveListingID,
      @ListPrice,
      @DaysOnMarket
    )
    -- Begin Return Select <- do not remove
    SELECT [WorkOrderID],
           [PropertyForSaleByID],
           [RealtorName],
           [RealtorPhone],
           [ActiveListingID],
           [ListPrice],
           [DaysOnMarket]
    FROM   [inspection].[ForSale]
    WHERE  [WorkOrderID] = @WorkOrderID

-- End Return Select <- do not remove

GO
