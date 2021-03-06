USE [master]
GO
/****** Object:  Database [penjualan]    Script Date: 19/04/2021 13.39.20 ******/
CREATE DATABASE [penjualan]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'penjualan2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\penjualan2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'penjualan2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\penjualan2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [penjualan] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [penjualan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [penjualan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [penjualan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [penjualan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [penjualan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [penjualan] SET ARITHABORT OFF 
GO
ALTER DATABASE [penjualan] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [penjualan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [penjualan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [penjualan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [penjualan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [penjualan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [penjualan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [penjualan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [penjualan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [penjualan] SET  DISABLE_BROKER 
GO
ALTER DATABASE [penjualan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [penjualan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [penjualan] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [penjualan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [penjualan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [penjualan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [penjualan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [penjualan] SET RECOVERY FULL 
GO
ALTER DATABASE [penjualan] SET  MULTI_USER 
GO
ALTER DATABASE [penjualan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [penjualan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [penjualan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [penjualan] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [penjualan] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [penjualan] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'penjualan', N'ON'
GO
ALTER DATABASE [penjualan] SET QUERY_STORE = OFF
GO
USE [penjualan]
GO
/****** Object:  Table [dbo].[Barangs]    Script Date: 19/04/2021 13.39.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Barangs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Harga] [int] NOT NULL,
	[Stock] [int] NOT NULL,
	[Keterangan] [text] NOT NULL,
 CONSTRAINT [PK_Barangs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PesananDetails]    Script Date: 19/04/2021 13.39.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PesananDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PesananId] [int] NOT NULL,
	[BarangId] [int] NOT NULL,
	[Jumlah] [int] NOT NULL,
	[Total] [int] NOT NULL,
 CONSTRAINT [PK_PesananDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pesanans]    Script Date: 19/04/2021 13.39.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pesanans](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nchar](10) NOT NULL,
	[UserId] [int] NOT NULL,
	[Tanggal] [date] NOT NULL,
	[Status] [varchar](20) NOT NULL,
	[Total] [int] NOT NULL,
 CONSTRAINT [PK_Pesanans] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 19/04/2021 13.39.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 19/04/2021 13.39.20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[Alamat] [text] NOT NULL,
	[NoHp] [varchar](20) NOT NULL,
	[RoleId] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Barangs] ON 

INSERT [dbo].[Barangs] ([Id], [Name], [Harga], [Stock], [Keterangan]) VALUES (1, N'Redmi 4a', 800000, 10, N'Redmi 4a')
SET IDENTITY_INSERT [dbo].[Barangs] OFF
GO
SET IDENTITY_INSERT [dbo].[PesananDetails] ON 

INSERT [dbo].[PesananDetails] ([Id], [PesananId], [BarangId], [Jumlah], [Total]) VALUES (1, 1, 1, 2, 1600000)
SET IDENTITY_INSERT [dbo].[PesananDetails] OFF
GO
SET IDENTITY_INSERT [dbo].[Pesanans] ON 

INSERT [dbo].[Pesanans] ([Id], [CustomerName], [UserId], [Tanggal], [Status], [Total]) VALUES (1, N'Pembeli   ', 2, CAST(N'2021-04-19' AS Date), N'Lunas', 1600000)
SET IDENTITY_INSERT [dbo].[Pesanans] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([Id], [Name]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([Id], [Name]) VALUES (2, N'Kasir')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Name], [Username], [Password], [Alamat], [NoHp], [RoleId]) VALUES (1, N'Admin', N'admin', N'admin123', N'Admin', N'08123', 1)
INSERT [dbo].[Users] ([Id], [Name], [Username], [Password], [Alamat], [NoHp], [RoleId]) VALUES (2, N'Kasir', N'kasir', N'kasir123', N'Kasir', N'08123', 2)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[PesananDetails]  WITH CHECK ADD  CONSTRAINT [FK_PesananDetails_Barangs] FOREIGN KEY([BarangId])
REFERENCES [dbo].[Barangs] ([Id])
GO
ALTER TABLE [dbo].[PesananDetails] CHECK CONSTRAINT [FK_PesananDetails_Barangs]
GO
ALTER TABLE [dbo].[PesananDetails]  WITH CHECK ADD  CONSTRAINT [FK_PesananDetails_Pesanans] FOREIGN KEY([PesananId])
REFERENCES [dbo].[Pesanans] ([Id])
GO
ALTER TABLE [dbo].[PesananDetails] CHECK CONSTRAINT [FK_PesananDetails_Pesanans]
GO
ALTER TABLE [dbo].[Pesanans]  WITH CHECK ADD  CONSTRAINT [FK_Pesanans_Users] FOREIGN KEY([UserId])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Pesanans] CHECK CONSTRAINT [FK_Pesanans_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
USE [master]
GO
ALTER DATABASE [penjualan] SET  READ_WRITE 
GO
