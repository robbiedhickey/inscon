SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[UserAreaCoverage_SelectByUserIdAndServiceId]
  @UserID INT, 
  @ServiceID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [UserAreaCoverageID],
           [UserID],
           [ZipCode],
           [ServiceID]
    FROM   [dbo].[UserAreaCoverage]
    WHERE  [UserID] = @UserID AND [ServiceID] = @ServiceID

GO
