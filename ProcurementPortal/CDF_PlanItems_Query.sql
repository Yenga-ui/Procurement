USE [MyPayroll]
GO

/****** Object:  Table [dbo].[CDF_PlanItems]    Script Date: 18/04/2022 2:24:55 am ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CDF_PlanItems](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlanHeaderId] [int] NULL,
	[Class] [nvarchar](100) NOT NULL,
	[Unspsc] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NOT NULL,
	[RefNo] [nvarchar](50) NOT NULL,
	[ProjectCode] [nvarchar](50) NULL,
	[UnitOfMeasure] [nvarchar](50) NULL,
	[Quantity] [nvarchar](50) NULL,
	[SourceOfFunds] [nvarchar](50) NULL,
	[Prequalification] [char](1) NULL,
	[ProcurementMethod] [nvarchar](50) NULL,
	[Publication] [datetime] NOT NULL,
	[Award] [datetime] NOT NULL,
	[Start] [datetime] NULL,
	[Comments] [nvarchar](50) NULL,
	[TypeOfEntry] [nvarchar](50) NULL,
 CONSTRAINT [PK_CDF_PlanItems] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


