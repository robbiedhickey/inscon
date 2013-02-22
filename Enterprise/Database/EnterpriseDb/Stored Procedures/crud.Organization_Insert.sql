
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Organization_Insert]
  @Name     VARCHAR(75),
  @Code     VARCHAR(8),
  @TypeID   INT,
  @StatusID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [organization].[Organization]
    (
      [Name],
      [Code],
      [TypeID],
      [StatusID]
    )
    VALUES
    (
      @Name,
      @Code,
      @TypeID,
      @StatusID
    )
    -- Begin Return Select <- do not remove
    SELECT [OrganizationID],
           [Name],
           [Code],
           [TypeID],
           [StatusID]
    FROM   [organization].[Organization]
    WHERE  [OrganizationID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove

GO
