
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Exterior_SelectById]
  @WorkOrderID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [WorkOrderID],
           [ConstructionTypeID],
           [BuildingTypeID],
           [StoriesID],
           [PrimaryColorID],
           [RoofTypeID],
           [PoolOnSiteID],
           [PoolSecuredID],
           [PoolDrainedID],
           [DoorTagStatusID],
           [ContactMade],
           [OccupancyID],
           [OccupancyVerifiedByID],
           [PropertyConditionID],
           [NeighborhoodConditionID],
           [EMVID],
           [ElectricID],
           [WaterID],
           [GasID],
           [PersonalPropertyOnSiteID],
           [IsWinterizedID],
           [WinterizedByID],
           [WinterizedDate],
           [HowLongVacant],
           [HazardsExist],
           [PersonInterviewed],
           [ManagingCompany]
    FROM   [inspection].[Exterior]
    WHERE  [WorkOrderID] = @WorkOrderID

GO
