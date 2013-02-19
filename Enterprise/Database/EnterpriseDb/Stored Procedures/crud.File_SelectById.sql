
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[File_SelectById]
  @FileID INT
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
    FROM   [generic].[File]
    WHERE  [FileID] = @FileID

GO
