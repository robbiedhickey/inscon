SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[UserContact_SelectAll]

AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [UserContactID],
           [UserID],
           [Value],
           [TypeID],
           [IsPrimary]
    FROM   [dbo].[UserContact]
    

GO
