CREATE TABLE [dbo].[ProductCategory]
(
[ProductCategoryID] [int] NOT NULL IDENTITY(1, 1),
[Name] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Code] [varchar] (8) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ProductCategory] ADD CONSTRAINT [PK_ProductCategory] PRIMARY KEY CLUSTERED  ([ProductCategoryID]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'Product Categpry Code', 'SCHEMA', N'dbo', 'TABLE', N'ProductCategory', 'COLUMN', N'Code'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Product Categpry Name', 'SCHEMA', N'dbo', 'TABLE', N'ProductCategory', 'COLUMN', N'Name'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'dbo', 'TABLE', N'ProductCategory', 'COLUMN', N'ProductCategoryID'
GO
