
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Address_SelectById]
  @AddressID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [AddressID],
           [ParentID],
           [EntityID],
           [Street],
           [Suite],
           [City],
           [State],
           [Zip]
    FROM   [common].[Address]
    WHERE  [AddressID] = @AddressID
GO
