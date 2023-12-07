Create Database DBGIAY_DUAN1
go
USE [DBGIAY_DUAN1]
GO
/****** Object:  Table [dbo].[BANGLUONG]    Script Date: 03/12/2023 8:30:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANGLUONG](
	[MALUONG] [int] IDENTITY(1,1) NOT NULL,
	[THANGLAM] [int] NULL,
	[LUONGCOBAN] [float] NULL,
	[TIENTHUONG] [float] NULL,
	[TIENKHAUTRU] [float] NULL,
	[TONGTHUNHAP] [float] NULL,
	[MATAIKHOAN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MALUONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHATLIEU]    Script Date: 03/12/2023 8:30:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHATLIEU](
	[MACHATLIEU] [int] IDENTITY(1,1) NOT NULL,
	[TENCHATLIEU] [nvarchar](50) NULL,
	[MOTA] [nvarchar](200) NULL,
	[TRANGTHAI] [bit] NULL,
	[MATAIKHOAN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MACHATLIEU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 03/12/2023 8:30:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MACHUCVU] [int] IDENTITY(1,1) NOT NULL,
	[TENCHUCVU] [nvarchar](50) NULL,
	[MOTACHUCVU] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MACHUCVU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIAOCA]    Script Date: 03/12/2023 8:30:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAOCA](
	[MAGIAOCA] [int] IDENTITY(1,1) NOT NULL,
	[TENCA] [nvarchar](50) NULL,
	[THOIGIANBATDAU] [time](7) NULL,
	[THOIGIANKETTHUC] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAGIAOCA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIAOCANHANVIEN]    Script Date: 03/12/2023 8:30:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAOCANHANVIEN](
	[MAGIAOCANHANVIEN] [int] IDENTITY(1,1) NOT NULL,
	[MATAIKHOAN] [int] NULL,
	[MAGIAOCA] [int] NULL,
	[NGAYGIAOCA] [date] NULL,
	[THOIGIANDEN] [time](7) NULL,
	[THOIGIANVE] [time](7) NULL,
	[SANPHAMDAGIAO] [nvarchar](100) NULL,
	[TIENDAGIAO] [float] NULL,
	[GHICHU] [nvarchar](300) NULL,
	[TRANGTHAI] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAGIAOCANHANVIEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIAY]    Script Date: 03/12/2023 8:30:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAY](
	[MAGIAY] [int] IDENTITY(1,1) NOT NULL,
	[TENGIAY] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAGIAY] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GIAYCHITIET]    Script Date: 03/12/2023 8:30:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GIAYCHITIET](
	[MAGIAYCHITIET] [int] IDENTITY(1,1) NOT NULL,
	[MAGIAY] [int] NULL,
	[MACHATLIEU] [int] NULL,
	[MAMAUSAC] [int] NULL,
	[MAKICHCO] [int] NULL,
	[MATHUONGHIEU] [int] NULL,
	[MAKIEUDANG] [int] NULL,
	[SOLUONGCON] [int] NULL,
	[NGAYTAO] [datetime] NULL,
	[NGAYSUA] [datetime] NULL,
	[NGUOITAO] [int] NULL,
	[NGUOISUA] [int] NULL,
	[GIA] [float] NULL,
	[MOTA] [nvarchar](300) NULL,
	[TRANGTHAI] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAGIAYCHITIET] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HINHTHUCTHANHTOAN]    Script Date: 03/12/2023 8:30:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HINHTHUCTHANHTOAN](
	[MAHINHTHUCTHANHTOAN] [int] IDENTITY(1,1) NOT NULL,
	[TENHINHTHUC] [nvarchar](50) NULL,
	[MOTA] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHINHTHUCTHANHTOAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 03/12/2023 8:30:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHOADON] [int] IDENTITY(1,1) NOT NULL,
	[MATAIKHOAN] [int] NULL,
	[MAUUDAI] [int] NULL,
	[MAKHACHHANG] [int] NULL,
	[MAHINHTHUCTHANHTOAN] [int] NULL,
	[TENCUAHANG] [nvarchar](100) NULL,
	[DIACHICUAHANG] [nvarchar](200) NULL,
	[SDTCUAHANG] [varchar](10) NULL,
	[EMAILCUAHANG] [varchar](50) NULL,
	[NGAYTAO] [datetime] NULL,
	[TONGTIEN] [float] NULL,
	[TRANGTHAI] [bit] NULL,
	[GHICHU] [nvarchar](200) NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADONCHITIET]    Script Date: 03/12/2023 8:30:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADONCHITIET](
	[MAHOADONCHITIET] [int] IDENTITY(1,1) NOT NULL,
	[MAGIAYCHITIET] [int] NULL,
	[MAHOADON] [int] NULL,
	[SOLUONGMUA] [int] NULL,
	[GIA] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAHOADONCHITIET] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KICHCO]    Script Date: 03/12/2023 8:30:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KICHCO](
	[MAKICHCO] [int] IDENTITY(1,1) NOT NULL,
	[TENKICHCO] [nvarchar](50) NULL,
	[MOTA] [nvarchar](200) NULL,
	[TRANGTHAI] [bit] NULL,
	[MATAIKHOAN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAKICHCO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KIEUDANG]    Script Date: 03/12/2023 8:30:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KIEUDANG](
	[MAKIEUDANG] [int] IDENTITY(1,1) NOT NULL,
	[TENKIEUDANG] [nvarchar](50) NULL,
	[MOTA] [nvarchar](200) NULL,
	[TRANGTHAI] [bit] NULL,
	[MATAIKHOAN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAKIEUDANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 03/12/2023 8:30:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MAKHACHHANG] [int] IDENTITY(1,1) NOT NULL,
	[TENKHACHHANG] [nvarchar](50) NULL,
	[SDT] [varchar](10) NULL,
	[DIEMKHACHHANG] [int] NULL,
	[TRANGTHAI] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAKHACHHANG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MAUSAC]    Script Date: 03/12/2023 8:30:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MAUSAC](
	[MAMAUSAC] [int] IDENTITY(1,1) NOT NULL,
	[TENMAUSAC] [nvarchar](50) NULL,
	[MOTA] [nvarchar](200) NULL,
	[TRANGTHAI] [bit] NULL,
	[MATAIKHOAN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAMAUSAC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 03/12/2023 8:30:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MATAIKHOAN] [int] IDENTITY(1,1) NOT NULL,
	[USERNAME] [varchar](30) NULL,
	[PASWORD] [varchar](30) NULL,
	[HOVATEN] [nvarchar](50) NULL,
	[GIOITINH] [bit] NULL,
	[SODIENTHOAI] [varchar](10) NULL,
	[DIACHI] [nvarchar](200) NULL,
	[EMAIL] [varchar](50) NULL,
	[NGAYSINH] [date] NULL,
	[NGAYTAOTAIKHOAN] [date] NULL,
	[MACHUCVU] [int] NOT NULL,
	[TRANGTHAI] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MATAIKHOAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THUONGHIEU]    Script Date: 03/12/2023 8:30:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUONGHIEU](
	[MATHUONGHIEU] [int] IDENTITY(1,1) NOT NULL,
	[TENTHUONGHIEU] [nvarchar](50) NULL,
	[EMAIL] [varchar](50) NULL,
	[SDT] [varchar](10) NULL,
	[TRANGTHAI] [bit] NULL,
	[MOTA] [nvarchar](200) NULL,
	[MATAIKHOAN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MATHUONGHIEU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UUDAI]    Script Date: 03/12/2023 8:30:13 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UUDAI](
	[MAUUDAI] [int] IDENTITY(1,1) NOT NULL,
	[TENUUDAI] [nvarchar](50) NULL,
	[NGAYBATDAU] [datetime] NULL,
	[NGAYKETTHUC] [datetime] NULL,
	[PHANTRAM] [int] NULL,
	[TRANGTHAI] [int] NULL,
	[SOLUONG] [int] NULL,
	[MATAIKHOAN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MAUUDAI] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CHATLIEU] ON 

INSERT [dbo].[CHATLIEU] ([MACHATLIEU], [TENCHATLIEU], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (2, N'Da', N'Da là một chất liệu phổ biến cho phần upper của giày, mang lại độ bền và thoải mái. Da có thể được chế tạo từ da thật hoặc da tổng hợp.', 1, 1)
INSERT [dbo].[CHATLIEU] ([MACHATLIEU], [TENCHATLIEU], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (3, N'Vải Canvas', N'Canvas là một loại vải bền và nhẹ, thường được sử dụng cho upper của giày casual và skate.
', 1, 1)
INSERT [dbo].[CHATLIEU] ([MACHATLIEU], [TENCHATLIEU], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (4, N'Mesh', N'Nylon là một chất liệu nhẹ và bền, thường được sử dụng trong phần upper và phần lót của giày.
', 1, 1)
INSERT [dbo].[CHATLIEU] ([MACHATLIEU], [TENCHATLIEU], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (5, N'Suede (Da Lụa)', N'Suede là một loại da mịn, thường được sử dụng cho việc tạo kiểu và tăng tính thẩm mỹ của giày.
', 1, 1)
SET IDENTITY_INSERT [dbo].[CHATLIEU] OFF
GO
SET IDENTITY_INSERT [dbo].[CHUCVU] ON 

INSERT [dbo].[CHUCVU] ([MACHUCVU], [TENCHUCVU], [MOTACHUCVU]) VALUES (1, N'Nhân viên', N'')
INSERT [dbo].[CHUCVU] ([MACHUCVU], [TENCHUCVU], [MOTACHUCVU]) VALUES (2, N'Quẩn lý', NULL)
SET IDENTITY_INSERT [dbo].[CHUCVU] OFF
GO
SET IDENTITY_INSERT [dbo].[GIAOCA] ON 

INSERT [dbo].[GIAOCA] ([MAGIAOCA], [TENCA], [THOIGIANBATDAU], [THOIGIANKETTHUC]) VALUES (1, N'Ca1', CAST(N'07:00:00' AS Time), CAST(N'15:00:00' AS Time))
INSERT [dbo].[GIAOCA] ([MAGIAOCA], [TENCA], [THOIGIANBATDAU], [THOIGIANKETTHUC]) VALUES (2, N'Ca2', CAST(N'15:00:00' AS Time), CAST(N'23:00:00' AS Time))
SET IDENTITY_INSERT [dbo].[GIAOCA] OFF
GO
SET IDENTITY_INSERT [dbo].[GIAY] ON 

INSERT [dbo].[GIAY] ([MAGIAY], [TENGIAY]) VALUES (3, N'Giày sneaker cổ thấp truyền thống')
INSERT [dbo].[GIAY] ([MAGIAY], [TENGIAY]) VALUES (4, N'Giày sneaker Nike Air Force 1 Low')
SET IDENTITY_INSERT [dbo].[GIAY] OFF
GO
SET IDENTITY_INSERT [dbo].[GIAYCHITIET] ON 

INSERT [dbo].[GIAYCHITIET] ([MAGIAYCHITIET], [MAGIAY], [MACHATLIEU], [MAMAUSAC], [MAKICHCO], [MATHUONGHIEU], [MAKIEUDANG], [SOLUONGCON], [NGAYTAO], [NGAYSUA], [NGUOITAO], [NGUOISUA], [GIA], [MOTA], [TRANGTHAI]) VALUES (4, 3, 2, 1, 1, 2, 1, 198, CAST(N'2023-12-03T18:10:11.877' AS DateTime), CAST(N'2023-12-03T18:10:11.877' AS DateTime), 1, 1, 2000, N'5', 1)
SET IDENTITY_INSERT [dbo].[GIAYCHITIET] OFF
GO
SET IDENTITY_INSERT [dbo].[HINHTHUCTHANHTOAN] ON 

INSERT [dbo].[HINHTHUCTHANHTOAN] ([MAHINHTHUCTHANHTOAN], [TENHINHTHUC], [MOTA]) VALUES (1, N'Chưa chọn hình thức thanh toán', NULL)
INSERT [dbo].[HINHTHUCTHANHTOAN] ([MAHINHTHUCTHANHTOAN], [TENHINHTHUC], [MOTA]) VALUES (2, N'Tiền mặt', N'Khách hàng trả bằng tiền mặt')
INSERT [dbo].[HINHTHUCTHANHTOAN] ([MAHINHTHUCTHANHTOAN], [TENHINHTHUC], [MOTA]) VALUES (3, N'Chuyển khoản', N'Thanh toán bằng cách chuyển tiền qua ngân hàng')
INSERT [dbo].[HINHTHUCTHANHTOAN] ([MAHINHTHUCTHANHTOAN], [TENHINHTHUC], [MOTA]) VALUES (4, N'Quẹt thẻ', N'Thanh toán bằng thẻ Visa hoặc ATM nội địa')
SET IDENTITY_INSERT [dbo].[HINHTHUCTHANHTOAN] OFF
GO
SET IDENTITY_INSERT [dbo].[HOADON] ON 

INSERT [dbo].[HOADON] ([MAHOADON], [MATAIKHOAN], [MAUUDAI], [MAKHACHHANG], [MAHINHTHUCTHANHTOAN], [TENCUAHANG], [DIACHICUAHANG], [SDTCUAHANG], [EMAILCUAHANG], [NGAYTAO], [TONGTIEN], [TRANGTHAI], [GHICHU]) VALUES (2, 1, 1, 1, 2, N'Cửa hàng bán giày sneaker', N'221 Phú Diễn, phường Phú Diễn, Quận Bắc Từ Liêm, Hà Nội', N'0358384108', N'vuongxuanha8@gmail.com', CAST(N'2023-12-03T20:04:20.180' AS DateTime), 4000, 1, N'khách đưa: 4000 - khách nhận: 0')
SET IDENTITY_INSERT [dbo].[HOADON] OFF
GO
SET IDENTITY_INSERT [dbo].[HOADONCHITIET] ON 

INSERT [dbo].[HOADONCHITIET] ([MAHOADONCHITIET], [MAGIAYCHITIET], [MAHOADON], [SOLUONGMUA], [GIA]) VALUES (1, 4, 2, 2, 4000)
SET IDENTITY_INSERT [dbo].[HOADONCHITIET] OFF
GO
SET IDENTITY_INSERT [dbo].[KICHCO] ON 

INSERT [dbo].[KICHCO] ([MAKICHCO], [TENKICHCO], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (1, N'Kích cỡ 36', N'Kích cỡ 36: Phù hợp với chiều dài bàn chân 23 cm.
', 1, 1)
INSERT [dbo].[KICHCO] ([MAKICHCO], [TENKICHCO], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (2, N'Kích cỡ 37', N'Phù hợp với chiều dài bàn chân 23.5 cm', 1, 1)
INSERT [dbo].[KICHCO] ([MAKICHCO], [TENKICHCO], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (3, N'Kích cỡ 38', N'Phù hợp với chiều dài bàn chân 24 cm', 1, 1)
INSERT [dbo].[KICHCO] ([MAKICHCO], [TENKICHCO], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (4, N'Kích cỡ 39', N'Phù hợp với chiều dài bàn chân 24.5 cm', 1, 1)
INSERT [dbo].[KICHCO] ([MAKICHCO], [TENKICHCO], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (5, N'Kích cỡ 40', N'Phù hợp với chiều dài bàn chân 25 cm', 1, 1)
INSERT [dbo].[KICHCO] ([MAKICHCO], [TENKICHCO], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (6, N'Kích cỡ 41', N'Phù hợp với chiều dài bàn chân 25.5 cm', 1, 1)
INSERT [dbo].[KICHCO] ([MAKICHCO], [TENKICHCO], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (7, N'Kích cỡ 42', N' Phù hợp với chiều dài bàn chân 26 cm.', 1, 1)
SET IDENTITY_INSERT [dbo].[KICHCO] OFF
GO
SET IDENTITY_INSERT [dbo].[KIEUDANG] ON 

INSERT [dbo].[KIEUDANG] ([MAKIEUDANG], [TENKIEUDANG], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (1, N'Low-Top Sneakers', N'Thấp, thường không lên quá mắt cá.
', 1, 1)
INSERT [dbo].[KIEUDANG] ([MAKIEUDANG], [TENKIEUDANG], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (2, N'High-Top Sneakers
', N'Cao, bao phủ mắt cá và mắt chân.
', 1, 1)
INSERT [dbo].[KIEUDANG] ([MAKIEUDANG], [TENKIEUDANG], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (3, N'Mid-Top Sneakers', N'Ở giữa giữa low-top và high-top, chủ yếu bao phủ mắt cá.
', 1, 1)
INSERT [dbo].[KIEUDANG] ([MAKIEUDANG], [TENKIEUDANG], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (4, N'Slip-On Sneakers', N'Không có dây buộc, có thể đeo thoải mái.
', 1, 1)
INSERT [dbo].[KIEUDANG] ([MAKIEUDANG], [TENKIEUDANG], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (5, N'Athletic Sneakers', N'Thiết kế cho hoạt động thể thao, như chạy, đạp xe, hoặc đi bộ.
', 1, 1)
INSERT [dbo].[KIEUDANG] ([MAKIEUDANG], [TENKIEUDANG], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (6, N'Skate Sneakers', N'Thiết kế chủ yếu cho việc đạp xe skateboard, thường có đế dày và chống trơn.
', 1, 1)
INSERT [dbo].[KIEUDANG] ([MAKIEUDANG], [TENKIEUDANG], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (7, N'Basketball Sneakers', N'Thiết kế cho cầu lông, có thể có đế cao và hỗ trợ mắt cá.
', 1, 1)
SET IDENTITY_INSERT [dbo].[KIEUDANG] OFF
GO
SET IDENTITY_INSERT [dbo].[KHACHHANG] ON 

INSERT [dbo].[KHACHHANG] ([MAKHACHHANG], [TENKHACHHANG], [SDT], [DIEMKHACHHANG], [TRANGTHAI]) VALUES (1, N'N/A', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[KHACHHANG] OFF
GO
SET IDENTITY_INSERT [dbo].[MAUSAC] ON 

INSERT [dbo].[MAUSAC] ([MAMAUSAC], [TENMAUSAC], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (1, N'Trắng', N'Trắng là một màu sắc phổ biến và dễ kết hợp, thường được sử dụng cho giày sneaker thể thao và lifestyle.
', 1, 1)
INSERT [dbo].[MAUSAC] ([MAMAUSAC], [TENMAUSAC], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (2, N'Đen', N'Đen là một màu sắc cổ điển và linh hoạt, phổ biến trong cả giày sneaker casual và formal.
', 1, 1)
INSERT [dbo].[MAUSAC] ([MAMAUSAC], [TENMAUSAC], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (3, N'Xám', N'Xám là một màu sắc trung tính, thường xuất hiện trong nhiều kiểu dáng giày sneaker.
', 1, 1)
INSERT [dbo].[MAUSAC] ([MAMAUSAC], [TENMAUSAC], [MOTA], [TRANGTHAI], [MATAIKHOAN]) VALUES (4, N'Đỏ', N'Đỏ thường được sử dụng để tạo điểm nhấn hoặc trong các mô hình thể thao năng động.
', 1, 1)
SET IDENTITY_INSERT [dbo].[MAUSAC] OFF
GO
SET IDENTITY_INSERT [dbo].[TAIKHOAN] ON 

INSERT [dbo].[TAIKHOAN] ([MATAIKHOAN], [USERNAME], [PASWORD], [HOVATEN], [GIOITINH], [SODIENTHOAI], [DIACHI], [EMAIL], [NGAYSINH], [NGAYTAOTAIKHOAN], [MACHUCVU], [TRANGTHAI]) VALUES (1, N'NV1', N'NV1', N'Nhân viên 1', 1, N'0123456789', N'Địa chỉ nhân viên 1', N'nhanvien1@gmail.com', CAST(N'2000-02-02' AS Date), CAST(N'2022-12-02' AS Date), 1, 1)
INSERT [dbo].[TAIKHOAN] ([MATAIKHOAN], [USERNAME], [PASWORD], [HOVATEN], [GIOITINH], [SODIENTHOAI], [DIACHI], [EMAIL], [NGAYSINH], [NGAYTAOTAIKHOAN], [MACHUCVU], [TRANGTHAI]) VALUES (4, N'QL1', N'QL1', N'Quản lý 1', 0, N'0987654321', N'Địa chỉ quản lý 1', N'quanly1@gmail.com', CAST(N'2002-02-02' AS Date), CAST(N'2022-02-02' AS Date), 2, 1)
SET IDENTITY_INSERT [dbo].[TAIKHOAN] OFF
GO
SET IDENTITY_INSERT [dbo].[THUONGHIEU] ON 

INSERT [dbo].[THUONGHIEU] ([MATHUONGHIEU], [TENTHUONGHIEU], [EMAIL], [SDT], [TRANGTHAI], [MOTA], [MATAIKHOAN]) VALUES (2, N'Nike', N'nike123@gmail.com', N'0123456789', 1, N'Thương hiệu giày thể thao lớn nhất thế giới, được thành lập vào năm 1964. Nike chuyên sản xuất các loại giày sneaker, trang phục thể thao, thiết bị thể thao,...', 1)
SET IDENTITY_INSERT [dbo].[THUONGHIEU] OFF
GO
SET IDENTITY_INSERT [dbo].[UUDAI] ON 

INSERT [dbo].[UUDAI] ([MAUUDAI], [TENUUDAI], [NGAYBATDAU], [NGAYKETTHUC], [PHANTRAM], [TRANGTHAI], [SOLUONG], [MATAIKHOAN]) VALUES (1, N'N/A', NULL, NULL, 0, 0, 0, 1)
SET IDENTITY_INSERT [dbo].[UUDAI] OFF
GO
ALTER TABLE [dbo].[BANGLUONG]  WITH CHECK ADD FOREIGN KEY([MATAIKHOAN])
REFERENCES [dbo].[TAIKHOAN] ([MATAIKHOAN])
GO
ALTER TABLE [dbo].[CHATLIEU]  WITH CHECK ADD FOREIGN KEY([MATAIKHOAN])
REFERENCES [dbo].[TAIKHOAN] ([MATAIKHOAN])
GO
ALTER TABLE [dbo].[GIAOCANHANVIEN]  WITH CHECK ADD FOREIGN KEY([MAGIAOCA])
REFERENCES [dbo].[GIAOCA] ([MAGIAOCA])
GO
ALTER TABLE [dbo].[GIAOCANHANVIEN]  WITH CHECK ADD FOREIGN KEY([MATAIKHOAN])
REFERENCES [dbo].[TAIKHOAN] ([MATAIKHOAN])
GO
ALTER TABLE [dbo].[GIAYCHITIET]  WITH CHECK ADD FOREIGN KEY([MACHATLIEU])
REFERENCES [dbo].[CHATLIEU] ([MACHATLIEU])
GO
ALTER TABLE [dbo].[GIAYCHITIET]  WITH CHECK ADD FOREIGN KEY([MAGIAY])
REFERENCES [dbo].[GIAY] ([MAGIAY])
GO
ALTER TABLE [dbo].[GIAYCHITIET]  WITH CHECK ADD FOREIGN KEY([MAKICHCO])
REFERENCES [dbo].[KICHCO] ([MAKICHCO])
GO
ALTER TABLE [dbo].[GIAYCHITIET]  WITH CHECK ADD FOREIGN KEY([MAKIEUDANG])
REFERENCES [dbo].[KIEUDANG] ([MAKIEUDANG])
GO
ALTER TABLE [dbo].[GIAYCHITIET]  WITH CHECK ADD FOREIGN KEY([MAMAUSAC])
REFERENCES [dbo].[MAUSAC] ([MAMAUSAC])
GO
ALTER TABLE [dbo].[GIAYCHITIET]  WITH CHECK ADD FOREIGN KEY([MATHUONGHIEU])
REFERENCES [dbo].[THUONGHIEU] ([MATHUONGHIEU])
GO
ALTER TABLE [dbo].[GIAYCHITIET]  WITH CHECK ADD FOREIGN KEY([NGUOITAO])
REFERENCES [dbo].[TAIKHOAN] ([MATAIKHOAN])
GO
ALTER TABLE [dbo].[GIAYCHITIET]  WITH CHECK ADD FOREIGN KEY([NGUOISUA])
REFERENCES [dbo].[TAIKHOAN] ([MATAIKHOAN])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MAHINHTHUCTHANHTOAN])
REFERENCES [dbo].[HINHTHUCTHANHTOAN] ([MAHINHTHUCTHANHTOAN])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MAKHACHHANG])
REFERENCES [dbo].[KHACHHANG] ([MAKHACHHANG])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MATAIKHOAN])
REFERENCES [dbo].[TAIKHOAN] ([MATAIKHOAN])
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD FOREIGN KEY([MAUUDAI])
REFERENCES [dbo].[UUDAI] ([MAUUDAI])
GO
ALTER TABLE [dbo].[HOADONCHITIET]  WITH CHECK ADD FOREIGN KEY([MAGIAYCHITIET])
REFERENCES [dbo].[GIAYCHITIET] ([MAGIAYCHITIET])
GO
ALTER TABLE [dbo].[HOADONCHITIET]  WITH CHECK ADD FOREIGN KEY([MAHOADON])
REFERENCES [dbo].[HOADON] ([MAHOADON])
GO
ALTER TABLE [dbo].[KICHCO]  WITH CHECK ADD FOREIGN KEY([MATAIKHOAN])
REFERENCES [dbo].[TAIKHOAN] ([MATAIKHOAN])
GO
ALTER TABLE [dbo].[KIEUDANG]  WITH CHECK ADD FOREIGN KEY([MATAIKHOAN])
REFERENCES [dbo].[TAIKHOAN] ([MATAIKHOAN])
GO
ALTER TABLE [dbo].[MAUSAC]  WITH CHECK ADD FOREIGN KEY([MATAIKHOAN])
REFERENCES [dbo].[TAIKHOAN] ([MATAIKHOAN])
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD FOREIGN KEY([MACHUCVU])
REFERENCES [dbo].[CHUCVU] ([MACHUCVU])
GO
ALTER TABLE [dbo].[THUONGHIEU]  WITH CHECK ADD FOREIGN KEY([MATAIKHOAN])
REFERENCES [dbo].[TAIKHOAN] ([MATAIKHOAN])
GO
ALTER TABLE [dbo].[UUDAI]  WITH CHECK ADD FOREIGN KEY([MATAIKHOAN])
REFERENCES [dbo].[TAIKHOAN] ([MATAIKHOAN])
GO
