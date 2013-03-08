SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[PropertyDamage_SelectById] 
    @WorkOrderID INT
AS 
	SET NOCOUNT ON 
	SET XACT_ABORT ON  

	SELECT [WorkOrderID], [Vandalized], [FireDamage], [LiabilityHazard], [StormDamage], [FloodDamage], [FreezeDamage], [RoofLeak], [Neglected], [EarthquakeDamage], [CityViolation], [Mold], [BrokenWindows], [BurstPipes], [StructuralDamage] 
	FROM   [inspection].[PropertyDamage] 
	WHERE  [WorkOrderID] = @WorkOrderID 


GO
