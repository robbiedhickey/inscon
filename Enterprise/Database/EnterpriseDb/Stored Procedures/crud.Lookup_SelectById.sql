SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Lookup_SelectById]
  @LookupID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [LookupID],
           [LookupGroupID],
           [Value]
    FROM   [generic].[Lookup]
    WHERE  [LookupID] = @LookupID

GO
