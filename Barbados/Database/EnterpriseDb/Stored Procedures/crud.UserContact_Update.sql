
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROC [crud].[UserContact_Update]
  @UserContactID INT,
  @UserID        INT,
  @Value         VARCHAR(50),
  @TypeID        INT,
  @IsPrimary     BIT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    UPDATE [organization].[UserContact]
    SET    [UserID] = @UserID,
           [Value] = @Value,
           [TypeID] = @TypeID,
           [IsPrimary] = @IsPrimary
    WHERE  [UserContactID] = @UserContactID
GO
