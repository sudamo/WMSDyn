USE [WMS]
GO

/****** Object:  Table [dbo].[RL_MTLDrawing]    Script Date: 2018/12/17 17:10:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[RL_MTLDrawing](
	[PID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[SourcePath] [varchar](300) NOT NULL,
	[Barcode] [varchar](50) NULL,
	[FMaterialId] [int] NULL,
	[FNumber] [varchar](50) NULL,
	[F_PAEZ_BRAND] [varchar](50) NULL,
	[F_PAEZ_SERIES] [varchar](50) NULL,
	[F_PAEZ_TRADE] [varchar](50) NULL,
	[F_PAEZ_CARSERIES] [varchar](50) NULL,
	[F_PAEZ_CARTYPE] [varchar](50) NULL,
	[Flag] [bit] NULL,
	[IsDelete] [bit] NULL,
	[Description] [varchar](300) NULL,
 CONSTRAINT [PK_RL_MTLDrawing_PID] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_RL_MTLDrawing_SourcePath] UNIQUE NONCLUSTERED 
(
	[SourcePath] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_RL_MTLDrawing_TRADE_CARSERIES_CARTYPE] UNIQUE NONCLUSTERED 
(
	[F_PAEZ_TRADE] ASC,
	[F_PAEZ_CARSERIES] ASC,
	[F_PAEZ_CARTYPE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[RL_MTLDrawing] ADD  CONSTRAINT [DF_RL_MTLDrawing_CategoryID]  DEFAULT ((1)) FOR [CategoryId]
GO

ALTER TABLE [dbo].[RL_MTLDrawing] ADD  CONSTRAINT [DF_MTLDrawing_Flag]  DEFAULT ((0)) FOR [Flag]
GO

ALTER TABLE [dbo].[RL_MTLDrawing] ADD  CONSTRAINT [DF_MTLDrawing_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO

ALTER TABLE [dbo].[RL_MTLDrawing] ADD  CONSTRAINT [DF_MTLDrawing_Description]  DEFAULT ('') FOR [Description]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'版型类别：1、一码一图；2、一码两图，同时打开；3、一码两图，选择打开其一。' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RL_MTLDrawing', @level2type=N'COLUMN',@level2name=N'CategoryId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'图纸原路径' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RL_MTLDrawing', @level2type=N'COLUMN',@level2name=N'SourcePath'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'条码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RL_MTLDrawing', @level2type=N'COLUMN',@level2name=N'Barcode'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'物料ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RL_MTLDrawing', @level2type=N'COLUMN',@level2name=N'FMaterialId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'物料编码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RL_MTLDrawing', @level2type=N'COLUMN',@level2name=N'FNumber'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品牌' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RL_MTLDrawing', @level2type=N'COLUMN',@level2name=N'F_PAEZ_BRAND'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系列' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RL_MTLDrawing', @level2type=N'COLUMN',@level2name=N'F_PAEZ_SERIES'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'商品名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RL_MTLDrawing', @level2type=N'COLUMN',@level2name=N'F_PAEZ_TRADE'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'车系' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RL_MTLDrawing', @level2type=N'COLUMN',@level2name=N'F_PAEZ_CARSERIES'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'车型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RL_MTLDrawing', @level2type=N'COLUMN',@level2name=N'F_PAEZ_CARTYPE'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'通用标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RL_MTLDrawing', @level2type=N'COLUMN',@level2name=N'Flag'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'作废标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RL_MTLDrawing', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'RL_MTLDrawing', @level2type=N'COLUMN',@level2name=N'Description'
GO


