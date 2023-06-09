USE [master]
GO
/****** Object:  Database [FinalLibrary]    Script Date: 3/14/2023 1:28:51 PM ******/
CREATE DATABASE [FinalLibrary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FinalLibrary', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.KHANHTRAN\MSSQL\DATA\FinalLibrary.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FinalLibrary_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.KHANHTRAN\MSSQL\DATA\FinalLibrary_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [FinalLibrary] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FinalLibrary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FinalLibrary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FinalLibrary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FinalLibrary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FinalLibrary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FinalLibrary] SET ARITHABORT OFF 
GO
ALTER DATABASE [FinalLibrary] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FinalLibrary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FinalLibrary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FinalLibrary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FinalLibrary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FinalLibrary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FinalLibrary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FinalLibrary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FinalLibrary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FinalLibrary] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FinalLibrary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FinalLibrary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FinalLibrary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FinalLibrary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FinalLibrary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FinalLibrary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FinalLibrary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FinalLibrary] SET RECOVERY FULL 
GO
ALTER DATABASE [FinalLibrary] SET  MULTI_USER 
GO
ALTER DATABASE [FinalLibrary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FinalLibrary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FinalLibrary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FinalLibrary] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FinalLibrary] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FinalLibrary] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'FinalLibrary', N'ON'
GO
ALTER DATABASE [FinalLibrary] SET QUERY_STORE = OFF
GO
USE [FinalLibrary]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 3/14/2023 1:28:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[BookID] [nvarchar](50) NOT NULL,
	[BookName] [nvarchar](50) NOT NULL,
	[Author] [nvarchar](50) NOT NULL,
	[Publication] [nvarchar](50) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
	[PurchaseDate] [smalldatetime] NOT NULL,
	[Price] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 3/14/2023 1:28:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IRBook]    Script Date: 3/14/2023 1:28:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IRBook](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SID] [nvarchar](50) NOT NULL,
	[SName] [nvarchar](50) NOT NULL,
	[SFaculty] [nvarchar](50) NOT NULL,
	[SPhone] [nchar](10) NOT NULL,
	[SEmail] [nvarchar](50) NOT NULL,
	[BookID] [nvarchar](50) NOT NULL,
	[BookName] [nvarchar](50) NOT NULL,
	[DayIssue] [smalldatetime] NOT NULL,
	[DayReturn] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 3/14/2023 1:28:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [nvarchar](50) NOT NULL,
	[StudentName] [nvarchar](50) NOT NULL,
	[Faculty] [nvarchar](50) NOT NULL,
	[Semester] [nvarchar](50) NOT NULL,
	[Phone] [char](10) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Image] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Table]    Script Date: 3/14/2023 1:28:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Table](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SID] [nvarchar](50) NOT NULL,
	[SName] [nvarchar](50) NOT NULL,
	[SFaculty] [nvarchar](50) NOT NULL,
	[BookID] [nvarchar](50) NOT NULL,
	[BookName] [nvarchar](50) NOT NULL,
	[DayIssue] [smalldatetime] NOT NULL,
	[DayReturn] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/14/2023 1:28:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Username] [nvarchar](50) NOT NULL,
	[Password] [nchar](10) NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [FinalLibrary] SET  READ_WRITE 
GO
