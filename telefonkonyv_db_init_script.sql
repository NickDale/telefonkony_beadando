USE [telefonszamok]
GO
/****** Object:  User [dev_user]    Script Date: 2024. 06. 17. 14:59:15 ******/
CREATE USER [dev_user] FOR LOGIN [dev_user] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [dev_user]
GO
/****** Object:  Table [dbo].[felhasznalo]    Script Date: 2024. 06. 17. 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[felhasznalo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nev] [nvarchar](250) NOT NULL,
	[email] [nvarchar](100) NULL,
	[password] [nvarchar](300) NOT NULL,
 CONSTRAINT [PK_felhasznalo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[helyseg]    Script Date: 2024. 06. 17. 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[helyseg](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[IRSZ] [nvarchar](15) NOT NULL,
	[nev] [nvarchar](75) NOT NULL,
 CONSTRAINT [PK_helyseg] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Szemely]    Script Date: 2024. 06. 17. 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Szemely](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[vezeteknev] [nvarchar](100) NOT NULL,
	[utonev] [nvarchar](100) NOT NULL,
	[lakcim] [nvarchar](100) NOT NULL,
	[enHelysegid] [int] NULL,
 CONSTRAINT [PK_Szemely] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[telefonszam]    Script Date: 2024. 06. 17. 14:59:15 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[telefonszam](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[szam] [nvarchar](50) NOT NULL,
	[enSzemlyid] [int] NULL,
 CONSTRAINT [PK_telefonszam] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[felhasznalo] ON 

INSERT [dbo].[felhasznalo] ([id], [nev], [email], [password]) VALUES (1, N'teszt1', N'test@teszt.com', N'$2a$11$htKnEvfQEUMlOjVtbKxlBe7S.HSSaZoeJvaYZFVVMUbmUHiA4hV5y')
INSERT [dbo].[felhasznalo] ([id], [nev], [email], [password]) VALUES (2, N'user', N'user@teszt.com', N'$2a$11$ygpYD8cVSl9SOffmNVEre.YoGrXTe4xVcW67mKoY6Sr6Q9/5hHaUa')
SET IDENTITY_INSERT [dbo].[felhasznalo] OFF
GO
SET IDENTITY_INSERT [dbo].[helyseg] ON 

INSERT [dbo].[helyseg] ([id], [IRSZ], [nev]) VALUES (1, N'6000', N'Kecskemét')
INSERT [dbo].[helyseg] ([id], [IRSZ], [nev]) VALUES (2, N'1013', N'Budapest X. ker.')
INSERT [dbo].[helyseg] ([id], [IRSZ], [nev]) VALUES (3, N'1153', N'Budapest X. ker')
INSERT [dbo].[helyseg] ([id], [IRSZ], [nev]) VALUES (4, N'2046', N'TörökBálint')
INSERT [dbo].[helyseg] ([id], [IRSZ], [nev]) VALUES (5, N'6726', N'Szeged')
INSERT [dbo].[helyseg] ([id], [IRSZ], [nev]) VALUES (6, N'6720', N'Szeged')
INSERT [dbo].[helyseg] ([id], [IRSZ], [nev]) VALUES (7, N'6300', N'Kalocsa')
INSERT [dbo].[helyseg] ([id], [IRSZ], [nev]) VALUES (8, N'8230', N'Balatonfüred')
SET IDENTITY_INSERT [dbo].[helyseg] OFF
GO
SET IDENTITY_INSERT [dbo].[Szemely] ON 

INSERT [dbo].[Szemely] ([id], [vezeteknev], [utonev], [lakcim], [enHelysegid]) VALUES (2, N'Teszt', N'Elek', N'Fő út 11', 1)
INSERT [dbo].[Szemely] ([id], [vezeteknev], [utonev], [lakcim], [enHelysegid]) VALUES (3, N'Gipsz ', N'Jakab', N'Alma utca 55', 5)
INSERT [dbo].[Szemely] ([id], [vezeteknev], [utonev], [lakcim], [enHelysegid]) VALUES (4, N'Bármi', N'Áron', N'Töltés utca 2', 3)
INSERT [dbo].[Szemely] ([id], [vezeteknev], [utonev], [lakcim], [enHelysegid]) VALUES (5, N'Locsoló K', N'Anna', N'Virág utca 4', 6)
SET IDENTITY_INSERT [dbo].[Szemely] OFF
GO
SET IDENTITY_INSERT [dbo].[telefonszam] ON 

INSERT [dbo].[telefonszam] ([id], [szam], [enSzemlyid]) VALUES (1, N'+36-444-444', 2)
INSERT [dbo].[telefonszam] ([id], [szam], [enSzemlyid]) VALUES (2, N'+36-111-111', 2)
INSERT [dbo].[telefonszam] ([id], [szam], [enSzemlyid]) VALUES (3, N'+36-777-777', 3)
INSERT [dbo].[telefonszam] ([id], [szam], [enSzemlyid]) VALUES (5, N'+45-111-15151', 5)
SET IDENTITY_INSERT [dbo].[telefonszam] OFF
GO
ALTER TABLE [dbo].[Szemely]  WITH CHECK ADD  CONSTRAINT [FK_Szemely_helyseg_0] FOREIGN KEY([enHelysegid])
REFERENCES [dbo].[helyseg] ([id])
GO
ALTER TABLE [dbo].[Szemely] CHECK CONSTRAINT [FK_Szemely_helyseg_0]
GO
ALTER TABLE [dbo].[telefonszam]  WITH CHECK ADD  CONSTRAINT [FK_telefonszam_Szemely_0] FOREIGN KEY([enSzemlyid])
REFERENCES [dbo].[Szemely] ([id])
GO
ALTER TABLE [dbo].[telefonszam] CHECK CONSTRAINT [FK_telefonszam_Szemely_0]
GO
