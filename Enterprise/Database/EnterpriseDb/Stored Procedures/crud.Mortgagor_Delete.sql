SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[Mortgagor_Delete]
  @MortgagorID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [dbo].[Mortgagor]
    WHERE  [MortgagorID] = @MortgagorID

GO
