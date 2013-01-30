
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE Procedure [dbo].[sp_CoreEntityEnums]

AS
SELECT 'public const Int16 ' + Name + '_EntityId = ' + CONVERT(VARCHAR, EntityID) + ';'
FROM   EnterpriseDb.dbo.Entity
ORDER  BY Name 
GO
