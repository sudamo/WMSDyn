
/****** Object:  Table [dbo].[BD_Drawing]    Script Date: 2018/11/29 10:51:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[BD_Drawing](
	[PID] [int] IDENTITY(1,1) NOT NULL,
	[FMaterialId] [int] NULL,
	[FNumber] [varchar](50) NOT NULL,
	[FileName] [varchar](80) NOT NULL,
	[FileSuffix] [varchar](30) NULL,
	[FileType] [varchar](30) NULL,
	[FileSize] [int] NULL,
	[SizeUnit] [varchar](10) NULL,
	[SourcePath] [varchar](200) NULL,
	[Author] [varchar](50) NULL,
	[CreationDate] [datetime] NULL,
	[Modifier] [varchar](50) NULL,
	[ModificationDate] [datetime] NULL,
	[SaveDate] [datetime] NOT NULL,
	[IsDelete] [bit] NOT NULL,
	[Description] [nvarchar](300) NOT NULL,
	[Context] [varbinary](max) NOT NULL,
 CONSTRAINT [PK_DB_Drawing_PID] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_BD_Drawing_FileName] UNIQUE NONCLUSTERED 
(
	[FileName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[BD_Drawing] ADD  CONSTRAINT [DF_ForbiddenPrivate_FileSize]  DEFAULT ((0)) FOR [FileSize]
GO

ALTER TABLE [dbo].[BD_Drawing] ADD  CONSTRAINT [DF_ForbiddenPrivate_SizeUnit]  DEFAULT ('Byte') FOR [SizeUnit]
GO

ALTER TABLE [dbo].[BD_Drawing] ADD  CONSTRAINT [DF_ForbiddenPrivate_SaveDate]  DEFAULT (getdate()) FOR [SaveDate]
GO

ALTER TABLE [dbo].[BD_Drawing] ADD  CONSTRAINT [DF_ForbiddenPrivate_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO

ALTER TABLE [dbo].[BD_Drawing] ADD  CONSTRAINT [DF_ForbiddenPrivate_Description]  DEFAULT ('') FOR [Description]
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Drawing', @level2type=N'COLUMN',@level2name=N'FMaterialId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'���ϱ���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Drawing', @level2type=N'COLUMN',@level2name=N'FNumber'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ļ���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Drawing', @level2type=N'COLUMN',@level2name=N'FileName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��׺' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Drawing', @level2type=N'COLUMN',@level2name=N'FileSuffix'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ļ�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Drawing', @level2type=N'COLUMN',@level2name=N'FileType'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ļ���С(Byte)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Drawing', @level2type=N'COLUMN',@level2name=N'FileSize'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��λ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Drawing', @level2type=N'COLUMN',@level2name=N'SizeUnit'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ļ��ϴ�·��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Drawing', @level2type=N'COLUMN',@level2name=N'SourcePath'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Drawing', @level2type=N'COLUMN',@level2name=N'Author'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Drawing', @level2type=N'COLUMN',@level2name=N'CreationDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�޸���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Drawing', @level2type=N'COLUMN',@level2name=N'Modifier'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�޸�ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Drawing', @level2type=N'COLUMN',@level2name=N'ModificationDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ϴ�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Drawing', @level2type=N'COLUMN',@level2name=N'SaveDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'ɾ��״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Drawing', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��ע' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Drawing', @level2type=N'COLUMN',@level2name=N'Description'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Context' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Drawing', @level2type=N'COLUMN',@level2name=N'Context'
GO


