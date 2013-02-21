SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Maintenance_Update]
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

    UPDATE [inspection].[Maintenance]
    SET    [WorkOrderID] = @WorkOrderID,
           [ChangeLocks] = @ChangeLocks,
           [ReplaceGlass] = @ReplaceGlass,
           [BoardSecure] = @BoardSecure,
           [Winterize] = @Winterize,
           [CutGrass] = @CutGrass,
           [GrassHeightInches] = @GrassHeightInches,
           [DrainPool] = @DrainPool,
           [RemoveDebris] = @RemoveDebris,
           [RecommendedOther] = @RecommendedOther
    WHERE  [WorkOrderID] = @WorkOrderID

GO
