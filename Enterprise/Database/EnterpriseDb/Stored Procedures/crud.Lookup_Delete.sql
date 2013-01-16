SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Lookup_Delete]
  @LookupID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [generic].[Lookup]
    WHERE  [LookupID] = @LookupID

GO
