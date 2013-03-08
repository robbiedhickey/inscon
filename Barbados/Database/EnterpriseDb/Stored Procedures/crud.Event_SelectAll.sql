
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[Event_SelectAll]

AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [EventID],
           [ParentID],
           [EntityID],
           [TypeID],
           [UserID],
           [EventDate]
    FROM   [common].[Event]
GO
