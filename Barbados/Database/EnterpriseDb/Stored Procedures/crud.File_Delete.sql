
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[File_Delete]
  @FileID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [common].[File]
    WHERE  [FileID] = @FileID
GO
