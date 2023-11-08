USE [master]
GO
/****** Object:  Database [db_barrios_privados]    Script Date: 8/11/2023 13:22:48 ******/
CREATE DATABASE [db_barrios_privados]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_barrios_privados', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\db_barrios_privados.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_barrios_privados_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\db_barrios_privados_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [db_barrios_privados] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_barrios_privados].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_barrios_privados] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_barrios_privados] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_barrios_privados] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_barrios_privados] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_barrios_privados] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_barrios_privados] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_barrios_privados] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_barrios_privados] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_barrios_privados] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_barrios_privados] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_barrios_privados] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_barrios_privados] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_barrios_privados] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_barrios_privados] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_barrios_privados] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_barrios_privados] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_barrios_privados] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_barrios_privados] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_barrios_privados] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_barrios_privados] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_barrios_privados] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_barrios_privados] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_barrios_privados] SET RECOVERY FULL 
GO
ALTER DATABASE [db_barrios_privados] SET  MULTI_USER 
GO
ALTER DATABASE [db_barrios_privados] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_barrios_privados] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_barrios_privados] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_barrios_privados] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_barrios_privados] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_barrios_privados] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_barrios_privados', N'ON'
GO
ALTER DATABASE [db_barrios_privados] SET QUERY_STORE = ON
GO
ALTER DATABASE [db_barrios_privados] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [db_barrios_privados]
GO
/****** Object:  Table [dbo].[egresos]    Script Date: 8/11/2023 13:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[egresos](
	[id_egreso] [int] IDENTITY(1,1) NOT NULL,
	[id_ingreso] [int] NOT NULL,
	[fecha] [datetime] NULL,
	[observaciones] [nvarchar](max) NULL,
 CONSTRAINT [PK_Egreso] PRIMARY KEY CLUSTERED 
(
	[id_egreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ingresos]    Script Date: 8/11/2023 13:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ingresos](
	[id_ingreso] [int] IDENTITY(1,1) NOT NULL,
	[id_solicitud] [int] NULL,
	[fecha] [datetime] NULL,
 CONSTRAINT [PK_Ingreso] PRIMARY KEY CLUSTERED 
(
	[id_ingreso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[roles]    Script Date: 8/11/2023 13:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[roles](
	[id_rol] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[solicitudes]    Script Date: 8/11/2023 13:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[solicitudes](
	[id_solicitud] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NULL,
	[id_visitante] [int] NULL,
	[fecha] [date] NULL,
	[baja] [bit] NULL,
	[estado] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_solicitud] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 8/11/2023 13:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NULL,
	[apellido] [varchar](255) NULL,
	[email] [varchar](255) NULL,
	[contrasena] [varchar](255) NULL,
	[telefono] [varchar](15) NULL,
	[id_rol] [int] NULL,
	[direccion] [varchar](255) NULL,
	[estado] [int] NULL,
	[dni] [varchar](8) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[visitantes]    Script Date: 8/11/2023 13:22:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[visitantes](
	[id_visitante] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](255) NULL,
	[apellido] [varchar](255) NULL,
	[dni] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_visitante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[egresos]  WITH CHECK ADD  CONSTRAINT [FK_Egreso_Ingreso_IngresoId] FOREIGN KEY([id_ingreso])
REFERENCES [dbo].[ingresos] ([id_ingreso])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[egresos] CHECK CONSTRAINT [FK_Egreso_Ingreso_IngresoId]
GO
ALTER TABLE [dbo].[solicitudes]  WITH CHECK ADD FOREIGN KEY([id_usuario])
REFERENCES [dbo].[usuarios] ([id_usuario])
GO
ALTER TABLE [dbo].[solicitudes]  WITH CHECK ADD FOREIGN KEY([id_visitante])
REFERENCES [dbo].[visitantes] ([id_visitante])
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD FOREIGN KEY([id_rol])
REFERENCES [dbo].[roles] ([id_rol])
GO
ALTER TABLE [dbo].[usuarios]  WITH CHECK ADD  CONSTRAINT [CHK_DNI_Length] CHECK  ((len([dni])>=(7) AND len([dni])<=(8)))
GO
ALTER TABLE [dbo].[usuarios] CHECK CONSTRAINT [CHK_DNI_Length]
GO
USE [master]
GO
ALTER DATABASE [db_barrios_privados] SET  READ_WRITE 
GO
