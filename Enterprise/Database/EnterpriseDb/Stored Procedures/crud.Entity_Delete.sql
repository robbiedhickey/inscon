
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Entity_Delete]
  @EntityID TINYINT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [common].[Entity]
    WHERE  [EntityID] = @EntityID
GO
