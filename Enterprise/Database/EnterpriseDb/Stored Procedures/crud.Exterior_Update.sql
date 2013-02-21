SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Exterior_Update]
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

    UPDATE [inspection].[Exterior]
    SET    [WorkOrderID] = @WorkOrderID,
           [ConstructionTypeID] = @ConstructionTypeID,
           [BuildingTypeID] = @BuildingTypeID,
           [StoriesID] = @StoriesID,
           [PrimaryColorID] = @PrimaryColorID,
           [RoofTypeID] = @RoofTypeID,
           [PoolOnSite] = @PoolOnSite,
           [PoolSecured] = @PoolSecured,
           [PoolDrained] = @PoolDrained,
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
           [PersonalPropertyOnSite] = @PersonalPropertyOnSite,
           [IsWinterized] = @IsWinterized,
           [idWinterizedByType] = @idWinterizedByType,
           [WinterizedDate] = @WinterizedDate,
           [HowLongVacant] = @HowLongVacant,
           [HazardsExist] = @HazardsExist,
           [PersonInterviewed] = @PersonInterviewed,
           [ManagingCompany] = @ManagingCompany
    WHERE  [WorkOrderID] = @WorkOrderID

GO
