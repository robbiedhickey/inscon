SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Entity_Update]
  @EntityID TINYINT,
  @Name     VARCHAR(50)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [dbo].[Entity]
    SET    [Name] = @Name
    WHERE  [EntityID] = @EntityID

GO
