SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE FUNCTION [dbo].[GetNewLookupValue]
(
	-- Add the parameters for the function here
	@OldId int
)
RETURNS INT
AS
BEGIN
	-- Declare the return variable here
	DECLARE @retval INT

	SET @retval = (SELECT LookupID FROM [generic].[Lookup] WHERE OldID = @OldId)
	-- Return the result of the function
	return @retval

END
GO
