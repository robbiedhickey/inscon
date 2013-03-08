SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE FUNCTION [dbo].[GetEntityID](@EntityName varchar(50))
RETURNS INT

AS
BEGIN
	
	DECLARE @retval As INT
			
	SET @retval = 0;
	
	BEGIN
		
		SET @retval = (SELECT EntityID FROM [EnterpriseDb].[dbo].[Entity] WHERE [Name] = @EntityName)
		
	END	
	
	
RETURN @retval

END
GO
