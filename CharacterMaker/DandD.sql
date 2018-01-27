--USE [master]
--GO

--/****** Object:  Database [D&D]    Script Date: 2018-01-14 14:48:02 ******/
--CREATE DATABASE [D&D]
-- CONTAINMENT = NONE
-- ON  PRIMARY 
--( NAME = N'D&D', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER1\MSSQL\DATA\D&D.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
-- LOG ON 
--( NAME = N'D&D_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER1\MSSQL\DATA\D&D_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
--GO

--ALTER DATABASE [D&D] SET COMPATIBILITY_LEVEL = 120
--GO

--IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
--begin
--EXEC [D&D].[dbo].[sp_fulltext_database] @action = 'enable'
--end
--GO

--ALTER DATABASE [D&D] SET ANSI_NULL_DEFAULT OFF 
--GO

--ALTER DATABASE [D&D] SET ANSI_NULLS OFF 
--GO

--ALTER DATABASE [D&D] SET ANSI_PADDING OFF 
--GO

--ALTER DATABASE [D&D] SET ANSI_WARNINGS OFF 
--GO

--ALTER DATABASE [D&D] SET ARITHABORT OFF 
--GO

--ALTER DATABASE [D&D] SET AUTO_CLOSE OFF 
--GO

--ALTER DATABASE [D&D] SET AUTO_SHRINK OFF 
--GO

--ALTER DATABASE [D&D] SET AUTO_UPDATE_STATISTICS ON 
--GO

--ALTER DATABASE [D&D] SET CURSOR_CLOSE_ON_COMMIT OFF 
--GO

--ALTER DATABASE [D&D] SET CURSOR_DEFAULT  GLOBAL 
--GO

--ALTER DATABASE [D&D] SET CONCAT_NULL_YIELDS_NULL OFF 
--GO

--ALTER DATABASE [D&D] SET NUMERIC_ROUNDABORT OFF 
--GO

--ALTER DATABASE [D&D] SET QUOTED_IDENTIFIER OFF 
--GO

--ALTER DATABASE [D&D] SET RECURSIVE_TRIGGERS OFF 
--GO

--ALTER DATABASE [D&D] SET  DISABLE_BROKER 
--GO

--ALTER DATABASE [D&D] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
--GO

--ALTER DATABASE [D&D] SET DATE_CORRELATION_OPTIMIZATION OFF 
--GO

--ALTER DATABASE [D&D] SET TRUSTWORTHY OFF 
--GO

--ALTER DATABASE [D&D] SET ALLOW_SNAPSHOT_ISOLATION OFF 
--GO

--ALTER DATABASE [D&D] SET PARAMETERIZATION SIMPLE 
--GO

--ALTER DATABASE [D&D] SET READ_COMMITTED_SNAPSHOT OFF 
--GO

--ALTER DATABASE [D&D] SET HONOR_BROKER_PRIORITY OFF 
--GO

--ALTER DATABASE [D&D] SET RECOVERY SIMPLE 
--GO

--ALTER DATABASE [D&D] SET  MULTI_USER 
--GO

--ALTER DATABASE [D&D] SET PAGE_VERIFY CHECKSUM  
--GO

--ALTER DATABASE [D&D] SET DB_CHAINING OFF 
--GO

--ALTER DATABASE [D&D] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
--GO

--ALTER DATABASE [D&D] SET TARGET_RECOVERY_TIME = 0 SECONDS 
--GO

--ALTER DATABASE [D&D] SET DELAYED_DURABILITY = DISABLED 
--GO

--ALTER DATABASE [D&D] SET  READ_WRITE 
--GO

USE [master]
GO
/****** Object:  Database [D&D]    Script Date: 2018-01-26 22:14:53 ******/
CREATE DATABASE [D&D]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'D&D', FILENAME = N'E:\books\D&D.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'D&D_log', FILENAME = N'E:\books\D&D_log.ldf' , SIZE = 768KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
GO
ALTER DATABASE [D&D] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [D&D].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [D&D] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [D&D] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [D&D] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [D&D] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [D&D] SET ARITHABORT OFF 
GO
ALTER DATABASE [D&D] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [D&D] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [D&D] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [D&D] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [D&D] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [D&D] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [D&D] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [D&D] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [D&D] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [D&D] SET  DISABLE_BROKER 
GO
ALTER DATABASE [D&D] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [D&D] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [D&D] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [D&D] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [D&D] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [D&D] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [D&D] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [D&D] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [D&D] SET  MULTI_USER 
GO
ALTER DATABASE [D&D] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [D&D] SET DB_CHAINING OFF 
GO
ALTER DATABASE [D&D] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [D&D] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [D&D] SET DELAYED_DURABILITY = DISABLED 
GO
USE [D&D]
GO
/****** Object:  Table [dbo].[Alignments]    Script Date: 2018-01-26 22:14:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alignments](
	[AlignmentID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Alignments] PRIMARY KEY CLUSTERED 
(
	[AlignmentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AlignmentSets]    Script Date: 2018-01-26 22:14:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AlignmentSets](
	[AlignmentID] [int] NOT NULL,
	[ClassID] [int] NOT NULL,
 CONSTRAINT [PK_AlignmentSets] PRIMARY KEY CLUSTERED 
(
	[AlignmentID] ASC,
	[ClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Classes]    Script Date: 2018-01-26 22:14:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[ClassID] [int] IDENTITY(1,1) NOT NULL,
	[HitDie] [int] NOT NULL,
	[ModifiersID] [int] NOT NULL,
	[GoldDieNumber] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Classes] PRIMARY KEY CLUSTERED 
(
	[ClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Deities]    Script Date: 2018-01-26 22:14:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Deities](
	[DeityID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Deities] PRIMARY KEY CLUSTERED 
(
	[DeityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Feats]    Script Date: 2018-01-26 22:14:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feats](
	[FeatID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ModifiersID] [int] NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[CanStack] [bit] NOT NULL,
 CONSTRAINT [PK_Feats] PRIMARY KEY CLUSTERED 
(
	[FeatID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FeatSets]    Script Date: 2018-01-26 22:14:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FeatSets](
	[FeatID] [int] NOT NULL,
	[PlayerID] [int] NOT NULL,
 CONSTRAINT [PK_FeatSets] PRIMARY KEY CLUSTERED 
(
	[FeatID] ASC,
	[PlayerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ItemCategories]    Script Date: 2018-01-26 22:14:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemCategories](
	[ItemCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ItemCategories] PRIMARY KEY CLUSTERED 
(
	[ItemCategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Items]    Script Date: 2018-01-26 22:14:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[ItemID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Cost] [int] NOT NULL,
	[ItemCategoryID] [int] NOT NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ItemSets]    Script Date: 2018-01-26 22:14:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ItemSets](
	[ItemID] [int] NOT NULL,
	[PlayerID] [int] NOT NULL,
 CONSTRAINT [PK_ItemSets] PRIMARY KEY CLUSTERED 
(
	[ItemID] ASC,
	[PlayerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ModifierSets]    Script Date: 2018-01-26 22:14:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModifierSets](
	[ModifierID] [int] IDENTITY(1,1) NOT NULL,
	[STRModifier] [int] NOT NULL,
	[DEXModifier] [int] NOT NULL,
	[CONModifier] [int] NOT NULL,
	[INTModifier] [int] NOT NULL,
	[WISModifier] [int] NOT NULL,
	[CHAModifier] [int] NOT NULL,
	[SPDModifier] [int] NOT NULL,
	[SkillPointsModifier] [int] NOT NULL,
	[BonusFeats] [int] NOT NULL,
	[BonusSkillPoints] [int] NOT NULL,
 CONSTRAINT [PK_ModifierSets] PRIMARY KEY CLUSTERED 
(
	[ModifierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Player]    Script Date: 2018-01-26 22:14:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Player](
	[PlayerID] [int] NOT NULL,
	[ClassID] [int] NOT NULL,
	[RaceID] [int] NOT NULL,
	[Gold] [int] NOT NULL,
	[DeityID] [int] NOT NULL,
	[AlignmentID] [int] NOT NULL,
	[Gender] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Player] PRIMARY KEY CLUSTERED 
(
	[PlayerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Races]    Script Date: 2018-01-26 22:14:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Races](
	[RaceID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ModifiersID] [int] NOT NULL,
	[Speed] [int] NOT NULL,
	[Size] [nvarchar](50) NOT NULL,
	[PreferredClassID] [int] NULL,
 CONSTRAINT [PK_Races] PRIMARY KEY CLUSTERED 
(
	[RaceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SkillClassSets]    Script Date: 2018-01-26 22:14:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SkillClassSets](
	[SkillID] [int] NOT NULL,
	[ClassID] [int] NOT NULL,
 CONSTRAINT [PK_SkillSets] PRIMARY KEY CLUSTERED 
(
	[SkillID] ASC,
	[ClassID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SkillPlayerSets]    Script Date: 2018-01-26 22:14:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SkillPlayerSets](
	[SkillID] [int] NOT NULL,
	[PlayerID] [int] NOT NULL,
 CONSTRAINT [PK_SkillPlayerSets] PRIMARY KEY CLUSTERED 
(
	[SkillID] ASC,
	[PlayerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Skills]    Script Date: 2018-01-26 22:14:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Skills](
	[SkillID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[KeyAbility] [nchar](3) NOT NULL,
 CONSTRAINT [PK_Skills] PRIMARY KEY CLUSTERED 
(
	[SkillID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Alignments] ON 

INSERT [dbo].[Alignments] ([AlignmentID], [Name]) VALUES (1, N'Lawful Good')
INSERT [dbo].[Alignments] ([AlignmentID], [Name]) VALUES (2, N'Lawful Neutral')
INSERT [dbo].[Alignments] ([AlignmentID], [Name]) VALUES (3, N'Lawful Evil')
INSERT [dbo].[Alignments] ([AlignmentID], [Name]) VALUES (4, N'Neutral Good')
INSERT [dbo].[Alignments] ([AlignmentID], [Name]) VALUES (5, N'True Neutral')
INSERT [dbo].[Alignments] ([AlignmentID], [Name]) VALUES (6, N'Neutral Evil')
INSERT [dbo].[Alignments] ([AlignmentID], [Name]) VALUES (7, N'Chaotic Good')
INSERT [dbo].[Alignments] ([AlignmentID], [Name]) VALUES (8, N'Chaotic Neutral')
INSERT [dbo].[Alignments] ([AlignmentID], [Name]) VALUES (9, N'Chotic Evil')
SET IDENTITY_INSERT [dbo].[Alignments] OFF
SET IDENTITY_INSERT [dbo].[Classes] ON 

INSERT [dbo].[Classes] ([ClassID], [HitDie], [ModifiersID], [GoldDieNumber], [Name]) VALUES (2, 10, 4, 6, N'Fighter')
INSERT [dbo].[Classes] ([ClassID], [HitDie], [ModifiersID], [GoldDieNumber], [Name]) VALUES (3, 6, 6, 5, N'Rogue')
SET IDENTITY_INSERT [dbo].[Classes] OFF
SET IDENTITY_INSERT [dbo].[Deities] ON 

INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (1, N'Boccob')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (2, N'Corellon Larethian')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (3, N'Ehlonna')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (4, N'Erythnul')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (5, N'Gruumsh')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (6, N'Neironeous')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (7, N'Erythnul')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (8, N'Kord')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (9, N'Hextor')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (10, N'Fharlanghn')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (11, N'Garl Glittergold')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (12, N'Moradin')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (13, N'Nerull')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (14, N'Obad-Hai')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (15, N'St. Cuthbert')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (16, N'Vecna')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (17, N'Olidammara')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (18, N'Wee Jas')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (19, N'Yondalla')
INSERT [dbo].[Deities] ([DeityID], [Name]) VALUES (20, N'Pelor')
SET IDENTITY_INSERT [dbo].[Deities] OFF
SET IDENTITY_INSERT [dbo].[Feats] ON 

INSERT [dbo].[Feats] ([FeatID], [Name], [ModifiersID], [Description], [CanStack]) VALUES (4, N'Acrobatic', 7, N'+2 bonus on Jump and Tumble checks', 0)
INSERT [dbo].[Feats] ([FeatID], [Name], [ModifiersID], [Description], [CanStack]) VALUES (5, N'Endurance', 7, N'+4 bonus on checks or saves to resist nonlethal damage', 0)
INSERT [dbo].[Feats] ([FeatID], [Name], [ModifiersID], [Description], [CanStack]) VALUES (6, N'Improved Unarmed Strik', 7, N'Considered armed even if unarmed', 0)
INSERT [dbo].[Feats] ([FeatID], [Name], [ModifiersID], [Description], [CanStack]) VALUES (7, N'Toughness', 7, N'+3 hit points', 1)
SET IDENTITY_INSERT [dbo].[Feats] OFF
SET IDENTITY_INSERT [dbo].[ModifierSets] ON 

INSERT [dbo].[ModifierSets] ([ModifierID], [STRModifier], [DEXModifier], [CONModifier], [INTModifier], [WISModifier], [CHAModifier], [SPDModifier], [SkillPointsModifier], [BonusFeats], [BonusSkillPoints]) VALUES (1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 4)
INSERT [dbo].[ModifierSets] ([ModifierID], [STRModifier], [DEXModifier], [CONModifier], [INTModifier], [WISModifier], [CHAModifier], [SPDModifier], [SkillPointsModifier], [BonusFeats], [BonusSkillPoints]) VALUES (2, 0, 0, 2, 0, 0, -2, 0, 0, 0, 0)
INSERT [dbo].[ModifierSets] ([ModifierID], [STRModifier], [DEXModifier], [CONModifier], [INTModifier], [WISModifier], [CHAModifier], [SPDModifier], [SkillPointsModifier], [BonusFeats], [BonusSkillPoints]) VALUES (4, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0)
INSERT [dbo].[ModifierSets] ([ModifierID], [STRModifier], [DEXModifier], [CONModifier], [INTModifier], [WISModifier], [CHAModifier], [SPDModifier], [SkillPointsModifier], [BonusFeats], [BonusSkillPoints]) VALUES (5, -2, 2, 0, 0, 0, 0, 0, 0, 0, 0)
INSERT [dbo].[ModifierSets] ([ModifierID], [STRModifier], [DEXModifier], [CONModifier], [INTModifier], [WISModifier], [CHAModifier], [SPDModifier], [SkillPointsModifier], [BonusFeats], [BonusSkillPoints]) VALUES (6, 0, 0, 0, 0, 0, 0, 0, 8, 0, 0)
INSERT [dbo].[ModifierSets] ([ModifierID], [STRModifier], [DEXModifier], [CONModifier], [INTModifier], [WISModifier], [CHAModifier], [SPDModifier], [SkillPointsModifier], [BonusFeats], [BonusSkillPoints]) VALUES (7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0)
SET IDENTITY_INSERT [dbo].[ModifierSets] OFF
SET IDENTITY_INSERT [dbo].[Races] ON 

INSERT [dbo].[Races] ([RaceID], [Name], [ModifiersID], [Speed], [Size], [PreferredClassID]) VALUES (2, N'Human', 1, 30, N'Medium', NULL)
INSERT [dbo].[Races] ([RaceID], [Name], [ModifiersID], [Speed], [Size], [PreferredClassID]) VALUES (4, N'Halfling', 5, 20, N'Small', 3)
SET IDENTITY_INSERT [dbo].[Races] OFF
SET IDENTITY_INSERT [dbo].[Skills] ON 

INSERT [dbo].[Skills] ([SkillID], [Name], [KeyAbility]) VALUES (1, N'Climb', N'STR')
INSERT [dbo].[Skills] ([SkillID], [Name], [KeyAbility]) VALUES (2, N'Jump', N'STR')
INSERT [dbo].[Skills] ([SkillID], [Name], [KeyAbility]) VALUES (3, N'Ride', N'DEX')
INSERT [dbo].[Skills] ([SkillID], [Name], [KeyAbility]) VALUES (4, N'Swim', N'STR')
INSERT [dbo].[Skills] ([SkillID], [Name], [KeyAbility]) VALUES (5, N'Intimidate', N'CHA')
INSERT [dbo].[Skills] ([SkillID], [Name], [KeyAbility]) VALUES (6, N'Craft', N'INT')
INSERT [dbo].[Skills] ([SkillID], [Name], [KeyAbility]) VALUES (7, N'Handle Animal', N'CHA')
INSERT [dbo].[Skills] ([SkillID], [Name], [KeyAbility]) VALUES (8, N'Listen', N'WIS')
INSERT [dbo].[Skills] ([SkillID], [Name], [KeyAbility]) VALUES (9, N'Search', N'INT')
INSERT [dbo].[Skills] ([SkillID], [Name], [KeyAbility]) VALUES (11, N'Spot', N'WIS')
SET IDENTITY_INSERT [dbo].[Skills] OFF
ALTER TABLE [dbo].[AlignmentSets]  WITH CHECK ADD  CONSTRAINT [FK_AlignmentSets_Alignments] FOREIGN KEY([AlignmentID])
REFERENCES [dbo].[Alignments] ([AlignmentID])
GO
ALTER TABLE [dbo].[AlignmentSets] CHECK CONSTRAINT [FK_AlignmentSets_Alignments]
GO
ALTER TABLE [dbo].[AlignmentSets]  WITH CHECK ADD  CONSTRAINT [FK_AlignmentSets_Classes] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Classes] ([ClassID])
GO
ALTER TABLE [dbo].[AlignmentSets] CHECK CONSTRAINT [FK_AlignmentSets_Classes]
GO
ALTER TABLE [dbo].[Classes]  WITH CHECK ADD  CONSTRAINT [FK_Classes_ModifierSets] FOREIGN KEY([ModifiersID])
REFERENCES [dbo].[ModifierSets] ([ModifierID])
GO
ALTER TABLE [dbo].[Classes] CHECK CONSTRAINT [FK_Classes_ModifierSets]
GO
ALTER TABLE [dbo].[Feats]  WITH CHECK ADD  CONSTRAINT [FK_Feats_ModifierSets] FOREIGN KEY([ModifiersID])
REFERENCES [dbo].[ModifierSets] ([ModifierID])
GO
ALTER TABLE [dbo].[Feats] CHECK CONSTRAINT [FK_Feats_ModifierSets]
GO
ALTER TABLE [dbo].[FeatSets]  WITH CHECK ADD  CONSTRAINT [FK_FeatSets_Feats] FOREIGN KEY([FeatID])
REFERENCES [dbo].[Feats] ([FeatID])
GO
ALTER TABLE [dbo].[FeatSets] CHECK CONSTRAINT [FK_FeatSets_Feats]
GO
ALTER TABLE [dbo].[FeatSets]  WITH CHECK ADD  CONSTRAINT [FK_FeatSets_Player] FOREIGN KEY([PlayerID])
REFERENCES [dbo].[Player] ([PlayerID])
GO
ALTER TABLE [dbo].[FeatSets] CHECK CONSTRAINT [FK_FeatSets_Player]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_ItemCategories] FOREIGN KEY([ItemCategoryID])
REFERENCES [dbo].[ItemCategories] ([ItemCategoryID])
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_ItemCategories]
GO
ALTER TABLE [dbo].[ItemSets]  WITH CHECK ADD  CONSTRAINT [FK_ItemSets_Items] FOREIGN KEY([ItemID])
REFERENCES [dbo].[Items] ([ItemID])
GO
ALTER TABLE [dbo].[ItemSets] CHECK CONSTRAINT [FK_ItemSets_Items]
GO
ALTER TABLE [dbo].[ItemSets]  WITH CHECK ADD  CONSTRAINT [FK_ItemSets_Player] FOREIGN KEY([PlayerID])
REFERENCES [dbo].[Player] ([PlayerID])
GO
ALTER TABLE [dbo].[ItemSets] CHECK CONSTRAINT [FK_ItemSets_Player]
GO
ALTER TABLE [dbo].[Player]  WITH CHECK ADD  CONSTRAINT [FK_Player_Alignments] FOREIGN KEY([AlignmentID])
REFERENCES [dbo].[Alignments] ([AlignmentID])
GO
ALTER TABLE [dbo].[Player] CHECK CONSTRAINT [FK_Player_Alignments]
GO
ALTER TABLE [dbo].[Player]  WITH CHECK ADD  CONSTRAINT [FK_Player_Classes] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Classes] ([ClassID])
GO
ALTER TABLE [dbo].[Player] CHECK CONSTRAINT [FK_Player_Classes]
GO
ALTER TABLE [dbo].[Player]  WITH CHECK ADD  CONSTRAINT [FK_Player_Deities] FOREIGN KEY([DeityID])
REFERENCES [dbo].[Deities] ([DeityID])
GO
ALTER TABLE [dbo].[Player] CHECK CONSTRAINT [FK_Player_Deities]
GO
ALTER TABLE [dbo].[Player]  WITH CHECK ADD  CONSTRAINT [FK_Player_Races] FOREIGN KEY([RaceID])
REFERENCES [dbo].[Races] ([RaceID])
GO
ALTER TABLE [dbo].[Player] CHECK CONSTRAINT [FK_Player_Races]
GO
ALTER TABLE [dbo].[Races]  WITH CHECK ADD  CONSTRAINT [FK_Races_Classes] FOREIGN KEY([PreferredClassID])
REFERENCES [dbo].[Classes] ([ClassID])
GO
ALTER TABLE [dbo].[Races] CHECK CONSTRAINT [FK_Races_Classes]
GO
ALTER TABLE [dbo].[Races]  WITH CHECK ADD  CONSTRAINT [FK_Races_ModifierSets] FOREIGN KEY([ModifiersID])
REFERENCES [dbo].[ModifierSets] ([ModifierID])
GO
ALTER TABLE [dbo].[Races] CHECK CONSTRAINT [FK_Races_ModifierSets]
GO
ALTER TABLE [dbo].[SkillClassSets]  WITH CHECK ADD  CONSTRAINT [FK_SkillSets_Classes] FOREIGN KEY([ClassID])
REFERENCES [dbo].[Classes] ([ClassID])
GO
ALTER TABLE [dbo].[SkillClassSets] CHECK CONSTRAINT [FK_SkillSets_Classes]
GO
ALTER TABLE [dbo].[SkillClassSets]  WITH CHECK ADD  CONSTRAINT [FK_SkillSets_Skills] FOREIGN KEY([SkillID])
REFERENCES [dbo].[Skills] ([SkillID])
GO
ALTER TABLE [dbo].[SkillClassSets] CHECK CONSTRAINT [FK_SkillSets_Skills]
GO
ALTER TABLE [dbo].[SkillPlayerSets]  WITH CHECK ADD  CONSTRAINT [FK_SkillPlayerSets_Player] FOREIGN KEY([PlayerID])
REFERENCES [dbo].[Player] ([PlayerID])
GO
ALTER TABLE [dbo].[SkillPlayerSets] CHECK CONSTRAINT [FK_SkillPlayerSets_Player]
GO
ALTER TABLE [dbo].[SkillPlayerSets]  WITH CHECK ADD  CONSTRAINT [FK_SkillPlayerSets_Skills] FOREIGN KEY([SkillID])
REFERENCES [dbo].[Skills] ([SkillID])
GO
ALTER TABLE [dbo].[SkillPlayerSets] CHECK CONSTRAINT [FK_SkillPlayerSets_Skills]
GO
USE [master]
GO
ALTER DATABASE [D&D] SET  READ_WRITE 
GO
