
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[AddressUse_SelectById]
  @AddressUseID INT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    SELECT [AddressUserID] AS AddressUseID,
           [AddressID],
           [TypeID]
    FROM   [generic].[AddressUse]
    WHERE  [AddressUserID] = @AddressUseID

GO
