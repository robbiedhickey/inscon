
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[AddressLocation_Delete]
  @AddressID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [common].[AddressLocation]
    WHERE  [AddressID] = @AddressID
GO
