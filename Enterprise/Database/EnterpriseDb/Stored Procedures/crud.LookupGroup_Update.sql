
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[LookupGroup_Update]
  @LookupGroupID INT,
  @Name          VARCHAR(75)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [generic].[LookupGroup]
    SET    [Name] = @Name
    WHERE  [LookupGroupID] = @LookupGroupID

GO
