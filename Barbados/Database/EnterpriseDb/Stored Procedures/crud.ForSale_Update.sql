SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[ForSale_Update]
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

    UPDATE [inspection].[ForSale]
    SET    [WorkOrderID] = @WorkOrderID,
           [PropertyForSaleByID] = @PropertyForSaleByID,
           [RealtorName] = @RealtorName,
           [RealtorPhone] = @RealtorPhone,
           [ActiveListingID] = @ActiveListingID,
           [ListPrice] = @ListPrice,
           [DaysOnMarket] = @DaysOnMarket
    WHERE  [WorkOrderID] = @WorkOrderID

GO
