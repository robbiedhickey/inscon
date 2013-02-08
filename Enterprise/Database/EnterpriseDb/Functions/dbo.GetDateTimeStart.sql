SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE FUNCTION [dbo].[GetDateTimeStart] 

(@Start datetime) 

RETURNS datetime AS

BEGIN 

	SET @Start = CONVERT(varchar(10), @Start, 101) 
	SET @Start = CONVERT(datetime, @Start + '00:00:00.000', 1)
	
RETURN @Start

END


GO
