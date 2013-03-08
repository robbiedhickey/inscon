SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Maintenance_SelectById]
  @WorkOrderID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

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

GO
