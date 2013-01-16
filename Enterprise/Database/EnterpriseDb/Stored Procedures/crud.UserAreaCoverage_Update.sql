SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[UserAreaCoverage_Update]
  @UserAreaCoverageID INT,
  @UserID             INT,
  @ZipCode            VARCHAR(10),
  @ServiceID          INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [dbo].[UserAreaCoverage]
    SET    [UserID] = @UserID,
           [ZipCode] = @ZipCode,
           [ServiceID] = @ServiceID
    WHERE  [UserAreaCoverageID] = @UserAreaCoverageID

GO
