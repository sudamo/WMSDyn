
/****** Object:  Table [dbo].[Log_Operation]    Script Date: 2018/11/29 10:53:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Log_Operation](
	[PID] [int] IDENTITY(1,1) NOT NULL,
	[Barcode] [varchar](50) NULL,
	[FID] [int] NULL,
	[FBillNo] [varchar](50) NULL,
	[OperatorId] [int] NULL,
	[Operator] [varchar](50) NULL CONSTRAINT [DF_Log_Operation_Operator]  DEFAULT (''),
	[Client] [varchar](50) NULL,
	[IP] [varchar](50) NULL,
	[MAC] [varchar](50) NULL,
	[Creator] [varchar](50) NULL CONSTRAINT [DF_Log_Operation_Creator]  DEFAULT (''),
	[CreationDate] [datetime] NULL CONSTRAINT [DF_Log_Operation_CreationDate]  DEFAULT (getdate()),
	[Flag] [tinyint] NULL CONSTRAINT [DF_Log_Operation_Flag]  DEFAULT ((0)),
	[Description] [varchar](300) NULL CONSTRAINT [DF_Log_Operation_Description]  DEFAULT (''),
 CONSTRAINT [PK_Log_Operation_PID] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'条码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Log_Operation', @level2type=N'COLUMN',@level2name=N'Barcode'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'任务单ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Log_Operation', @level2type=N'COLUMN',@level2name=N'FID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'任务单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Log_Operation', @level2type=N'COLUMN',@level2name=N'FBillNo'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作员ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Log_Operation', @level2type=N'COLUMN',@level2name=N'OperatorId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'操作员' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Log_Operation', @level2type=N'COLUMN',@level2name=N'Operator'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'客户端' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Log_Operation', @level2type=N'COLUMN',@level2name=N'Client'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'IP地址' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Log_Operation', @level2type=N'COLUMN',@level2name=N'IP'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'MAC' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Log_Operation', @level2type=N'COLUMN',@level2name=N'MAC'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Log_Operation', @level2type=N'COLUMN',@level2name=N'Creator'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Log_Operation', @level2type=N'COLUMN',@level2name=N'CreationDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Log_Operation', @level2type=N'COLUMN',@level2name=N'Flag'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Log_Operation', @level2type=N'COLUMN',@level2name=N'Description'
GO


