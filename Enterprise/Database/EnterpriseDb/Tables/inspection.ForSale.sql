CREATE TABLE [inspection].[ForSale]
(
[WorkOrderID] [int] NOT NULL,
[PropertyForSaleBy_Lookup] [int] NULL,
[RealtorName] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[RealtorPhone] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[idActiveListing] [int] NULL,
[ListPrice] [decimal] (11, 2) NULL,
[DaysOnMarket] [int] NULL
) ON [PRIMARY]
GO
ALTER TABLE [inspection].[ForSale] ADD CONSTRAINT [PK_ForSale] PRIMARY KEY CLUSTERED  ([WorkOrderID]) ON [PRIMARY]
GO
ALTER TABLE [inspection].[ForSale] ADD CONSTRAINT [FK_ForSale_WorkOrder] FOREIGN KEY ([WorkOrderID]) REFERENCES [dbo].[WorkOrder] ([WorkOrderID]) ON DELETE CASCADE ON UPDATE CASCADE
GO
EXEC sp_addextendedproperty N'MS_Description', N'Number of Days On Market', 'SCHEMA', N'inspection', 'TABLE', N'ForSale', 'COLUMN', N'DaysOnMarket'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Does the property have an active listing?', 'SCHEMA', N'inspection', 'TABLE', N'ForSale', 'COLUMN', N'idActiveListing'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Listing Price', 'SCHEMA', N'inspection', 'TABLE', N'ForSale', 'COLUMN', N'ListPrice'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Lookup Value - Is Property For Sale', 'SCHEMA', N'inspection', 'TABLE', N'ForSale', 'COLUMN', N'PropertyForSaleBy_Lookup'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Realtor Name', 'SCHEMA', N'inspection', 'TABLE', N'ForSale', 'COLUMN', N'RealtorName'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Realtor Phone', 'SCHEMA', N'inspection', 'TABLE', N'ForSale', 'COLUMN', N'RealtorPhone'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'inspection', 'TABLE', N'ForSale', 'COLUMN', N'WorkOrderID'
GO
