USE [master]
GO
/****** Object:  Database [JAMAIAHSALAFIYAH_HOUSTON]    Script Date: 10/16/2017 12:57:38 AM ******/
CREATE DATABASE [JAMAIAHSALAFIYAH_HOUSTON]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JAMAIAHSALAFIYAH_HOUSTON', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\JAMAIAHSALAFIYAH_HOUSTON.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'JAMAIAHSALAFIYAH_HOUSTON_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\JAMAIAHSALAFIYAH_HOUSTON_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JAMAIAHSALAFIYAH_HOUSTON].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET ARITHABORT OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET  DISABLE_BROKER 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET  MULTI_USER 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [JAMAIAHSALAFIYAH_HOUSTON]
GO
/****** Object:  Table [dbo].[BoardExamination]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BoardExamination](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ExminationName] [nvarchar](max) NULL,
 CONSTRAINT [PK_BoardExamination] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Company]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Company](
	[CompanyKey] [uniqueidentifier] NOT NULL,
	[CompanyID] [nvarchar](max) NULL,
	[CompanyName] [nvarchar](max) NULL,
	[CompanyAddress] [nvarchar](max) NULL,
	[CompanyPhone] [nvarchar](max) NULL,
	[CompanyMobile] [nvarchar](max) NULL,
	[CompanyEmail] [nvarchar](max) NULL,
	[CompanyWebsite] [nvarchar](max) NULL,
	[CompanyFax] [nvarchar](max) NULL,
	[ContactPersonName] [nvarchar](max) NULL,
	[ContactPersonNo] [nvarchar](max) NULL,
	[Logo] [image] NULL,
	[LogoType] [varchar](max) NULL,
	[IsDelete] [bit] NULL,
	[StateCode] [int] NULL,
	[CityKey] [int] NULL,
	[ZIPKey] [bigint] NULL,
	[Title] [nvarchar](max) NULL,
	[ContactEmail] [nvarchar](max) NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[CompanyKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CompanyForm]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyForm](
	[CompanyFormKey] [uniqueidentifier] NOT NULL,
	[FormKey] [uniqueidentifier] NULL,
	[CompanyKey] [uniqueidentifier] NULL,
	[ModuleKey] [uniqueidentifier] NULL,
 CONSTRAINT [PK_CompanyForm] PRIMARY KEY CLUSTERED 
(
	[CompanyFormKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CompanyModule]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyModule](
	[CompanyModuleID] [uniqueidentifier] NOT NULL,
	[CompanyKey] [uniqueidentifier] NULL,
	[ModuleKey] [uniqueidentifier] NULL,
 CONSTRAINT [PK_CompanyModule] PRIMARY KEY CLUSTERED 
(
	[CompanyModuleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Department]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Category_FK] [int] NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Forms]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Forms](
	[FormID] [uniqueidentifier] NOT NULL,
	[ModuleID] [uniqueidentifier] NOT NULL,
	[FormName] [nvarchar](max) NULL,
	[FormLevel] [int] NULL,
	[FormController] [nvarchar](max) NULL,
	[FormView] [nvarchar](max) NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK_Forms] PRIMARY KEY CLUSTERED 
(
	[FormID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Gender]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gender](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GenderName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Gender] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ImageFile]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ImageFile](
	[ImageFileKey] [int] IDENTITY(1,1) NOT NULL,
	[FileName] [varchar](max) NULL,
	[FileType] [varchar](max) NULL,
	[FileContent] [image] NULL,
 CONSTRAINT [PK_ImageFile] PRIMARY KEY CLUSTERED 
(
	[ImageFileKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Modules]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modules](
	[ModuleID] [uniqueidentifier] NOT NULL,
	[ModuleName] [nvarchar](max) NULL,
	[ModuleLevel] [int] NULL,
	[NoSub] [bit] NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK_Modules] PRIMARY KEY CLUSTERED 
(
	[ModuleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MonthlyTutionFee]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MonthlyTutionFee](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SessionYearId] [int] NULL,
	[DepartmentId] [int] NULL,
	[SessionMonthId] [int] NULL,
	[ResidentTypeId] [int] NULL,
	[TutionFeeTypeId] [int] NULL,
	[Amount] [int] NULL,
 CONSTRAINT [PK_MonthlyTutionFee] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ResidentType]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResidentType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ResidentType] [nvarchar](max) NULL,
 CONSTRAINT [PK_ResidentType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SessionMonth]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SessionMonth](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Month] [nvarchar](max) NULL,
 CONSTRAINT [PK_SessionMonth] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SessionYear]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SessionYear](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_SessionYear] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StaffList]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StaffList](
	[PersonnelKey] [uniqueidentifier] NOT NULL,
	[PID] [nvarchar](max) NULL,
	[PName] [nvarchar](max) NULL,
	[Mobile] [nvarchar](max) NULL,
	[Mail] [nvarchar](max) NULL,
	[Designation] [nvarchar](max) NULL,
	[Department] [nvarchar](max) NULL,
	[Pic] [image] NULL,
	[PicType] [nvarchar](max) NULL,
	[CompanyKey] [uniqueidentifier] NULL,
	[Usergr] [uniqueidentifier] NULL,
	[Username] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[IsUser] [bit] NULL,
	[IsDelete] [bit] NULL,
 CONSTRAINT [PK_StaffList] PRIMARY KEY CLUSTERED 
(
	[PersonnelKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentAssigned]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentAssigned](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentInfo_FK] [int] NULL,
	[Department_FK] [int] NULL,
	[ResidentType_FK] [int] NULL,
 CONSTRAINT [PK_StudentAssigned] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentAttachFile]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentAttachFile](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Student_FK] [int] NULL,
	[FileType] [nvarchar](max) NULL,
	[FileContent] [image] NULL,
	[FileName] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
 CONSTRAINT [PK_StudentAttachFile] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentInfo]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentPhoto] [image] NULL,
	[StudentNameBangla] [nvarchar](max) NULL,
	[StudentNameEnglish] [nvarchar](max) NULL,
	[StudentNameArabic] [nvarchar](max) NULL,
	[StudentDateOfBirth] [datetime] NULL,
	[GenderId] [int] NULL,
	[Nationality] [nvarchar](max) NULL,
	[FatherNameBangla] [nvarchar](max) NULL,
	[FatherNameEnglish] [nvarchar](max) NULL,
	[FatherIsAlive] [bit] NULL,
	[FatherOccupation] [nvarchar](max) NULL,
	[FatherMobile] [nvarchar](max) NULL,
	[MotherNameBangla] [nvarchar](max) NULL,
	[MotherNameEnglish] [nvarchar](max) NULL,
	[MotherIsAlive] [bit] NULL,
	[MotherMobile] [nvarchar](max) NULL,
	[GuardianName] [nvarchar](max) NULL,
	[GuardianOccupation] [nvarchar](max) NULL,
	[GuardianHouseNo] [nvarchar](max) NULL,
	[GuardianVillage] [nvarchar](max) NULL,
	[GuardianPostOffice] [nvarchar](max) NULL,
	[GuardianThana] [nvarchar](max) NULL,
	[GuardianDistrict] [nvarchar](max) NULL,
	[RelationWithGuardian] [nvarchar](max) NULL,
	[YearlyIncomeGuardian] [int] NULL,
	[PermanentAddressHouse] [nvarchar](max) NULL,
	[PermanentAddressVillage] [nvarchar](max) NULL,
	[PermanentAddressPostOffice] [nvarchar](max) NULL,
	[PermanentAddressThana] [nvarchar](max) NULL,
	[PermanentAddressDistrict] [nvarchar](max) NULL,
	[HonarablePersonNameInArea] [nvarchar](max) NULL,
	[PreviousInstitutionName] [nvarchar](max) NULL,
	[PreviousInstitutionAddress] [nvarchar](max) NULL,
	[PreviousInstitutionClass] [nvarchar](max) NULL,
	[PreviousInstitutionClearanceNo] [nvarchar](max) NULL,
	[PreviousInstitutionClearanceDate] [datetime] NULL,
	[AdmittedDepartmentId] [int] NULL,
 CONSTRAINT [PK_StudentInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[StudentInfoPreviousInstitution]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentInfoPreviousInstitution](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentInfo_FK] [int] NULL,
	[ExamName] [nvarchar](max) NULL,
	[ExamYear] [nvarchar](max) NULL,
	[InstitutionName] [nvarchar](max) NULL,
	[InstitutionCode] [nvarchar](max) NULL,
	[InstitutionDistrict] [nvarchar](max) NULL,
	[RegiNo] [nvarchar](max) NULL,
	[RollNo] [nvarchar](max) NULL,
	[Grade] [nvarchar](max) NULL,
 CONSTRAINT [PK_StudentInfoPreviousInstitution] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Subject]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DepartmentId] [int] NULL,
	[SubjectName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TutionFeeType]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TutionFeeType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TutionFeeType] [nvarchar](max) NULL,
 CONSTRAINT [PK_TutionFeeType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usergroup]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usergroup](
	[UserGroupKey] [uniqueidentifier] NOT NULL,
	[GroupID] [nvarchar](max) NULL,
	[GroupName] [nvarchar](max) NULL,
	[CompanyKey] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Usergroup] PRIMARY KEY CLUSTERED 
(
	[UserGroupKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserGroupForm]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGroupForm](
	[UserGroupFormKey] [uniqueidentifier] NOT NULL,
	[UserGroupKey] [uniqueidentifier] NULL,
	[CompanyKey] [uniqueidentifier] NULL,
	[ModuleKey] [uniqueidentifier] NULL,
	[FormKey] [uniqueidentifier] NULL,
 CONSTRAINT [PK_UserGroupForm] PRIMARY KEY CLUSTERED 
(
	[UserGroupFormKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserGroupModule]    Script Date: 10/16/2017 12:57:38 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserGroupModule](
	[UserGroupModuleKey] [uniqueidentifier] NOT NULL,
	[UserGroupKey] [uniqueidentifier] NULL,
	[CompanyKey] [uniqueidentifier] NULL,
	[ModuleKey] [uniqueidentifier] NULL,
 CONSTRAINT [PK_UserGroupModule] PRIMARY KEY CLUSTERED 
(
	[UserGroupModuleKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CompanyForm]  WITH CHECK ADD  CONSTRAINT [FK_CompanyForm_Company] FOREIGN KEY([CompanyKey])
REFERENCES [dbo].[Company] ([CompanyKey])
GO
ALTER TABLE [dbo].[CompanyForm] CHECK CONSTRAINT [FK_CompanyForm_Company]
GO
ALTER TABLE [dbo].[CompanyForm]  WITH CHECK ADD  CONSTRAINT [FK_CompanyForm_Forms] FOREIGN KEY([FormKey])
REFERENCES [dbo].[Forms] ([FormID])
GO
ALTER TABLE [dbo].[CompanyForm] CHECK CONSTRAINT [FK_CompanyForm_Forms]
GO
ALTER TABLE [dbo].[CompanyForm]  WITH CHECK ADD  CONSTRAINT [FK_CompanyForm_Modules] FOREIGN KEY([ModuleKey])
REFERENCES [dbo].[Modules] ([ModuleID])
GO
ALTER TABLE [dbo].[CompanyForm] CHECK CONSTRAINT [FK_CompanyForm_Modules]
GO
ALTER TABLE [dbo].[CompanyModule]  WITH CHECK ADD  CONSTRAINT [FK_CompanyModule_Company] FOREIGN KEY([CompanyKey])
REFERENCES [dbo].[Company] ([CompanyKey])
GO
ALTER TABLE [dbo].[CompanyModule] CHECK CONSTRAINT [FK_CompanyModule_Company]
GO
ALTER TABLE [dbo].[CompanyModule]  WITH CHECK ADD  CONSTRAINT [FK_CompanyModule_Modules] FOREIGN KEY([ModuleKey])
REFERENCES [dbo].[Modules] ([ModuleID])
GO
ALTER TABLE [dbo].[CompanyModule] CHECK CONSTRAINT [FK_CompanyModule_Modules]
GO
ALTER TABLE [dbo].[Department]  WITH CHECK ADD  CONSTRAINT [FK_Department_Category] FOREIGN KEY([Category_FK])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Department] CHECK CONSTRAINT [FK_Department_Category]
GO
ALTER TABLE [dbo].[Forms]  WITH CHECK ADD  CONSTRAINT [FK_Forms_Modules] FOREIGN KEY([ModuleID])
REFERENCES [dbo].[Modules] ([ModuleID])
GO
ALTER TABLE [dbo].[Forms] CHECK CONSTRAINT [FK_Forms_Modules]
GO
ALTER TABLE [dbo].[MonthlyTutionFee]  WITH CHECK ADD  CONSTRAINT [FK_MonthlyTutionFee_Department] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[MonthlyTutionFee] CHECK CONSTRAINT [FK_MonthlyTutionFee_Department]
GO
ALTER TABLE [dbo].[MonthlyTutionFee]  WITH CHECK ADD  CONSTRAINT [FK_MonthlyTutionFee_ResidentType] FOREIGN KEY([ResidentTypeId])
REFERENCES [dbo].[ResidentType] ([Id])
GO
ALTER TABLE [dbo].[MonthlyTutionFee] CHECK CONSTRAINT [FK_MonthlyTutionFee_ResidentType]
GO
ALTER TABLE [dbo].[MonthlyTutionFee]  WITH CHECK ADD  CONSTRAINT [FK_MonthlyTutionFee_SessionMonth] FOREIGN KEY([SessionMonthId])
REFERENCES [dbo].[SessionMonth] ([Id])
GO
ALTER TABLE [dbo].[MonthlyTutionFee] CHECK CONSTRAINT [FK_MonthlyTutionFee_SessionMonth]
GO
ALTER TABLE [dbo].[MonthlyTutionFee]  WITH CHECK ADD  CONSTRAINT [FK_MonthlyTutionFee_SessionYear] FOREIGN KEY([SessionYearId])
REFERENCES [dbo].[SessionYear] ([Id])
GO
ALTER TABLE [dbo].[MonthlyTutionFee] CHECK CONSTRAINT [FK_MonthlyTutionFee_SessionYear]
GO
ALTER TABLE [dbo].[MonthlyTutionFee]  WITH CHECK ADD  CONSTRAINT [FK_MonthlyTutionFee_TutionFeeType] FOREIGN KEY([TutionFeeTypeId])
REFERENCES [dbo].[TutionFeeType] ([Id])
GO
ALTER TABLE [dbo].[MonthlyTutionFee] CHECK CONSTRAINT [FK_MonthlyTutionFee_TutionFeeType]
GO
ALTER TABLE [dbo].[StaffList]  WITH CHECK ADD  CONSTRAINT [FK_StaffList_Usergroup] FOREIGN KEY([Usergr])
REFERENCES [dbo].[Usergroup] ([UserGroupKey])
GO
ALTER TABLE [dbo].[StaffList] CHECK CONSTRAINT [FK_StaffList_Usergroup]
GO
ALTER TABLE [dbo].[StudentAssigned]  WITH CHECK ADD  CONSTRAINT [FK_StudentAssigned_Department] FOREIGN KEY([Department_FK])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[StudentAssigned] CHECK CONSTRAINT [FK_StudentAssigned_Department]
GO
ALTER TABLE [dbo].[StudentAssigned]  WITH CHECK ADD  CONSTRAINT [FK_StudentAssigned_ResidentType] FOREIGN KEY([ResidentType_FK])
REFERENCES [dbo].[ResidentType] ([Id])
GO
ALTER TABLE [dbo].[StudentAssigned] CHECK CONSTRAINT [FK_StudentAssigned_ResidentType]
GO
ALTER TABLE [dbo].[StudentAssigned]  WITH CHECK ADD  CONSTRAINT [FK_StudentAssigned_StudentInfo] FOREIGN KEY([StudentInfo_FK])
REFERENCES [dbo].[StudentInfo] ([Id])
GO
ALTER TABLE [dbo].[StudentAssigned] CHECK CONSTRAINT [FK_StudentAssigned_StudentInfo]
GO
ALTER TABLE [dbo].[StudentAttachFile]  WITH CHECK ADD  CONSTRAINT [FK_StudentAttachFile_StudentInfo] FOREIGN KEY([Student_FK])
REFERENCES [dbo].[StudentInfo] ([Id])
GO
ALTER TABLE [dbo].[StudentAttachFile] CHECK CONSTRAINT [FK_StudentAttachFile_StudentInfo]
GO
ALTER TABLE [dbo].[StudentInfo]  WITH CHECK ADD  CONSTRAINT [FK_StudentInfo_Department] FOREIGN KEY([AdmittedDepartmentId])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[StudentInfo] CHECK CONSTRAINT [FK_StudentInfo_Department]
GO
ALTER TABLE [dbo].[StudentInfo]  WITH CHECK ADD  CONSTRAINT [FK_StudentInfo_Gender] FOREIGN KEY([GenderId])
REFERENCES [dbo].[Gender] ([Id])
GO
ALTER TABLE [dbo].[StudentInfo] CHECK CONSTRAINT [FK_StudentInfo_Gender]
GO
ALTER TABLE [dbo].[StudentInfoPreviousInstitution]  WITH CHECK ADD  CONSTRAINT [FK_StudentInfoPreviousInstitution_StudentInfo] FOREIGN KEY([StudentInfo_FK])
REFERENCES [dbo].[StudentInfo] ([Id])
GO
ALTER TABLE [dbo].[StudentInfoPreviousInstitution] CHECK CONSTRAINT [FK_StudentInfoPreviousInstitution_StudentInfo]
GO
ALTER TABLE [dbo].[Subject]  WITH CHECK ADD  CONSTRAINT [FK_Subject_Department] FOREIGN KEY([DepartmentId])
REFERENCES [dbo].[Department] ([Id])
GO
ALTER TABLE [dbo].[Subject] CHECK CONSTRAINT [FK_Subject_Department]
GO
ALTER TABLE [dbo].[Usergroup]  WITH CHECK ADD  CONSTRAINT [FK_Usergroup_Company] FOREIGN KEY([CompanyKey])
REFERENCES [dbo].[Company] ([CompanyKey])
GO
ALTER TABLE [dbo].[Usergroup] CHECK CONSTRAINT [FK_Usergroup_Company]
GO
ALTER TABLE [dbo].[UserGroupForm]  WITH CHECK ADD  CONSTRAINT [FK_UserGroupForm_Forms] FOREIGN KEY([FormKey])
REFERENCES [dbo].[Forms] ([FormID])
GO
ALTER TABLE [dbo].[UserGroupForm] CHECK CONSTRAINT [FK_UserGroupForm_Forms]
GO
ALTER TABLE [dbo].[UserGroupForm]  WITH CHECK ADD  CONSTRAINT [FK_UserGroupForm_Modules] FOREIGN KEY([ModuleKey])
REFERENCES [dbo].[Modules] ([ModuleID])
GO
ALTER TABLE [dbo].[UserGroupForm] CHECK CONSTRAINT [FK_UserGroupForm_Modules]
GO
ALTER TABLE [dbo].[UserGroupForm]  WITH CHECK ADD  CONSTRAINT [FK_UserGroupForm_Usergroup] FOREIGN KEY([UserGroupKey])
REFERENCES [dbo].[Usergroup] ([UserGroupKey])
GO
ALTER TABLE [dbo].[UserGroupForm] CHECK CONSTRAINT [FK_UserGroupForm_Usergroup]
GO
ALTER TABLE [dbo].[UserGroupModule]  WITH CHECK ADD  CONSTRAINT [FK_UserGroupModule_Modules] FOREIGN KEY([ModuleKey])
REFERENCES [dbo].[Modules] ([ModuleID])
GO
ALTER TABLE [dbo].[UserGroupModule] CHECK CONSTRAINT [FK_UserGroupModule_Modules]
GO
ALTER TABLE [dbo].[UserGroupModule]  WITH CHECK ADD  CONSTRAINT [FK_UserGroupModule_Usergroup] FOREIGN KEY([UserGroupKey])
REFERENCES [dbo].[Usergroup] ([UserGroupKey])
GO
ALTER TABLE [dbo].[UserGroupModule] CHECK CONSTRAINT [FK_UserGroupModule_Usergroup]
GO
USE [master]
GO
ALTER DATABASE [JAMAIAHSALAFIYAH_HOUSTON] SET  READ_WRITE 
GO
