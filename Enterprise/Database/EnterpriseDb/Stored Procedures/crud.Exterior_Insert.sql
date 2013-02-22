
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Exterior_Insert]
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

    INSERT INTO [inspection].[Exterior]
    (
      [WorkOrderID],
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
    )
    VALUES
    (
      @WorkOrderID,
      @ConstructionTypeID,
      @BuildingTypeID,
      @StoriesID,
      @PrimaryColorID,
      @RoofTypeID,
      @PoolOnSiteID,
      @PoolSecuredID,
      @PoolDrainedID,
      @DoorTagStatusID,
      @ContactMade,
      @OccupancyID,
      @OccupancyVerifiedByID,
      @PropertyConditionID,
      @NeighborhoodConditionID,
      @EMVID,
      @ElectricID,
      @WaterID,
      @GasID,
      @PersonalPropertyOnSiteID,
      @IsWinterizedID,
      @WinterizedByID,
      @WinterizedDate,
      @HowLongVacant,
      @HazardsExist,
      @PersonInterviewed,
      @ManagingCompany
    )
    -- Begin Return Select <- do not remove
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

-- End Return Select <- do not remove

GO
