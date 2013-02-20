
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[LookupGroup_SelectById]
  @LookupGroupID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [LookupGroupID],
           [Name]
    FROM   [generic].[LookupGroup]
    WHERE  [LookupGroupID] = @LookupGroupID

GO
