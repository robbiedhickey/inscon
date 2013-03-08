
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE FUNCTION [dbo].[CheckConstraint]
(
  @LookupID      INT,
  @LookupGroupID INT
)
RETURNS BIT
AS
  BEGIN
      DECLARE @found BIT = 0

      BEGIN
          IF ( EXISTS(SELECT LookupID
                      FROM   [common].[Lookup]
                      WHERE  ( LookupID = @LookupID )
                             AND LookupGroupID = @LookupGroupID) )
            BEGIN
                SET @found = 1
            END
      END

      RETURN @found

  END 
GO
