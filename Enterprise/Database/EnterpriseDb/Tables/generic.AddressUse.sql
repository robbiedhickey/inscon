CREATE TABLE [generic].[AddressUse]
(
[AddressUserID] [int] NOT NULL IDENTITY(1, 1),
[AddressID] [int] NOT NULL,
[TypeID] [int] NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [generic].[AddressUse] ADD CONSTRAINT [PK_AddressUse] PRIMARY KEY CLUSTERED  ([AddressUserID]) ON [PRIMARY]
GO
CREATE UNIQUE NONCLUSTERED INDEX [Unique_LocationTableUse] ON [generic].[AddressUse] ([AddressID]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'ParentID', 'SCHEMA', N'generic', 'TABLE', N'AddressUse', 'COLUMN', N'AddressID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Mailing, Billing, Physical, Personal', 'SCHEMA', N'generic', 'TABLE', N'AddressUse', 'COLUMN', N'TypeID'
GO
