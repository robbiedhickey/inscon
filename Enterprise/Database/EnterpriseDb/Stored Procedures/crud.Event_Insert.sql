SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Event_Insert]
  @ParentID  INT,
  @EntityID  SMALLINT,
  @TypeID    INT,
  @UserID    INT,
  @EventDate DATETIME
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [generic].[Event]
    (
      [ParentID],
      [EntityID],
      [TypeID],
      [UserID],
      [EventDate]
    )
    VALUES
    (
      @ParentID,
      @EntityID,
      @TypeID,
      @UserID,
      @EventDate
    )
    -- Begin Return Select <- do not remove
    SELECT [EventID],
           [ParentID],
           [EntityID],
           [TypeID],
           [UserID],
           [EventDate]
    FROM   [generic].[Event]
    WHERE  [EventID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove

GO
