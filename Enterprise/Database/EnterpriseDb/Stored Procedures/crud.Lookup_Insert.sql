SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Lookup_Insert]
  @LookupGroupID SMALLINT,
  @Value         VARCHAR(50)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [generic].[Lookup]
    (
      [LookupGroupID],
      [Value]
    )
    VALUES
    (
      @LookupGroupID,
      @Value
    )
    -- Begin Return Select <- do not remove
    SELECT [LookupID],
           [LookupGroupID],
           [Value]
    FROM   [generic].[Lookup]
    WHERE  [LookupID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove

GO
