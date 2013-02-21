SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[PropertyDamage_Update] 
    @WorkOrderID int,
    @Vandalized bit,
    @FireDamage bit,
    @LiabilityHazard bit,
    @StormDamage bit,
    @FloodDamage bit,
    @FreezeDamage bit,
    @RoofLeak bit,
    @Neglected bit,
    @EarthquakeDamage bit,
    @CityViolation bit,
    @Mold bit,
    @BrokenWindows bit,
    @BurstPipes bit,
    @StructuralDamage bit
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	UPDATE [inspection].[PropertyDamage]
	SET    [WorkOrderID] = @WorkOrderID, [Vandalized] = @Vandalized, [FireDamage] = @FireDamage, [LiabilityHazard] = @LiabilityHazard, [StormDamage] = @StormDamage, [FloodDamage] = @FloodDamage, [FreezeDamage] = @FreezeDamage, [RoofLeak] = @RoofLeak, [Neglected] = @Neglected, [EarthquakeDamage] = @EarthquakeDamage, [CityViolation] = @CityViolation, [Mold] = @Mold, [BrokenWindows] = @BrokenWindows, [BurstPipes] = @BurstPipes, [StructuralDamage] = @StructuralDamage
	WHERE  [WorkOrderID] = @WorkOrderID	


GO
