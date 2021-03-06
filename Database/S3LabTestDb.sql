USE [master]
GO
/****** Object:  Database [S3LabTestDB]    Script Date: 08-Sep-17 10:07:18 AM ******/
CREATE DATABASE [S3LabTestDB] 
GO
USE [S3LabTestDB]
GO
/****** Object:  Table [dbo].[tblLanguages]    Script Date: 08-Sep-17 10:07:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblLanguages](
	[colLanguageId] [int] NOT NULL,
	[colLanguageName] [varchar](50) NOT NULL,
	[colLanguageShortName] [varchar](10) NOT NULL,
 CONSTRAINT [PK_tblLanguages] PRIMARY KEY CLUSTERED 
(
	[colLanguageId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblLevels]    Script Date: 08-Sep-17 10:07:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblLevels](
	[colLevelId] [int] NOT NULL,
	[colLevelName] [varchar](50) NOT NULL,
	[colLevelShortName] [varchar](20) NOT NULL,
	[colLevelDescription] [varchar](200) NULL,
	[colTradeId] [int] NOT NULL,
 CONSTRAINT [PK_tblLevels] PRIMARY KEY CLUSTERED 
(
	[colLevelId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblSyllabus]    Script Date: 08-Sep-17 10:07:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblSyllabus](
	[colSyllabusId] [int] IDENTITY(1,1) NOT NULL,
	[colSyllabusName] [varchar](50) NOT NULL,
	[colTradeId] [int] NOT NULL,
	[colLevelId] [int] NOT NULL,
	[colSyllabusDocUrl] [varchar](200) NOT NULL,
	[colTestPlanUrl] [varchar](200) NOT NULL,
	[colDevelopmentOfficer] [varchar](100) NOT NULL,
	[colManager] [varchar](100) NOT NULL,
	[colUploadBy] [int] NOT NULL,
	[colUploadDt] [datetime] NOT NULL,
	[colActiveDt] [datetime] NOT NULL,
	[colSt] [bit] NOT NULL,
 CONSTRAINT [PK_tblSyllabus] PRIMARY KEY CLUSTERED 
(
	[colSyllabusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tblSyllabusLanguages]    Script Date: 08-Sep-17 10:07:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSyllabusLanguages](
	[colSyllabusId] [int] NOT NULL,
	[colLanguageId] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tblTrades]    Script Date: 08-Sep-17 10:07:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tblTrades](
	[colTradeId] [int] NOT NULL,
	[colTradeCode] [varchar](50) NULL,
	[colTradeName] [varchar](200) NOT NULL,
	[colAbbreviation] [varchar](50) NOT NULL,
	[colSt] [bit] NOT NULL,
 CONSTRAINT [PK_tblTrades] PRIMARY KEY CLUSTERED 
(
	[colTradeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[tblLanguages] ([colLanguageId], [colLanguageName], [colLanguageShortName]) VALUES (1, N'English', N'EN')
INSERT [dbo].[tblLanguages] ([colLanguageId], [colLanguageName], [colLanguageShortName]) VALUES (2, N'Chinese', N'CH')
INSERT [dbo].[tblLanguages] ([colLanguageId], [colLanguageName], [colLanguageShortName]) VALUES (3, N'Thai', N'TH')
INSERT [dbo].[tblLanguages] ([colLanguageId], [colLanguageName], [colLanguageShortName]) VALUES (4, N'Tamil', N'TA')
INSERT [dbo].[tblLanguages] ([colLanguageId], [colLanguageName], [colLanguageShortName]) VALUES (5, N'Korean', N'KR')
INSERT [dbo].[tblLevels] ([colLevelId], [colLevelName], [colLevelShortName], [colLevelDescription], [colTradeId]) VALUES (1, N'SEC(K)', N'SEC(K)', NULL, 1)
INSERT [dbo].[tblLevels] ([colLevelId], [colLevelName], [colLevelShortName], [colLevelDescription], [colTradeId]) VALUES (2, N'SATF', N'SATF', N'', 1)
SET IDENTITY_INSERT [dbo].[tblSyllabus] ON 

INSERT [dbo].[tblSyllabus] ([colSyllabusId], [colSyllabusName], [colTradeId], [colLevelId], [colSyllabusDocUrl], [colTestPlanUrl], [colDevelopmentOfficer], [colManager], [colUploadBy], [colUploadDt], [colActiveDt], [colSt]) VALUES (13, N'Test Syllabus', 1, 1, N'Instruction_1807277529.docx', N'S_78949919.pdf', N'S.M. Rizwanr Rahman', N'Touhid', 1, CAST(0x0000A7D900000000 AS DateTime), CAST(0x0000A7D900000000 AS DateTime), 0)
INSERT [dbo].[tblSyllabus] ([colSyllabusId], [colSyllabusName], [colTradeId], [colLevelId], [colSyllabusDocUrl], [colTestPlanUrl], [colDevelopmentOfficer], [colManager], [colUploadBy], [colUploadDt], [colActiveDt], [colSt]) VALUES (14, N'2nd Test Syllabus', 2, 2, N'Instruction_1808531872.docx', N'Rizwan_CV_850732190.pdf', N'Rizwan', N'Mr. Touhid', 1, CAST(0x0000A7D900000000 AS DateTime), CAST(0x0000A7D900000000 AS DateTime), 1)
INSERT [dbo].[tblSyllabus] ([colSyllabusId], [colSyllabusName], [colTradeId], [colLevelId], [colSyllabusDocUrl], [colTestPlanUrl], [colDevelopmentOfficer], [colManager], [colUploadBy], [colUploadDt], [colActiveDt], [colSt]) VALUES (15, N'3rd Test', 1, 1, N'Is-wb-gs-gh_v3_823027901.png', N'Is-wb-gs-gh_v3_823027901.png', N'S.M. Rumi', N'Rahman', 1, CAST(0x0000A7D900000000 AS DateTime), CAST(0x0000A7E000000000 AS DateTime), 0)
SET IDENTITY_INSERT [dbo].[tblSyllabus] OFF
INSERT [dbo].[tblSyllabusLanguages] ([colSyllabusId], [colLanguageId]) VALUES (0, 1)
INSERT [dbo].[tblSyllabusLanguages] ([colSyllabusId], [colLanguageId]) VALUES (0, 2)
INSERT [dbo].[tblSyllabusLanguages] ([colSyllabusId], [colLanguageId]) VALUES (0, 4)
INSERT [dbo].[tblSyllabusLanguages] ([colSyllabusId], [colLanguageId]) VALUES (13, 1)
INSERT [dbo].[tblSyllabusLanguages] ([colSyllabusId], [colLanguageId]) VALUES (13, 2)
INSERT [dbo].[tblSyllabusLanguages] ([colSyllabusId], [colLanguageId]) VALUES (14, 1)
INSERT [dbo].[tblSyllabusLanguages] ([colSyllabusId], [colLanguageId]) VALUES (14, 2)
INSERT [dbo].[tblSyllabusLanguages] ([colSyllabusId], [colLanguageId]) VALUES (14, 3)
INSERT [dbo].[tblSyllabusLanguages] ([colSyllabusId], [colLanguageId]) VALUES (15, 5)
INSERT [dbo].[tblSyllabusLanguages] ([colSyllabusId], [colLanguageId]) VALUES (15, 2)
INSERT [dbo].[tblSyllabusLanguages] ([colSyllabusId], [colLanguageId]) VALUES (15, 3)
INSERT [dbo].[tblSyllabusLanguages] ([colSyllabusId], [colLanguageId]) VALUES (15, 4)
INSERT [dbo].[tblSyllabusLanguages] ([colSyllabusId], [colLanguageId]) VALUES (13, 3)
INSERT [dbo].[tblTrades] ([colTradeId], [colTradeCode], [colTradeName], [colAbbreviation], [colSt]) VALUES (1, N'0001', N'Timber Formwork Installation', N'TFI', 1)
INSERT [dbo].[tblTrades] ([colTradeId], [colTradeCode], [colTradeName], [colAbbreviation], [colSt]) VALUES (2, N'0002', N'Tower Crane Operation (Luffing Jib)', N'TCO (LJ)', 1)
USE [master]
GO
ALTER DATABASE [S3LabTestDB] SET  READ_WRITE 
GO
