SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE FUNCTION [dbo].[FormatPhone](@phoneNumber varchar(20))
RETURNS varchar(15)

AS
BEGIN
	
	DECLARE @retval As varchar(15)
			
	If(LEN(@phoneNumber) = 10)
	BEGIN
	
		SET @retval = 
		(		
				'(' 
				+ SUBSTRING(@phoneNumber, 1, 3) 
				+ ') ' 
				+ SUBSTRING(@phoneNumber, 4, 3) 
				+ '-' 
				+ SUBSTRING(@phoneNumber, 7, 4)
		)
	END
	ELSE
		BEGIN
		SET @retval =  IsNull(@phoneNumber, '')
	END
	
	
RETURN @retval

END
GO
