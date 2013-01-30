
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
  @Value   VARCHAR(MAX)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [generic].[Comment]
    SET    [ParentID] = @ParentID,
           [EntityID] = @EntityID,
           [UserID] = @UserID,
           [TypeID] = @TypeID,
           [Value] = @Value
    WHERE  [CommentID] = @CommentID

GO
