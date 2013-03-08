CREATE TABLE [request].[Request]
(
[RequestID] [int] NOT NULL IDENTITY(1, 1),
[DateInserted] [datetime] NULL CONSTRAINT [DF_Request_DateInserted] DEFAULT (getdate()),
[CustomerRequestID] [varchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
) ON [PRIMARY]
GO
ALTER TABLE [request].[Request] ADD CONSTRAINT [PK_Request] PRIMARY KEY CLUSTERED  ([RequestID]) ON [PRIMARY]
GO
EXEC sp_addextendedproperty N'MS_Description', N'Customer Defined RequestID', 'SCHEMA', N'request', 'TABLE', N'Request', 'COLUMN', N'CustomerRequestID'
GO
EXEC sp_addextendedproperty N'MS_Description', N'Date Inserted', 'SCHEMA', N'request', 'TABLE', N'Request', 'COLUMN', N'DateInserted'
GO
EXEC sp_addextendedproperty N'MS_Description', N'RecordID', 'SCHEMA', N'request', 'TABLE', N'Request', 'COLUMN', N'RequestID'
GO
