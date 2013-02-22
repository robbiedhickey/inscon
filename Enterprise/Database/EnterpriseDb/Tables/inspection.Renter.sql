CREATE TABLE [inspection].[Renter]
(
[WorkOrderID] [int] NOT NULL,
[RenterName] [varchar] (50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[RenterPhone] [varchar] (10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[RentPaidTo] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[RentPaidToAddress] [varchar] (65) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
[RentCurrent] [bit] NULL,
[RentAmountMonthly] [decimal] (15, 2) NULL
) ON [PRIMARY]

GO
ALTER TABLE [inspection].[Renter] ADD CONSTRAINT [pk_renter] PRIMARY KEY CLUSTERED  ([WorkOrderID]) ON [PRIMARY]
GO

EXEC sp_addextendedproperty N'MS_Description', N'How much rent is paid each month', 'SCHEMA', N'inspection', 'TABLE', N'Renter', 'COLUMN', N'RentAmountMonthly'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Is rent current', 'SCHEMA', N'inspection', 'TABLE', N'Renter', 'COLUMN', N'RentCurrent'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Renter Name', 'SCHEMA', N'inspection', 'TABLE', N'Renter', 'COLUMN', N'RenterName'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Renter Phone', 'SCHEMA', N'inspection', 'TABLE', N'Renter', 'COLUMN', N'RenterPhone'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Who rent is paid to', 'SCHEMA', N'inspection', 'TABLE', N'Renter', 'COLUMN', N'RentPaidTo'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Address rent is paid to', 'SCHEMA', N'inspection', 'TABLE', N'Renter', 'COLUMN', N'RentPaidToAddress'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'inspection', 'TABLE', N'Renter', 'COLUMN', N'WorkOrderID'
GO
