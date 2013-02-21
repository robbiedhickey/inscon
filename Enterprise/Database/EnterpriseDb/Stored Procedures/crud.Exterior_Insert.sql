SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Exterior_Insert]
  @WorkOrderID             INT,
  @ConstructionTypeID      INT,
  @BuildingTypeID          INT,
  @StoriesID               INT,
  @PrimaryColorID          INT,
  @RoofTypeID              INT,
  @PoolOnSite              TINYINT,
  @PoolSecured             TINYINT,
  @PoolDrained             TINYINT,
  @DoorTagStatusID         INT,
  @ContactMade             TINYINT,
  @OccupancyID             INT,
  @OccupancyVerifiedByID   INT,
  @PropertyConditionID     INT,
  @NeighborhoodConditionID INT,
  @EMVID                   INT,
  @ElectricID              INT,
  @WaterID                 INT,
  @GasID                   INT,
  @PersonalPropertyOnSite  TINYINT,
  @IsWinterized            TINYINT,
  @idWinterizedByType      INT,
  @WinterizedDate          DATETIME,
  @HowLongVacant           VARCHAR(15),
  @HazardsExist            INT,
  @PersonInterviewed       VARCHAR(30),
  @ManagingCompany         VARCHAR(36)
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
      [PoolOnSite],
      [PoolSecured],
      [PoolDrained],
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
      [PersonalPropertyOnSite],
      [IsWinterized],
      [idWinterizedByType],
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
      @PoolOnSite,
      @PoolSecured,
      @PoolDrained,
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
      @PersonalPropertyOnSite,
      @IsWinterized,
      @idWinterizedByType,
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
           [PoolOnSite],
           [PoolSecured],
           [PoolDrained],
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
           [PersonalPropertyOnSite],
           [IsWinterized],
           [idWinterizedByType],
           [WinterizedDate],
           [HowLongVacant],
           [HazardsExist],
           [PersonInterviewed],
           [ManagingCompany]
    FROM   [inspection].[Exterior]
    WHERE  [WorkOrderID] = @WorkOrderID

-- End Return Select <- do not remove

GO
