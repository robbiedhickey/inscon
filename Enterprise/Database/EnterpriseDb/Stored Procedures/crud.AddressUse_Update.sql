SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[AddressUse_Update]
  @AddressUserID INT,
  @AddressID     INT,
  @TypeID        INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [generic].[AddressUse]
    SET    [AddressID] = @AddressID,
           [TypeID] = @TypeID
    WHERE  [AddressUserID] = @AddressUserID

GO
