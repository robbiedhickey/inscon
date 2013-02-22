
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Location_Insert]
  @OrganizationID INT,
  @Name           VARCHAR(75),
  @Code           VARCHAR(8),
  @TypeID         INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [organization].[Location]
    (
      [OrganizationID],
      [Name],
      [Code],
      [TypeID]
    )
    VALUES
    (
      @OrganizationID,
      @Name,
      @Code,
      @TypeID
    )
    -- Begin Return Select <- do not remove
    SELECT [LocationID],
           [OrganizationID],
           [Name],
           [Code],
           [TypeID]
    FROM   [organization].[Location]
    WHERE  [LocationID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove
GO
