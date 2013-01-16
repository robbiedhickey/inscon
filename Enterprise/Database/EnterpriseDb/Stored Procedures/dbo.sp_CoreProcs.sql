SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO

CREATE PROCEDURE [dbo].[sp_CoreProcs]
AS
  -- STORED PROCEDURE CREATES C# code for 'BusinessSystem.Core.Types'
  BEGIN
      SELECT '// ' + sproc.name                                                                                         AS 'name'
             , 'public const String ' + sproc.name + ' = @"[' + sch.name + '].[' + sproc.name + ']";' AS 'desc'
      INTO   #MyTempTable
      FROM   sys.procedures sproc
             INNER JOIN sys.schemas sch
               ON sch.schema_id = sproc.schema_id
      WHERE  sch.name = 'crud'
      UNION ALL
      SELECT '// ' + tbl.[name]
             , '// ' + tbl.[name]
      FROM   sys.tables tbl
      WHERE  LEFT(tbl.[name], 3) != 'sys'
      ORDER  BY [name]

      SELECT [desc]
      FROM   #MyTempTable
      ORDER BY [name]

      DROP TABLE [#MyTempTable]
  END 
GO
