
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[AddressLocation_SelectById]
  @AddressID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [AddressID],
           [BuildingNumber],
           [StreetName],
           [City],
           [State],
           [Zip],
           [GeoCode],
           [Lattitude],
           [Longitude]
    FROM   [common].[AddressLocation]
    WHERE  [AddressID] = @AddressID
GO
