SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Comment_Update]
  @CommentID INT,
  @ParentID  INT,
  @EntityID  SMALLINT,
  @UserID    INT,
  @TypeID    INT,
  @Comment   VARCHAR(MAX)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [generic].[Comment]
    SET    [ParentID] = @ParentID,
           [EntityID] = @EntityID,
           [UserID] = @UserID,
           [TypeID] = @TypeID,
           [Comment] = @Comment
    WHERE  [CommentID] = @CommentID

GO
