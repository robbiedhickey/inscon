
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[AddressUse_Delete]
  @AddressUserID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    DELETE FROM [common].[AddressUse]
    WHERE  [AddressUserID] = @AddressUserID
GO
