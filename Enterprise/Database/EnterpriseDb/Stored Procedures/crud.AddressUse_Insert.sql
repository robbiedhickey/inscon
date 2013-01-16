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

    INSERT INTO [generic].[AddressUse]
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
    SELECT [AddressUserID],
           [AddressID],
           [TypeID]
    FROM   [generic].[AddressUse]
    WHERE  [AddressUserID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove

GO
