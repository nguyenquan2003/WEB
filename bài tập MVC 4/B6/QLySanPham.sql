USE [master]
GO
/****** Object:  Database [QLSanPham]    Script Date: 5/29/2019 2:13:14 PM ******/
CREATE DATABASE [QLSanPham]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLSanPham', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLSanPham.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QLSanPham_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\QLSanPham_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QLSanPham] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLSanPham].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLSanPham] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLSanPham] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLSanPham] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLSanPham] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLSanPham] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLSanPham] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QLSanPham] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [QLSanPham] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLSanPham] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLSanPham] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLSanPham] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLSanPham] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLSanPham] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLSanPham] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLSanPham] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLSanPham] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QLSanPham] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLSanPham] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLSanPham] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLSanPham] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLSanPham] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLSanPham] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLSanPham] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLSanPham] SET RECOVERY FULL 
GO
ALTER DATABASE [QLSanPham] SET  MULTI_USER 
GO
ALTER DATABASE [QLSanPham] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLSanPham] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLSanPham] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLSanPham] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QLSanPham', N'ON'
GO
USE [QLSanPham]
GO
/****** Object:  Table [dbo].[tbl_ChiTiet]    Script Date: 5/29/2019 2:13:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ChiTiet](
	[MaHD] [int] NOT NULL,
	[MaSP] [nvarchar](50) NOT NULL,
	[SoLuong] [int] NULL,
 CONSTRAINT [PK_tbl_ChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_HoaDon]    Script Date: 5/29/2019 2:13:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HoaDon](
	[MaHoaDon] [int] NOT NULL,
	[NgayTao] [datetime] NULL,
	[MaKH] [int] NULL,
 CONSTRAINT [PK_tbl_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_KhachHang]    Script Date: 5/29/2019 2:13:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_KhachHang](
	[MaKhachHang] [int] NOT NULL,
	[TenKhachHang] [nvarchar](max) NULL,
	[SoDienThoai] [nvarchar](15) NULL,
	[MatKhau] [nvarchar](10) NULL,
 CONSTRAINT [PK_tbl_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Loai]    Script Date: 5/29/2019 2:13:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Loai](
	[MaLoai] [int] NOT NULL,
	[TenLoai] [nvarchar](100) NULL,
 CONSTRAINT [PK_tbl_Loai] PRIMARY KEY CLUSTERED 
(
	[MaLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_NhaSanXuat]    Script Date: 5/29/2019 2:13:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_NhaSanXuat](
	[MaNSX] [int] NOT NULL,
	[TenNSX] [nvarchar](100) NULL,
 CONSTRAINT [PK_tbl_NhaSanXuat] PRIMARY KEY CLUSTERED 
(
	[MaNSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_SanPham]    Script Date: 5/29/2019 2:13:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_SanPham](
	[MaSanPham] [nvarchar](50) NOT NULL,
	[TenSP] [nvarchar](max) NULL,
	[MaL] [int] NULL,
	[MaSX] [int] NULL,
	[Gia] [float] NULL,
	[GhiChu] [nvarchar](max) NULL,
	[Hinh] [nvarchar](max) NULL,
 CONSTRAINT [PK_tbl_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[tbl_ChiTiet] ([MaHD], [MaSP], [SoLuong]) VALUES (1, N'02', 1)
INSERT [dbo].[tbl_ChiTiet] ([MaHD], [MaSP], [SoLuong]) VALUES (1, N'05', 1)
INSERT [dbo].[tbl_HoaDon] ([MaHoaDon], [NgayTao], [MaKH]) VALUES (1, CAST(0x0000A9BF00000000 AS DateTime), 1)
INSERT [dbo].[tbl_KhachHang] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [MatKhau]) VALUES (1, N'Hoa', N'0394773229', N'123456')
INSERT [dbo].[tbl_Loai] ([MaLoai], [TenLoai]) VALUES (1, N'Sách giáo khoa')
INSERT [dbo].[tbl_Loai] ([MaLoai], [TenLoai]) VALUES (2, N'Sách từ điển')
INSERT [dbo].[tbl_Loai] ([MaLoai], [TenLoai]) VALUES (3, N'Sách đại học')
INSERT [dbo].[tbl_Loai] ([MaLoai], [TenLoai]) VALUES (4, N'Truyện tranh')
INSERT [dbo].[tbl_NhaSanXuat] ([MaNSX], [TenNSX]) VALUES (1, N'Hà Nội')
INSERT [dbo].[tbl_NhaSanXuat] ([MaNSX], [TenNSX]) VALUES (2, N'Thanh Niên')
INSERT [dbo].[tbl_NhaSanXuat] ([MaNSX], [TenNSX]) VALUES (3, N'Kim Đồng')
INSERT [dbo].[tbl_NhaSanXuat] ([MaNSX], [TenNSX]) VALUES (4, N'Bách Khoa')
INSERT [dbo].[tbl_SanPham] ([MaSanPham], [TenSP], [MaL], [MaSX], [Gia], [GhiChu], [Hinh]) VALUES (N'01', N'Toán 10 Nâng cao', 1, 1, 15000, N'Giải bài tập toán lớp 10 Nâng cao như là cuốn để học tốt Toán lớp 10 Nâng cao. Tổng hợp công thức, lý thuyết, phương pháp giải bài tập đại số và hình học', N'h1.png')
INSERT [dbo].[tbl_SanPham] ([MaSanPham], [TenSP], [MaL], [MaSX], [Gia], [GhiChu], [Hinh]) VALUES (N'02', N'Ngữ Văn 11', 1, 1, 21000, N'oạn văn lớp 11 đầy đủ tất cả bài, ngắn gọn nhất như là cuốn để học tốt Ngữ văn 11. Giúp học sinh soạn bài, tóm tắt, phân tích, nghị luận,... đầy đủ các bài văn ...', N'h2.png')
INSERT [dbo].[tbl_SanPham] ([MaSanPham], [TenSP], [MaL], [MaSX], [Gia], [GhiChu], [Hinh]) VALUES (N'03', N'Từ điển 1000 từ', 2, 2, 56000, N'Từ điển 1000 từ được biên soạn nhằm làm cho việc học tập trở nên thú vị và vui thích đối với trẻ. Điều này quan trọng đối với những trẻ ở độ tuổi tiểu học vốn ...', N'h3.png')
INSERT [dbo].[tbl_SanPham] ([MaSanPham], [TenSP], [MaL], [MaSX], [Gia], [GhiChu], [Hinh]) VALUES (N'04', N'Anh-Viet 500 từ', 2, 3, 47000, N'Langmaster xin giới thiệu 500 tính từ thông dụng được sử dụng ... điển hình. competitive. cạnh tranh. critical. quan trọng. electronic. điện tử.', N'h4.png')
INSERT [dbo].[tbl_SanPham] ([MaSanPham], [TenSP], [MaL], [MaSX], [Gia], [GhiChu], [Hinh]) VALUES (N'05', N'Anh-Anh', 2, 4, 120900, N'Từ điển và Từ điển từ đồng nghĩa được ưa chuộng nhất cho người học tiếng Anh. Các định nghĩa và ý nghĩa của từ cùng với phát âm và các bản dịch.', N'h5.png')
INSERT [dbo].[tbl_SanPham] ([MaSanPham], [TenSP], [MaL], [MaSX], [Gia], [GhiChu], [Hinh]) VALUES (N'06', N'Viet - Anh', 2, 1, 34000, N'Từ điển trực tuyến miễn phí cho người Việt. Cung cấp 2 bộ từ điển chính: Anh - Việt và Việt - Anh. Kho từ đồ sộ cùng hệ thống gợi ý từ thông minh, Laban', N'h6.png')
INSERT [dbo].[tbl_SanPham] ([MaSanPham], [TenSP], [MaL], [MaSX], [Gia], [GhiChu], [Hinh]) VALUES (N'07', N'Hoa-Việt', 2, 2, 81000, N'Từ điển trực tuyến miễn phí cho người Việt. Cung cấp 2 bộ từ điển chính: Anh - Việt và Việt - Anh. Kho từ đồ sộ cùng hệ thống gợi ý từ thông minh, Laban', N'h7.png')
INSERT [dbo].[tbl_SanPham] ([MaSanPham], [TenSP], [MaL], [MaSX], [Gia], [GhiChu], [Hinh]) VALUES (N'08', N'Toán Cao cấp', 3, 2, 47900, N'Tài liệu tham khảo Giáo trình toán cao cấp A2 - trường Đại học quốc gia Tp. Hồ Chí Minh dành cho các bạn sinh viên . Chúc bạn học và luyện thi tốt trong các kỳ', N'h8.png')
INSERT [dbo].[tbl_SanPham] ([MaSanPham], [TenSP], [MaL], [MaSX], [Gia], [GhiChu], [Hinh]) VALUES (N'09', N'Tin học văn phòng', 3, 1, 289700, N'Tin học văn phòng là chứng chỉ cần thiết và là cơ hội đối với học viên để có được công việc và tương lai tươi sáng', N'h9.png')
INSERT [dbo].[tbl_SanPham] ([MaSanPham], [TenSP], [MaL], [MaSX], [Gia], [GhiChu], [Hinh]) VALUES (N'10', N'Nhập môn lập trình', 3, 4, 26000, N'Giới thiệu. Nhập môn Lập Trình- Giải Thuật cơ bản. Khóa học trực tuyến này được thiết kế, biên tập lại từ khóa học cấu trúc dữ liệu giải thuật phòng lab rất ...', N'h10.png')
INSERT [dbo].[tbl_SanPham] ([MaSanPham], [TenSP], [MaL], [MaSX], [Gia], [GhiChu], [Hinh]) VALUES (N'11', N'Cơ sở dữ liệu', 3, 2, 34000, N'Cơ sở dữ liệu là một tập hợp các dữ liệu có tổ chức, thường được lưu trữ và truy cập điện tử từ hệ thống máy tính. Khi cơ sở dữ liệu phức tạp hơn, chúng ...', N'h11.png')
INSERT [dbo].[tbl_SanPham] ([MaSanPham], [TenSP], [MaL], [MaSX], [Gia], [GhiChu], [Hinh]) VALUES (N'12', N'7 viên ngọc rồng', 4, 1, 12600, N'Game 7 viên ngọc rồng 4 đã quay trở lại, một trận chiến của 7 vien ngoc rong sieu cap đã nổ ra. Bấm chơi game 7 viên ngọc rồng 4 cho 2 người chơi.', N'h12.png')
INSERT [dbo].[tbl_SanPham] ([MaSanPham], [TenSP], [MaL], [MaSX], [Gia], [GhiChu], [Hinh]) VALUES (N'13', N'Công chúa Win', 4, 2, 23500, N'Chỉ có ở trên kênh Winx Club Vietnam… Mỗi ngày một tập phim mới, đừng bỏ qua! Winx Club', N'h13.png')
INSERT [dbo].[tbl_SanPham] ([MaSanPham], [TenSP], [MaL], [MaSX], [Gia], [GhiChu], [Hinh]) VALUES (N'14', N'Doreamon', 4, 3, 45000, N'Chỉ có ở trên kênh Winx Club Vietnam… Mỗi ngày một tập phim mới, đừng bỏ qua! Winx Club', N'h14.png')
ALTER TABLE [dbo].[tbl_ChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ChiTiet_tbl_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[tbl_HoaDon] ([MaHoaDon])
GO
ALTER TABLE [dbo].[tbl_ChiTiet] CHECK CONSTRAINT [FK_tbl_ChiTiet_tbl_HoaDon]
GO
ALTER TABLE [dbo].[tbl_ChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_tbl_ChiTiet_tbl_SanPham] FOREIGN KEY([MaSP])
REFERENCES [dbo].[tbl_SanPham] ([MaSanPham])
GO
ALTER TABLE [dbo].[tbl_ChiTiet] CHECK CONSTRAINT [FK_tbl_ChiTiet_tbl_SanPham]
GO
ALTER TABLE [dbo].[tbl_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HoaDon_tbl_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tbl_KhachHang] ([MaKhachHang])
GO
ALTER TABLE [dbo].[tbl_HoaDon] CHECK CONSTRAINT [FK_tbl_HoaDon_tbl_KhachHang]
GO
ALTER TABLE [dbo].[tbl_SanPham]  WITH CHECK ADD  CONSTRAINT [FK_tbl_SanPham_tbl_Loai] FOREIGN KEY([MaL])
REFERENCES [dbo].[tbl_Loai] ([MaLoai])
GO
ALTER TABLE [dbo].[tbl_SanPham] CHECK CONSTRAINT [FK_tbl_SanPham_tbl_Loai]
GO
ALTER TABLE [dbo].[tbl_SanPham]  WITH CHECK ADD  CONSTRAINT [FK_tbl_SanPham_tbl_NhaSanXuat] FOREIGN KEY([MaSX])
REFERENCES [dbo].[tbl_NhaSanXuat] ([MaNSX])
GO
ALTER TABLE [dbo].[tbl_SanPham] CHECK CONSTRAINT [FK_tbl_SanPham_tbl_NhaSanXuat]
GO
USE [master]
GO
ALTER DATABASE [QLSanPham] SET  READ_WRITE 
GO
