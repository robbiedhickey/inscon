SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROC [crud].[UserContact_Insert]
  @UserID    INT,
  @Value     VARCHAR(50),
  @TypeID    INT,
  @IsPrimary BIT
AS
    SET NOCOUNT ON
    SET XACT_ABORT ON

    INSERT INTO [dbo].[UserContact]
    (
      [UserID],
      [Value],
      [TypeID],
      [IsPrimary]
    )
    VALUES
    (
      @UserID,
      @Value,
      @TypeID,
      @IsPrimary
    )
    -- Begin Return Select <- do not remove
    SELECT [UserContactID],
           [UserID],
           [Value],
           [TypeID],
           [IsPrimary]
    FROM   [dbo].[UserContact]
    WHERE  [UserContactID] = SCOPE_IDENTITY()

-- End Return Select <- do not remove

GO
