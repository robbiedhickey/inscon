CREATE TABLE [generic].[AddressUse_XREF]
(
[AddressID] [int] NOT NULL,
[TypeID] [int] NOT NULL
) ON [PRIMARY]
ALTER TABLE [generic].[AddressUse_XREF] ADD
CONSTRAINT [FK_AddressUse_XREF_Lookup] FOREIGN KEY ([TypeID]) REFERENCES [generic].[Lookup] ([LookupID])
GO
ALTER TABLE [generic].[AddressUse_XREF] ADD CONSTRAINT [PK_AddressUse_1] PRIMARY KEY CLUSTERED  ([AddressID], [TypeID]) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX [Unique_LocationTableUse] ON [generic].[AddressUse_XREF] ([AddressID]) ON [PRIMARY]
GO
ALTER TABLE [generic].[AddressUse_XREF] ADD CONSTRAINT [FK_AddressUse_Address1] FOREIGN KEY ([AddressID]) REFERENCES [generic].[Address] ([AddressID]) ON DELETE CASCADE ON UPDATE CASCADE
GO
EXEC sp_addextendedproperty N'MS_Description', N'ParentID', 'SCHEMA', N'generic', 'TABLE', N'AddressUse_XREF', 'COLUMN', N'AddressID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Mailing, Billing, Physical, Personal', 'SCHEMA', N'generic', 'TABLE', N'AddressUse_XREF', 'COLUMN', N'TypeID'
GO
