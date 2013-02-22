
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Comment_SelectAll]

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
    FROM   [common].[Comment]
GO
