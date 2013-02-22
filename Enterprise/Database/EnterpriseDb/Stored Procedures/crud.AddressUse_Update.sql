
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[AddressUse_Update]
  @AddressID     INT,
  @TypeID        INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [common].[AddressUse]
    SET    [AddressID] = @AddressID,
           [TypeID] = @TypeID
    WHERE  [AddressID] = @AddressID AND [TypeID] = @TypeID
GO
