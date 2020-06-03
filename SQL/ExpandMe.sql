USE [master]
GO
/****** Object:  Database [CHANGEME]    Script Date: 03.06.2020 16:36:36 ******/
CREATE DATABASE [CHANGEME]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CHANGEME', FILENAME = N'D:\MSSQLDataBases\CHANGEME.mdf' , SIZE = 10240KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CHANGEME_log', FILENAME = N'D:\MSSQLDataBases\CHANGEME_log.ldf' , SIZE = 123584KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [CHANGEME] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CHANGEME].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CHANGEME] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CHANGEME] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CHANGEME] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CHANGEME] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CHANGEME] SET ARITHABORT OFF 
GO
ALTER DATABASE [CHANGEME] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CHANGEME] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CHANGEME] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CHANGEME] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CHANGEME] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CHANGEME] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CHANGEME] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CHANGEME] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CHANGEME] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CHANGEME] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CHANGEME] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CHANGEME] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CHANGEME] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CHANGEME] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CHANGEME] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CHANGEME] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CHANGEME] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CHANGEME] SET RECOVERY FULL 
GO
ALTER DATABASE [CHANGEME] SET  MULTI_USER 
GO
ALTER DATABASE [CHANGEME] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CHANGEME] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CHANGEME] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CHANGEME] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CHANGEME] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CHANGEME', N'ON'
GO
ALTER DATABASE [CHANGEME] SET QUERY_STORE = OFF
GO
USE [CHANGEME]
GO
/****** Object:  User [admin]    Script Date: 03.06.2020 16:36:36 ******/
CREATE USER [admin] FOR LOGIN [admin] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_owner] ADD MEMBER [admin]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [admin]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [admin]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [admin]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [admin]
GO
ALTER ROLE [db_datareader] ADD MEMBER [admin]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [admin]
GO
/****** Object:  Schema [Raports]    Script Date: 03.06.2020 16:36:36 ******/
CREATE SCHEMA [Raports]
GO
/****** Object:  Schema [Scripts]    Script Date: 03.06.2020 16:36:36 ******/
CREATE SCHEMA [Scripts]
GO
/****** Object:  Schema [ServersAndMarkers]    Script Date: 03.06.2020 16:36:36 ******/
CREATE SCHEMA [ServersAndMarkers]
GO
/****** Object:  Table [Raports].[Compleate]    Script Date: 03.06.2020 16:36:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Raports].[Compleate](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DataTime] [datetime2](7) NULL,
	[ServerDBUserPasswd] [varchar](256) NOT NULL,
	[ScriptName] [varchar](256) NOT NULL,
 CONSTRAINT [PK_Compleate_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Raports].[Errors]    Script Date: 03.06.2020 16:36:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Raports].[Errors](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DataTime] [datetime2](7) NULL,
	[ServerDBUserPasswd] [varchar](1024) NOT NULL,
	[ScriptName] [varchar](256) NOT NULL,
	[ErrorCode] [int] NOT NULL,
	[ErrorMessage] [nvarchar](512) NOT NULL,
 CONSTRAINT [PK_Errors_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Raports].[Info]    Script Date: 03.06.2020 16:36:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Raports].[Info](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DataTime] [datetime2](7) NOT NULL,
	[ServerDB] [varchar](1024) NOT NULL,
	[Script] [varchar](256) NOT NULL,
	[MessageInfo] [nvarchar](512) NOT NULL,
 CONSTRAINT [PK_Info_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Scripts].[ChangingOfScripts]    Script Date: 03.06.2020 16:36:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Scripts].[ChangingOfScripts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ScriptID] [uniqueidentifier] NOT NULL,
	[ScriptLastName] [varchar](256) NOT NULL,
	[OperationDate] [datetime] NOT NULL,
	[Operation] [varchar](6) NULL,
	[OperationLogin] [varchar](256) NOT NULL,
 CONSTRAINT [PK_ChangingOfScripts_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [Scripts].[ScriptsTable]    Script Date: 03.06.2020 16:36:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Scripts].[ScriptsTable](
	[ID] [uniqueidentifier] NOT NULL,
	[ScriptName] [varchar](256) NOT NULL,
	[ScriptContent] [text] NULL,
 CONSTRAINT [PK_ScriptsTable_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_ScriptsTable_ScriptName] UNIQUE NONCLUSTERED 
(
	[ScriptName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [ServersAndMarkers].[Markers]    Script Date: 03.06.2020 16:36:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ServersAndMarkers].[Markers](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MarkerName] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_Markers_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [ServersAndMarkers].[Relations]    Script Date: 03.06.2020 16:36:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ServersAndMarkers].[Relations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ServerListID] [int] NOT NULL,
	[MarkerID] [int] NOT NULL,
 CONSTRAINT [PK_Relations_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [ServersAndMarkers].[ServerList]    Script Date: 03.06.2020 16:36:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ServersAndMarkers].[ServerList](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ServerDomainName] [nvarchar](256) NOT NULL,
	[DataBaseName] [nvarchar](256) NOT NULL,
	[ServerLogin] [nvarchar](256) NOT NULL,
	[ServerPassword] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_ServerList_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [UI]    Script Date: 03.06.2020 16:36:36 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UI] ON [ServersAndMarkers].[Relations]
(
	[ServerListID] ASC,
	[MarkerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_ServerDB]    Script Date: 03.06.2020 16:36:36 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_ServerDB] ON [ServersAndMarkers].[ServerList]
(
	[ServerDomainName] ASC,
	[DataBaseName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [Raports].[Compleate] ADD  CONSTRAINT [DF_Compleate_datatime]  DEFAULT (getdate()) FOR [DataTime]
GO
ALTER TABLE [Raports].[Errors] ADD  CONSTRAINT [DF_Errors_datatime]  DEFAULT (getdate()) FOR [DataTime]
GO
ALTER TABLE [Raports].[Info] ADD  CONSTRAINT [DF_Info_Data]  DEFAULT (getdate()) FOR [DataTime]
GO
ALTER TABLE [Scripts].[ChangingOfScripts] ADD  CONSTRAINT [DF_ChangingOfScripts_OperationDate]  DEFAULT (getdate()) FOR [OperationDate]
GO
ALTER TABLE [Scripts].[ChangingOfScripts] ADD  CONSTRAINT [DF_ChangingOfScripts_OperationLogin]  DEFAULT (suser_sname()) FOR [OperationLogin]
GO
ALTER TABLE [Scripts].[ScriptsTable] ADD  DEFAULT (newid()) FOR [ID]
GO
ALTER TABLE [ServersAndMarkers].[Relations]  WITH CHECK ADD  CONSTRAINT [FK_Relations_MarkerID] FOREIGN KEY([MarkerID])
REFERENCES [ServersAndMarkers].[Markers] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [ServersAndMarkers].[Relations] CHECK CONSTRAINT [FK_Relations_MarkerID]
GO
ALTER TABLE [ServersAndMarkers].[Relations]  WITH CHECK ADD  CONSTRAINT [FK_Relations_ServerListID] FOREIGN KEY([ServerListID])
REFERENCES [ServersAndMarkers].[ServerList] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [ServersAndMarkers].[Relations] CHECK CONSTRAINT [FK_Relations_ServerListID]
GO
ALTER TABLE [Scripts].[ChangingOfScripts]  WITH CHECK ADD  CONSTRAINT [CK_ChangingOfScripts_Operation] CHECK  (([Operation]='DELETE' OR [Operation]='UPDATE' OR [Operation]='INSERT'))
GO
ALTER TABLE [Scripts].[ChangingOfScripts] CHECK CONSTRAINT [CK_ChangingOfScripts_Operation]
GO
/****** Object:  StoredProcedure [Scripts].[AddScript]    Script Date: 03.06.2020 16:36:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Scripts].[AddScript] @ScriptName VARCHAR(256), @ScriptContent TEXT
AS
  IF @ScriptName IN (SELECT
        st.ScriptName
      FROM Scripts.ScriptsTable st
      WHERE st.ScriptName = @ScriptName)
  BEGIN
    UPDATE Scripts.ScriptsTable
    SET ScriptContent = @ScriptContent
    WHERE ScriptName = @ScriptName
  END
  ELSE
  BEGIN
    INSERT Scripts.ScriptsTable(ScriptName, ScriptContent)
      VALUES(@ScriptName, @ScriptContent)
  END
GO
/****** Object:  StoredProcedure [Scripts].[TruncateTables]    Script Date: 03.06.2020 16:36:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [Scripts].[TruncateTables]
AS
  TRUNCATE TABLE Scripts.ChangingOfScripts;
  TRUNCATE TABLE Scripts.ScriptsTable;
GO
USE [master]
GO
ALTER DATABASE [CHANGEME] SET  READ_WRITE 
GO
