SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Address_SelectByParentIdAndEntityId]
  @ParentID INT,
  @EntityID SMALLINT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [AddressID],
           [ParentID],
           [EntityID],
           [Street],
           [Suite],
           [City],
           [State],
           [Zip]
    FROM   [generic].[Address]
    WHERE  [ParentID] = @ParentID AND [EntityID] = @EntityID

GO