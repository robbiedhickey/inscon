
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[AddressUse_Delete]
  @AddressID INT,
  @TypeID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [common].[AddressUse_XREF]
    WHERE  [AddressID] = @AddressID AND TypeID = @TypeID
GO
