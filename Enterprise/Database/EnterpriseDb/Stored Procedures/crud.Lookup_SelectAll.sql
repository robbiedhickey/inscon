
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Lookup_SelectAll]
 
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [LookupID],
           [LookupGroupID],
           [Value]
    FROM   [common].[Lookup]
GO
