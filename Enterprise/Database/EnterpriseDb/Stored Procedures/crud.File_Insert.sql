
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[File_Insert]
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

    INSERT INTO [common].[File]
    (
      [ParentID],
      [EntityID],
      [ParentFolder],
      [Name],
      [Size],
      [TypeID],
      [Caption]
    )
    VALUES
    (
      @ParentID,
      @EntityID,
      @ParentFolder,
      @Name,
      @Size,
      @TypeID,
      @Caption
    )
    -- Begin Return Select <- do not remove
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
    WHERE  [FileID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove
GO
