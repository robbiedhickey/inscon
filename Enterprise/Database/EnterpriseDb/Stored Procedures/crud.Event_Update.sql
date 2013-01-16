SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Event_Update]
  @EventID   INT,
  @ParentID  INT,
  @EntityID  SMALLINT,
  @TypeID    INT,
  @UserID    INT,
  @EventDate DATETIME
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [generic].[Event]
    SET    [ParentID] = @ParentID,
           [EntityID] = @EntityID,
           [TypeID] = @TypeID,
           [UserID] = @UserID,
           [EventDate] = @EventDate
    WHERE  [EventID] = @EventID

GO
