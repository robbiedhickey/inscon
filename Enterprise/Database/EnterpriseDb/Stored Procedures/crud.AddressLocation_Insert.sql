SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[AddressLocation_Insert]
  @AddressID      INT,
  @BuildingNumber VARCHAR(20),
  @StreetName     VARCHAR(60),
  @City           VARCHAR(38),
  @State          VARCHAR(2),
  @Zip            VARCHAR(10),
  @GeoCode        GEOGRAPHY,
  @Lattitude      FLOAT,
  @Longitude      FLOAT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [generic].[AddressLocation]
    (
      [AddressID],
      [BuildingNumber],
      [StreetName],
      [City],
      [State],
      [Zip],
      [GeoCode],
      [Lattitude],
      [Longitude]
    )
    VALUES
    (
      @AddressID,
      @BuildingNumber,
      @StreetName,
      @City,
      @State,
      @Zip,
      @GeoCode,
      @Lattitude,
      @Longitude
    )
    -- Begin Return Select <- do not remove
    SELECT [AddressID],
           [BuildingNumber],
           [StreetName],
           [City],
           [State],
           [Zip],
           [GeoCode],
           [Lattitude],
           [Longitude]
    FROM   [generic].[AddressLocation]
    WHERE  [AddressID] = @AddressID

-- End Return Select <- do not remove

GO
