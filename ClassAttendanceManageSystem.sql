﻿USE [master]
GO
/****** Object:  Database [ClassAttendanceManageSystem]    Script Date: 06/26/2020 12:44:18 ******/
CREATE DATABASE [ClassAttendanceManageSystem] ON  PRIMARY 
( NAME = N'ClassAttendance', FILENAME = N'C:\SQL Server\Program\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\ClassAttendance.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ClassAttendance_log', FILENAME = N'C:\SQL Server\Program\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\ClassAttendance_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ClassAttendanceManageSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET ANSI_NULLS OFF
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET ANSI_PADDING OFF
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET ARITHABORT OFF
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET  DISABLE_BROKER
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET  READ_WRITE
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET RECOVERY FULL
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET  MULTI_USER
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [ClassAttendanceManageSystem] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'ClassAttendanceManageSystem', N'ON'
GO
USE [ClassAttendanceManageSystem]
GO
/****** Object:  Table [dbo].[teacherInfo]    Script Date: 06/26/2020 12:44:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[teacherInfo](
	[teacherID] [nchar](20) NOT NULL,
	[teacherName] [nchar](10) NULL,
	[teacherSex] [nchar](2) NULL,
	[courseID] [nchar](20) NOT NULL,
	[teacherPassword] [nchar](20) NULL,
 CONSTRAINT [PK_teacherInfo] PRIMARY KEY CLUSTERED 
(
	[teacherID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[teacherInfo] ([teacherID], [teacherName], [teacherSex], [courseID], [teacherPassword]) VALUES (N'0021                ', N'李远        ', N'男 ', N'001                 ', N'123                 ')
INSERT [dbo].[teacherInfo] ([teacherID], [teacherName], [teacherSex], [courseID], [teacherPassword]) VALUES (N'0022                ', N'张丽        ', N'女 ', N'002                 ', N'123                 ')
INSERT [dbo].[teacherInfo] ([teacherID], [teacherName], [teacherSex], [courseID], [teacherPassword]) VALUES (N'0023                ', N'王晓晓       ', N'女 ', N'003                 ', N'1                   ')
/****** Object:  Table [dbo].[studentInfo]    Script Date: 06/26/2020 12:44:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[studentInfo](
	[stuID] [nchar](20) NOT NULL,
	[stuName] [nchar](10) NULL,
	[stuSex] [nchar](2) NULL,
	[classID] [nchar](20) NULL,
	[className] [nchar](20) NULL,
	[cardID] [nchar](20) NOT NULL,
	[courseID] [nchar](20) NULL,
	[stuPassword] [nchar](20) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_studentInfo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[studentInfo] ON
INSERT [dbo].[studentInfo] ([stuID], [stuName], [stuSex], [classID], [className], [cardID], [courseID], [stuPassword], [id]) VALUES (N'201700210131        ', N'张亮      ', N'男 ', N'0021                ', N'17物联网工程             ', N'D34B7402            ', N'003                 ', N'123                 ', 15)
INSERT [dbo].[studentInfo] ([stuID], [stuName], [stuSex], [classID], [className], [cardID], [courseID], [stuPassword], [id]) VALUES (N'201700210131        ', N'张亮       ', N'男 ', N'0021                ', N'17物联网工程             ', N'D34B7402            ', N'002                 ', N'123                 ', 16)
INSERT [dbo].[studentInfo] ([stuID], [stuName], [stuSex], [classID], [className], [cardID], [courseID], [stuPassword], [id]) VALUES (N'201700210132        ', N'陈思        ', N'女 ', N'0021                ', N'17物联网工程             ', N'097C95A3            ', N'001                 ', N'123                 ', 17)
INSERT [dbo].[studentInfo] ([stuID], [stuName], [stuSex], [classID], [className], [cardID], [courseID], [stuPassword], [id]) VALUES (N'201700210131        ', N'张亮        ', N'男 ', N'0021                ', N'17物联网工程             ', N'D34B7402            ', N'001                 ', N'123                 ', 18)
SET IDENTITY_INSERT [dbo].[studentInfo] OFF
/****** Object:  Table [dbo].[courseInfo]    Script Date: 06/26/2020 12:44:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[courseInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[courseID] [nchar](20) NOT NULL,
	[couseName] [nchar](20) NULL,
	[courseTime] [nchar](20) NULL,
	[classRoom] [nchar](10) NULL,
	[courseNote] [nchar](30) NULL,
 CONSTRAINT [PK_courseInfo_1] PRIMARY KEY CLUSTERED 
(
	[courseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[courseInfo] ON
INSERT [dbo].[courseInfo] ([id], [courseID], [couseName], [courseTime], [classRoom], [courseNote]) VALUES (20, N'001                 ', N'RFID原理与应用           ', N'周四6-8节              ', N's201      ', N'无                             ')
INSERT [dbo].[courseInfo] ([id], [courseID], [couseName], [courseTime], [classRoom], [courseNote]) VALUES (21, N'002                 ', N'Java2应用教程           ', N'周三1-3节              ', N's202      ', N'无                             ')
INSERT [dbo].[courseInfo] ([id], [courseID], [couseName], [courseTime], [classRoom], [courseNote]) VALUES (22, N'003                 ', N'C#程序设计教程            ', N'周一3-5节              ', N's201      ', N'无                             ')
SET IDENTITY_INSERT [dbo].[courseInfo] OFF
/****** Object:  Table [dbo].[attendenceInfo]    Script Date: 06/26/2020 12:44:18 ******/
SET ANSI_NULLS ON 
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[attendenceInfo](
	[recordID] [int] IDENTITY(1,1) NOT FOR REPLICATION NOT NULL,
	[cardID] [nchar](20) NOT NULL,
	[time] [datetime] NULL,
	[flag] [nchar](10) NULL,
	[courseID] [nchar](20) NULL,
 CONSTRAINT [PK_attendenceInfo] PRIMARY KEY CLUSTERED 
(
	[recordID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[attendenceInfo] ON
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (82, N'97C95A31            ', CAST(0x0000ABD60120B2A4 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (83, N'97C95A31            ', CAST(0x0000ABD6012245C4 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (84, N'97C95A31            ', CAST(0x0000ABD6012246F0 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (85, N'97C95A31            ', CAST(0x0000ABD6012246F0 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (86, N'97C95A31            ', CAST(0x0000ABD601224948 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (87, N'97C95A31            ', CAST(0x0000ABD60133B7C8 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (88, N'97C95A31            ', CAST(0x0000ABD60133B7C8 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (89, N'97C95A31            ', CAST(0x0000ABD60133B8F4 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (90, N'97C95A31            ', CAST(0x0000ABD60133BA20 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (91, N'97C95A31            ', CAST(0x0000ABD60133BA20 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (92, N'97C95A31            ', CAST(0x0000ABD60133BB4C AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (93, N'97C95A31            ', CAST(0x0000ABD60133BB4C AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (94, N'97C95A31            ', CAST(0x0000ABD60133BC78 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (95, N'97C95A31            ', CAST(0x0000ABD60133BC78 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (96, N'97C95A31            ', CAST(0x0000ABD60133BDA4 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (97, N'97C95A31            ', CAST(0x0000ABD60133BDA4 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (98, N'97C95A31            ', CAST(0x0000ABD60135D1AC AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (99, N'97C95A31            ', CAST(0x0000ABD60135D2D8 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (100, N'97C95A31            ', CAST(0x0000ABD60135D2D8 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (101, N'97C95A31            ', CAST(0x0000ABD60135D404 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (102, N'97C95A31            ', CAST(0x0000ABD60135D530 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (103, N'97C95A31            ', CAST(0x0000ABD60135D530 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (104, N'97C95A31            ', CAST(0x0000ABD60135D65C AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (105, N'97C95A31            ', CAST(0x0000ABD60135D65C AS DateTime), N'未签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (106, N'97C95A31            ', CAST(0x0000ABD800C2A9FC AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (107, N'97C95A31            ', CAST(0x0000ABD800C2AC54 AS DateTime), N'未签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (108, N'097C95A3            ', CAST(0x0000ABD800C37710 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (109, N'D34B7402            ', CAST(0x0000ABD800C3B2D4 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (110, N'D34B7402            ', CAST(0x0000ABD800C3B2D4 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (111, N'097C95A3            ', CAST(0x0000ABD800C3B658 AS DateTime), N'未签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (112, N'097C95A3            ', CAST(0x0000ABD800C3B784 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (113, N'097C95A3            ', CAST(0x0000ABD800C3B784 AS DateTime), N'未签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (114, N'097C95A3            ', CAST(0x0000ABD800C3B8B0 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (115, N'D34B7402            ', CAST(0x0000ABDB01427E98 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (116, N'D34B7402            ', CAST(0x0000ABDB01427FC4 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (117, N'D34B7402            ', CAST(0x0000ABDB01428A50 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (118, N'D34B7402            ', CAST(0x0000ABE300A2A008 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (119, N'D34B7402            ', CAST(0x0000ABE300A2A5E4 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (120, N'33342A43            ', CAST(0x0000ABE300A2AA94 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (121, N'097C95A3            ', CAST(0x0000ABE300A2B070 AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (122, N'D34B7402            ', CAST(0x0000ABE300A2B64C AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (123, N'D34B7402            ', CAST(0x0000ABE300AC326C AS DateTime), N'已签        ', N'001                 ')
INSERT [dbo].[attendenceInfo] ([recordID], [cardID], [time], [flag], [courseID]) VALUES (124, N'097C95A3            ', CAST(0x0000ABE300AC3AA0 AS DateTime), N'已签        ', N'001                 ')
SET IDENTITY_INSERT [dbo].[attendenceInfo] OFF
/****** Object:  Table [dbo].[adminInfo]    Script Date: 06/26/2020 12:44:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[adminInfo](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[adminID] [nchar](10) NOT NULL,
	[adminPassword] [nchar](10) NULL,
	[adminName] [nchar](10) NULL,
	[adminSex] [nchar](4) NULL,
 CONSTRAINT [PK_adminInfo] PRIMARY KEY CLUSTERED 
(
	[adminID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[adminInfo] ON
INSERT [dbo].[adminInfo] ([id], [adminID], [adminPassword], [adminName], [adminSex]) VALUES (1, N'001       ', N'001       ', N'admin     ', N'男   ')
INSERT [dbo].[adminInfo] ([id], [adminID], [adminPassword], [adminName], [adminSex]) VALUES (2, N'002       ', N'002       ', N'root      ', N'男   ')
SET IDENTITY_INSERT [dbo].[adminInfo] OFF
