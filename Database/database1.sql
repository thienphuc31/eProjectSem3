USE [master]
GO
/****** Object:  Database [ProjectsDB]    Script Date: 10/03/2023 2:27:21 CH ******/
CREATE DATABASE [ProjectsDB]
 
GO
ALTER DATABASE [ProjectsDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProjectsDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProjectsDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProjectsDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProjectsDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProjectsDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProjectsDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProjectsDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProjectsDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProjectsDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProjectsDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProjectsDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProjectsDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProjectsDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProjectsDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProjectsDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProjectsDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProjectsDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProjectsDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProjectsDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProjectsDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProjectsDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProjectsDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProjectsDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProjectsDB] SET RECOVERY FULL 
GO
ALTER DATABASE [ProjectsDB] SET  MULTI_USER 
GO
ALTER DATABASE [ProjectsDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProjectsDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProjectsDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProjectsDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProjectsDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProjectsDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProjectsDB', N'ON'
GO
ALTER DATABASE [ProjectsDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [ProjectsDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [ProjectsDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 10/03/2023 2:27:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 10/03/2023 2:27:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[admin_id] [nvarchar](450) NOT NULL,
	[admin_name] [nvarchar](50) NOT NULL,
	[admin_password] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[admin_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bell]    Script Date: 10/03/2023 2:27:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bell](
	[bell_id] [int] IDENTITY(1,1) NOT NULL,
	[text] [nvarchar](max) NOT NULL,
	[employee_id] [nvarchar](450) NULL,
 CONSTRAINT [PK_Bell] PRIMARY KEY CLUSTERED 
(
	[bell_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 10/03/2023 2:27:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[contact_id] [int] IDENTITY(1,1) NOT NULL,
	[contact_title] [nvarchar](max) NULL,
	[contact_text] [nvarchar](max) NULL,
	[createdate] [datetime2](7) NOT NULL,
	[answer] [nvarchar](max) NULL,
	[status] [int] NOT NULL,
	[employee_id] [nvarchar](450) NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[contact_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Department]    Script Date: 10/03/2023 2:27:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Department](
	[department_id] [int] IDENTITY(1,1) NOT NULL,
	[department_name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Department] PRIMARY KEY CLUSTERED 
(
	[department_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 10/03/2023 2:27:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[employee_id] [nvarchar](450) NOT NULL,
	[employee_name] [nvarchar](50) NOT NULL,
	[employee_password] [nvarchar](20) NOT NULL,
	[employee_DOB] [datetime2](7) NOT NULL,
	[employee_email] [nvarchar](max) NOT NULL,
	[employee_address] [nvarchar](max) NOT NULL,
	[employee_phone] [nvarchar](max) NOT NULL,
	[Role] [int] NOT NULL,
	[department_id] [int] NOT NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeEvent]    Script Date: 10/03/2023 2:27:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeEvent](
	[EE_id] [int] IDENTITY(1,1) NOT NULL,
	[employee_id] [nvarchar](450) NULL,
	[event_id] [int] NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_EmployeeEvent] PRIMARY KEY CLUSTERED 
(
	[EE_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Event]    Script Date: 10/03/2023 2:27:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Event](
	[event_id] [int] IDENTITY(1,1) NOT NULL,
	[event_name] [nvarchar](max) NOT NULL,
	[event_content] [nvarchar](max) NOT NULL,
	[event_img] [nvarchar](max) NULL,
	[number] [int] NOT NULL,
	[event_startdate] [datetime2](7) NOT NULL,
	[event_enddate] [datetime2](7) NOT NULL,
	[event_type] [int] NOT NULL,
	[status] [bit] NOT NULL,
 CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED 
(
	[event_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FAQ]    Script Date: 10/03/2023 2:27:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FAQ](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [varchar](max) NULL,
	[lastName] [varchar](max) NULL,
	[email] [varchar](max) NULL,
	[phone] [varchar](max) NULL,
	[comments] [varchar](max) NULL,
 CONSTRAINT [PK_FAQ] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[News]    Script Date: 10/03/2023 2:27:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[news_id] [int] IDENTITY(1,1) NOT NULL,
	[news_title] [nvarchar](max) NOT NULL,
	[news_subtitle] [nvarchar](max) NOT NULL,
	[news_img] [nvarchar](max) NULL,
	[news_text] [nvarchar](max) NOT NULL,
	[news_date] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[news_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Question]    Script Date: 10/03/2023 2:27:21 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Question](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[question] [varchar](max) NULL,
	[answer] [varchar](max) NULL,
	[status] [varchar](max) NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230309160124_eProject1', N'5.0.11')
GO
SET IDENTITY_INSERT [dbo].[Department] ON 

INSERT [dbo].[Department] ([department_id], [department_name]) VALUES (1, N'Information Technology Department

')
INSERT [dbo].[Department] ([department_id], [department_name]) VALUES (2, N'NULLMarketing Department

')
INSERT [dbo].[Department] ([department_id], [department_name]) VALUES (3, N'Sales Department

')
INSERT [dbo].[Department] ([department_id], [department_name]) VALUES (4, N'Public Relations Department

')
INSERT [dbo].[Department] ([department_id], [department_name]) VALUES (5, N'Administration Department

')
INSERT [dbo].[Department] ([department_id], [department_name]) VALUES (6, N'Human Resource Department

')
INSERT [dbo].[Department] ([department_id], [department_name]) VALUES (7, N'Training Department

')
SET IDENTITY_INSERT [dbo].[Department] OFF
GO
INSERT [dbo].[Employee] ([employee_id], [employee_name], [employee_password], [employee_DOB], [employee_email], [employee_address], [employee_phone], [Role], [department_id]) VALUES (N'E001', N'NguyenTamHieu', N'abc123', CAST(N'1999-03-04T00:00:00.0000000' AS DateTime2), N'tamhieu@gmail.com', N'221 Phan Huy Ich', N'0912212214', 0, 1)
INSERT [dbo].[Employee] ([employee_id], [employee_name], [employee_password], [employee_DOB], [employee_email], [employee_address], [employee_phone], [Role], [department_id]) VALUES (N'E002', N'TranLeThienPhuc', N'abc123!', CAST(N'2000-04-13T00:00:00.0000000' AS DateTime2), N'phuctran@gmail.com', N'590 CMT8 Tp Ho Chi Minh', N'0912577842', 0, 1)
INSERT [dbo].[Employee] ([employee_id], [employee_name], [employee_password], [employee_DOB], [employee_email], [employee_address], [employee_phone], [Role], [department_id]) VALUES (N'E003', N'Nguyen Duc Anh', N'ducanh123', CAST(N'2000-05-24T00:00:00.0000000' AS DateTime2), N'ducanh@gmail.com', N'888 Ly Thuong Kiet Tp Ho Chi Minh', N'0974922855', 1, 3)
INSERT [dbo].[Employee] ([employee_id], [employee_name], [employee_password], [employee_DOB], [employee_email], [employee_address], [employee_phone], [Role], [department_id]) VALUES (N'E004', N'VuLamMinhTuan', N'minhtuan123', CAST(N'2000-04-24T00:00:00.0000000' AS DateTime2), N'minhtuan@gmail.com', N'679 Le Quy Don Tp Ho Chi Minh', N'0982003123', 1, 5)
GO
SET IDENTITY_INSERT [dbo].[Event] ON 

INSERT [dbo].[Event] ([event_id], [event_name], [event_content], [event_img], [number], [event_startdate], [event_enddate], [event_type], [status]) VALUES (1, N'Camping Tour', N'Hoạt động ngoài trời  ', N'admin/img/game1.jpeg', 0, CAST(N'2023-03-10T10:15:00.0000000' AS DateTime2), CAST(N'2023-03-11T21:15:00.0000000' AS DateTime2), 2, 1)
INSERT [dbo].[Event] ([event_id], [event_name], [event_content], [event_img], [number], [event_startdate], [event_enddate], [event_type], [status]) VALUES (2, N'Travel', N'Đăng kí các tour du lịch', N'admin/img/game2.png', 0, CAST(N'2023-03-03T07:16:00.0000000' AS DateTime2), CAST(N'2023-03-05T19:16:00.0000000' AS DateTime2), 2, 0)
INSERT [dbo].[Event] ([event_id], [event_name], [event_content], [event_img], [number], [event_startdate], [event_enddate], [event_type], [status]) VALUES (3, N'Mini Games', N'Các mini game sẽ diển ra vào cuối tuần ', N'admin/img/game3.png', 0, CAST(N'2023-03-11T11:16:00.0000000' AS DateTime2), CAST(N'2023-03-12T20:16:00.0000000' AS DateTime2), 2, 1)
INSERT [dbo].[Event] ([event_id], [event_name], [event_content], [event_img], [number], [event_startdate], [event_enddate], [event_type], [status]) VALUES (4, N'Sping event', N'Sự kiện tân xuân cuối năm ', N'admin/img/game4.png', 0, CAST(N'2023-01-02T11:17:00.0000000' AS DateTime2), CAST(N'2023-01-08T11:17:00.0000000' AS DateTime2), 2, 0)
INSERT [dbo].[Event] ([event_id], [event_name], [event_content], [event_img], [number], [event_startdate], [event_enddate], [event_type], [status]) VALUES (5, N'Music Festival', N'Sự kiện âm nhạc , minigame phát quà', N'admin/img/game5.png', 0, CAST(N'2023-03-18T18:18:00.0000000' AS DateTime2), CAST(N'2023-03-18T23:18:00.0000000' AS DateTime2), 2, 1)
INSERT [dbo].[Event] ([event_id], [event_name], [event_content], [event_img], [number], [event_startdate], [event_enddate], [event_type], [status]) VALUES (6, N'International Bussiness', N'Cuộc họp doanh nghiệp nước ngoài', N'admin/img/meeting1.png', 0, CAST(N'2023-03-13T11:18:00.0000000' AS DateTime2), CAST(N'2023-03-13T02:18:00.0000000' AS DateTime2), 1, 1)
INSERT [dbo].[Event] ([event_id], [event_name], [event_content], [event_img], [number], [event_startdate], [event_enddate], [event_type], [status]) VALUES (7, N'Increase  Revenue ', N'Sự tăng trưởng về doanh số bán ra', N'admin/img/meeting2.png', 0, CAST(N'2023-03-10T10:19:00.0000000' AS DateTime2), CAST(N'2023-03-10T11:19:00.0000000' AS DateTime2), 1, 1)
INSERT [dbo].[Event] ([event_id], [event_name], [event_content], [event_img], [number], [event_startdate], [event_enddate], [event_type], [status]) VALUES (8, N'Leadership Meeting', N'Cuộc họp với lãnh đạo cấp cao báo cáo về doanh số ', N'admin/img/meeting3.png', 0, CAST(N'2023-03-02T09:21:00.0000000' AS DateTime2), CAST(N'2023-03-02T11:21:00.0000000' AS DateTime2), 1, 0)
INSERT [dbo].[Event] ([event_id], [event_name], [event_content], [event_img], [number], [event_startdate], [event_enddate], [event_type], [status]) VALUES (9, N'Meeting year-end', N'Tổng kết doanh thu cuối năm , doanh số đầu ra, đầu vào của công ty', N'admin/img/meeting5.png', 0, CAST(N'2022-12-29T10:23:00.0000000' AS DateTime2), CAST(N'2022-12-29T00:23:00.0000000' AS DateTime2), 1, 0)
INSERT [dbo].[Event] ([event_id], [event_name], [event_content], [event_img], [number], [event_startdate], [event_enddate], [event_type], [status]) VALUES (10, N'Sales', N'Nguời có doanh số bán cao nhất trong tháng ', N'admin/img/comp1.png', 0, CAST(N'2023-03-13T07:24:00.0000000' AS DateTime2), CAST(N'2023-03-17T11:24:00.0000000' AS DateTime2), 3, 1)
INSERT [dbo].[Event] ([event_id], [event_name], [event_content], [event_img], [number], [event_startdate], [event_enddate], [event_type], [status]) VALUES (11, N'Event', N'Người có nhiều đóng góp nhất trong các sự kiện ', N'admin/img/comp3.jpg', 0, CAST(N'2023-03-06T11:24:00.0000000' AS DateTime2), CAST(N'2023-03-10T11:24:00.0000000' AS DateTime2), 3, 0)
INSERT [dbo].[Event] ([event_id], [event_name], [event_content], [event_img], [number], [event_startdate], [event_enddate], [event_type], [status]) VALUES (12, N'Project', N'Đóng góp nhiều ý kiến dự án và KPI', N'admin/img/comp4.png', 0, CAST(N'2023-03-20T11:25:00.0000000' AS DateTime2), CAST(N'2023-03-24T11:25:00.0000000' AS DateTime2), 3, 1)
SET IDENTITY_INSERT [dbo].[Event] OFF
GO
SET IDENTITY_INSERT [dbo].[Question] ON 

INSERT [dbo].[Question] ([id], [question], [answer], [status]) VALUES (1, N'How to participate in the events? ', N'You can register for games and events in the event section', N'show')
INSERT [dbo].[Question] ([id], [question], [answer], [status]) VALUES (2, N'What if I am unable to login into the site? ', N'You can go to the FAQ to ask the admin how to login', N'show')
INSERT [dbo].[Question] ([id], [question], [answer], [status]) VALUES (3, N'What if I am unable to send the participation request for the event? ', N'If you can''t submit an event request, you can reset the page or go to the FAQ to ask the admin', N'show')
INSERT [dbo].[Question] ([id], [question], [answer], [status]) VALUES (4, N'How can one be intimated with the upcoming events', N'There will be announcements for upcoming events that will take place on specific dates', N'show')
SET IDENTITY_INSERT [dbo].[Question] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Bell_employee_id]    Script Date: 10/03/2023 2:27:21 CH ******/
CREATE NONCLUSTERED INDEX [IX_Bell_employee_id] ON [dbo].[Bell]
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Contact_employee_id]    Script Date: 10/03/2023 2:27:21 CH ******/
CREATE NONCLUSTERED INDEX [IX_Contact_employee_id] ON [dbo].[Contact]
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Employee_department_id]    Script Date: 10/03/2023 2:27:21 CH ******/
CREATE NONCLUSTERED INDEX [IX_Employee_department_id] ON [dbo].[Employee]
(
	[department_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_EmployeeEvent_employee_id]    Script Date: 10/03/2023 2:27:21 CH ******/
CREATE NONCLUSTERED INDEX [IX_EmployeeEvent_employee_id] ON [dbo].[EmployeeEvent]
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_EmployeeEvent_event_id]    Script Date: 10/03/2023 2:27:21 CH ******/
CREATE NONCLUSTERED INDEX [IX_EmployeeEvent_event_id] ON [dbo].[EmployeeEvent]
(
	[event_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Bell]  WITH CHECK ADD  CONSTRAINT [FK_Bell_Employee_employee_id] FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([employee_id])
GO
ALTER TABLE [dbo].[Bell] CHECK CONSTRAINT [FK_Bell_Employee_employee_id]
GO
ALTER TABLE [dbo].[Contact]  WITH CHECK ADD  CONSTRAINT [FK_Contact_Employee_employee_id] FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([employee_id])
GO
ALTER TABLE [dbo].[Contact] CHECK CONSTRAINT [FK_Contact_Employee_employee_id]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [FK_Employee_Department_department_id] FOREIGN KEY([department_id])
REFERENCES [dbo].[Department] ([department_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [FK_Employee_Department_department_id]
GO
ALTER TABLE [dbo].[EmployeeEvent]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeEvent_Employee_employee_id] FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([employee_id])
GO
ALTER TABLE [dbo].[EmployeeEvent] CHECK CONSTRAINT [FK_EmployeeEvent_Employee_employee_id]
GO
ALTER TABLE [dbo].[EmployeeEvent]  WITH CHECK ADD  CONSTRAINT [FK_EmployeeEvent_Event_event_id] FOREIGN KEY([event_id])
REFERENCES [dbo].[Event] ([event_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmployeeEvent] CHECK CONSTRAINT [FK_EmployeeEvent_Event_event_id]
GO
USE [master]
GO
ALTER DATABASE [ProjectsDB] SET  READ_WRITE 
GO
