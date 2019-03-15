
/****** Object:  Table [dbo].[BD_Material]    Script Date: 2018/11/29 10:51:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[BD_Material](
	[PID] [int] IDENTITY(1,1) NOT NULL,
	[FMaterialId] [int] NULL,
	[FNumber] [varchar](50) NOT NULL,
	[FName] [varchar](300) NULL CONSTRAINT [DF_BD_Material_FName]  DEFAULT (''),
	[FUseOrgId] [int] NOT NULL CONSTRAINT [DF_BD_Material_FUseOrgId]  DEFAULT ((100508)),
	[FGroupId] [int] NULL CONSTRAINT [DF_BD_Material_FGroupId]  DEFAULT ((0)),
	[FDocumentStatus] [char](1) NULL CONSTRAINT [DF_BD_Material_FDocumentStatus]  DEFAULT ('C'),
	[FForbidStatus] [char](1) NULL CONSTRAINT [DF_BD_Material_FForbidStatus]  DEFAULT ('A'),
	[F_PAEZ_BRAND] [varchar](50) NULL,
	[F_PAEZ_SERIES] [varchar](50) NULL,
	[F_PAEZ_TRADE] [varchar](50) NULL,
	[F_PAEZ_CARSERIES] [varchar](50) NULL,
	[F_PAEZ_CARTYPE] [varchar](50) NULL,
	[F_PAEZ_COLOR] [varchar](50) NULL,
	[Creator] [varchar](50) NULL CONSTRAINT [DF_BD_Material_Creator]  DEFAULT (''),
	[CreationDate] [datetime] NULL CONSTRAINT [DF_BD_Material_CreationDate]  DEFAULT (getdate()),
	[Modifier] [varchar](50) NULL CONSTRAINT [DF_BD_Material_Modifier]  DEFAULT (''),
	[ModificationDate] [datetime] NULL CONSTRAINT [DF_BD_Material_ModificationDate]  DEFAULT (getdate()),
	[Flag] [tinyint] NULL CONSTRAINT [DF_BD_Material_Flag]  DEFAULT ((0)),
	[Description] [varchar](300) NULL CONSTRAINT [DF_BD_Material_Description]  DEFAULT (''),
 CONSTRAINT [PK_BD_Material_PID] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_BD_Material_FNumber_FUseOrgId] UNIQUE NONCLUSTERED 
(
	[FNumber] ASC,
	[FUseOrgId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'主键' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'PID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'物料ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'FMaterialId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'物料编码' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'FNumber'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'物料名称' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'FName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'使用组织' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'FUseOrgId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'分组ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'FGroupId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'数据状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'FDocumentStatus'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'禁用状态' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'FForbidStatus'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'品牌' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'F_PAEZ_BRAND'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'系列' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'F_PAEZ_SERIES'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'商品名' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'F_PAEZ_TRADE'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'车系' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'F_PAEZ_CARSERIES'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'车型' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'F_PAEZ_CARTYPE'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'颜色' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'F_PAEZ_COLOR'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'Creator'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'创建日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'CreationDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改人' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'Modifier'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'修改日期' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'ModificationDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'标识' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'Flag'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'描述' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Material', @level2type=N'COLUMN',@level2name=N'Description'
GO


