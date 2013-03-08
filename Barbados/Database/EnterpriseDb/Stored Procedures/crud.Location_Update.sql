
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Location_Update]
  @LocationID     INT,
  @OrganizationID INT,
  @Name           VARCHAR(75),
  @Code           VARCHAR(8),
  @TypeID         INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [organization].[Location]
    SET    [OrganizationID] = @OrganizationID,
           [Name] = @Name,
           [Code] = @Code,
           [TypeID] = @TypeID
    WHERE  [LocationID] = @LocationID
GO
