USE [master]
GO
/****** Object:  Database [exeltool]    Script Date: 6/1/2018 12:34:39 PM ******/
CREATE DATABASE [exeltool]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'exeltool', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER2017\MSSQL\DATA\exeltool.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'exeltool_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER2017\MSSQL\DATA\exeltool_log.ldf' , SIZE = 204800KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [exeltool] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [exeltool].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [exeltool] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [exeltool] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [exeltool] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [exeltool] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [exeltool] SET ARITHABORT OFF 
GO
ALTER DATABASE [exeltool] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [exeltool] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [exeltool] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [exeltool] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [exeltool] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [exeltool] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [exeltool] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [exeltool] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [exeltool] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [exeltool] SET  DISABLE_BROKER 
GO
ALTER DATABASE [exeltool] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [exeltool] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [exeltool] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [exeltool] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [exeltool] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [exeltool] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [exeltool] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [exeltool] SET RECOVERY FULL 
GO
ALTER DATABASE [exeltool] SET  MULTI_USER 
GO
ALTER DATABASE [exeltool] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [exeltool] SET DB_CHAINING OFF 
GO
ALTER DATABASE [exeltool] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [exeltool] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [exeltool] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'exeltool', N'ON'
GO
ALTER DATABASE [exeltool] SET QUERY_STORE = OFF
GO
USE [exeltool]
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
USE [exeltool]
GO
/****** Object:  Table [dbo].[bom]    Script Date: 6/1/2018 12:34:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bom](
	[component_id] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[check] [int] NULL,
	[component_name] [nvarchar](50) NULL,
	[object_description] [nvarchar](50) NULL,
 CONSTRAINT [PK_bom_1] PRIMARY KEY CLUSTERED 
(
	[component_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[bom_model]    Script Date: 6/1/2018 12:34:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bom_model](
	[component_id] [decimal](18, 0) NOT NULL,
	[model_name] [nvarchar](50) NOT NULL,
	[model_value] [decimal](18, 0) NULL,
	[id] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_bom_model] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[chiacat]    Script Date: 6/1/2018 12:34:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chiacat](
	[id] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[scan] [nvarchar](50) NULL,
	[shift] [nvarchar](50) NULL,
	[date] [nvarchar](50) NULL,
	[code] [nvarchar](50) NULL,
	[quantity] [decimal](18, 0) NULL,
	[line] [int] NULL,
	[model] [nvarchar](50) NULL,
 CONSTRAINT [PK_chiacat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[kitting]    Script Date: 6/1/2018 12:34:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[kitting](
	[id] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[scan] [nvarchar](50) NULL,
	[shift] [nvarchar](50) NULL,
	[date] [nvarchar](50) NULL,
	[code] [nvarchar](50) NULL,
	[quantity] [decimal](18, 0) NULL,
	[line] [int] NULL,
	[model] [nvarchar](50) NULL,
 CONSTRAINT [PK_kitting] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[nhanle]    Script Date: 6/1/2018 12:34:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[nhanle](
	[id] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[scan] [nvarchar](50) NULL,
	[shift] [nvarchar](50) NULL,
	[date] [nvarchar](50) NULL,
	[code] [nvarchar](50) NULL,
	[quantity] [decimal](18, 0) NULL,
	[line] [int] NULL,
	[model] [nvarchar](50) NULL,
 CONSTRAINT [PK_nhanle] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pgmtrave]    Script Date: 6/1/2018 12:34:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pgmtrave](
	[id] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[scan] [nvarchar](50) NULL,
	[shift] [nvarchar](50) NULL,
	[date] [nvarchar](50) NULL,
	[code] [nvarchar](50) NULL,
	[quantity] [decimal](18, 0) NULL,
	[line] [int] NULL,
	[model] [nvarchar](50) NULL,
 CONSTRAINT [PK_pgmtrave] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[planx]    Script Date: 6/1/2018 12:34:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[planx](
	[plan_id] [decimal](18, 0) IDENTITY(1,1) NOT NULL,
	[component_id] [decimal](18, 0) NULL,
	[model_id] [decimal](18, 0) NULL,
	[plan_data] [decimal](18, 0) NULL,
	[plan_line] [decimal](18, 0) NULL,
	[plan_time] [nvarchar](50) NULL,
	[model_code] [nvarchar](50) NULL,
	[bom_model_id] [decimal](18, 0) NULL,
 CONSTRAINT [PK_plan] PRIMARY KEY CLUSTERED 
(
	[plan_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[bom_model] ADD  CONSTRAINT [DF_bom_model_model_value]  DEFAULT ((0)) FOR [model_value]
GO
ALTER TABLE [dbo].[bom_model]  WITH CHECK ADD  CONSTRAINT [FK_bom_model_bom] FOREIGN KEY([component_id])
REFERENCES [dbo].[bom] ([component_id])
GO
ALTER TABLE [dbo].[bom_model] CHECK CONSTRAINT [FK_bom_model_bom]
GO
ALTER TABLE [dbo].[planx]  WITH CHECK ADD  CONSTRAINT [FK_plan_bom] FOREIGN KEY([component_id])
REFERENCES [dbo].[bom] ([component_id])
GO
ALTER TABLE [dbo].[planx] CHECK CONSTRAINT [FK_plan_bom]
GO
ALTER TABLE [dbo].[planx]  WITH CHECK ADD  CONSTRAINT [FK_plan_bom_model] FOREIGN KEY([model_id])
REFERENCES [dbo].[bom_model] ([id])
GO
ALTER TABLE [dbo].[planx] CHECK CONSTRAINT [FK_plan_bom_model]
GO
USE [master]
GO
ALTER DATABASE [exeltool] SET  READ_WRITE 
GO
