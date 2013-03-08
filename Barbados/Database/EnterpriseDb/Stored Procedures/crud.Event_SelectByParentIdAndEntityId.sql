
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Event_SelectByParentIdAndEntityId]
  @ParentID INT,
  @EntityID SmallInt
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [EventID],
           [ParentID],
           [EntityID],
           [TypeID],
           [UserID],
           [EventDate]
    FROM   [common].[Event]
    WHERE  [ParentID] = @ParentID AND [EntityID] = @EntityID
GO
