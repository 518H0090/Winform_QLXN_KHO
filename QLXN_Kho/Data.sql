USE [master]
GO
/****** Object:  Database [QLXuatNhapKho]    Script Date: 2/9/2021 10:14:42 AM ******/
CREATE DATABASE [QLXuatNhapKho]
GO
USE [QLXuatNhapKho]
GO
/****** Object:  Table [dbo].[Input]    Script Date: 2/9/2021 10:14:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Input](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [int] NOT NULL,
	[DateInput] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[InputInfo]    Script Date: 2/9/2021 10:14:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InputInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdObject] [int] NOT NULL,
	[IdInput] [int] NOT NULL,
	[Count] [int] NULL,
	[InputPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Object]    Script Date: 2/9/2021 10:14:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Object](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](150) NOT NULL,
	[IdUnit] [int] NOT NULL,
	[IdSuplier] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Output]    Script Date: 2/9/2021 10:14:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Output](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [int] NOT NULL,
	[DateOutput] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OutputInfo]    Script Date: 2/9/2021 10:14:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OutputInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdOutput] [int] NOT NULL,
	[IdObject] [int] NOT NULL,
	[Count] [int] NULL,
	[OutputPrice] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Suplier]    Script Date: 2/9/2021 10:14:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Suplier](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](150) NOT NULL,
	[Address] [nvarchar](200) NULL,
	[Phone] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Unit]    Script Date: 2/9/2021 10:14:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Unit](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserRole]    Script Date: 2/9/2021 10:14:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRole](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DisplayName] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 2/9/2021 10:14:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](150) NOT NULL,
	[DisplayName] [nvarchar](150) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[IdRole] [int] NOT NULL,
	[Status] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[UserRole] ON 

INSERT [dbo].[UserRole] ([Id], [DisplayName]) VALUES (1, N'Admin')
INSERT [dbo].[UserRole] ([Id], [DisplayName]) VALUES (2, N'Nhân viên')
SET IDENTITY_INSERT [dbo].[UserRole] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [UserName], [DisplayName], [Password], [IdRole], [Status]) VALUES (1, N'admin', N'Nguyễn Admin', N'YWRtaW4xMjM=', 1, 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
ALTER TABLE [dbo].[InputInfo] ADD  DEFAULT ((1)) FOR [Count]
GO
ALTER TABLE [dbo].[InputInfo] ADD  DEFAULT ((0)) FOR [InputPrice]
GO
ALTER TABLE [dbo].[OutputInfo] ADD  DEFAULT ((1)) FOR [Count]
GO
ALTER TABLE [dbo].[OutputInfo] ADD  DEFAULT ((0)) FOR [OutputPrice]
GO
ALTER TABLE [dbo].[Input]  WITH CHECK ADD FOREIGN KEY([IdUser])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[InputInfo]  WITH CHECK ADD FOREIGN KEY([IdInput])
REFERENCES [dbo].[Input] ([Id])
GO
ALTER TABLE [dbo].[InputInfo]  WITH CHECK ADD FOREIGN KEY([IdObject])
REFERENCES [dbo].[Object] ([Id])
GO
ALTER TABLE [dbo].[Object]  WITH CHECK ADD FOREIGN KEY([IdSuplier])
REFERENCES [dbo].[Suplier] ([Id])
GO
ALTER TABLE [dbo].[Object]  WITH CHECK ADD FOREIGN KEY([IdUnit])
REFERENCES [dbo].[Unit] ([Id])
GO
ALTER TABLE [dbo].[Output]  WITH CHECK ADD FOREIGN KEY([IdUser])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[OutputInfo]  WITH CHECK ADD FOREIGN KEY([IdObject])
REFERENCES [dbo].[Object] ([Id])
GO
ALTER TABLE [dbo].[OutputInfo]  WITH CHECK ADD FOREIGN KEY([IdOutput])
REFERENCES [dbo].[Output] ([Id])
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD FOREIGN KEY([IdRole])
REFERENCES [dbo].[UserRole] ([Id])
GO
/****** Object:  StoredProcedure [dbo].[AddSuplier]    Script Date: 2/9/2021 10:14:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--suplier
create proc [dbo].[AddSuplier]
    @DisplayName nvarchar(max) ,
	@Address nvarchar(max),
	@Phone varchar(20) 
as insert into Suplier(DisplayName,Address,Phone)
values (@DisplayName,@Address,@Phone)

GO
/****** Object:  StoredProcedure [dbo].[AddUnit]    Script Date: 2/9/2021 10:14:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--unit
create proc [dbo].[AddUnit]
@DisplayName nvarchar(max)
as insert into Unit(DisplayName)
values (@DisplayName)

GO
/****** Object:  StoredProcedure [dbo].[DeleteSuplier]    Script Date: 2/9/2021 10:14:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[DeleteSuplier]
@Id int
as delete from Suplier
where Id =@Id

GO
/****** Object:  StoredProcedure [dbo].[DeleteUnit]    Script Date: 2/9/2021 10:14:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteUnit]
@Id int
as delete from Unit 
where Id =@Id

GO
/****** Object:  StoredProcedure [dbo].[EditSuplier]    Script Date: 2/9/2021 10:14:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[EditSuplier]
	@Id int,
    @DisplayName nvarchar(max) ,
	@Address nvarchar(max),
	@Phone varchar(20) 
	
as update  Suplier set DisplayName=@DisplayName,Address=@Address,Phone=@Phone where Id=@Id

GO
/****** Object:  StoredProcedure [dbo].[EditUnit]    Script Date: 2/9/2021 10:14:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[EditUnit]
@Id int,
@DisplayName nvarchar(max)
as update Unit set DisplayName=@DisplayName
where Id =@Id

GO
USE [master]
GO
ALTER DATABASE [QLXuatNhapKho] SET  READ_WRITE 
GO





