SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Renter_Insert]
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

    INSERT INTO [inspection].[Renter]
    (
      [WorkOrderID],
      [RenterName],
      [RenterPhone],
      [RentPaidTo],
      [RentPaidToAddress],
      [RentCurrent],
      [RentAmountMonthly]
    )
    VALUES
    (
      @WorkOrderID,
      @RenterName,
      @RenterPhone,
      @RentPaidTo,
      @RentPaidToAddress,
      @RentCurrent,
      @RentAmountMonthly
    )
    -- Begin Return Select <- do not remove
    SELECT [WorkOrderID],
           [RenterName],
           [RenterPhone],
           [RentPaidTo],
           [RentPaidToAddress],
           [RentCurrent],
           [RentAmountMonthly]
    FROM   [inspection].[Renter]
    WHERE  [WorkOrderID] = @WorkOrderID

-- End Return Select <- do not remove

GO
