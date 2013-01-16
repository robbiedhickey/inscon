SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Event_Delete]
  @EventID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [generic].[Event]
    WHERE  [EventID] = @EventID

GO
