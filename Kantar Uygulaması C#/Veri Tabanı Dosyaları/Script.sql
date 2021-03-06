USE [master]
GO
/****** Object:  Database [VtKantar]    Script Date: 10.04.2019 21:54:22 ******/
CREATE DATABASE [VtKantar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VtKantar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\VtKantar.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VtKantar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\VtKantar_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [VtKantar] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VtKantar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VtKantar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VtKantar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VtKantar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VtKantar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VtKantar] SET ARITHABORT OFF 
GO
ALTER DATABASE [VtKantar] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [VtKantar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VtKantar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VtKantar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VtKantar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VtKantar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VtKantar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VtKantar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VtKantar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VtKantar] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VtKantar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VtKantar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VtKantar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VtKantar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VtKantar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VtKantar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VtKantar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VtKantar] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VtKantar] SET  MULTI_USER 
GO
ALTER DATABASE [VtKantar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VtKantar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VtKantar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VtKantar] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [VtKantar] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VtKantar] SET QUERY_STORE = OFF
GO
USE [VtKantar]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [VtKantar]
GO
/****** Object:  UserDefinedFunction [dbo].[FnkSoforIdBul]    Script Date: 10.04.2019 21:54:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[FnkSoforIdBul](@Sofor varchar(40))
 returns tinyint
 begin
 declare @SoforId tinyint
 Select @SoforId=SoforId from TblSofor where Sofor=@Sofor
 return @SoforId
 end
GO
/****** Object:  UserDefinedFunction [dbo].[FnkUrunIdBul]    Script Date: 10.04.2019 21:54:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 Create function [dbo].[FnkUrunIdBul](@UrunAd varchar(30))
 returns tinyint
 begin
declare @UrunId tinyint
Select @UrunId=UrunId from TblUrun where UrunAd=@UrunAd
return @UrunId
 end
GO
/****** Object:  Table [dbo].[TblCalisan]    Script Date: 10.04.2019 21:54:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblCalisan](
	[KulId] [tinyint] IDENTITY(1,1) NOT NULL,
	[CalisanAd] [varchar](30) NULL,
	[CalisanSoyad] [varchar](30) NULL,
	[KulAdi] [varchar](10) NULL,
	[Parola] [varchar](10) NULL,
 CONSTRAINT [PK_TblCalisan] PRIMARY KEY CLUSTERED 
(
	[KulId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblKayitlar]    Script Date: 10.04.2019 21:54:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblKayitlar](
	[IslemId] [int] IDENTITY(1,1) NOT NULL,
	[Plaka] [varchar](10) NULL,
	[SoforId] [tinyint] NULL,
	[KulId] [tinyint] NULL,
	[GirisTarihi] [date] NULL,
	[GirisSaati] [time](7) NULL,
	[GirisAgirlik] [int] NULL,
	[GirenUrun] [tinyint] NULL,
	[CikisAgirlik] [int] NULL,
	[UrunAgirlik] [int] NULL,
	[CikisTarihi] [date] NULL,
	[CikisSaat] [time](7) NULL,
	[CikanUrun] [tinyint] NULL,
	[Durum] [bit] NULL,
 CONSTRAINT [PK_TblKayitlar] PRIMARY KEY CLUSTERED 
(
	[IslemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblSofor]    Script Date: 10.04.2019 21:54:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblSofor](
	[SoforId] [tinyint] IDENTITY(1,1) NOT NULL,
	[Sofor] [varchar](40) NULL,
 CONSTRAINT [PK_TblSofor] PRIMARY KEY CLUSTERED 
(
	[SoforId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TblUrun]    Script Date: 10.04.2019 21:54:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TblUrun](
	[UrunId] [tinyint] IDENTITY(1,1) NOT NULL,
	[UrunAd] [varchar](30) NULL,
 CONSTRAINT [PK_TblUrun] PRIMARY KEY CLUSTERED 
(
	[UrunId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TblCalisan] ON 

INSERT [dbo].[TblCalisan] ([KulId], [CalisanAd], [CalisanSoyad], [KulAdi], [Parola]) VALUES (1, N'Uğur', N'Mamak', N'ugur', N'1632')
INSERT [dbo].[TblCalisan] ([KulId], [CalisanAd], [CalisanSoyad], [KulAdi], [Parola]) VALUES (2, N'Eyüp Can', N'Doğan', N'eyup', N'1234')
SET IDENTITY_INSERT [dbo].[TblCalisan] OFF
SET IDENTITY_INSERT [dbo].[TblKayitlar] ON 

INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (1, N'34 fgs 45', 1, 1, CAST(N'2019-03-06' AS Date), CAST(N'17:18:00' AS Time), 2343, 1, 8530, 6187, CAST(N'2019-04-07' AS Date), CAST(N'11:16:00' AS Time), 5, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (2, N'76 ıgr 43', 2, 1, CAST(N'2019-02-25' AS Date), CAST(N'17:21:00' AS Time), 2391, 3, 7549, 5158, CAST(N'2019-02-27' AS Date), CAST(N'11:16:00' AS Time), 14, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (3, N'36 ygs 73', 3, 1, CAST(N'2019-01-30' AS Date), CAST(N'17:22:00' AS Time), 2196, 1, 2531, 335, CAST(N'2019-02-03' AS Date), CAST(N'21:24:00' AS Time), 5, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (4, N'01 dnm 42', 4, 1, CAST(N'2019-01-06' AS Date), CAST(N'17:27:00' AS Time), 2578, 4, 2271, -307, CAST(N'2019-01-08' AS Date), CAST(N'17:28:00' AS Time), 1, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (5, N'34 Ts 1632', 5, 1, CAST(N'2019-03-06' AS Date), CAST(N'20:13:00' AS Time), 2073, 1, 2658, 585, CAST(N'2019-03-10' AS Date), CAST(N'21:21:00' AS Time), 3, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (6, N'36 tse 42', 6, 1, CAST(N'2019-03-06' AS Date), CAST(N'21:20:00' AS Time), 2073, 1, 2577, 504, CAST(N'2019-03-11' AS Date), CAST(N'21:22:00' AS Time), 3, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (7, N'01 ste 41', 7, 1, CAST(N'2019-04-06' AS Date), CAST(N'21:24:00' AS Time), 2711, 6, 2096, -615, CAST(N'2019-04-06' AS Date), CAST(N'21:25:00' AS Time), 5, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (8, N'02 jgh 38', 8, 1, CAST(N'2019-04-06' AS Date), CAST(N'21:27:00' AS Time), 2050, 1, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (9, N'03opl59', 9, 1, CAST(N'2019-04-06' AS Date), CAST(N'21:56:00' AS Time), 2807, 7, 2249, -558, CAST(N'2019-04-06' AS Date), CAST(N'21:56:00' AS Time), 1, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (10, N'34 ngf 46', 10, 1, CAST(N'2019-04-02' AS Date), CAST(N'10:57:00' AS Time), 2807, 3, 7745, 4938, CAST(N'2019-04-07' AS Date), CAST(N'11:11:00' AS Time), 5, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (11, N'07 anl 487', 11, 1, CAST(N'2019-04-07' AS Date), CAST(N'10:58:00' AS Time), 2930, 8, 3073, 143, CAST(N'2019-04-09' AS Date), CAST(N'16:35:00' AS Time), 5, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (12, N'52 br 734', 12, 1, CAST(N'2019-04-03' AS Date), CAST(N'11:02:00' AS Time), 6249, 9, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (13, N'52 aş 105', 13, 1, CAST(N'2019-04-03' AS Date), CAST(N'11:03:00' AS Time), 5544, 9, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (14, N'01 wgf 43', 14, 1, CAST(N'2019-04-06' AS Date), CAST(N'11:04:00' AS Time), 7923, 6, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (15, N'76 ugr 134', 15, 1, CAST(N'2019-04-03' AS Date), CAST(N'11:06:00' AS Time), 8560, 10, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (16, N'41 hs 295', 16, 1, CAST(N'2019-04-06' AS Date), CAST(N'11:07:00' AS Time), 8933, 11, 2862, -6071, CAST(N'2019-04-09' AS Date), CAST(N'15:43:00' AS Time), 11, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (17, N'25 dsf 40', 17, 1, CAST(N'2019-03-04' AS Date), CAST(N'11:08:00' AS Time), 6810, 12, 2930, -3880, CAST(N'2019-03-08' AS Date), CAST(N'11:42:00' AS Time), 1, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (18, N'41 tyj 19', 17, 1, CAST(N'2019-04-06' AS Date), CAST(N'11:09:00' AS Time), 2672, 1, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (19, N'34 mb 826', 18, 1, CAST(N'2019-04-06' AS Date), CAST(N'11:09:00' AS Time), 3393, 1, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (20, N'34 sdgh 45', 19, 1, CAST(N'2019-04-05' AS Date), CAST(N'11:10:00' AS Time), 2336, 1, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (21, N'34 ngf 46', 10, 1, CAST(N'2019-04-05' AS Date), CAST(N'11:11:00' AS Time), 2228, 1, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (22, N'75 ddg 63', 20, 1, CAST(N'2019-04-06' AS Date), CAST(N'11:12:00' AS Time), 8194, 13, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (23, N'34 dsa 162', 21, 1, CAST(N'2019-04-06' AS Date), CAST(N'11:13:00' AS Time), 3153, 1, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (24, N'34 asf 51', 22, 1, CAST(N'2019-04-07' AS Date), CAST(N'11:14:00' AS Time), 3708, 1, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (25, N'16 lfd 59', 23, 1, CAST(N'2019-04-06' AS Date), CAST(N'11:15:00' AS Time), 2196, 1, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (26, N'01 dnm 42', 4, 1, CAST(N'2019-04-07' AS Date), CAST(N'11:18:00' AS Time), 7853, 4, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (27, N'46 hjf 19', 24, 1, CAST(N'2019-04-07' AS Date), CAST(N'11:41:00' AS Time), 3073, 1, 6249, 3176, CAST(N'2019-04-09' AS Date), CAST(N'14:27:00' AS Time), 10, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (28, N'36 ygs 73', 3, 1, CAST(N'2019-04-07' AS Date), CAST(N'14:11:00' AS Time), 6249, 5, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (29, N'34 üms 62', 5, 1, CAST(N'2019-04-07' AS Date), CAST(N'16:42:00' AS Time), 4807, 3, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (30, N'34 jhgf 46', 25, 1, CAST(N'2019-04-08' AS Date), CAST(N'10:49:00' AS Time), 4807, 1, 5544, 737, CAST(N'2019-04-08' AS Date), CAST(N'10:49:00' AS Time), 4, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (31, N'34 at 4761', 26, 1, CAST(N'2019-04-08' AS Date), CAST(N'19:13:00' AS Time), 4807, 1, 7923, 3116, CAST(N'2019-04-08' AS Date), CAST(N'19:14:00' AS Time), 15, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (32, N'34 bu 380', 27, 1, CAST(N'2019-04-08' AS Date), CAST(N'19:36:00' AS Time), 4807, 1, 6249, 1442, CAST(N'2019-04-08' AS Date), CAST(N'19:38:00' AS Time), 16, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (33, N'34 jld 76', 28, 1, CAST(N'2019-04-09' AS Date), CAST(N'10:12:00' AS Time), 4807, 1, 6249, 1442, CAST(N'2019-04-09' AS Date), CAST(N'10:12:00' AS Time), 6, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (34, N'34 fgs 45', 1, 1, CAST(N'2019-04-09' AS Date), CAST(N'10:13:00' AS Time), 3073, 1, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (35, N'34 lul 179', 29, 1, CAST(N'2019-04-09' AS Date), CAST(N'12:53:00' AS Time), 3658, 1, 5544, 1886, CAST(N'2019-04-09' AS Date), CAST(N'12:54:00' AS Time), 4, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (36, N'34 ts 1632', 5, 1, CAST(N'2019-04-09' AS Date), CAST(N'14:26:00' AS Time), 4807, 1, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (37, N'34 svvk 54', 30, 1, CAST(N'2019-04-09' AS Date), CAST(N'14:37:00' AS Time), 4807, 1, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (38, N'41 abc565', 30, 1, CAST(N'2019-04-09' AS Date), CAST(N'14:37:00' AS Time), 6249, 14, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (39, N'76 gol 42', 31, 1, CAST(N'2019-04-09' AS Date), CAST(N'14:41:00' AS Time), 7979, 5, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (40, N'34 lul 180', 32, 1, CAST(N'2019-04-09' AS Date), CAST(N'15:43:00' AS Time), 8391, 3, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (41, N'34 mbr 78', 33, 1, CAST(N'2019-04-09' AS Date), CAST(N'16:01:00' AS Time), 4086, 1, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (42, N'02 jgh 39', 34, 1, CAST(N'2019-04-09' AS Date), CAST(N'16:02:00' AS Time), 3052, 1, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (43, N'34 abc 82', 35, 1, CAST(N'2019-04-09' AS Date), CAST(N'16:06:00' AS Time), 2755, 1, 5173, 2418, CAST(N'2019-04-09' AS Date), CAST(N'16:14:00' AS Time), 5, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (44, N'34 ngf 46p', 35, 1, CAST(N'2019-04-09' AS Date), CAST(N'16:06:00' AS Time), 8350, 3, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (45, N'03pl59', 36, 1, CAST(N'2019-04-09' AS Date), CAST(N'16:07:00' AS Time), 3306, 1, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (46, N'03opl59', 36, 1, CAST(N'2019-04-09' AS Date), CAST(N'16:07:00' AS Time), 8427, 5, 5137, -3290, CAST(N'2019-04-09' AS Date), CAST(N'16:14:00' AS Time), 1, 1)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (47, N'41 hs 295', 37, 1, CAST(N'2019-04-09' AS Date), CAST(N'16:12:00' AS Time), 4807, 1, NULL, NULL, NULL, NULL, 2, 0)
INSERT [dbo].[TblKayitlar] ([IslemId], [Plaka], [SoforId], [KulId], [GirisTarihi], [GirisSaati], [GirisAgirlik], [GirenUrun], [CikisAgirlik], [UrunAgirlik], [CikisTarihi], [CikisSaat], [CikanUrun], [Durum]) VALUES (48, N'34 hut 25', 5, 1, CAST(N'2019-04-09' AS Date), CAST(N'16:35:00' AS Time), 6249, 1, NULL, NULL, NULL, NULL, 2, 0)
SET IDENTITY_INSERT [dbo].[TblKayitlar] OFF
SET IDENTITY_INSERT [dbo].[TblSofor] ON 

INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (1, N'mehmet gezer')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (2, N'selim yavuzoğlu')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (3, N'Abdullah Görgü')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (4, N'Sadık susar')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (5, N'Sezai Bilen')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (6, N'Yavuz Bahar')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (7, N'Kasım Kol')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (8, N'Rıza Bilen')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (9, N'Şevket esen')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (10, N'Samet Pot')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (11, N'Doğukan Aktürk')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (12, N'berkan ergün')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (13, N'Hüseyin Aksoy')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (14, N'Bülent Usanmaz')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (15, N'Mahmut Mustafa Şengül')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (16, N'Yusuf Akgün')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (17, N'Melih Balcı')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (18, N'Ramazan Oğul')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (19, N'Muhsin değerli')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (20, N'Ali Usanmaz')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (21, N'Mehmet Bilen')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (22, N'Kemal sever')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (23, N'Ahmet gider')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (24, N'Ömer uzak')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (25, N'Deneme Deneme')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (26, N'Sezgin Solmaz')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (27, N'Şevval Kaya')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (28, N'Tuncay Şahin')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (29, N'Tırcı Eyüp')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (30, N'emir berk bayraktar')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (31, N'Nasip Yıldırım')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (32, N'Ömer Faruk Gündoğdu')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (33, N'melek sancaklı')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (34, N'Utku balır')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (35, N'Kadir Doğan')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (36, N'alperen uzun')
INSERT [dbo].[TblSofor] ([SoforId], [Sofor]) VALUES (37, N'Tolga Polat')
SET IDENTITY_INSERT [dbo].[TblSofor] OFF
SET IDENTITY_INSERT [dbo].[TblUrun] ON 

INSERT [dbo].[TblUrun] ([UrunId], [UrunAd]) VALUES (1, N'Boş Araç')
INSERT [dbo].[TblUrun] ([UrunId], [UrunAd]) VALUES (2, N'Çıkış Yapılmadı')
INSERT [dbo].[TblUrun] ([UrunId], [UrunAd]) VALUES (3, N'patates')
INSERT [dbo].[TblUrun] ([UrunId], [UrunAd]) VALUES (4, N'pamuk')
INSERT [dbo].[TblUrun] ([UrunId], [UrunAd]) VALUES (5, N'soğan')
INSERT [dbo].[TblUrun] ([UrunId], [UrunAd]) VALUES (6, N'portakal')
INSERT [dbo].[TblUrun] ([UrunId], [UrunAd]) VALUES (7, N'Üzüm')
INSERT [dbo].[TblUrun] ([UrunId], [UrunAd]) VALUES (8, N'Ispanak')
INSERT [dbo].[TblUrun] ([UrunId], [UrunAd]) VALUES (9, N'Fındık')
INSERT [dbo].[TblUrun] ([UrunId], [UrunAd]) VALUES (10, N'Elma')
INSERT [dbo].[TblUrun] ([UrunId], [UrunAd]) VALUES (11, N'Pırasa')
INSERT [dbo].[TblUrun] ([UrunId], [UrunAd]) VALUES (12, N'Pancar')
INSERT [dbo].[TblUrun] ([UrunId], [UrunAd]) VALUES (13, N'Kayısı')
INSERT [dbo].[TblUrun] ([UrunId], [UrunAd]) VALUES (14, N'Patlıcan')
INSERT [dbo].[TblUrun] ([UrunId], [UrunAd]) VALUES (15, N'Ay Çiçeği')
INSERT [dbo].[TblUrun] ([UrunId], [UrunAd]) VALUES (16, N'Buğday')
SET IDENTITY_INSERT [dbo].[TblUrun] OFF
/****** Object:  StoredProcedure [dbo].[PrcAracSayisi]    Script Date: 10.04.2019 21:54:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcAracSayisi] as begin
Select COUNT(*)   from TblKayitlar where durum=0
 end
GO
/****** Object:  StoredProcedure [dbo].[PrcDurumFiltre]    Script Date: 10.04.2019 21:54:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[PrcDurumFiltre](@Durum bit) as begin
Select tk.IslemId,tk.Plaka,ts.Sofor as 'Şoför',tk.GirisTarihi,tk.GirisSaati,tblu.UrunAd as 'Giren Ürün',tu.UrunAd as 'Çıkan Ürün',tk.GirisAgirlik,tk.CikisAgirlik,tk.UrunAgirlik,tk.CikisTarihi,tk.CikisSaat,tc.CalisanAd+' '+tc.CalisanSoyad as 'Kayıt Eden'
from TblKayitlar tk join TblSofor ts on tk.SoforId = ts.SoforId 
join TblCalisan tc on tc.KulId = tk.KulId join TblUrun tu on tu.UrunId = tk.CikanUrun  
join TblUrun tblu on tblu.UrunId = tk.GirenUrun
where Durum=@Durum
end
GO
/****** Object:  StoredProcedure [dbo].[PrcPlakaFiltre]    Script Date: 10.04.2019 21:54:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcPlakaFiltre](@Plaka varchar(10)) as 
begin
set @Plaka=@Plaka+'%'
Select tk.IslemId,tk.Plaka,ts.Sofor as 'Şoför',tk.GirisTarihi,tk.GirisSaati,tblu.UrunAd as 'Giren Ürün',tu.UrunAd as 'Çıkan Ürün',tk.GirisAgirlik,tk.CikisAgirlik,tk.UrunAgirlik,tk.CikisTarihi,tk.CikisSaat,tc.CalisanAd+' '+tc.CalisanSoyad as 'Kayıt Eden'
from TblKayitlar tk join TblSofor ts on tk.SoforId = ts.SoforId
 join TblCalisan tc on tc.KulId = tk.KulId join 
 TblUrun tu on tu.UrunId=tk.CikanUrun 
 join TblUrun tblu on tblu.UrunId=tk.GirenUrun 
 where tk.Plaka like @Plaka
 end
GO
/****** Object:  StoredProcedure [dbo].[PrcPlakaKontrol]    Script Date: 10.04.2019 21:54:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcPlakaKontrol](@plaka varchar(10)) as begin
Select count(*)
from TblKayitlar
where Plaka=@plaka and Durum=0 
end
GO
/****** Object:  StoredProcedure [dbo].[PrcSoforFiltre]    Script Date: 10.04.2019 21:54:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcSoforFiltre](@Sofor varchar(40)) as begin
 set @Sofor=@Sofor+'%'
Select tk.IslemId,tk.Plaka,ts.Sofor as 'Şoför',tk.GirisTarihi,tk.GirisSaati,tblu.UrunAd as 'Giren Ürün',tu.UrunAd as 'Çıkan Ürün',tk.GirisAgirlik,tk.CikisAgirlik,tk.UrunAgirlik,tk.CikisTarihi,tk.CikisSaat,tc.CalisanAd+' '+tc.CalisanSoyad as 'Kayıt Eden'
from TblKayitlar tk join TblSofor ts on tk.SoforId = ts.SoforId
 join TblCalisan tc on tc.KulId = tk.KulId join 
 TblUrun tu on tu.UrunId=tk.CikanUrun 
 join TblUrun tblu on tblu.UrunId=tk.GirenUrun
  where ts.Sofor like @Sofor
 end
GO
/****** Object:  StoredProcedure [dbo].[PrcTarihRapor]    Script Date: 10.04.2019 21:54:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcTarihRapor] (@Tarih1 date,@Tarih2 date)as begin
Select tk.IslemId,tk.Plaka,ts.Sofor as 'Şoför',tk.GirisTarihi,tk.GirisSaati,tblu.UrunAd as 'Giren Ürün',tu.UrunAd as 'Çıkan Ürün',tk.GirisAgirlik,tk.CikisAgirlik,tk.UrunAgirlik,tk.CikisTarihi,tk.CikisSaat,tc.CalisanAd+' '+tc.CalisanSoyad as 'Kayıt Eden'
from TblKayitlar tk join TblSofor ts on tk.SoforId = ts.SoforId
 join TblCalisan tc on tc.KulId = tk.KulId join 
 TblUrun tu on tu.UrunId=tk.CikanUrun 
 join TblUrun tblu on tblu.UrunId=tk.GirenUrun 
 where tk.GirisTarihi between @Tarih1 and @Tarih2
end
GO
/****** Object:  StoredProcedure [dbo].[PrcTblCalisanSelect]    Script Date: 10.04.2019 21:54:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcTblCalisanSelect](@KulAdi varchar(10),@Parola varchar(10)) as begin
--Select COUNT(*) from TblCalisan where KulAdi=@KulAdi and Parola=@Parola
select COUNT(*),KulId from TblCalisan where KulAdi=@KulAdi and Parola=@Parola
group by KulId
end
GO
/****** Object:  StoredProcedure [dbo].[PrcTblKayitlarInsert]    Script Date: 10.04.2019 21:54:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcTblKayitlarInsert]
 (@Plaka varchar(10),
 @Sofor varchar(40),
 @KulId tinyint,
 @GirisAgirlik int,
 @UrunAd varchar(30),
 @Durum bit
 ) as begin 


 declare @GirisTarihi date;
declare @GirisSaati time(7);
SELECT @GirisSaati=CONVERT(VARCHAR(5),GETDATE(),108) 
SELECT @GirisTarihi=CONVERT(date, GETDATE(), 120) 

   Declare @UrunId tinyint
  Select @UrunId=dbo.FnkUrunIdBul(@UrunAd)
  if(@UrunId is null)
  begin
  insert into TblUrun values(@UrunAd)
  Select @UrunId=dbo.FnkUrunIdBul(@UrunAd)
  end


Declare @SoforId tinyint /*bu değişken TblKayitlara eklemek için kullanılacak */
Select @SoforId=dbo.FnkSoforIdBul(@Sofor)
if(@SoforId is null)--eğer şoför kayıtlı değilse şoförü tblSofor  tablosuna ekler.
begin
 insert into TblSofor values(@Sofor)
 Select @SoforId=dbo.FnkSoforIdBul(@Sofor)
end
--Sadece  giriş işleminde kullanılacak sütünlara veri ekleme işlemi yaptık.
insert into TblKayitlar
(Plaka,SoforId,KulId,GirisTarihi,GirisSaati,GirisAgirlik,GirenUrun,Durum,CikanUrun) values
(@Plaka,@SoforId,@KulId,@GirisTarihi,@GirisSaati,@GirisAgirlik,@UrunId,0,2)
 end
GO
/****** Object:  StoredProcedure [dbo].[PrcTblKayitlarSelect]    Script Date: 10.04.2019 21:54:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcTblKayitlarSelect] as begin 
 Select tk.IslemId,tk.Plaka,ts.Sofor,tk.GirisTarihi,tk.CikisSaat,tc.CalisanAd,tc.CalisanSoyad,tk.GirisAgirlik,tk.Durum,tk.CikanUrun
 from TblKayitlar tk join TblSofor ts on tk.SoforId=ts.SoforId 
 join TblCalisan tc on tc.KulId=tk.KulId
 where Durum=0

 end
GO
/****** Object:  StoredProcedure [dbo].[PrcTblKayitlarUpdate]    Script Date: 10.04.2019 21:54:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[PrcTblKayitlarUpdate]
 (@IslemId int,
 @CikisAgirlik int,
 @UrunAgirlik int,
 @UrunAd varchar(30)
)
  as begin 

  declare @CikisTarih date;
declare  @CikisSaat time(7);
SELECT  @CikisSaat=CONVERT(VARCHAR(5),GETDATE(),108) 
SELECT @CikisTarih=CONVERT(date, GETDATE(), 120) 




  Declare @UrunId tinyint
  Select @UrunId=dbo.FnkUrunIdBul(@UrunAd)
  if(@UrunId is null)
  begin
  insert into TblUrun values(@UrunAd)
  Select @UrunId=dbo.FnkUrunIdBul(@UrunAd)
  end
  update TblKayitlar 
  set CikisAgirlik=@CikisAgirlik , UrunAgirlik=@UrunAgirlik , CikisTarihi=@CikisTarih,
  CikisSaat=@CikisSaat , CikanUrun=@UrunId , Durum=1
  where IslemId=@IslemId
 end
GO
/****** Object:  StoredProcedure [dbo].[PrcTblSoforInsert]    Script Date: 10.04.2019 21:54:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcTblSoforInsert](@Sofor varchar(40)) as begin
insert into TblSofor values(@Sofor)
end
GO
/****** Object:  StoredProcedure [dbo].[PrcTblSoforSelect]    Script Date: 10.04.2019 21:54:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[PrcTblSoforSelect] as begin
Select * from TblSofor
end
GO
/****** Object:  StoredProcedure [dbo].[PrcTblUrunInsert]    Script Date: 10.04.2019 21:54:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[PrcTblUrunInsert](@UrunAd varchar(30)) as begin
insert into TblUrun values(@UrunAd)
end
GO
/****** Object:  StoredProcedure [dbo].[PrcTblUrunSelect]    Script Date: 10.04.2019 21:54:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcTblUrunSelect] as begin
select * from TblUrun where UrunAd!='Çıkış Yapılmadı'
end
GO
/****** Object:  StoredProcedure [dbo].[PrcTumKayitListele]    Script Date: 10.04.2019 21:54:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PrcTumKayitListele] as begin
Select tk.IslemId,tk.Plaka,ts.Sofor as 'Şoför',tk.GirisTarihi,tk.GirisSaati,tblu.UrunAd as 'Giren Ürün',tu.UrunAd as 'Çıkan Ürün',tk.GirisAgirlik,tk.CikisAgirlik,tk.UrunAgirlik,tk.CikisTarihi,tk.CikisSaat,tc.CalisanAd+' '+tc.CalisanSoyad as 'Kayıt Eden'
from TblKayitlar tk join TblSofor ts on tk.SoforId = ts.SoforId 
join TblCalisan tc on tc.KulId = tk.KulId join TblUrun tu on tu.UrunId = tk.CikanUrun  
join TblUrun tblu on tblu.UrunId = tk.GirenUrun 
end
GO
USE [master]
GO
ALTER DATABASE [VtKantar] SET  READ_WRITE 
GO
