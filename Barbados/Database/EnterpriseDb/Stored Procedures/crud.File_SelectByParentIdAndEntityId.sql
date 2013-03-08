
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[File_SelectByParentIdAndEntityId]
  @ParentID INT,
  @EntityID SmallINT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [FileID],
           [ParentID],
           [EntityID],
           [ParentFolder],
           [Name],
           [Size],
           [TypeID],
           [Caption],
           [DateInserted]
    FROM   [common].[File]
    WHERE  [ParentID] = @ParentID AND [EntityID] = @EntityID
GO
