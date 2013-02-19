
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[AddressUse_SelectByAddressId]
  @AddressID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [AddressID],
           [TypeID]
    FROM   [generic].[AddressUse_XREF]
    WHERE  [AddressID] = @AddressID

GO
