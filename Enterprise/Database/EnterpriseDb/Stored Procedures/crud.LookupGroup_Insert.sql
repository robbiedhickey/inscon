SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[LookupGroup_Insert]
  @Name VARCHAR(75)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [generic].[LookupGroup]
    (
      [Name]
    )
    VALUES
    (
      @Name
    )
    -- Begin Return Select <- do not remove
    SELECT [LookupGroupID],
           [Name]
    FROM   [generic].[LookupGroup]
    WHERE  [LookupGroupID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove

GO
