
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Lookup_Update]
  @LookupID      INT,
  @LookupGroupID SMALLINT,
  @Value         VARCHAR(50)
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [common].[Lookup]
    SET    [LookupGroupID] = @LookupGroupID,
           [Value] = @Value
    WHERE  [LookupID] = @LookupID
GO
