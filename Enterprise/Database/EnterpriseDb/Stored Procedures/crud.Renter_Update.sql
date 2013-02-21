SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Renter_Update]
  @WorkOrderID       INT,
  @RenterName        VARCHAR(50),
  @RenterPhone       VARCHAR(10),
  @RentPaidTo        VARCHAR(30),
  @RentPaidToAddress VARCHAR(65),
  @RentCurrent       BIT,
  @RentAmountMonthly DECIMAL(15, 2)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [inspection].[Renter]
    SET    [WorkOrderID] = @WorkOrderID,
           [RenterName] = @RenterName,
           [RenterPhone] = @RenterPhone,
           [RentPaidTo] = @RentPaidTo,
           [RentPaidToAddress] = @RentPaidToAddress,
           [RentCurrent] = @RentCurrent,
           [RentAmountMonthly] = @RentAmountMonthly
    WHERE  [WorkOrderID] = @WorkOrderID

GO
