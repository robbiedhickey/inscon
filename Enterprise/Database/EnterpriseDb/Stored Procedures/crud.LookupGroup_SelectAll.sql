
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[LookupGroup_SelectAll]

AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [LookupGroupID],
           [Name]
    FROM   [common].[LookupGroup]
GO
