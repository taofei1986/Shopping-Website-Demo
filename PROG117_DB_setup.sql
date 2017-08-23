----------------------------------------
-- CREATE A NEW DATABASE
----------------------------------------
USE [master]
GO
CREATE DATABASE [PROG117DB]
 CONTAINMENT = NONE

 -- Make this DB compatible to SQL Server 2012 through SQL Server 2016
 -- more info on this link --> https://msdn.microsoft.com/en-us/library/bb510680.aspx
ALTER DATABASE [PROG117DB] SET COMPATIBILITY_LEVEL = 110
GO

---------------------------------------
-- CREATE THE LOGIN
---------------------------------------
USE [master]
GO
CREATE LOGIN [PROG117_web_user] WITH PASSWORD='abc123', DEFAULT_DATABASE=[PROG117DB], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

----------------------------------------
-- CREATE THE PERSON TABLE
----------------------------------------
use [PROG117DB]
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[person](
    [firstName] [varchar](50) NOT NULL,
    [lastName] [varchar](50) NOT NULL,
    [userName] [varchar](50) NOT NULL,
    [password] [varchar](50) NOT NULL,
    [address] [varchar](50) NOT NULL,
    [email] [varchar](50) NOT NULL,
    [phone] [varchar](50) NOT NULL,
    [id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_PROG117_personAz] PRIMARY KEY CLUSTERED
(
    [id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_PROG117_person2_1Az] UNIQUE NONCLUSTERED
(
    [email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_PROG117_personAz] UNIQUE NONCLUSTERED
(
    [userName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO



----------------------------------------
-- CREATE THE PRODUCT TABLE
----------------------------------------
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[products](
    [productName] [varchar](50) NOT NULL,
    [description] [varchar](250) NOT NULL,
    [price] [float] NOT NULL,
    [currentAmount] [int] NOT NULL,
    [pid] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_productsAz] PRIMARY KEY CLUSTERED
(
    [pid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

------------------------------------
-- CREATE THE USER
------------------------------------
USE [PROG117DB]
GO

CREATE USER [PROG117_web_user] FOR LOGIN [PROG117_web_user] WITH DEFAULT_SCHEMA=[dbo]
GO
ALTER ROLE [db_datareader] ADD MEMBER [PROG117_web_user]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [PROG117_web_user]
GO