USE [master]
GO
/****** Object:  Database [CodeWorks]    Script Date: 10/06/2022 12:22:05 AM ******/
CREATE DATABASE [CodeWorks]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CodeWorks', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\CodeWorks.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CodeWorks_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\CodeWorks_log.ldf' , SIZE = 139264KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CodeWorks] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CodeWorks].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CodeWorks] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CodeWorks] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CodeWorks] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CodeWorks] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CodeWorks] SET ARITHABORT OFF 
GO
ALTER DATABASE [CodeWorks] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CodeWorks] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CodeWorks] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CodeWorks] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CodeWorks] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CodeWorks] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CodeWorks] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CodeWorks] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CodeWorks] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CodeWorks] SET  DISABLE_BROKER 
GO
ALTER DATABASE [CodeWorks] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CodeWorks] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CodeWorks] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CodeWorks] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CodeWorks] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CodeWorks] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CodeWorks] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CodeWorks] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CodeWorks] SET  MULTI_USER 
GO
ALTER DATABASE [CodeWorks] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CodeWorks] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CodeWorks] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CodeWorks] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CodeWorks] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CodeWorks] SET QUERY_STORE = OFF
GO
USE [CodeWorks]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [CodeWorks]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10/06/2022 12:22:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 10/06/2022 12:22:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[Surname] [varchar](150) NOT NULL,
	[JobTitleId] [int] NOT NULL,
	[DateOfBirth] [date] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeSkill]    Script Date: 10/06/2022 12:22:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeSkill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeID] [int] NOT NULL,
	[SkillID] [int] NOT NULL,
 CONSTRAINT [PK_EmployeeSkill] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobTitle]    Script Date: 10/06/2022 12:22:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobTitle](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[JobTitle] [varchar](150) NOT NULL,
 CONSTRAINT [PK_JobTitle] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 10/06/2022 12:22:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[Startdate] [datetime] NOT NULL,
	[Enddate] [datetime] NULL,
	[Cost] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectEmployee]    Script Date: 10/06/2022 12:22:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectEmployee](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectID] [int] NOT NULL,
	[EmployeeID] [int] NOT NULL,
 CONSTRAINT [PK_ProjectEmployee] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProjectLocations]    Script Date: 10/06/2022 12:22:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectLocations](
	[Id] [int] NULL,
	[Name] [varchar](50) NULL,
	[Location] [varchar](150) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Skill]    Script Date: 10/06/2022 12:22:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skill](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](150) NOT NULL,
 CONSTRAINT [PK_Skill] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 10/06/2022 12:22:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](150) NOT NULL,
	[Surname] [varchar](150) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Role] [int] NOT NULL,
	[Active] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([id], [Name], [Surname], [JobTitleId], [DateOfBirth]) VALUES (3, N'Dani', N'Welbeck', 4, CAST(N'1900-01-01' AS Date))
INSERT [dbo].[Employee] ([id], [Name], [Surname], [JobTitleId], [DateOfBirth]) VALUES (4, N'Alexis', N'Sanchez', 2, CAST(N'1900-01-01' AS Date))
INSERT [dbo].[Employee] ([id], [Name], [Surname], [JobTitleId], [DateOfBirth]) VALUES (5, N'Mesut', N'Ozil', 1, CAST(N'1900-01-01' AS Date))
INSERT [dbo].[Employee] ([id], [Name], [Surname], [JobTitleId], [DateOfBirth]) VALUES (6, N'Musa', N'Dembele', 2, CAST(N'1900-01-01' AS Date))
INSERT [dbo].[Employee] ([id], [Name], [Surname], [JobTitleId], [DateOfBirth]) VALUES (7, N'Harry', N'Kane', 3, CAST(N'1900-01-01' AS Date))
INSERT [dbo].[Employee] ([id], [Name], [Surname], [JobTitleId], [DateOfBirth]) VALUES (8, N'David', N'Silva', 1, CAST(N'1900-01-01' AS Date))
INSERT [dbo].[Employee] ([id], [Name], [Surname], [JobTitleId], [DateOfBirth]) VALUES (9, N'Roy', N'Keane', 2, CAST(N'1900-01-01' AS Date))
INSERT [dbo].[Employee] ([id], [Name], [Surname], [JobTitleId], [DateOfBirth]) VALUES (10, N'Dele', N'Alli', 1, CAST(N'1900-01-01' AS Date))
INSERT [dbo].[Employee] ([id], [Name], [Surname], [JobTitleId], [DateOfBirth]) VALUES (11, N'Romelu', N'Lukaku', 1, CAST(N'1900-01-01' AS Date))
INSERT [dbo].[Employee] ([id], [Name], [Surname], [JobTitleId], [DateOfBirth]) VALUES (12, N'Anthony', N'Martial', 2, CAST(N'1900-01-01' AS Date))
INSERT [dbo].[Employee] ([id], [Name], [Surname], [JobTitleId], [DateOfBirth]) VALUES (1018, N'Johan', N'Potgieter', 2, CAST(N'1974-11-01' AS Date))
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[JobTitle] ON 

INSERT [dbo].[JobTitle] ([id], [JobTitle]) VALUES (1, N'Developer')
INSERT [dbo].[JobTitle] ([id], [JobTitle]) VALUES (2, N'DBA')
INSERT [dbo].[JobTitle] ([id], [JobTitle]) VALUES (3, N'Tester')
INSERT [dbo].[JobTitle] ([id], [JobTitle]) VALUES (4, N'Business Analyst')
SET IDENTITY_INSERT [dbo].[JobTitle] OFF
GO
SET IDENTITY_INSERT [dbo].[Project] ON 

INSERT [dbo].[Project] ([id], [Name], [Startdate], [Enddate], [Cost]) VALUES (1, N'Arsenal Playground', CAST(N'2017-01-01T00:00:00.000' AS DateTime), NULL, CAST(100.00 AS Decimal(18, 2)))
INSERT [dbo].[Project] ([id], [Name], [Startdate], [Enddate], [Cost]) VALUES (2, N'Aston Villa Training Facility', CAST(N'2017-04-02T00:00:00.000' AS DateTime), CAST(N'2017-05-01T00:00:00.000' AS DateTime), CAST(1200.00 AS Decimal(18, 2)))
INSERT [dbo].[Project] ([id], [Name], [Startdate], [Enddate], [Cost]) VALUES (3, N'Manchester Foundation', CAST(N'2016-04-02T00:00:00.000' AS DateTime), CAST(N'2017-01-01T00:00:00.000' AS DateTime), CAST(20000.00 AS Decimal(18, 2)))
INSERT [dbo].[Project] ([id], [Name], [Startdate], [Enddate], [Cost]) VALUES (4, N'Chelsea''s Funeral', CAST(N'2015-01-01T00:00:00.000' AS DateTime), CAST(N'2015-02-02T00:00:00.000' AS DateTime), CAST(1000.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[Project] OFF
GO
SET IDENTITY_INSERT [dbo].[ProjectEmployee] ON 

INSERT [dbo].[ProjectEmployee] ([id], [ProjectID], [EmployeeID]) VALUES (1, 1, 3)
INSERT [dbo].[ProjectEmployee] ([id], [ProjectID], [EmployeeID]) VALUES (2, 1, 4)
INSERT [dbo].[ProjectEmployee] ([id], [ProjectID], [EmployeeID]) VALUES (3, 1, 5)
INSERT [dbo].[ProjectEmployee] ([id], [ProjectID], [EmployeeID]) VALUES (4, 2, 3)
INSERT [dbo].[ProjectEmployee] ([id], [ProjectID], [EmployeeID]) VALUES (5, 2, 12)
INSERT [dbo].[ProjectEmployee] ([id], [ProjectID], [EmployeeID]) VALUES (6, 3, 12)
INSERT [dbo].[ProjectEmployee] ([id], [ProjectID], [EmployeeID]) VALUES (7, 3, 11)
INSERT [dbo].[ProjectEmployee] ([id], [ProjectID], [EmployeeID]) VALUES (8, 3, 9)
SET IDENTITY_INSERT [dbo].[ProjectEmployee] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([id], [Name], [Surname], [Username], [Password], [Role], [Active]) VALUES (7, N'David', N'Beckham', N'davidb', N'goldenballs', 1, 1)
INSERT [dbo].[User] ([id], [Name], [Surname], [Username], [Password], [Role], [Active]) VALUES (8, N'Ryan', N'Giggs', N'ryang', N'runningdownthewing', 1, 1)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Employee] ADD  CONSTRAINT [DF_Employee_DateOfBirth]  DEFAULT ('1900-01-01') FOR [DateOfBirth]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_E_JTID] FOREIGN KEY([JobTitleId])
REFERENCES [dbo].[JobTitle] ([id])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_E_JTID]
GO
ALTER TABLE [dbo].[EmployeeSkill]  WITH CHECK ADD  CONSTRAINT [FK_ES_E_EmployeeID] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([id])
GO
ALTER TABLE [dbo].[EmployeeSkill] CHECK CONSTRAINT [FK_ES_E_EmployeeID]
GO
ALTER TABLE [dbo].[EmployeeSkill]  WITH CHECK ADD  CONSTRAINT [FK_ES_S_SkillID] FOREIGN KEY([SkillID])
REFERENCES [dbo].[Skill] ([id])
GO
ALTER TABLE [dbo].[EmployeeSkill] CHECK CONSTRAINT [FK_ES_S_SkillID]
GO
ALTER TABLE [dbo].[ProjectEmployee]  WITH CHECK ADD  CONSTRAINT [FK_PE_E_EmployeeID] FOREIGN KEY([EmployeeID])
REFERENCES [dbo].[Employee] ([id])
GO
ALTER TABLE [dbo].[ProjectEmployee] CHECK CONSTRAINT [FK_PE_E_EmployeeID]
GO
ALTER TABLE [dbo].[ProjectEmployee]  WITH CHECK ADD  CONSTRAINT [FK_PE_P_ProjectID] FOREIGN KEY([ProjectID])
REFERENCES [dbo].[Project] ([id])
GO
ALTER TABLE [dbo].[ProjectEmployee] CHECK CONSTRAINT [FK_PE_P_ProjectID]
GO
USE [master]
GO
ALTER DATABASE [CodeWorks] SET  READ_WRITE 
GO
