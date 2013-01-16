SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[AddressLocation_Update]
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

    UPDATE [generic].[AddressLocation]
    SET    [AddressID] = @AddressID,
           [BuildingNumber] = @BuildingNumber,
           [StreetName] = @StreetName,
           [City] = @City,
           [State] = @State,
           [Zip] = @Zip,
           [GeoCode] = @GeoCode,
           [Lattitude] = @Lattitude,
           [Longitude] = @Longitude
    WHERE  [AddressID] = @AddressID

GO
