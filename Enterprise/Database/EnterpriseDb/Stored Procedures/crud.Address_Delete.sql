
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Address_Delete]
  @AddressID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [common].[Address]
    WHERE  [AddressID] = @AddressID
GO
