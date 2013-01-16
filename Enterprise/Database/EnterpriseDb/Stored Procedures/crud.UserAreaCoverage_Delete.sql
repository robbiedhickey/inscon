SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[UserAreaCoverage_Delete]
  @UserAreaCoverageID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [dbo].[UserAreaCoverage]
    WHERE  [UserAreaCoverageID] = @UserAreaCoverageID

GO
