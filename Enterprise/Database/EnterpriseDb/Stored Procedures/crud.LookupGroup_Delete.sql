SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[LookupGroup_Delete]
  @LookupGroupID SMALLINT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [generic].[LookupGroup]
    WHERE  [LookupGroupID] = @LookupGroupID

GO
