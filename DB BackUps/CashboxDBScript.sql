USE [CashboxDB]
GO
/****** Object:  Table [dbo].[FreeItemSales]    Script Date: 27.10.2019 10:28:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FreeItemSales](
	[SId] [bigint] NOT NULL,
	[Sum] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_FreeItemSales] PRIMARY KEY CLUSTERED 
(
	[SId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 27.10.2019 10:28:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[IId] [varchar](50) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Price] [decimal](18, 2) NULL,
	[Number] [bigint] NULL,
	[Discount] [int] NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[IId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Returns]    Script Date: 27.10.2019 10:28:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Returns](
	[SId] [bigint] NOT NULL,
	[IId] [varchar](50) NOT NULL,
	[Number] [bigint] NOT NULL,
 CONSTRAINT [PK_Returns] PRIMARY KEY CLUSTERED 
(
	[SId] ASC,
	[IId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sales]    Script Date: 27.10.2019 10:28:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sales](
	[SId] [bigint] NOT NULL,
	[IId] [varchar](50) NOT NULL,
	[Number] [bigint] NOT NULL,
 CONSTRAINT [PK_Sales] PRIMARY KEY CLUSTERED 
(
	[SId] ASC,
	[IId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shifts]    Script Date: 27.10.2019 10:28:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shifts](
	[SId] [bigint] IDENTITY(1,1) NOT NULL,
	[UId] [varchar](50) NOT NULL,
	[StartDateTime] [datetime] NOT NULL,
	[EndDateTime] [datetime] NULL,
	[CashReceived] [decimal](18, 2) NOT NULL,
	[CashReturned] [decimal](18, 2) NOT NULL,
	[CashAdded] [decimal](18, 2) NOT NULL,
	[CashWithdrawn] [decimal](18, 2) NOT NULL,
	[CurrentCash] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Shift] PRIMARY KEY CLUSTERED 
(
	[SId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 27.10.2019 10:28:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UId] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[SurName] [varchar](50) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[FatherName] [varchar](50) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Items] ([IId], [Name], [Price], [Number], [Discount]) VALUES (N'0', N'Товар', NULL, NULL, NULL)
INSERT [dbo].[Users] ([UId], [Password], [SurName], [Name], [FatherName]) VALUES (N'root', N'1243', N'Куроедов', N'Роман', N'Александрович')
ALTER TABLE [dbo].[FreeItemSales] ADD  CONSTRAINT [DF_FreeItemSales_Sum]  DEFAULT ((0)) FOR [Sum]
GO
ALTER TABLE [dbo].[Shifts] ADD  CONSTRAINT [DF_Shifts_EndDateTime]  DEFAULT (NULL) FOR [EndDateTime]
GO
ALTER TABLE [dbo].[Shifts] ADD  CONSTRAINT [DF_Shifts_CashReceived]  DEFAULT ((0)) FOR [CashReceived]
GO
ALTER TABLE [dbo].[Shifts] ADD  CONSTRAINT [DF_Shifts_CashReturned]  DEFAULT ((0)) FOR [CashReturned]
GO
ALTER TABLE [dbo].[Shifts] ADD  CONSTRAINT [DF_Shifts_CashAdded]  DEFAULT ((0)) FOR [CashAdded]
GO
ALTER TABLE [dbo].[Shifts] ADD  CONSTRAINT [DF_Shifts_CashWithdrawn]  DEFAULT ((0)) FOR [CashWithdrawn]
GO
