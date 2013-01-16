SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Comment_Insert]
  @ParentID INT,
  @EntityID SMALLINT,
  @UserID   INT,
  @TypeID   INT,
  @Comment  VARCHAR(MAX)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [generic].[Comment]
    (
      [ParentID],
      [EntityID],
      [UserID],
      [TypeID],
      [Comment]
    )
    VALUES
    (
      @ParentID,
      @EntityID,
      @UserID,
      @TypeID,
      @Comment
    )
    -- Begin Return Select <- do not remove
    SELECT [CommentID],
           [ParentID],
           [EntityID],
           [UserID],
           [TypeID],
           [Comment]
    FROM   [generic].[Comment]
    WHERE  [CommentID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove

GO
