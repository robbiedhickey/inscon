SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Renter_InsertUpdate]
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

If(LEN(@RenterName) = 0) SET @RenterName = NULL
If(LEN(@RenterPhone) = 0) SET @RenterPhone = NULL
If(LEN(@RentPaidTo) = 0) SET @RentPaidTo = NULL
If(LEN(@RentPaidToAddress) = 0) SET @RentPaidToAddress = NULL


-- DOES RECORD EXIST?
SELECT WorkOrderID FROM [inspection].[Renter] WHERE WorkOrderID = @WorkOrderID

IF( @@ROWCOUNT > 0)
	BEGIN
	-- UPDATE RECORD
	UPDATE [inspection].[Renter]
	SET    [WorkOrderID] = @WorkOrderID,
		   [RenterName] = @RenterName,
		   [RenterPhone] = @RenterPhone,
		   [RentPaidTo] = @RentPaidTo,
		   [RentPaidToAddress] = @RentPaidToAddress,
		   [RentCurrent] = @RentCurrent,
		   [RentAmountMonthly] = @RentAmountMonthly
	WHERE  [WorkOrderID] = @WorkOrderID
	END
ELSE
	-- INSERT RECORD
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
GO
