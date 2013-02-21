SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Maintenance_Insert]
  @WorkOrderID       INT,
  @ChangeLocks       BIT,
  @ReplaceGlass      BIT,
  @BoardSecure       BIT,
  @Winterize         BIT,
  @CutGrass          BIT,
  @GrassHeightInches TINYINT,
  @DrainPool         BIT,
  @RemoveDebris      BIT,
  @RecommendedOther  VARCHAR(30)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [inspection].[Maintenance]
    (
      [WorkOrderID],
      [ChangeLocks],
      [ReplaceGlass],
      [BoardSecure],
      [Winterize],
      [CutGrass],
      [GrassHeightInches],
      [DrainPool],
      [RemoveDebris],
      [RecommendedOther]
    )
    VALUES
    (
      @WorkOrderID,
      @ChangeLocks,
      @ReplaceGlass,
      @BoardSecure,
      @Winterize,
      @CutGrass,
      @GrassHeightInches,
      @DrainPool,
      @RemoveDebris,
      @RecommendedOther
    )
    -- Begin Return Select <- do not remove
    SELECT [WorkOrderID],
           [ChangeLocks],
           [ReplaceGlass],
           [BoardSecure],
           [Winterize],
           [CutGrass],
           [GrassHeightInches],
           [DrainPool],
           [RemoveDebris],
           [RecommendedOther]
    FROM   [inspection].[Maintenance]
    WHERE  [WorkOrderID] = @WorkOrderID

-- End Return Select <- do not remove

GO
