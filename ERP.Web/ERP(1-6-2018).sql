USE [master]
GO
/****** Object:  Database [ERP]    Script Date: 01-06-2018 06:39:43 ******/
CREATE DATABASE [ERP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ERP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ERP.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'ERP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\ERP_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [ERP] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ERP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ERP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ERP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ERP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ERP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ERP] SET ARITHABORT OFF 
GO
ALTER DATABASE [ERP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ERP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ERP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ERP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ERP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ERP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ERP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ERP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ERP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ERP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ERP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ERP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ERP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ERP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ERP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ERP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ERP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ERP] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ERP] SET  MULTI_USER 
GO
ALTER DATABASE [ERP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ERP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ERP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ERP] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ERP] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ERP] SET QUERY_STORE = OFF
GO
USE [ERP]
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
USE [ERP]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 01-06-2018 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedOnUtc] [datetime2](7) NOT NULL,
	[Deleted] [bit] NOT NULL,
	[Description] [nvarchar](max) NULL,
	[DisplayOrder] [int] NOT NULL,
	[IncludeInTopMenu] [bit] NOT NULL,
	[MetaDescription] [nvarchar](max) NULL,
	[MetaKeywords] [nvarchar](400) NULL,
	[MetaTitle] [nvarchar](400) NULL,
	[Name] [nvarchar](400) NOT NULL,
	[ParentCategoryId] [int] NULL,
	[PictureId] [int] NULL,
	[Published] [bit] NOT NULL,
	[ShowOnHomePage] [bit] NOT NULL,
	[UpdatedOnUtc] [datetime2](7) NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CMSs]    Script Date: 01-06-2018 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CMSs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Content] [nvarchar](max) NOT NULL,
	[CreatedOnUtc] [datetime2](7) NOT NULL,
	[Deleted] [bit] NOT NULL,
	[DisplayOrder] [int] NOT NULL,
	[IncludeInFooter] [bit] NOT NULL,
	[IncludeInTopMenu] [bit] NOT NULL,
	[MetaDescription] [nvarchar](max) NULL,
	[MetaKeywords] [nvarchar](400) NULL,
	[MetaTitle] [nvarchar](400) NULL,
	[PageName] [nvarchar](256) NOT NULL,
	[Published] [bit] NOT NULL,
	[UpdatedOnUtc] [datetime2](7) NULL,
 CONSTRAINT [PK_CMSs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Collections]    Script Date: 01-06-2018 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Collections](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[DisplayOrder] [int] NOT NULL,
	[IncludeInTopMenu] [bit] NOT NULL,
	[MetaDescription] [nvarchar](max) NULL,
	[MetaKeywords] [nvarchar](400) NULL,
	[MetaTitle] [nvarchar](400) NULL,
	[Name] [nvarchar](400) NOT NULL,
	[PictureId] [int] NULL,
	[ShowOnHomePage] [bit] NOT NULL,
 CONSTRAINT [PK_Collections] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyConfigurations]    Script Date: 01-06-2018 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyConfigurations](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Address] [nvarchar](400) NULL,
	[ColorScheme] [nvarchar](80) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Email] [nvarchar](400) NOT NULL,
	[LogoBinary] [varbinary](max) NOT NULL,
	[MapBinary] [varbinary](max) NOT NULL,
	[MimeType] [nvarchar](40) NULL,
	[Mobile] [nvarchar](18) NULL,
	[Name] [nvarchar](256) NOT NULL,
	[OpeningHours] [nvarchar](256) NULL,
	[Phone] [nvarchar](18) NULL,
 CONSTRAINT [PK_CompanyConfigurations] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer_Wishlist_Mappings]    Script Date: 01-06-2018 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Wishlist_Mappings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_Customer_Wishlist_Mappings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 01-06-2018 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Active] [bit] NOT NULL,
	[CreatedOnUtc] [datetime2](7) NOT NULL,
	[CustomerGuid] [uniqueidentifier] NOT NULL,
	[Deleted] [bit] NOT NULL,
	[Email] [nvarchar](400) NOT NULL,
	[LastLoginDateUtc] [datetime2](7) NULL,
	[Password] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inquiry_Product_Mappings]    Script Date: 01-06-2018 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inquiry_Product_Mappings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[InquiryId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_Inquiry_Product_Mappings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inquirys]    Script Date: 01-06-2018 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inquirys](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedOnUtc] [datetime2](7) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[Deleted] [bit] NOT NULL,
	[DisplayOrder] [int] NOT NULL,
	[UpdatedOnUtc] [datetime2](7) NULL,
 CONSTRAINT [PK_Inquirys] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mst_MenuList]    Script Date: 01-06-2018 06:39:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mst_MenuList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[modulename] [varchar](50) NULL,
	[menuname] [varchar](50) NULL,
	[url] [nvarchar](max) NULL,
	[cssClassName] [varchar](50) NULL,
 CONSTRAINT [PK_Mst_MenuList_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mst_ModuleList]    Script Date: 01-06-2018 06:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mst_ModuleList](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[ModuleName] [nvarchar](50) NULL,
	[MenuName] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[URL] [nvarchar](max) NULL,
	[CssClassName] [nvarchar](500) NULL,
 CONSTRAINT [PK_Mst_ModuleList] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pictures]    Script Date: 01-06-2018 06:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pictures](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AltAttribute] [nvarchar](max) NULL,
	[IsNew] [bit] NOT NULL,
	[MimeType] [nvarchar](40) NULL,
	[PictureBinary] [varbinary](max) NOT NULL,
	[SeoFilename] [nvarchar](300) NULL,
	[TitleAttribute] [nvarchar](max) NULL,
 CONSTRAINT [PK_Pictures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product_Category_Mappings]    Script Date: 01-06-2018 06:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Category_Mappings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CategoryId] [int] NOT NULL,
	[DisplayOrder] [int] NOT NULL,
	[IsFeaturedProduct] [bit] NOT NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_Product_Category_Mappings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product_Collection_Mappings]    Script Date: 01-06-2018 06:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Collection_Mappings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CollectionId] [int] NOT NULL,
	[DisplayOrder] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_Product_Collection_Mappings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product_Metal_Mappings]    Script Date: 01-06-2018 06:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Metal_Mappings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedOnUtc] [datetime2](7) NOT NULL,
	[Deleted] [bit] NOT NULL,
	[MetalPurity] [int] NOT NULL,
	[MetalType] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
	[UpdatedOnUtc] [datetime2](7) NULL,
	[Weight] [decimal](18, 4) NOT NULL,
 CONSTRAINT [PK_Product_Metal_Mappings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product_Picture_Mappings]    Script Date: 01-06-2018 06:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Picture_Mappings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayOrder] [int] NOT NULL,
	[PictureId] [int] NOT NULL,
	[ProductId] [int] NOT NULL,
 CONSTRAINT [PK_Product_Picture_Mappings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product_ProductTag_Mappings]    Script Date: 01-06-2018 06:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_ProductTag_Mappings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProductId] [int] NOT NULL,
	[ProductTagId] [int] NOT NULL,
 CONSTRAINT [PK_Product_ProductTag_Mappings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product_Stone_Mappings]    Script Date: 01-06-2018 06:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product_Stone_Mappings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedOnUtc] [datetime2](7) NOT NULL,
	[Deleted] [bit] NOT NULL,
	[ProductId] [int] NOT NULL,
	[StoneCarat] [decimal](18, 4) NOT NULL,
	[StoneClarityId] [int] NOT NULL,
	[StoneColorId] [int] NOT NULL,
	[StoneCutId] [int] NOT NULL,
	[StonePositionId] [int] NOT NULL,
	[StoneQuantity] [int] NOT NULL,
	[StoneShapeId] [int] NOT NULL,
	[StoneTypeId] [int] NOT NULL,
	[UpdatedOnUtc] [datetime2](7) NULL,
 CONSTRAINT [PK_Product_Stone_Mappings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 01-06-2018 06:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedOnUtc] [datetime2](7) NOT NULL,
	[Deleted] [bit] NOT NULL,
	[DesignCode] [nvarchar](30) NOT NULL,
	[DisableInquiryButton] [bit] NOT NULL,
	[Discount] [decimal](18, 4) NOT NULL,
	[DiscountEndDateTimeUtc] [datetime2](7) NULL,
	[DiscountStartDateTimeUtc] [datetime2](7) NULL,
	[DiscountType] [char](1) NULL,
	[DisplayOrder] [int] NOT NULL,
	[DisplayStockAvailability] [bit] NOT NULL,
	[DisplayStockQuantity] [bit] NOT NULL,
	[FullDescription] [nvarchar](max) NULL,
	[Height] [decimal](18, 4) NOT NULL,
	[Length] [decimal](18, 4) NOT NULL,
	[MarkAsNew] [bit] NOT NULL,
	[MarkAsNewEndDateTimeUtc] [datetime2](7) NULL,
	[MarkAsNewStartDateTimeUtc] [datetime2](7) NULL,
	[MetaDescription] [nvarchar](max) NULL,
	[MetaKeywords] [nvarchar](400) NULL,
	[MetaTitle] [nvarchar](400) NULL,
	[Name] [nvarchar](400) NOT NULL,
	[Price] [decimal](18, 4) NOT NULL,
	[Published] [bit] NOT NULL,
	[ShortDescription] [nvarchar](max) NULL,
	[ShowOnHomePage] [bit] NOT NULL,
	[Sku] [nvarchar](400) NULL,
	[StockQuantity] [int] NOT NULL,
	[UpdatedOnUtc] [datetime2](7) NULL,
	[Weight] [decimal](18, 4) NOT NULL,
	[Width] [decimal](18, 4) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductTags]    Script Date: 01-06-2018 06:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductTags](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](400) NULL,
 CONSTRAINT [PK_ProductTags] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subscribers]    Script Date: 01-06-2018 06:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subscribers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](400) NOT NULL,
 CONSTRAINT [PK_Subscribers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 01-06-2018 06:39:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[Password] [varbinary](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[UserName] [nvarchar](256) NULL,
	[LastLoginDateUtc] [datetime2](7) NULL,
	[Active] [bit] NOT NULL,
	[CreatedOnUtc] [datetime2](7) NOT NULL,
	[FullName] [nvarchar](80) NULL,
	[ProfilePicBinary] [varbinary](max) NULL,
	[MimeType] [nvarchar](40) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Categories]  WITH CHECK ADD  CONSTRAINT [FK_Categories_Categories_ParentCategoryId] FOREIGN KEY([ParentCategoryId])
REFERENCES [dbo].[Categories] ([Id])
GO
ALTER TABLE [dbo].[Categories] CHECK CONSTRAINT [FK_Categories_Categories_ParentCategoryId]
GO
ALTER TABLE [dbo].[Categories]  WITH CHECK ADD  CONSTRAINT [FK_Categories_Pictures_PictureId] FOREIGN KEY([PictureId])
REFERENCES [dbo].[Pictures] ([Id])
GO
ALTER TABLE [dbo].[Categories] CHECK CONSTRAINT [FK_Categories_Pictures_PictureId]
GO
ALTER TABLE [dbo].[Collections]  WITH CHECK ADD  CONSTRAINT [FK_Collections_Pictures_PictureId] FOREIGN KEY([PictureId])
REFERENCES [dbo].[Pictures] ([Id])
GO
ALTER TABLE [dbo].[Collections] CHECK CONSTRAINT [FK_Collections_Pictures_PictureId]
GO
ALTER TABLE [dbo].[Customer_Wishlist_Mappings]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Wishlist_Mappings_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Customer_Wishlist_Mappings] CHECK CONSTRAINT [FK_Customer_Wishlist_Mappings_Customers_CustomerId]
GO
ALTER TABLE [dbo].[Customer_Wishlist_Mappings]  WITH CHECK ADD  CONSTRAINT [FK_Customer_Wishlist_Mappings_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Customer_Wishlist_Mappings] CHECK CONSTRAINT [FK_Customer_Wishlist_Mappings_Products_ProductId]
GO
ALTER TABLE [dbo].[Inquiry_Product_Mappings]  WITH CHECK ADD  CONSTRAINT [FK_Inquiry_Product_Mappings_Inquirys_InquiryId] FOREIGN KEY([InquiryId])
REFERENCES [dbo].[Inquirys] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Inquiry_Product_Mappings] CHECK CONSTRAINT [FK_Inquiry_Product_Mappings_Inquirys_InquiryId]
GO
ALTER TABLE [dbo].[Inquiry_Product_Mappings]  WITH CHECK ADD  CONSTRAINT [FK_Inquiry_Product_Mappings_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Inquiry_Product_Mappings] CHECK CONSTRAINT [FK_Inquiry_Product_Mappings_Products_ProductId]
GO
ALTER TABLE [dbo].[Inquirys]  WITH CHECK ADD  CONSTRAINT [FK_Inquirys_Customers_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Inquirys] CHECK CONSTRAINT [FK_Inquirys_Customers_CustomerId]
GO
ALTER TABLE [dbo].[Product_Category_Mappings]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category_Mappings_Categories_CategoryId] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Categories] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product_Category_Mappings] CHECK CONSTRAINT [FK_Product_Category_Mappings_Categories_CategoryId]
GO
ALTER TABLE [dbo].[Product_Category_Mappings]  WITH CHECK ADD  CONSTRAINT [FK_Product_Category_Mappings_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product_Category_Mappings] CHECK CONSTRAINT [FK_Product_Category_Mappings_Products_ProductId]
GO
ALTER TABLE [dbo].[Product_Collection_Mappings]  WITH CHECK ADD  CONSTRAINT [FK_Product_Collection_Mappings_Collections_CollectionId] FOREIGN KEY([CollectionId])
REFERENCES [dbo].[Collections] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product_Collection_Mappings] CHECK CONSTRAINT [FK_Product_Collection_Mappings_Collections_CollectionId]
GO
ALTER TABLE [dbo].[Product_Collection_Mappings]  WITH CHECK ADD  CONSTRAINT [FK_Product_Collection_Mappings_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product_Collection_Mappings] CHECK CONSTRAINT [FK_Product_Collection_Mappings_Products_ProductId]
GO
ALTER TABLE [dbo].[Product_Metal_Mappings]  WITH CHECK ADD  CONSTRAINT [FK_Product_Metal_Mappings_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product_Metal_Mappings] CHECK CONSTRAINT [FK_Product_Metal_Mappings_Products_ProductId]
GO
ALTER TABLE [dbo].[Product_Picture_Mappings]  WITH CHECK ADD  CONSTRAINT [FK_Product_Picture_Mappings_Pictures_PictureId] FOREIGN KEY([PictureId])
REFERENCES [dbo].[Pictures] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product_Picture_Mappings] CHECK CONSTRAINT [FK_Product_Picture_Mappings_Pictures_PictureId]
GO
ALTER TABLE [dbo].[Product_Picture_Mappings]  WITH CHECK ADD  CONSTRAINT [FK_Product_Picture_Mappings_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product_Picture_Mappings] CHECK CONSTRAINT [FK_Product_Picture_Mappings_Products_ProductId]
GO
ALTER TABLE [dbo].[Product_ProductTag_Mappings]  WITH CHECK ADD  CONSTRAINT [FK_Product_ProductTag_Mappings_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product_ProductTag_Mappings] CHECK CONSTRAINT [FK_Product_ProductTag_Mappings_Products_ProductId]
GO
ALTER TABLE [dbo].[Product_ProductTag_Mappings]  WITH CHECK ADD  CONSTRAINT [FK_Product_ProductTag_Mappings_ProductTags_ProductTagId] FOREIGN KEY([ProductTagId])
REFERENCES [dbo].[ProductTags] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product_ProductTag_Mappings] CHECK CONSTRAINT [FK_Product_ProductTag_Mappings_ProductTags_ProductTagId]
GO
ALTER TABLE [dbo].[Product_Stone_Mappings]  WITH CHECK ADD  CONSTRAINT [FK_Product_Stone_Mappings_Products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product_Stone_Mappings] CHECK CONSTRAINT [FK_Product_Stone_Mappings_Products_ProductId]
GO
USE [master]
GO
ALTER DATABASE [ERP] SET  READ_WRITE 
GO
