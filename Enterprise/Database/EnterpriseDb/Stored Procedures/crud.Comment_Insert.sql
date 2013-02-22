
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Comment_Insert]
  @ParentID INT,
  @EntityID SMALLINT,
  @UserID   INT,
  @TypeID   INT,
  @Value  VARCHAR(MAX)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [common].[Comment]
    (
      [ParentID],
      [EntityID],
      [UserID],
      [TypeID],
      [Value]
    )
    VALUES
    (
      @ParentID,
      @EntityID,
      @UserID,
      @TypeID,
      @Value
    )
    -- Begin Return Select <- do not remove
    SELECT [CommentID],
           [ParentID],
           [EntityID],
           [UserID],
           [TypeID],
           [Value],
           [DateInserted]
    FROM   [common].[Comment]
    WHERE  [CommentID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove
GO
