CREATE TABLE [dbo].[Product]
(
[ProductID] [int] NOT NULL IDENTITY(1, 1),
[ProductCategoryID] [int] NOT NULL,
[Caption] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[Code] [varchar] (8) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[SKU] [varchar] (20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[Rate] [decimal] (18, 2) NOT NULL CONSTRAINT [DF_Product_Rate] DEFAULT ((0)),
[Cost] [decimal] (18, 2) NOT NULL CONSTRAINT [DF_Product_Cost] DEFAULT ((0))
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Product] ADD CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED  ([ProductID]) ON [PRIMARY]
GO

EXEC sp_addextendedproperty N'MS_Description', N'Product Caption', 'SCHEMA', N'dbo', 'TABLE', N'Product', 'COLUMN', N'Caption'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Product Code', 'SCHEMA', N'dbo', 'TABLE', N'Product', 'COLUMN', N'Code'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Product Cost', 'SCHEMA', N'dbo', 'TABLE', N'Product', 'COLUMN', N'Cost'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Parent RecordID', 'SCHEMA', N'dbo', 'TABLE', N'Product', 'COLUMN', N'ProductCategoryID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'dbo', 'TABLE', N'Product', 'COLUMN', N'ProductID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Product Rate', 'SCHEMA', N'dbo', 'TABLE', N'Product', 'COLUMN', N'Rate'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Product SKU', 'SCHEMA', N'dbo', 'TABLE', N'Product', 'COLUMN', N'SKU'
GO
