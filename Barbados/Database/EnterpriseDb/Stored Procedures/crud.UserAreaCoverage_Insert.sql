
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[UserAreaCoverage_Insert]
  @UserID    INT,
  @ZipCode   VARCHAR(10),
  @ServiceID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [organization].[UserAreaCoverage]
    (
      [UserID],
      [ZipCode],
      [ServiceID]
    )
    VALUES
    (
      @UserID,
      @ZipCode,
      @ServiceID
    )
    -- Begin Return Select <- do not remove
    SELECT [UserAreaCoverageID],
           [UserID],
           [ZipCode],
           [ServiceID]
    FROM   [organization].[UserAreaCoverage]
    WHERE  [UserAreaCoverageID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove
GO
