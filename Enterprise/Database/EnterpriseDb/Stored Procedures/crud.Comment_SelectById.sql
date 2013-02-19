
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Comment_SelectById]
  @CommentID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [CommentID],
           [ParentID],
           [EntityID],
           [UserID],
           [TypeID],
           [Value],
           [DateInserted]
    FROM   [generic].[Comment]
    WHERE  [CommentID] = @CommentID

GO
