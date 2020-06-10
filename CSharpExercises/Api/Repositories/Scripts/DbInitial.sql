USE [demo]
GO

/****** Object:  Table [dbo].[Person]    Script Date: 9/06/2020 7:36:03 p. m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Person](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](20) NOT NULL,
	[LastName] [varchar](20) NOT NULL,
	[Age] [int] NOT NULL,
	[Identification] [varchar](10) NOT NULL,
	[Genre] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO