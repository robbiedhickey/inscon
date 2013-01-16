SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Address_Insert]
  @ParentID INT,
  @EntityID SMALLINT,
  @Street   VARCHAR(60),
  @Suite    VARCHAR(50),
  @City     VARCHAR(38),
  @State    VARCHAR(2),
  @Zip      VARCHAR(10)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [generic].[Address]
    (
      [ParentID],
      [EntityID],
      [Street],
      [Suite],
      [City],
      [State],
      [Zip]
    )
    VALUES
    (
      @ParentID,
      @EntityID,
      @Street,
      @Suite,
      @City,
      @State,
      @Zip
    )
    -- Begin Return Select <- do not remove
    SELECT [AddressID],
           [ParentID],
           [EntityID],
           [Street],
           [Suite],
           [City],
           [State],
           [Zip]
    FROM   [generic].[Address]
    WHERE  [AddressID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove

GO
