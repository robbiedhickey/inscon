SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[File_Update]
  @FileID       INT,
  @ParentID     INT,
  @EntityID     SMALLINT,
  @ParentFolder VARCHAR(100),
  @Name         VARCHAR(50),
  @Size         DECIMAL(18, 2),
  @TypeID       INT,
  @Caption      VARCHAR(50)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [generic].[File]
    SET    [ParentID] = @ParentID,
           [EntityID] = @EntityID,
           [ParentFolder] = @ParentFolder,
           [Name] = @Name,
           [Size] = @Size,
           [TypeID] = @TypeID,
           [Caption] = @Caption
    WHERE  [FileID] = @FileID

GO
