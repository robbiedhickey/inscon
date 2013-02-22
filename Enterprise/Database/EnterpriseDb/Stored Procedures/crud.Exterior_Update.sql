
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Exterior_Update]
  @WorkOrderID              INT,
  @ConstructionTypeID       INT,
  @BuildingTypeID           INT,
  @StoriesID                INT,
  @PrimaryColorID           INT,
  @RoofTypeID               INT,
  @PoolOnSiteID             INT,
  @PoolSecuredID            INT,
  @PoolDrainedID            INT,
  @DoorTagStatusID          INT,
  @ContactMade              BIT,
  @OccupancyID              INT,
  @OccupancyVerifiedByID    INT,
  @PropertyConditionID      INT,
  @NeighborhoodConditionID  INT,
  @EMVID                    INT,
  @ElectricID               INT,
  @WaterID                  INT,
  @GasID                    INT,
  @PersonalPropertyOnSiteID INT,
  @IsWinterizedID           INT,
  @WinterizedByID           INT,
  @WinterizedDate           DATETIME,
  @HowLongVacant            VARCHAR(15),
  @HazardsExist             INT,
  @PersonInterviewed        VARCHAR(30),
  @ManagingCompany          VARCHAR(36)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [inspection].[Exterior]
    SET    [WorkOrderID] = @WorkOrderID,
           [ConstructionTypeID] = @ConstructionTypeID,
           [BuildingTypeID] = @BuildingTypeID,
           [StoriesID] = @StoriesID,
           [PrimaryColorID] = @PrimaryColorID,
           [RoofTypeID] = @RoofTypeID,
           [PoolOnSiteID] = @PoolOnSiteID,
           [PoolSecuredID] = @PoolSecuredID,
           [PoolDrainedID] = @PoolDrainedID,
           [DoorTagStatusID] = @DoorTagStatusID,
           [ContactMade] = @ContactMade,
           [OccupancyID] = @OccupancyID,
           [OccupancyVerifiedByID] = @OccupancyVerifiedByID,
           [PropertyConditionID] = @PropertyConditionID,
           [NeighborhoodConditionID] = @NeighborhoodConditionID,
           [EMVID] = @EMVID,
           [ElectricID] = @ElectricID,
           [WaterID] = @WaterID,
           [GasID] = @GasID,
           [PersonalPropertyOnSiteID] = @PersonalPropertyOnSiteID,
           [IsWinterizedID] = @IsWinterizedID,
           [WinterizedByID] = @WinterizedByID,
           [WinterizedDate] = @WinterizedDate,
           [HowLongVacant] = @HowLongVacant,
           [HazardsExist] = @HazardsExist,
           [PersonInterviewed] = @PersonInterviewed,
           [ManagingCompany] = @ManagingCompany
    WHERE  [WorkOrderID] = @WorkOrderID

GO
