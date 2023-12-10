USE [Hotel]
GO
/****** Object:  User [Admin]    Script Date: 06.12.2023 20:14:01 ******/
CREATE USER [Admin] FOR LOGIN [Admin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [User]    Script Date: 06.12.2023 20:14:01 ******/
CREATE USER [User] FOR LOGIN [User] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Application]    Script Date: 06.12.2023 20:14:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Application](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[RoomID] [int] NOT NULL,
	[GuestID] [int] NOT NULL,
 CONSTRAINT [PK_Application] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guest]    Script Date: 06.12.2023 20:14:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guest](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PhoneNumber] [nvarchar](50) NOT NULL,
	[FullName] [nvarchar](100) NOT NULL,
	[PasportData] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Guest] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 06.12.2023 20:14:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [int] NOT NULL,
	[Title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 06.12.2023 20:14:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NOT NULL,
	[Price] [int] NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 06.12.2023 20:14:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[Login] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_User_1] PRIMARY KEY CLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Application] ON 

INSERT [dbo].[Application] ([ID], [PhoneNumber], [RoomID], [GuestID]) VALUES (1, N'+7912-111-11-11', 1, 1)
INSERT [dbo].[Application] ([ID], [PhoneNumber], [RoomID], [GuestID]) VALUES (10, N'+7912-126-27-02', 8, 2)
INSERT [dbo].[Application] ([ID], [PhoneNumber], [RoomID], [GuestID]) VALUES (13, N'345345', 1, 1)
SET IDENTITY_INSERT [dbo].[Application] OFF
GO
SET IDENTITY_INSERT [dbo].[Guest] ON 

INSERT [dbo].[Guest] ([ID], [PhoneNumber], [FullName], [PasportData]) VALUES (1, N'+7912-111-11-11', N'Родин Олег Альбертович', N'11-11-111111')
INSERT [dbo].[Guest] ([ID], [PhoneNumber], [FullName], [PasportData]) VALUES (2, N'+7912-228-00-00', N'Путин Владимир Владимирович', N'00-01-000001')
INSERT [dbo].[Guest] ([ID], [PhoneNumber], [FullName], [PasportData]) VALUES (3, N'+7912-486-55-78', N'Шуметов Максим Сергеевич', N'57-77-552121')
SET IDENTITY_INSERT [dbo].[Guest] OFF
GO
INSERT [dbo].[Role] ([ID], [Title]) VALUES (1, N'Admin')
INSERT [dbo].[Role] ([ID], [Title]) VALUES (2, N'Manager')
GO
SET IDENTITY_INSERT [dbo].[Room] ON 

INSERT [dbo].[Room] ([ID], [Number], [Price], [Category]) VALUES (1, 1, 1200, N'Одиночный')
INSERT [dbo].[Room] ([ID], [Number], [Price], [Category]) VALUES (2, 2, 2000, N'Двойной')
INSERT [dbo].[Room] ([ID], [Number], [Price], [Category]) VALUES (3, 3, 5000, N'Люкс')
INSERT [dbo].[Room] ([ID], [Number], [Price], [Category]) VALUES (8, 4, 10000, N'Для Путина')
SET IDENTITY_INSERT [dbo].[Room] OFF
GO
INSERT [dbo].[User] ([Login], [Password], [RoleID]) VALUES (N'5563BBE566E6CB8DAEAB62C1111C0793', N'5563BBE566E6CB8DAEAB62C1111C0793', 2)
INSERT [dbo].[User] ([Login], [Password], [RoleID]) VALUES (N'6FB4F22992A0D164B77267FDE5477248', N'6FB4F22992A0D164B77267FDE5477248', 1)
GO
ALTER TABLE [dbo].[Application]  WITH CHECK ADD  CONSTRAINT [FK_Application_Guest] FOREIGN KEY([GuestID])
REFERENCES [dbo].[Guest] ([ID])
GO
ALTER TABLE [dbo].[Application] CHECK CONSTRAINT [FK_Application_Guest]
GO
ALTER TABLE [dbo].[Application]  WITH CHECK ADD  CONSTRAINT [FK_Application_Room] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Room] ([ID])
GO
ALTER TABLE [dbo].[Application] CHECK CONSTRAINT [FK_Application_Room]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
