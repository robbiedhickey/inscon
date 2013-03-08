SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[ForSale_SelectById]
  @WorkOrderID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [WorkOrderID],
           [PropertyForSaleByID],
           [RealtorName],
           [RealtorPhone],
           [ActiveListingID],
           [ListPrice],
           [DaysOnMarket]
    FROM   [inspection].[ForSale]
    WHERE  [WorkOrderID] = @WorkOrderID

GO
