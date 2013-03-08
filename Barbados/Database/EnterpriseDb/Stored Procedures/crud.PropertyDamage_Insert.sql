SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[PropertyDamage_Insert] 
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
	
	INSERT INTO [inspection].[PropertyDamage] ([WorkOrderID], [Vandalized], [FireDamage], [LiabilityHazard], [StormDamage], [FloodDamage], [FreezeDamage], [RoofLeak], [Neglected], [EarthquakeDamage], [CityViolation], [Mold], [BrokenWindows], [BurstPipes], [StructuralDamage])
	VALUES
		(
		 @WorkOrderID, @Vandalized, @FireDamage, @LiabilityHazard, @StormDamage, @FloodDamage, @FreezeDamage, @RoofLeak, @Neglected, @EarthquakeDamage, @CityViolation, @Mold, @BrokenWindows, @BurstPipes, @StructuralDamage
		)
	
	-- Begin Return Select <- do not remove
	SELECT [WorkOrderID], [Vandalized], [FireDamage], [LiabilityHazard], [StormDamage], [FloodDamage], [FreezeDamage], [RoofLeak], [Neglected], [EarthquakeDamage], [CityViolation], [Mold], [BrokenWindows], [BurstPipes], [StructuralDamage]
	FROM   [inspection].[PropertyDamage]
	WHERE  [WorkOrderID] = @WorkOrderID
	-- End Return Select <- do not remove


GO
