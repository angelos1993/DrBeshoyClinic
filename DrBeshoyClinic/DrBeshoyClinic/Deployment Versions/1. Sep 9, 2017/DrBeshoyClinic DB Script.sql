USE [master]
GO
/****** Object:  Database [DrBeshoyClinic]    Script Date: 9/9/2017 6:06:02 PM ******/
CREATE DATABASE [DrBeshoyClinic]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DrBeshoyClinic', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\DrBeshoyClinic.mdf' , SIZE = 18432KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DrBeshoyClinic_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\DrBeshoyClinic_log.ldf' , SIZE = 7616KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DrBeshoyClinic] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DrBeshoyClinic].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DrBeshoyClinic] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET ARITHABORT OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [DrBeshoyClinic] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DrBeshoyClinic] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DrBeshoyClinic] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DrBeshoyClinic] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DrBeshoyClinic] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET RECOVERY FULL 
GO
ALTER DATABASE [DrBeshoyClinic] SET  MULTI_USER 
GO
ALTER DATABASE [DrBeshoyClinic] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DrBeshoyClinic] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DrBeshoyClinic] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DrBeshoyClinic] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'DrBeshoyClinic', N'ON'
GO
USE [DrBeshoyClinic]
GO
/****** Object:  Table [dbo].[ChronicDiseases]    Script Date: 9/9/2017 6:06:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChronicDiseases](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_ChronicDiseases] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Complaints]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Complaints](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Date] [date] NOT NULL,
	[PatientId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Complaints] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Diagnosis]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diagnosis](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Date] [date] NOT NULL,
	[PatientId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Diagnosis] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DrugHx]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DrugHx](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
	[Date] [date] NOT NULL,
	[PatientId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DrugHx] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EmgNcv]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmgNcv](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Emg] [nvarchar](200) NOT NULL,
	[Ncv] [nvarchar](200) NOT NULL,
	[Date] [date] NOT NULL,
	[PatientId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EmgNcv] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ExaminationChronicDisease]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExaminationChronicDisease](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ExaminationId] [int] NOT NULL,
	[ChronicDiseaseId] [int] NOT NULL,
	[Notes] [nvarchar](max) NULL,
 CONSTRAINT [PK_ExaminationChronicDisease] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Examinations]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examinations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ExaminationOfExamination] [nvarchar](max) NOT NULL,
	[Date] [datetime] NOT NULL,
	[ExaminationType] [bit] NOT NULL,
	[PatientId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Examinations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FamilyHx]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FamilyHx](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[Date] [date] NOT NULL,
	[PatientId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_FamilyHx] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LabTests]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LabTests](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TestName] [nvarchar](200) NOT NULL,
	[TestResult] [nvarchar](200) NOT NULL,
	[Date] [date] NOT NULL,
	[PatientId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LabTests] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MedicineDetails]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicineDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MedicineId] [int] NOT NULL,
	[TreatmentId] [int] NOT NULL,
	[TreatmentPeriodId] [int] NOT NULL,
	[TreatmentDescriptionId] [int] NOT NULL,
 CONSTRAINT [PK_MedicineDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Medicines]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medicines](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NOT NULL,
	[PatientId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Medicines] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Operations]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PatientId] [nvarchar](50) NOT NULL,
	[Date] [date] NOT NULL,
	[OperativeDetails] [nvarchar](max) NOT NULL,
	[FuturePlan] [nvarchar](max) NOT NULL,
	[Approach] [nvarchar](max) NOT NULL,
	[Anesthesiologist] [nvarchar](200) NOT NULL,
	[Anesthesia] [nvarchar](200) NOT NULL,
	[Position] [nvarchar](200) NOT NULL,
	[Antibiotic] [nvarchar](200) NOT NULL,
	[BloodLoss] [nvarchar](200) NOT NULL,
	[ImplantUsed] [nvarchar](200) NOT NULL,
	[ImplantCompany] [nvarchar](200) NOT NULL,
	[Nurse] [nvarchar](200) NOT NULL,
	[Assisstant1] [nvarchar](200) NOT NULL,
	[Assisstant2] [nvarchar](200) NOT NULL,
	[Surgion] [nvarchar](200) NOT NULL,
	[Notes] [nvarchar](max) NOT NULL,
	[IsCultureAndSensitivity] [bit] NOT NULL,
	[IsBiopsy] [bit] NOT NULL,
	[Start] [decimal](18, 0) NOT NULL,
	[End] [decimal](18, 0) NOT NULL,
	[Pressure] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Operations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patients]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[Id] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Address] [nvarchar](200) NULL,
	[Phone] [nvarchar](15) NULL,
	[Job] [nvarchar](50) NULL,
	[BirthDate] [date] NULL,
	[Gender] [bit] NOT NULL,
 CONSTRAINT [PK_Patients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Photos]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Photos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Photo] [varbinary](max) NOT NULL,
	[Date] [date] NOT NULL,
	[PatientId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Photos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PostOperativeInstructions]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostOperativeInstructions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
	[OperationId] [int] NOT NULL,
 CONSTRAINT [PK_PostOperativeInstructions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PostOperativeTreatments]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PostOperativeTreatments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
	[OperationId] [int] NOT NULL,
 CONSTRAINT [PK_PostOperativeTreatment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Radiologies]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Radiologies](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
	[Date] [date] NOT NULL,
	[PatientId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Radiologies] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SurgicalHx]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SurgicalHx](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
	[Date] [date] NOT NULL,
	[PatientId] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SurgicalHx] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TreatmentDescriptions]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TreatmentDescriptions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_TreatmentDescriptions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TreatmentPeriods]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TreatmentPeriods](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_TreatmentPeriods] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Treatments]    Script Date: 9/9/2017 6:06:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Treatments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_Treatments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Complaints]  WITH CHECK ADD  CONSTRAINT [FK_Complaints_Patients] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[Complaints] CHECK CONSTRAINT [FK_Complaints_Patients]
GO
ALTER TABLE [dbo].[Diagnosis]  WITH CHECK ADD  CONSTRAINT [FK_Diagnosis_Patients] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[Diagnosis] CHECK CONSTRAINT [FK_Diagnosis_Patients]
GO
ALTER TABLE [dbo].[DrugHx]  WITH CHECK ADD  CONSTRAINT [FK_DrugHx_Patients] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[DrugHx] CHECK CONSTRAINT [FK_DrugHx_Patients]
GO
ALTER TABLE [dbo].[EmgNcv]  WITH CHECK ADD  CONSTRAINT [FK_EmgNcv_Patients] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[EmgNcv] CHECK CONSTRAINT [FK_EmgNcv_Patients]
GO
ALTER TABLE [dbo].[ExaminationChronicDisease]  WITH CHECK ADD  CONSTRAINT [FK_ExaminationChronicDisease_ChronicDiseases] FOREIGN KEY([ChronicDiseaseId])
REFERENCES [dbo].[ChronicDiseases] ([Id])
GO
ALTER TABLE [dbo].[ExaminationChronicDisease] CHECK CONSTRAINT [FK_ExaminationChronicDisease_ChronicDiseases]
GO
ALTER TABLE [dbo].[ExaminationChronicDisease]  WITH CHECK ADD  CONSTRAINT [FK_ExaminationChronicDisease_Examinations] FOREIGN KEY([ExaminationId])
REFERENCES [dbo].[Examinations] ([Id])
GO
ALTER TABLE [dbo].[ExaminationChronicDisease] CHECK CONSTRAINT [FK_ExaminationChronicDisease_Examinations]
GO
ALTER TABLE [dbo].[Examinations]  WITH CHECK ADD  CONSTRAINT [FK_Examinations_Patients] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[Examinations] CHECK CONSTRAINT [FK_Examinations_Patients]
GO
ALTER TABLE [dbo].[FamilyHx]  WITH CHECK ADD  CONSTRAINT [FK_FamilyHx_Patients] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[FamilyHx] CHECK CONSTRAINT [FK_FamilyHx_Patients]
GO
ALTER TABLE [dbo].[LabTests]  WITH CHECK ADD  CONSTRAINT [FK_LabTests_Patients] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[LabTests] CHECK CONSTRAINT [FK_LabTests_Patients]
GO
ALTER TABLE [dbo].[MedicineDetails]  WITH CHECK ADD  CONSTRAINT [FK_MedicineDetails_Medicines] FOREIGN KEY([MedicineId])
REFERENCES [dbo].[Medicines] ([Id])
GO
ALTER TABLE [dbo].[MedicineDetails] CHECK CONSTRAINT [FK_MedicineDetails_Medicines]
GO
ALTER TABLE [dbo].[MedicineDetails]  WITH CHECK ADD  CONSTRAINT [FK_MedicineDetails_TreatmentDescriptions] FOREIGN KEY([TreatmentDescriptionId])
REFERENCES [dbo].[TreatmentDescriptions] ([Id])
GO
ALTER TABLE [dbo].[MedicineDetails] CHECK CONSTRAINT [FK_MedicineDetails_TreatmentDescriptions]
GO
ALTER TABLE [dbo].[MedicineDetails]  WITH CHECK ADD  CONSTRAINT [FK_MedicineDetails_TreatmentPeriods] FOREIGN KEY([TreatmentPeriodId])
REFERENCES [dbo].[TreatmentPeriods] ([Id])
GO
ALTER TABLE [dbo].[MedicineDetails] CHECK CONSTRAINT [FK_MedicineDetails_TreatmentPeriods]
GO
ALTER TABLE [dbo].[MedicineDetails]  WITH CHECK ADD  CONSTRAINT [FK_MedicineDetails_Treatments] FOREIGN KEY([TreatmentId])
REFERENCES [dbo].[Treatments] ([Id])
GO
ALTER TABLE [dbo].[MedicineDetails] CHECK CONSTRAINT [FK_MedicineDetails_Treatments]
GO
ALTER TABLE [dbo].[Medicines]  WITH CHECK ADD  CONSTRAINT [FK_Medicines_Patients] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[Medicines] CHECK CONSTRAINT [FK_Medicines_Patients]
GO
ALTER TABLE [dbo].[Operations]  WITH CHECK ADD  CONSTRAINT [FK_Operations_Patients] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[Operations] CHECK CONSTRAINT [FK_Operations_Patients]
GO
ALTER TABLE [dbo].[Photos]  WITH CHECK ADD  CONSTRAINT [FK_Photos_Patients] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[Photos] CHECK CONSTRAINT [FK_Photos_Patients]
GO
ALTER TABLE [dbo].[PostOperativeInstructions]  WITH CHECK ADD  CONSTRAINT [FK_PostOperativeInstructions_Operations] FOREIGN KEY([OperationId])
REFERENCES [dbo].[Operations] ([Id])
GO
ALTER TABLE [dbo].[PostOperativeInstructions] CHECK CONSTRAINT [FK_PostOperativeInstructions_Operations]
GO
ALTER TABLE [dbo].[PostOperativeTreatments]  WITH CHECK ADD  CONSTRAINT [FK_PostOperativeTreatment_Operations] FOREIGN KEY([OperationId])
REFERENCES [dbo].[Operations] ([Id])
GO
ALTER TABLE [dbo].[PostOperativeTreatments] CHECK CONSTRAINT [FK_PostOperativeTreatment_Operations]
GO
ALTER TABLE [dbo].[Radiologies]  WITH CHECK ADD  CONSTRAINT [FK_Radiologies_Patients] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[Radiologies] CHECK CONSTRAINT [FK_Radiologies_Patients]
GO
ALTER TABLE [dbo].[SurgicalHx]  WITH CHECK ADD  CONSTRAINT [FK_SurgicalHx_Patients] FOREIGN KEY([PatientId])
REFERENCES [dbo].[Patients] ([Id])
GO
ALTER TABLE [dbo].[SurgicalHx] CHECK CONSTRAINT [FK_SurgicalHx_Patients]
GO
USE [master]
GO
ALTER DATABASE [DrBeshoyClinic] SET  READ_WRITE 
GO
