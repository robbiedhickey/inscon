
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Organization_SelectAll]

AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [OrganizationID],
           [Name],
           [Code],
           [TypeID],
           [StatusID]
    FROM   [organization].[Organization]
   

GO
