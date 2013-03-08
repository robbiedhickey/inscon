
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Entity_Insert]
  @Name VARCHAR(50)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [common].[Entity]
    (
      [Name]
    )
    VALUES
    (
      @Name
    )
    -- Begin Return Select <- do not remove
    SELECT [EntityID],
           [Name]
    FROM   [common].[Entity]
    WHERE  [EntityID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove
GO
