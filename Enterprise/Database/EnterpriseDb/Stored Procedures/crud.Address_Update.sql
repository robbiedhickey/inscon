SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Address_Update]
  @AddressID INT,
  @ParentID  INT,
  @EntityID  SMALLINT,
  @Street    VARCHAR(60),
  @Suite     VARCHAR(50),
  @City      VARCHAR(38),
  @State     VARCHAR(2),
  @Zip       VARCHAR(10)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [generic].[Address]
    SET    [ParentID] = @ParentID,
           [EntityID] = @EntityID,
           [Street] = @Street,
           [Suite] = @Suite,
           [City] = @City,
           [State] = @State,
           [Zip] = @Zip
    WHERE  [AddressID] = @AddressID

GO
