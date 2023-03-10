USE [master]
GO
/****** Object:  Database [ES104]    Script Date: 12/31/2022 7:50:22 PM ******/
CREATE DATABASE [ES104]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ES104', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ES104.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ES104_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\ES104_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ES104] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ES104].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ES104] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ES104] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ES104] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ES104] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ES104] SET ARITHABORT OFF 
GO
ALTER DATABASE [ES104] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [ES104] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ES104] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ES104] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ES104] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ES104] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ES104] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ES104] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ES104] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ES104] SET  ENABLE_BROKER 
GO
ALTER DATABASE [ES104] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ES104] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ES104] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ES104] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ES104] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ES104] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ES104] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ES104] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ES104] SET  MULTI_USER 
GO
ALTER DATABASE [ES104] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ES104] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ES104] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ES104] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ES104] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ES104] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ES104] SET QUERY_STORE = OFF
GO
USE [ES104]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 12/31/2022 7:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[IdCompany] [int] NOT NULL,
	[CompanyName] [varchar](100) NULL,
	[Address] [varchar](100) NULL,
	[ContactPhone] [varchar](20) NULL,
	[EmailAddress] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCompany] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Company_Detail]    Script Date: 12/31/2022 7:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company_Detail](
	[IdCompany] [int] NULL,
	[PID] [int] NULL,
	[AMOUNT] [int] NULL,
	[Done] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/31/2022 7:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] NOT NULL,
	[CustomerName] [varchar](40) NULL,
	[Gender] [varchar](10) NULL,
	[Address] [varchar](50) NULL,
	[ContactPhone] [varchar](20) NULL,
	[Totalmoney] [float] NULL,
	[VIP] [bit] NULL,
	[visible] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory_Report]    Script Date: 12/31/2022 7:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory_Report](
	[Month] [int] NOT NULL,
	[Year] [int] NOT NULL,
	[PID] [int] NOT NULL,
	[FirstInventory] [int] NULL,
	[QuantityPurchased] [int] NULL,
	[QuantitySold] [int] NULL,
	[LastInventory] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Month] ASC,
	[Year] ASC,
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parameter]    Script Date: 12/31/2022 7:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parameter](
	[ParameterName] [varchar](50) NOT NULL,
	[Value] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ParameterName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/31/2022 7:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[PID] [int] NOT NULL,
	[ProductName] [varchar](100) NULL,
	[PTypeID] [int] NOT NULL,
	[AMOUNT] [int] NULL,
	[PurchaseUnitPrice] [float] NULL,
	[SellUnitPrice] [float] NULL,
	[Picture] [text] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PType]    Script Date: 12/31/2022 7:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PType](
	[PTypeID] [int] NOT NULL,
	[PTypeName] [varchar](100) NULL,
	[UnitID] [int] NOT NULL,
	[ProfitPercentage] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[PTypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesSlip]    Script Date: 12/31/2022 7:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesSlip](
	[SalesSlipID] [int] NOT NULL,
	[SalesSlipDate] [smalldatetime] NULL,
	[CustomerID] [int] NOT NULL,
	[StaffID] [int] NOT NULL,
	[Total] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[SalesSlipID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesSlip_Detail]    Script Date: 12/31/2022 7:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesSlip_Detail](
	[SalesSlipID] [int] NOT NULL,
	[PID] [int] NOT NULL,
	[AMOUNT] [int] NULL,
	[SellUnitPrice] [float] NULL,
	[TAX] [int] NULL,
	[Discount] [int] NULL,
	[Total] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[SalesSlipID] ASC,
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 12/31/2022 7:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[S_ID] [int] NOT NULL,
	[ServiceType] [varchar](40) NULL,
	[Picture] [text] NOT NULL,
	[ServiceUnitPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[S_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceVoucher]    Script Date: 12/31/2022 7:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceVoucher](
	[S_VoucherID] [int] NOT NULL,
	[S_VoucherDate] [smalldatetime] NULL,
	[CustomerID] [int] NOT NULL,
	[StaffID] [int] NOT NULL,
	[Total] [float] NULL,
	[TotalPrepayment] [float] NULL,
	[TotalRemainingMoney] [float] NULL,
	[Status] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[S_VoucherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ServiceVoucher_Detail]    Script Date: 12/31/2022 7:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServiceVoucher_Detail](
	[S_VoucherID] [int] NOT NULL,
	[S_ID] [int] NOT NULL,
	[PID] [int] NULL,
	[OtherCosts] [float] NULL,
	[EstimatedUnitPrice] [float] NULL,
	[AMOUNT] [int] NULL,
	[SubTotal] [float] NULL,
	[AdvanceDeposit] [float] NULL,
	[Remaining] [float] NULL,
	[EstimatedRepairDate] [smalldatetime] NULL,
	[ItemDescription] [varchar](100) NULL,
	[Remarks] [varchar](100) NULL,
	[Status] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[S_VoucherID] ASC,
	[S_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 12/31/2022 7:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[StaffID] [int] NOT NULL,
	[StaffName] [varchar](40) NULL,
	[Gender] [varchar](10) NULL,
	[ContactPhone] [varchar](20) NULL,
	[EmailAddress] [varchar](50) NULL,
	[Manager] [bit] NULL,
	[Shift] [int] NULL,
	[visible] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[StaffID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 12/31/2022 7:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[UnitID] [int] NOT NULL,
	[UnitName] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[UnitID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[users]    Script Date: 12/31/2022 7:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[UserID] [int] NOT NULL,
	[UserName] [varchar](200) NOT NULL,
	[DisplayName] [varchar](200) NOT NULL,
	[Gender] [varchar](10) NOT NULL,
	[Contact] [varchar](50) NOT NULL,
	[Address] [varchar](100) NULL,
	[Email] [varchar](200) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[Type] [bit] NOT NULL,
	[profile_pic] [text] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Voucher]    Script Date: 12/31/2022 7:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voucher](
	[VoucherID] [int] NOT NULL,
	[VoucherDate] [smalldatetime] NULL,
	[IdCompany] [int] NOT NULL,
	[StaffID] [int] NOT NULL,
	[Total] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[VoucherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Voucher_Detail]    Script Date: 12/31/2022 7:50:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Voucher_Detail](
	[VoucherID] [int] NOT NULL,
	[PID] [int] NOT NULL,
	[AMOUNT] [int] NULL,
	[PurchaseUnitPrice] [float] NULL,
	[Total] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[VoucherID] ASC,
	[PID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Company_Detail]  WITH CHECK ADD FOREIGN KEY([IdCompany])
REFERENCES [dbo].[Company] ([IdCompany])
GO
ALTER TABLE [dbo].[Company_Detail]  WITH CHECK ADD FOREIGN KEY([PID])
REFERENCES [dbo].[Product] ([PID])
GO
ALTER TABLE [dbo].[Inventory_Report]  WITH CHECK ADD FOREIGN KEY([PID])
REFERENCES [dbo].[Product] ([PID])
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD FOREIGN KEY([PTypeID])
REFERENCES [dbo].[PType] ([PTypeID])
GO
ALTER TABLE [dbo].[PType]  WITH CHECK ADD FOREIGN KEY([UnitID])
REFERENCES [dbo].[Unit] ([UnitID])
GO
ALTER TABLE [dbo].[SalesSlip]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[SalesSlip]  WITH CHECK ADD FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[SalesSlip_Detail]  WITH CHECK ADD FOREIGN KEY([SalesSlipID])
REFERENCES [dbo].[SalesSlip] ([SalesSlipID])
GO
ALTER TABLE [dbo].[SalesSlip_Detail]  WITH CHECK ADD FOREIGN KEY([PID])
REFERENCES [dbo].[Product] ([PID])
GO
ALTER TABLE [dbo].[ServiceVoucher]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[ServiceVoucher]  WITH CHECK ADD FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[ServiceVoucher_Detail]  WITH CHECK ADD FOREIGN KEY([S_VoucherID])
REFERENCES [dbo].[ServiceVoucher] ([S_VoucherID])
GO
ALTER TABLE [dbo].[ServiceVoucher_Detail]  WITH CHECK ADD FOREIGN KEY([S_ID])
REFERENCES [dbo].[Service] ([S_ID])
GO
ALTER TABLE [dbo].[ServiceVoucher_Detail]  WITH CHECK ADD FOREIGN KEY([PID])
REFERENCES [dbo].[Product] ([PID])
GO
ALTER TABLE [dbo].[Voucher]  WITH CHECK ADD FOREIGN KEY([IdCompany])
REFERENCES [dbo].[Company] ([IdCompany])
GO
ALTER TABLE [dbo].[Voucher]  WITH CHECK ADD FOREIGN KEY([StaffID])
REFERENCES [dbo].[Staff] ([StaffID])
GO
ALTER TABLE [dbo].[Voucher_Detail]  WITH CHECK ADD FOREIGN KEY([VoucherID])
REFERENCES [dbo].[Voucher] ([VoucherID])
GO
ALTER TABLE [dbo].[Voucher_Detail]  WITH CHECK ADD FOREIGN KEY([PID])
REFERENCES [dbo].[Product] ([PID])
GO
ALTER TABLE [dbo].[ServiceVoucher]  WITH CHECK ADD  CONSTRAINT [CK_Status1] CHECK  (([Status]='Undone' OR [Status]='Done'))
GO
ALTER TABLE [dbo].[ServiceVoucher] CHECK CONSTRAINT [CK_Status1]
GO
ALTER TABLE [dbo].[ServiceVoucher_Detail]  WITH CHECK ADD  CONSTRAINT [CK_Status] CHECK  (([Status]='Delivered' OR [Status]='Not delivered yet'))
GO
ALTER TABLE [dbo].[ServiceVoucher_Detail] CHECK CONSTRAINT [CK_Status]
GO
USE [master]
GO
ALTER DATABASE [ES104] SET  READ_WRITE 
GO
