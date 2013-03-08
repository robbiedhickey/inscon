SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE FUNCTION [dbo].[GetDateTimeEndOfDay] 

(@End datetime) 

RETURNS datetime AS

BEGIN 
	
	SET @End = CONVERT(varchar(10), @End, 101) 
	SET @End = CONVERT(datetime, @End + '23:59:59.997', 1)	
	
RETURN @End

END
GO
