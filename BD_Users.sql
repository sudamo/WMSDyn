
/****** Object:  Table [dbo].[BD_Users]    Script Date: 2018/11/29 10:52:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[BD_Users](
	[PID] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](100) NOT NULL CONSTRAINT [DF_BD_Users_Password]  DEFAULT (''),
	[FDeptId] [int] NOT NULL CONSTRAINT [DF_BD_Users_GroupId]  DEFAULT ((0)),
	[IsUse] [bit] NOT NULL CONSTRAINT [DF_BD_Users_IsUse]  DEFAULT ((1)),
	[LogStatus] [bit] NOT NULL CONSTRAINT [DF_BD_Users_LogStatus]  DEFAULT ((0)),
	[Creator] [varchar](50) NOT NULL CONSTRAINT [DF_BD_Users_Creator]  DEFAULT (''),
	[CreationDate] [datetime] NOT NULL CONSTRAINT [DF_BD_Users_CreationDate]  DEFAULT (getdate()),
	[Modifier] [varchar](50) NOT NULL CONSTRAINT [DF_BD_Users_Modifer]  DEFAULT (''),
	[ModificationDate] [datetime] NOT NULL CONSTRAINT [DF_BD_Users_ModificationDate]  DEFAULT (getdate()),
	[LastLoginDate] [datetime] NOT NULL CONSTRAINT [DF_BD_Users_LastLoginDate]  DEFAULT (getdate()),
	[Flag] [tinyint] NOT NULL CONSTRAINT [DF_BD_Users_Flag]  DEFAULT ((0)),
	[Description] [varchar](200) NOT NULL CONSTRAINT [DF_BD_Users_Decription]  DEFAULT (''),
 CONSTRAINT [PK_BD_Users_PID] PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UK_BD_User_UserId] UNIQUE NONCLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Users', @level2type=N'COLUMN',@level2name=N'PID'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�û�ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Users', @level2type=N'COLUMN',@level2name=N'UserId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�û�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Users', @level2type=N'COLUMN',@level2name=N'UserName'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Users', @level2type=N'COLUMN',@level2name=N'Password'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Users', @level2type=N'COLUMN',@level2name=N'FDeptId'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Users', @level2type=N'COLUMN',@level2name=N'IsUse'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��¼״̬' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Users', @level2type=N'COLUMN',@level2name=N'LogStatus'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Users', @level2type=N'COLUMN',@level2name=N'Creator'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��������' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Users', @level2type=N'COLUMN',@level2name=N'CreationDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�޸���' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Users', @level2type=N'COLUMN',@level2name=N'Modifier'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�޸�����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Users', @level2type=N'COLUMN',@level2name=N'ModificationDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'�ϴε�¼ʱ��' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Users', @level2type=N'COLUMN',@level2name=N'LastLoginDate'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'��ʶ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Users', @level2type=N'COLUMN',@level2name=N'Flag'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'����' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'BD_Users', @level2type=N'COLUMN',@level2name=N'Description'
GO


