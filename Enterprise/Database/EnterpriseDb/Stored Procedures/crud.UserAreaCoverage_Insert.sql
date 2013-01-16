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

    INSERT INTO [dbo].[UserAreaCoverage]
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
    FROM   [dbo].[UserAreaCoverage]
    WHERE  [UserAreaCoverageID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove

GO
