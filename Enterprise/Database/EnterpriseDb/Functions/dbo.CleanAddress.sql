SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE FUNCTION [dbo].[CleanAddress] (@Address varchar(60))

RETURNS VARCHAR(60)

AS

BEGIN

    DECLARE @StringAddress VARCHAR(60)
	SET @StringAddress = @Address
	
    
    -- FIX WHERE BUILDING NUMBER AND STREET ARE MERGED
    IF( patindex('%[0-9][a-z] %', @StringAddress) > 0)
    BEGIN
		SET @StringAddress = Convert(varchar,LEFT(@StringAddress,patindex('%[0-9][a-z] %', @StringAddress))) + ' ' + Convert(varchar,RIGHT(@StringAddress, LEN(@StringAddress) - patindex('%[0-9][a-z] %', @StringAddress)))
	END
	
    
    SET @StringAddress = replace(@StringAddress, ' STREET',  ' ST ')
    SET @StringAddress = replace(@StringAddress, ' COURT',  ' CT ')
    SET @StringAddress = replace(@StringAddress, ' ROAD',  ' RD ')
    SET @StringAddress = replace(@StringAddress, ' DRIVE',  ' DR ')
    SET @StringAddress = replace(@StringAddress, ' AVENUE',  ' AVE ')
    
    SET @StringAddress = replace(@StringAddress, ' CIRCLE',  ' CIR ')
    --SET @StringAddress = replace(@StringAddress, ' PLACE',  ' PL ')
    SET @StringAddress = replace(@StringAddress, ' LANE',  ' LN ')
    
    -- DIRECTION
    SET @StringAddress = replace(@StringAddress, ' NORTHEAST',  ' NE ')
    SET @StringAddress = replace(@StringAddress, ' NORTHWEST',  ' NW ')
    SET @StringAddress = replace(@StringAddress, ' SOUTHEAST',  ' SE ')
    SET @StringAddress = replace(@StringAddress, ' SOUTHWEST',  ' SW ')
    SET @StringAddress = replace(@StringAddress, ' NORTH ',  ' N ')
    SET @StringAddress = replace(@StringAddress, ' EAST ',  ' E ')
    SET @StringAddress = replace(@StringAddress, ' SOUTH ',  ' S ')
    SET @StringAddress = replace(@StringAddress, ' WEST ',  ' W ')
    
    -- REMOVE BAD CHARACTERS
    SET @StringAddress = replace(@StringAddress, '.',  '')
    SET @StringAddress = replace(@StringAddress, '"',  '')
    
    -- REMOVE EXTRA SPACES
    BEGIN
    WHILE CHARINDEX('  ',@StringAddress) > 0
      SET @StringAddress = REPLACE(@StringAddress,'  ',' ')
	END    
	
RETURN LTRIM(RTRIM(@StringAddress))

END

GO
