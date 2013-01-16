SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Comment_SelectByParentIdAndEntityId]
  @ParentID INT,
  @EntityID SMALLINT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [CommentID],
           [ParentID],
           [EntityID],
           [UserID],
           [TypeID],
           [Comment]
    FROM   [generic].[Comment]
    WHERE  [ParentID] = @ParentID
           AND [EntityID] = @EntityID 
GO
