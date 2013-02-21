SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Renter_SelectById]
  @WorkOrderID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [WorkOrderID],
           [RenterName],
           [RenterPhone],
           [RentPaidTo],
           [RentPaidToAddress],
           [RentCurrent],
           [RentAmountMonthly]
    FROM   [inspection].[Renter]
    WHERE  [WorkOrderID] = @WorkOrderID

GO
