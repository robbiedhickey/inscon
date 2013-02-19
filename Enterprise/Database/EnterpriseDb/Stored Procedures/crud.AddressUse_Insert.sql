
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[AddressUse_Insert]
  @AddressID INT,
  @TypeID    INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [generic].[AddressUse_XREF]
    (
      [AddressID],
      [TypeID]
    )
    VALUES
    (
      @AddressID,
      @TypeID
    )
    -- Begin Return Select <- do not remove
    SELECT [AddressID],
           [TypeID]
    FROM   [generic].[AddressUse_XREF]
    WHERE  [AddressID] = @AddressID AND [TypeID] = @TypeID

-- End Return Select <- do not remove

GO
