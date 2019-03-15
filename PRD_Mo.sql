
/****** Object:  Table [dbo].[PRD_Mo]    Script Date: 2018/11/29 10:53:22 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[PRD_Mo](
	[PID] [int] IDENTITY(1,1) NOT NULL,
	[Barcode] [varchar](50) NOT NULL,
	[FID] [int] NULL,
	[FBillNo] [varchar](50) NULL,
	[FDate] [datetime] NULL CONSTRAINT [DF_PRD_Mo_FDate]  DEFAULT (getdate()),
	[FEntryId] [int] NULL,
	[FNumber] [varchar](50) NULL,
	[FQTY] [decimal](18, 4) NULL,
	[FSEQ] [int] NULL,
	[FDeptId] [int] NULL,
	[Times] [int] NULL CONSTRAINT [DF_PRD_Mo_Times]  DEFAULT ((0)),
	[Creator] [varchar](50) NULL CONSTRAINT [DF_PRD_Mo_Creator]  DEFAULT (''),
	[CreationDate] [datetime] NULL CONSTRAINT [DF_PRD_Mo_CreationDate]  DEFAULT (getdate()),
	[Modifier] [varchar](50) NULL CONSTRAINT [DF_PRD_Mo_Modifer]  DEFAULT (''),
	[ModificationDate] [datetime] NULL CONSTRAINT [DF_PRD_Mo_ModificationDate]  DEFAULT (getdate()),
	[Flag] [tinyint] NULL CONSTRAINT [DF_PRD_Mo_Flag]  DEFAULT ((0)),
	[Description] [varchar](200) NULL CONSTRAINT [DF_PRD_Mo_Decription]  DEFAULT (''),
 CONSTRAINT [PK_PRD_Mo_PID] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_PRD_Mo_Barcode] UNIQUE NONCLUSTERED 
(
	[Barcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PRD_Mo', @level2type=N'COLUMN',@level2name=N'PID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'条码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PRD_Mo', @level2type=N'COLUMN',@level2name=N'Barcode'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'任务单内码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PRD_Mo', @level2type=N'COLUMN',@level2name=N'FID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'任务单号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PRD_Mo', @level2type=N'COLUMN',@level2name=N'FBillNo'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PRD_Mo', @level2type=N'COLUMN',@level2name=N'FDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'任务单分录内码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PRD_Mo', @level2type=N'COLUMN',@level2name=N'FEntryId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'物料编码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PRD_Mo', @level2type=N'COLUMN',@level2name=N'FNumber'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数量' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PRD_Mo', @level2type=N'COLUMN',@level2name=N'FQTY'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'任务单分录序号' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PRD_Mo', @level2type=N'COLUMN',@level2name=N'FSEQ'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'班组ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PRD_Mo', @level2type=N'COLUMN',@level2name=N'FDeptId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'次数' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PRD_Mo', @level2type=N'COLUMN',@level2name=N'Times'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PRD_Mo', @level2type=N'COLUMN',@level2name=N'Creator'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PRD_Mo', @level2type=N'COLUMN',@level2name=N'CreationDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PRD_Mo', @level2type=N'COLUMN',@level2name=N'Modifier'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PRD_Mo', @level2type=N'COLUMN',@level2name=N'ModificationDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PRD_Mo', @level2type=N'COLUMN',@level2name=N'Flag'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'PRD_Mo', @level2type=N'COLUMN',@level2name=N'Description'
GO


