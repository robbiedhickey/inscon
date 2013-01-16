SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Organization_SelectByTypeId]
  @TypeID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [OrganizationID],
           [Name],
           [Code],
           [TypeID],
           [StatusID]
    FROM   [dbo].[Organization]
    WHERE  [TypeID] = @TypeID

GO
