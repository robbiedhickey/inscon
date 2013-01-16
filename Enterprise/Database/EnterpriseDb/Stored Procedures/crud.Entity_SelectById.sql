SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Entity_SelectById]
  @EntityID TINYINT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [EntityID],
           [Name]
    FROM   [dbo].[Entity]
    WHERE  [EntityID] = @EntityID

GO
