SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Comment_Delete]
  @CommentID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [generic].[Comment]
    WHERE  [CommentID] = @CommentID

GO
