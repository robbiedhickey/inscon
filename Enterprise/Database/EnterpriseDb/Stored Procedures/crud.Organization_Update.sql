SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Organization_Update]
  @OrganizationID INT,
  @Name           VARCHAR(75),
  @Code           VARCHAR(8),
  @TypeID         INT,
  @StatusID       INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [dbo].[Organization]
    SET    [Name] = @Name,
           [Code] = @Code,
           [TypeID] = @TypeID,
           [StatusID] = @StatusID
    WHERE  [OrganizationID] = @OrganizationID

GO
