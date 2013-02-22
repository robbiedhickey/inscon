CREATE TABLE [common].[AddressUse_XREF]
(
[AddressID] [int] NOT NULL,
[TypeID] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [common].[AddressUse_XREF] ADD CONSTRAINT [PK_AddressUse_1] PRIMARY KEY CLUSTERED  ([AddressID], [TypeID]) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX [Unique_LocationTableUse] ON [common].[AddressUse_XREF] ([AddressID]) ON [PRIMARY]
GO

EXEC sp_addextendedproperty N'MS_Description', N'ParentID', 'SCHEMA', N'common', 'TABLE', N'AddressUse_XREF', 'COLUMN', N'AddressID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Mailing, Billing, Physical, Personal', 'SCHEMA', N'common', 'TABLE', N'AddressUse_XREF', 'COLUMN', N'TypeID'
GO
