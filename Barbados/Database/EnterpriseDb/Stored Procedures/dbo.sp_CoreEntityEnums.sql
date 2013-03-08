
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[sp_CoreEntityEnums]

AS
SELECT 'public const Int16 ' + Name + '_EntityId = ' + CONVERT(VARCHAR, EntityID) + ';'
FROM   EnterpriseDb.common.Entity
ORDER  BY Name
GO
