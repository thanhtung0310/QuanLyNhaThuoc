
/****** Object:  UserDefinedFunction [dbo].[DOANHTHUNAM]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[DOANHTHUNAM](@date date)
returns int
as begin
	declare @year int = datepart(YEAR,@date)
	if not exists (select * from PHIEUXUAT where datepart(year,NgayXuat)=@year)
		return 0
	else
		declare @a int = 0 
		select @a = sum(Tong)
		from PHIEUXUAT
		where datepart(year,NgayXuat)=@year
		return @a
end

GO
/****** Object:  UserDefinedFunction [dbo].[DOANHTHUQUY]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[DOANHTHUQUY](@date date)
returns int
as begin
	declare @quarter int = datepart(q,@date)
	declare @year int = datepart(YEAR,@date)
	if not exists (select * from PHIEUXUAT where datepart(q,NgayXuat)=@quarter and datepart(year,NgayXuat)=@year)
		return 0
	else
		declare @a int = 0 
		select @a = sum(Tong)
		from PHIEUXUAT
		where datepart(q,NgayXuat)=@quarter and datepart(year,NgayXuat)=@year
		return @a
end

GO
/****** Object:  UserDefinedFunction [dbo].[DOANHTHUTHANG]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[DOANHTHUTHANG](@date date)
returns int
as begin
	declare @month int = datepart(MONTH,@date)
	declare @year int = datepart(YEAR,@date)
	if not exists (select * from PHIEUXUAT where datepart(month,NgayXuat)=@month and datepart(year,NgayXuat)=@year)
		return 0
	else
		declare @a int = 0 
		select @a = sum(Tong)
		from PHIEUXUAT
		where datepart(month,NgayXuat)=@month and datepart(year,NgayXuat)=@year
		return @a
end

GO
/****** Object:  UserDefinedFunction [dbo].[THUOCDABAN]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create FUNCTION [dbo].[THUOCDABAN](@MT char(20)) 
RETURNS INT
as begin
	if not exists (select * from CHITIETPHIEUXUAT where MaThuoc=@MT)
		return 0
	else
		declare @count int = 0
		select @count = SUM(SoLuong)
		from CHITIETPHIEUXUAT
		where MaThuoc=@MT
		return @count
end

GO
/****** Object:  Table [dbo].[CHITIETPHIEUNHAP]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUNHAP](
	[MaPhieuNhap] [char](20) NOT NULL,
	[MaThuoc] [char](20) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_CHITIETPHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC,
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CHITIETPHIEUXUAT]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CHITIETPHIEUXUAT](
	[MaPhieuXuat] [char](20) NOT NULL,
	[MaThuoc] [char](20) NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_CHITIETPHIEUXUAT] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC,
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HANGSANXUAT]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HANGSANXUAT](
	[MaHangSX] [char](15) NOT NULL,
	[TenHangSX] [nvarchar](50) NULL,
	[QuocGia] [nvarchar](30) NULL,
 CONSTRAINT [PK_HANGSANXUAT] PRIMARY KEY CLUSTERED 
(
	[MaHangSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[KHACHHANG]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[KHACHHANG](
	[MaKhachHang] [char](35) NOT NULL,
	[TenKhachHang] [nvarchar](40) NOT NULL,
	[SoDienThoai] [char](15) NOT NULL,
	[CMND/TCCCD] [nchar](12) NOT NULL,
 CONSTRAINT [PK_KHACHHANG] PRIMARY KEY CLUSTERED 
(
	[MaKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOAITHUOC]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOAITHUOC](
	[MaLoaiThuoc] [char](15) NOT NULL,
	[TenLoaiThuoc] [nvarchar](30) NULL,
 CONSTRAINT [PK_LOAITHUOC] PRIMARY KEY CLUSTERED 
(
	[MaLoaiThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LOTHUOC]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LOTHUOC](
	[MaLoThuoc] [char](15) NOT NULL,
	[MaHangSX] [char](15) NULL,
	[NgaySanXuat] [date] NULL,
	[HanSuDung] [date] NULL,
 CONSTRAINT [PK_LOTHUOC] PRIMARY KEY CLUSTERED 
(
	[MaLoThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHACUNGCAP]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHACUNGCAP](
	[MaNhaCungCap] [char](15) NOT NULL,
	[TenNhaCungCap] [nvarchar](30) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[ThongTinDaiDien] [nvarchar](50) NULL,
	[SoDienThoai] [char](11) NULL,
 CONSTRAINT [PK_NHACUNGCAP] PRIMARY KEY CLUSTERED 
(
	[MaNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNhanVien] [char](15) NOT NULL,
	[TenNhanVien] [nvarchar](40) NULL,
	[SoDienThoai] [char](20) NULL,
	[CMND/TCCCD] [nchar](12) NULL,
	[username] [char](50) NULL,
	[password] [char](50) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MaNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUNHAP]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUNHAP](
	[MaPhieuNhap] [char](20) NOT NULL,
	[NgayNhap] [date] NULL,
	[MaNhaCungCap] [char](15) NULL,
	[MaNhanVien] [char](15) NULL,
 CONSTRAINT [PK_PHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MaPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PHIEUXUAT]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PHIEUXUAT](
	[MaPhieuXuat] [char](20) NOT NULL,
	[NgayXuat] [date] NULL,
	[MaKhachHang] [char](35) NULL,
	[MaNhanVien] [char](15) NULL,
	[Tong] [int] NULL,
 CONSTRAINT [PK_PHIEUXUAT] PRIMARY KEY CLUSTERED 
(
	[MaPhieuXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[THUOC]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[THUOC](
	[MaThuoc] [char](20) NOT NULL,
	[MaLoThuoc] [char](15) NOT NULL,
	[TenThuoc] [nvarchar](max) NOT NULL,
	[CongDung] [nvarchar](max) NOT NULL,
	[ThanhPhan] [nvarchar](max) NOT NULL,
	[SoLuongTon] [int] NOT NULL,
	[DangThuoc] [nvarchar](20) NOT NULL,
	[MaLoaiThuoc] [char](15) NOT NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_THUOC] PRIMARY KEY CLUSTERED 
(
	[MaThuoc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[func_Thuoc]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_Thuoc] (@thang nchar(2))
returns table
as return 
(SELECT LOTHUOC.MaLoThuoc,TenThuoc,SoLuong
FROM THUOC,LOTHUOC,CHITIETPHIEUNHAP,PHIEUNHAP
WHERE THUOC.MaLoThuoc=LOTHUOC.MaLoThuoc
AND THUOC.MaThuoc=CHITIETPHIEUNHAP.MaThuoc
AND PHIEUNHAP.MaPhieuNhap=CHITIETPHIEUNHAP.MaPhieuNhap
AND MONTH(NgayNhap)=@thang
)

GO
/****** Object:  UserDefinedFunction [dbo].[func_XemGia]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[func_XemGia](@price1 char(10), @price2 char(10))
RETURNS TABLE AS RETURN
(
SELECT TenThuoc, CHITIETPHIEUNHAP.DonGia+CHITIETPHIEUNHAP.DonGia*0.2 as GiaTien
FROM THUOC,CHITIETPHIEUNHAP
WHERE THUOC.MaThuoc=CHITIETPHIEUNHAP.MaThuoc
AND CHITIETPHIEUNHAP.DonGia+CHITIETPHIEUNHAP.DonGia*0.2 BETWEEN @price1 AND @price2
)

GO
/****** Object:  UserDefinedFunction [dbo].[func_XemThuoc]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--7. Viết hàm đưa ra thuốc thuộc từng loại thuốc
CREATE FUNCTION [dbo].[func_XemThuoc](@maloai char(30))
RETURNS TABLE AS RETURN 
(
SELECT TenThuoc,CongDung
FROM THUOC,LOAITHUOC
WHERE THUOC.MaLoaiThuoc=LOAITHUOC.MaLoaiThuoc
AND LOAITHUOC.MaLoaiThuoc=@maloai
)

GO
/****** Object:  View [dbo].[HoaDon_VIEW]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[HoaDon_VIEW] AS
SELECT PHIEUXUAT.MaPhieuXuat,TenKhachHang,TenThuoc,TenNhanVien,SoLuong,CHITIETPHIEUXUAT.DonGia,SUM(SoLuong*CHITIETPHIEUXUAT.DonGia) 'ThanhTien'
FROM KHACHHANG,THUOC,CHITIETPHIEUXUAT,PHIEUXUAT,NHANVIEN
WHERE KHACHHANG.MaKhachHang=PHIEUXUAT.MaKhachHang
AND THUOC.MaThuoc=CHITIETPHIEUXUAT.MaThuoc
AND NHANVIEN.MaNhanVien=PHIEUXUAT.MaNhanVien
AND KHACHHANG.MaKhachHang = '0310990054830368732033'
GROUP BY TenKhachHang,TenThuoc,TenNhanVien,SoLuong,CHITIETPHIEUXUAT.DonGia,PHIEUXUAT.MaPhieuXuat

GO
/****** Object:  View [dbo].[HoaDonXuat]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[HoaDonXuat] AS
SELECT NHANVIEN.MaNhanVien, SoLuong*DonGia 'Doanh Thu'
FROM CHITIETPHIEUXUAT,NHANVIEN,PHIEUXUAT
WHERE CHITIETPHIEUXUAT.MaPhieuXuat=PHIEUXUAT.MaPhieuXuat
AND NHANVIEN.MaNhanVien=PHIEUXUAT.MaNhanVien

GO
/****** Object:  View [dbo].[HoaDonXuat_VIEW]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[HoaDonXuat_VIEW] AS
SELECT NHANVIEN.MaNhanVien, SoLuong*DonGia as 'DoanhThu'
FROM CHITIETPHIEUXUAT,NHANVIEN,PHIEUXUAT
WHERE CHITIETPHIEUXUAT.MaPhieuXuat=PHIEUXUAT.MaPhieuXuat
AND NHANVIEN.MaNhanVien=PHIEUXUAT.MaNhanVien

GO
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaThuoc], [SoLuong], [DonGia]) VALUES (N'13032020031099343454', N'DPSD0220.TTY.ACM1   ', 1300, 35000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaThuoc], [SoLuong], [DonGia]) VALUES (N'20122019031023324234', N'AT670218.TTY.DCT5   ', 5000, 50000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaThuoc], [SoLuong], [DonGia]) VALUES (N'20122019031023324234', N'DPDC0818.TTY.PTU    ', 3000, 100000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaThuoc], [SoLuong], [DonGia]) VALUES (N'20122019031055765565', N'DPHL1118.TTY.ABC    ', 1600, 50000)
INSERT [dbo].[CHITIETPHIEUNHAP] ([MaPhieuNhap], [MaThuoc], [SoLuong], [DonGia]) VALUES (N'21122019031099005436', N'DPPM0120.TTY.PCTM   ', 2500, 60000)
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaPhieuXuat], [MaThuoc], [SoLuong], [DonGia]) VALUES (N'080320200368732033  ', N'DPPM0120.TTY.PCTM   ', 2, 60000)
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaPhieuXuat], [MaThuoc], [SoLuong], [DonGia]) VALUES (N'090320200345454543  ', N'AT670218.TTY.DCT5   ', 2, 50000)
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaPhieuXuat], [MaThuoc], [SoLuong], [DonGia]) VALUES (N'100320200359999574  ', N'AT670218.TTY.DCT5   ', 1, 50000)
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaPhieuXuat], [MaThuoc], [SoLuong], [DonGia]) VALUES (N'100320200359999574  ', N'BG5T0519.TDY.CSR    ', 1, 50000)
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaPhieuXuat], [MaThuoc], [SoLuong], [DonGia]) VALUES (N'110320200368733032  ', N'BG5T0519.TDY.CSR    ', 1, 50000)
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaPhieuXuat], [MaThuoc], [SoLuong], [DonGia]) VALUES (N'110320200368733032  ', N'DPDC0818.TTY.PTU    ', 1, 100000)
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaPhieuXuat], [MaThuoc], [SoLuong], [DonGia]) VALUES (N'120320200356879565  ', N'AT670218.TTY.DCT5   ', 1, 50000)
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaPhieuXuat], [MaThuoc], [SoLuong], [DonGia]) VALUES (N'120320200356879565  ', N'BG5T0519.TDY.CSR    ', 1, 50000)
INSERT [dbo].[CHITIETPHIEUXUAT] ([MaPhieuXuat], [MaThuoc], [SoLuong], [DonGia]) VALUES (N'150320200433433443  ', N'BG5T0519.TDY.CSR    ', 1, 50000)
INSERT [dbo].[HANGSANXUAT] ([MaHangSX], [TenHangSX], [QuocGia]) VALUES (N'AT67           ', N'Công ty DP Armephaco', N'Việt Nam')
INSERT [dbo].[HANGSANXUAT] ([MaHangSX], [TenHangSX], [QuocGia]) VALUES (N'BG5T           ', N'Công ty DP Traphaco', N'Việt Nam')
INSERT [dbo].[HANGSANXUAT] ([MaHangSX], [TenHangSX], [QuocGia]) VALUES (N'DPDC           ', N'Công ty DP Davinci', N'Pháp')
INSERT [dbo].[HANGSANXUAT] ([MaHangSX], [TenHangSX], [QuocGia]) VALUES (N'DPPM           ', N'Công ty DP Pharmedic', N'Việt Nam')
INSERT [dbo].[HANGSANXUAT] ([MaHangSX], [TenHangSX], [QuocGia]) VALUES (N'DPSD           ', N'Công ty DP Shinpoong Daewoo', N'Hàn Quốc')
INSERT [dbo].[HANGSANXUAT] ([MaHangSX], [TenHangSX], [QuocGia]) VALUES (N'DPHL           ', N'Công ty DP Hoa Linh', N'Việt Nam')
INSERT [dbo].[HANGSANXUAT] ([MaHangSX], [TenHangSX], [QuocGia]) VALUES (N'MTV            ', N'Một thành viên', N'Việt Nam')
INSERT [dbo].[HANGSANXUAT] ([MaHangSX], [TenHangSX], [QuocGia]) VALUES (N'NTP            ', N'Nam Thiên Phú', N'Việt Nam')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [CMND/TCCCD]) VALUES (N'0310566549870356879565             ', N'Nguyễn Văn Dũng', N'0356879565     ', N'031056654987')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [CMND/TCCCD]) VALUES (N'0310990054320359999574             ', N'Hoàng Văn Việt', N'0359999574     ', N'031099005432')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [CMND/TCCCD]) VALUES (N'0310990054380368733032             ', N'Phan Thanh Tùng', N'0368733032     ', N'031099005438')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [CMND/TCCCD]) VALUES (N'0310990054830368732033             ', N'Lỗ Trung Hiếu', N'0368732033     ', N'031099005483')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [CMND/TCCCD]) VALUES (N'0312347659870345454543             ', N'Nguyễn Thị Chi', N'0345454543     ', N'031234765987')
INSERT [dbo].[KHACHHANG] ([MaKhachHang], [TenKhachHang], [SoDienThoai], [CMND/TCCCD]) VALUES (N'0433433443031456433434             ', N'Nguyễn Tiến Mạnh', N'0433433443     ', N'031456433434')
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc]) VALUES (N'TDY            ', N'Thuốc Đông Y')
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc]) VALUES (N'TKS            ', N'Thuốc Kháng Sinh')
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc]) VALUES (N'TNY            ', N'Thuốc Nam Y')
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc]) VALUES (N'TPCN           ', N'Thực Phẩm Chức Năng')
INSERT [dbo].[LOAITHUOC] ([MaLoaiThuoc], [TenLoaiThuoc]) VALUES (N'TTY            ', N'Thuốc Tây Y')
INSERT [dbo].[LOTHUOC] ([MaLoThuoc], [MaHangSX], [NgaySanXuat], [HanSuDung]) VALUES (N'AT67.06200     ', N'AT67           ', CAST(N'2020-06-03' AS Date), CAST(N'2022-06-03' AS Date))
INSERT [dbo].[LOTHUOC] ([MaLoThuoc], [MaHangSX], [NgaySanXuat], [HanSuDung]) VALUES (N'AT67.06201     ', N'AT67           ', CAST(N'2020-06-03' AS Date), CAST(N'2022-06-03' AS Date))
INSERT [dbo].[LOTHUOC] ([MaLoThuoc], [MaHangSX], [NgaySanXuat], [HanSuDung]) VALUES (N'AT67.06202     ', N'AT67           ', CAST(N'2020-06-03' AS Date), CAST(N'2022-06-03' AS Date))
INSERT [dbo].[LOTHUOC] ([MaLoThuoc], [MaHangSX], [NgaySanXuat], [HanSuDung]) VALUES (N'AT67.06203     ', N'AT67           ', CAST(N'2020-06-03' AS Date), CAST(N'2022-06-03' AS Date))
INSERT [dbo].[LOTHUOC] ([MaLoThuoc], [MaHangSX], [NgaySanXuat], [HanSuDung]) VALUES (N'AT67.06204     ', N'AT67           ', CAST(N'2020-06-03' AS Date), CAST(N'2022-06-03' AS Date))
INSERT [dbo].[LOTHUOC] ([MaLoThuoc], [MaHangSX], [NgaySanXuat], [HanSuDung]) VALUES (N'AT67.06205     ', N'AT67           ', CAST(N'2020-06-03' AS Date), CAST(N'2022-06-03' AS Date))
INSERT [dbo].[LOTHUOC] ([MaLoThuoc], [MaHangSX], [NgaySanXuat], [HanSuDung]) VALUES (N'AT670218       ', N'AT67           ', CAST(N'2018-02-18' AS Date), CAST(N'2023-02-18' AS Date))
INSERT [dbo].[LOTHUOC] ([MaLoThuoc], [MaHangSX], [NgaySanXuat], [HanSuDung]) VALUES (N'BG5T.0620      ', N'BG5T           ', CAST(N'2020-06-03' AS Date), CAST(N'2022-06-03' AS Date))
INSERT [dbo].[LOTHUOC] ([MaLoThuoc], [MaHangSX], [NgaySanXuat], [HanSuDung]) VALUES (N'BG5T0519       ', N'BG5T           ', CAST(N'2019-05-10' AS Date), CAST(N'2022-05-10' AS Date))
INSERT [dbo].[LOTHUOC] ([MaLoThuoc], [MaHangSX], [NgaySanXuat], [HanSuDung]) VALUES (N'DPDC.0620      ', N'DPDC           ', CAST(N'2020-06-03' AS Date), CAST(N'2022-06-03' AS Date))
INSERT [dbo].[LOTHUOC] ([MaLoThuoc], [MaHangSX], [NgaySanXuat], [HanSuDung]) VALUES (N'DPDC0818       ', N'DPDC           ', CAST(N'2018-08-30' AS Date), CAST(N'2023-08-30' AS Date))
INSERT [dbo].[LOTHUOC] ([MaLoThuoc], [MaHangSX], [NgaySanXuat], [HanSuDung]) VALUES (N'DPPM0120       ', N'DPPM           ', CAST(N'2020-01-11' AS Date), CAST(N'2023-01-11' AS Date))
INSERT [dbo].[LOTHUOC] ([MaLoThuoc], [MaHangSX], [NgaySanXuat], [HanSuDung]) VALUES (N'DPSD0220       ', N'DPSD           ', CAST(N'2020-02-21' AS Date), CAST(N'2024-02-21' AS Date))
INSERT [dbo].[LOTHUOC] ([MaLoThuoc], [MaHangSX], [NgaySanXuat], [HanSuDung]) VALUES (N'DPHL.0620      ', N'DPHL           ', CAST(N'2020-06-03' AS Date), CAST(N'2021-06-03' AS Date))
INSERT [dbo].[LOTHUOC] ([MaLoThuoc], [MaHangSX], [NgaySanXuat], [HanSuDung]) VALUES (N'DPHL1118       ', N'DPHL           ', CAST(N'2018-11-15' AS Date), CAST(N'2022-11-15' AS Date))
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [ThongTinDaiDien], [SoDienThoai]) VALUES (N'NCC1           ', N'CTY PP Ngô Phong', N'Ngô Hồng Phong', N'Hoàng Mai - Hà Nội', N'0123456788 ')
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [ThongTinDaiDien], [SoDienThoai]) VALUES (N'NCC2           ', N'CTY TNHH Downstair', N'Hai Bà Trưng - Hà Nội', N'Nguyễn Kiều Anh', N'0123456789 ')
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [ThongTinDaiDien], [SoDienThoai]) VALUES (N'NCC3           ', N'CTY PP Duy Anh', N'Chí Linh - Hải Dương', N'Phạm Công Anh', N'0123456789 ')
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [ThongTinDaiDien], [SoDienThoai]) VALUES (N'NCC4           ', N'CTY TNHH Hải Lam', N'Hưng Hà - Thái Bình', N'Nguyễn Văn Công', N'0123456789 ')
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [ThongTinDaiDien], [SoDienThoai]) VALUES (N'NCC5           ', N'CTY PP Wefor', N'Hoàn Kiếm - Hà Nội', N'Đào Duy Anh', N'0123456789 ')
INSERT [dbo].[NHACUNGCAP] ([MaNhaCungCap], [TenNhaCungCap], [DiaChi], [ThongTinDaiDien], [SoDienThoai]) VALUES (N'NCC6           ', N'CTY PP Gamma', N'Hai Bà Trưng - Hà Nội', N'Vũ Trọng Luận', N'0123456789 ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [SoDienThoai], [CMND/TCCCD], [username], [password]) VALUES (N'031023324234   ', N'Phạm Thị Anh', N'0375564555          ', N'031023324234', N'phamanh                                           ', N'A0B26016D05636CE808890D8AF1403BD                  ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [SoDienThoai], [CMND/TCCCD], [username], [password]) VALUES (N'031055765565   ', N'Nguyễn Thiên Anh', N'0365454544          ', N'031055765565', N'thienan                                           ', N'A0B26016D05636CE808890D8AF1403BD                  ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [SoDienThoai], [CMND/TCCCD], [username], [password]) VALUES (N'031099005436   ', N'Nguyễn Văn Toàn', N'0356784543          ', N'031099005436', N'vantoan                                           ', N'A0B26016D05636CE808890D8AF1403BD                  ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [SoDienThoai], [CMND/TCCCD], [username], [password]) VALUES (N'031099023897   ', N'Trần Tuấn Anh', N'0375656546          ', N'031099023897', N'tuananh                                           ', N'A0B26016D05636CE808890D8AF1403BD                  ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [SoDienThoai], [CMND/TCCCD], [username], [password]) VALUES (N'031099032765   ', N'Phạm Minh Tuấn', N'0563984533          ', N'031099032765', N'minhtuan                                          ', N'A0B26016D05636CE808890D8AF1403BD                  ')
INSERT [dbo].[NHANVIEN] ([MaNhanVien], [TenNhanVien], [SoDienThoai], [CMND/TCCCD], [username], [password]) VALUES (N'031099343454   ', N'Nguyễn Hoài Thu', N'0324345343          ', N'031099343454', N'hoaithu                                           ', N'A0B26016D05636CE808890D8AF1403BD                  ')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien]) VALUES (N'03062020031099343454', CAST(N'2020-06-03' AS Date), N'NCC1           ', N'031099343454   ')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien]) VALUES (N'030620201445        ', CAST(N'2020-06-03' AS Date), N'NCC1           ', N'031099343454   ')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien]) VALUES (N'030620201530        ', CAST(N'2020-06-03' AS Date), N'NCC2           ', N'031099343454   ')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien]) VALUES (N'030620201532        ', CAST(N'2020-06-03' AS Date), N'NCC2           ', N'031099343454   ')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien]) VALUES (N'03062020153438      ', CAST(N'2020-06-03' AS Date), N'NCC1           ', N'031099343454   ')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien]) VALUES (N'03062020153440      ', CAST(N'2020-06-03' AS Date), N'NCC1           ', N'031099343454   ')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien]) VALUES (N'12032020031099023897', CAST(N'2020-03-12' AS Date), N'NCC4           ', N'031099023897   ')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien]) VALUES (N'13032020031099032765', CAST(N'2020-03-13' AS Date), N'NCC5           ', N'031099032765   ')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien]) VALUES (N'13032020031099343454', CAST(N'2020-03-13' AS Date), N'NCC6           ', N'031099343454   ')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien]) VALUES (N'20122019031023324234', CAST(N'2019-12-20' AS Date), N'NCC1           ', N'031023324234   ')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien]) VALUES (N'20122019031055765565', CAST(N'2019-12-20' AS Date), N'NCC1           ', N'031055765565   ')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien]) VALUES (N'21122019031099005436', CAST(N'2019-12-21' AS Date), N'NCC2           ', N'031099005436   ')
INSERT [dbo].[PHIEUNHAP] ([MaPhieuNhap], [NgayNhap], [MaNhaCungCap], [MaNhanVien]) VALUES (N'21122019031099023897', CAST(N'2019-12-21' AS Date), N'NCC3           ', N'031099023897   ')
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayXuat], [MaKhachHang], [MaNhanVien], [Tong]) VALUES (N'080320200368732033  ', CAST(N'2020-03-08' AS Date), N'0310990054830368732033             ', N'031099023897   ', 120000)
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayXuat], [MaKhachHang], [MaNhanVien], [Tong]) VALUES (N'090320200345454543  ', CAST(N'2020-03-10' AS Date), N'0312347659870345454543             ', N'031099032765   ', 100000)
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayXuat], [MaKhachHang], [MaNhanVien], [Tong]) VALUES (N'100320200359999574  ', CAST(N'2020-03-10' AS Date), N'0310990054320359999574             ', N'031055765565   ', 100000)
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayXuat], [MaKhachHang], [MaNhanVien], [Tong]) VALUES (N'110320200368733032  ', CAST(N'2020-03-11' AS Date), N'0310990054380368733032             ', N'031099005436   ', 150000)
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayXuat], [MaKhachHang], [MaNhanVien], [Tong]) VALUES (N'120320200356879565  ', CAST(N'2020-03-12' AS Date), N'0310566549870356879565             ', N'031023324234   ', 50000)
INSERT [dbo].[PHIEUXUAT] ([MaPhieuXuat], [NgayXuat], [MaKhachHang], [MaNhanVien], [Tong]) VALUES (N'150320200433433443  ', CAST(N'2020-03-15' AS Date), N'0433433443031456433434             ', N'031099343454   ', 50000)
INSERT [dbo].[THUOC] ([MaThuoc], [MaLoThuoc], [TenThuoc], [CongDung], [ThanhPhan], [SoLuongTon], [DangThuoc], [MaLoaiThuoc], [DonGia]) VALUES (N'AT670218.TTY.DCT5   ', N'AT670218       ', N'D-Contresin 500', N'Chống đau lưng, vẹo cổ', N'Mephenesin', 1297, N'Viên nén', N'TTY            ', 10000)
INSERT [dbo].[THUOC] ([MaThuoc], [MaLoThuoc], [TenThuoc], [CongDung], [ThanhPhan], [SoLuongTon], [DangThuoc], [MaLoaiThuoc], [DonGia]) VALUES (N'BG5T0519.TDY.CSR    ', N'BG5T0519       ', N'Casoran', N'Thuốc hạ huyết áp', N'Cao hoa hòe, Cao dừa cạn, Cao tâm sen, Cao cúc hoa', 1296, N'Thuốc cốm', N'TDY            ', 24000)
INSERT [dbo].[THUOC] ([MaThuoc], [MaLoThuoc], [TenThuoc], [CongDung], [ThanhPhan], [SoLuongTon], [DangThuoc], [MaLoaiThuoc], [DonGia]) VALUES (N'DPDC0818.TTY.PTU    ', N'DPDC0818       ', N'PTU Thepharm', N'ức chế tổng hợp hormon tuyến giáp', N'Propylthiouracil', 1299, N'Viên nén', N'TTY            ', 56000)
INSERT [dbo].[THUOC] ([MaThuoc], [MaLoThuoc], [TenThuoc], [CongDung], [ThanhPhan], [SoLuongTon], [DangThuoc], [MaLoaiThuoc], [DonGia]) VALUES (N'DPPM0120.TTY.PCTM   ', N'DPPM0120       ', N'PARACETAMOL 500 mg', N'Hạ sốt', N'Paracetamol', 1299, N'Viên nén', N'TTY            ', 30000)
INSERT [dbo].[THUOC] ([MaThuoc], [MaLoThuoc], [TenThuoc], [CongDung], [ThanhPhan], [SoLuongTon], [DangThuoc], [MaLoaiThuoc], [DonGia]) VALUES (N'DPSD0220.TTY.ACM1   ', N'DPSD0220       ', N'ACM Control 1', N'Dùng trong bệnh tim', N'Acenocoumarol', 720, N'Viên nén', N'TTY            ', 40000)
INSERT [dbo].[THUOC] ([MaThuoc], [MaLoThuoc], [TenThuoc], [CongDung], [ThanhPhan], [SoLuongTon], [DangThuoc], [MaLoaiThuoc], [DonGia]) VALUES (N'DPHL1118.TTY.ABC    ', N'DPHL1118       ', N'Abicin 250', N'Tác dụng kháng sinh', N'Amikacin', 1599, N'Bột pha tiêm', N'TTY            ', 72000)
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAP_PHIEUNHAP] FOREIGN KEY([MaPhieuNhap])
REFERENCES [dbo].[PHIEUNHAP] ([MaPhieuNhap])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAP_PHIEUNHAP]
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUNHAP_THUOC] FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[THUOC] ([MaThuoc])
GO
ALTER TABLE [dbo].[CHITIETPHIEUNHAP] CHECK CONSTRAINT [FK_CHITIETPHIEUNHAP_THUOC]
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUXUAT_PHIEUXUAT] FOREIGN KEY([MaPhieuXuat])
REFERENCES [dbo].[PHIEUXUAT] ([MaPhieuXuat])
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT] CHECK CONSTRAINT [FK_CHITIETPHIEUXUAT_PHIEUXUAT]
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_CHITIETPHIEUXUAT_THUOC] FOREIGN KEY([MaThuoc])
REFERENCES [dbo].[THUOC] ([MaThuoc])
GO
ALTER TABLE [dbo].[CHITIETPHIEUXUAT] CHECK CONSTRAINT [FK_CHITIETPHIEUXUAT_THUOC]
GO
ALTER TABLE [dbo].[LOTHUOC]  WITH CHECK ADD  CONSTRAINT [FK_LOTHUOC_HANGSANXUAT] FOREIGN KEY([MaHangSX])
REFERENCES [dbo].[HANGSANXUAT] ([MaHangSX])
GO
ALTER TABLE [dbo].[LOTHUOC] CHECK CONSTRAINT [FK_LOTHUOC_HANGSANXUAT]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP] FOREIGN KEY([MaNhaCungCap])
REFERENCES [dbo].[NHACUNGCAP] ([MaNhaCungCap])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHACUNGCAP]
GO
ALTER TABLE [dbo].[PHIEUNHAP]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUNHAP_NHANVIEN] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUNHAP] CHECK CONSTRAINT [FK_PHIEUNHAP_NHANVIEN]
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUAT_KHACHHANG] FOREIGN KEY([MaKhachHang])
REFERENCES [dbo].[KHACHHANG] ([MaKhachHang])
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [FK_PHIEUXUAT_KHACHHANG]
GO
ALTER TABLE [dbo].[PHIEUXUAT]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUXUAT_NHANVIEN] FOREIGN KEY([MaNhanVien])
REFERENCES [dbo].[NHANVIEN] ([MaNhanVien])
GO
ALTER TABLE [dbo].[PHIEUXUAT] CHECK CONSTRAINT [FK_PHIEUXUAT_NHANVIEN]
GO
ALTER TABLE [dbo].[THUOC]  WITH CHECK ADD  CONSTRAINT [FK_THUOC_LOAITHUOC] FOREIGN KEY([MaLoaiThuoc])
REFERENCES [dbo].[LOAITHUOC] ([MaLoaiThuoc])
GO
ALTER TABLE [dbo].[THUOC] CHECK CONSTRAINT [FK_THUOC_LOAITHUOC]
GO
ALTER TABLE [dbo].[THUOC]  WITH CHECK ADD  CONSTRAINT [FK_THUOC_LOTHUOC] FOREIGN KEY([MaLoThuoc])
REFERENCES [dbo].[LOTHUOC] ([MaLoThuoc])
GO
ALTER TABLE [dbo].[THUOC] CHECK CONSTRAINT [FK_THUOC_LOTHUOC]
GO
/****** Object:  StoredProcedure [dbo].[DTNam]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DTNam] (@ngay date)
as begin
	select DISTINCT YEAR(@ngay) as N'Năm',dbo.DOANHTHUNAM(@ngay) as N'Doanh thu'
	from PHIEUXUAT 
end

GO
/****** Object:  StoredProcedure [dbo].[DTQuy]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DTQuy]
as begin
	select DISTINCT datepart(q,NgayXuat) as N'Quý', YEAR(NgayXuat) as N'Năm',dbo.DOANHTHUNAM(NgayXuat) as N'Doanh thu'
	from PHIEUXUAT
end

GO
/****** Object:  StoredProcedure [dbo].[DTThang]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[DTThang](@ngay date)
as begin
	select DISTINCT MONTH(@ngay) as N'Tháng',YEAR(@ngay) as N'Năm',dbo.DOANHTHUTHANG(@ngay) as N'Doanh Thu'
	from PHIEUXUAT
end

GO
/****** Object:  StoredProcedure [dbo].[DTThang0]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DTThang0]
as begin
	select DISTINCT MONTH(NgayXuat) as N'Tháng',YEAR(NgayXuat) as N'Năm',dbo.DOANHTHUTHANG(NgayXuat) as N'Doanh Thu' 
	from PHIEUXUAT
end
GO
/****** Object:  StoredProcedure [dbo].[proc_addCTPX]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_addCTPX]
	@mpx char(20),
	@maT char(20),
	@sl int,
	@gia int
as begin
	insert into dbo.CHITIETPHIEUXUAT
			(MaPhieuXuat,MaThuoc,SoLuong,DonGia)
	values(@mpx,@maT,@sl,@gia)
end
GO
/****** Object:  StoredProcedure [dbo].[proc_addHSX]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_addHSX]
	@ma char(30),
	@ten char(40),
	@quocgia char(20)
as begin
	insert into dbo.HANGSANXUAT
			(MaHangSX,TenHangSX,QuocGia)
	values(@ma,@ten,@quocgia)
end

GO
/****** Object:  StoredProcedure [dbo].[proc_addKH]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_addKH]
	@ten nvarchar(40),
	@sdt char(15),
	@cmnd char(12)
as begin
	declare @makh char(35)
	set @makh=stuff(rtrim(@sdt),6,0,@cmnd)
	insert into dbo.KHACHHANG
			(MaKhachHang,TenKhachHang,SoDienThoai,[CMND/TCCCD])
	values(@makh,@ten,@sdt,@cmnd)
end

GO
/****** Object:  StoredProcedure [dbo].[proc_addLoaiT]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_addLoaiT]
	@maL char(15),
	@ten nvarchar(30)
as begin
	insert into dbo.LOAITHUOC
			(MaLoaiThuoc,TenLoaiThuoc)
	values(@maL,@ten)
end

GO
/****** Object:  StoredProcedure [dbo].[proc_addNCC]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_addNCC]
	@ma char(15),
	@ten nvarchar(30),
	@diachi nvarchar(50),
	@tt nvarchar(50),
	@sdt nchar(11)
as begin
	insert into dbo.NHACUNGCAP
			(MaNhaCungCap,TenNhaCungCap,DiaChi,ThongTinDaiDien,SoDienThoai)
	values(@ma,@ten,@diachi,@tt,@sdt)
end

GO
/****** Object:  StoredProcedure [dbo].[proc_addNV]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_addNV]
	@ten nvarchar(40),
	@sdt char(20),
	@cmnd char(12)
as begin
	insert into dbo.NHANVIEN
			(MaNhanVien,TenNhanVien,SoDienThoai,[CMND/TCCCD])
	values(@cmnd,@ten,@sdt,@cmnd)
end

GO
/****** Object:  StoredProcedure [dbo].[proc_addPN]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_addPN]
	@date date,
	@mncc char(15),
	@mnv char(15)
as begin
	declare @mpn char(20)
	set @mpn=replace(convert(varchar, getdate(),103),'/','') + left(replace(convert(varchar, getdate(),108),':',''),4)
	insert into dbo.PHIEUNHAP
			(MaPhieuNhap,NgayNhap,MaNhaCungCap,MaNhanVien)
	values(@mpn,@date,@mncc,@mnv)
end
GO
/****** Object:  StoredProcedure [dbo].[proc_addPX]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_addPX]
	@date date,
	@mkh char(35),
	@mnv char(15),
	@tong int
as begin
	declare @mpx char(20)
	declare @sdt char(15)
	if not exists (select * from KHACHHANG where MaKhachHang=@mkh)
	begin
		print N'Mã khách hàng không hợp lệ'
		return
	end
	else if not exists (select * from NHANVIEN where MaNhanVien=@mnv)
	begin
		print N'Mã nhân viên không hợp lệ'
		return
	end
	else
	begin
		set @mpx=replace(convert(varchar, getdate(),103),'/','') + left(replace(convert(varchar, getdate(),108),':',''),4)
		insert into dbo.PHIEUXUAT
				(MaPhieuXuat,NgayXuat,MaKhachHang,MaNhanVien,Tong)
		values(@mpx,@date,@mkh,@mnv,@tong)
	end
end
GO
/****** Object:  StoredProcedure [dbo].[proc_addThuoc]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_addThuoc]
	@maT char(20),
	@mahang char(15),
	@nsx date,
	@hsd date,
	@ten nvarchar(max),
	@cd nvarchar(max),
	@tp nvarchar(max),
	@sl int,
	@dang nvarchar(20),
	@mLoai char(15),
	@date date,
	@mncc char(15),
	@mnv char(15),
	@gia int
as begin
	declare @maThuoc char(20)
	declare @maLo char(15)

	declare @count int
	set @count = (select count(MaHangSX) from LOTHUOC
	where MaHangSX=@mahang and NgaySanXuat=@nsx)
	set @maLo = rtrim(@mahang) +'.'+ RIGHT('00' + RTRIM(CAST(MONTH(@nsx) AS varchar(2))),2)+Right(Year(@nsx),2)+cast(@count as char)
	set @maThuoc= rtrim(@maLo)+'.'+rtrim(@mLoai)+'.'+rtrim(@maT)
	insert into dbo.LOTHUOC
				(MaLoThuoc,MaHangSX,NgaySanXuat,HanSuDung)
		values(@maLo,@mahang,@nsx,@hsd)
	insert into dbo.THUOC
			(MaThuoc,MaLoThuoc,TenThuoc,CongDung,ThanhPhan,SoLuongTon,DangThuoc,MaLoaiThuoc,DonGia)
	values(@maThuoc,@maLo,@ten,@cd,@tp,0,@dang,@mLoai,@gia)
		declare @mpn char(20)
	set @mpn=replace(convert(varchar, getdate(),103),'/','') + replace(convert(varchar, getdate(),108),':','')

	insert into dbo.PHIEUNHAP
			(MaPhieuNhap,NgayNhap,MaNhaCungCap,MaNhanVien)
	values(@mpn,@date,@mncc,@mnv)
	insert into dbo.CHITIETPHIEUNHAP
			(MaPhieuNhap,MaThuoc,SoLuong,DonGia)
	values(@mpn,@maThuoc,@sl,@gia)
end

GO
/****** Object:  StoredProcedure [dbo].[proc_deleteNCC]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_deleteNCC]
	@ma char(15)
as begin
	delete from CHITIETPHIEUNHAP where MaPhieuNhap in 
	(
		select MaPhieuNhap from PHIEUNHAP where MaNhaCungCap = @ma
	)
	delete from PHIEUNHAP where MaPhieuNhap in
	(
		select MaPhieuNhap from PHIEUNHAP where MaNhaCungCap = @ma
	)
	
	delete from NHACUNGCAP where MaNhaCungCap = @ma

end
GO
/****** Object:  StoredProcedure [dbo].[proc_deleteThuoc]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_deleteThuoc]
	@maT char(20)
as begin
	delete from CHITIETPHIEUNHAP where MaThuoc like @maT
	delete from CHITIETPHIEUXUAT where MaThuoc like @maT
	delete from THUOC where MaThuoc like @maT
end
GO
/****** Object:  StoredProcedure [dbo].[proc_searchHangSanXuat]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_searchHangSanXuat]
as begin
	select TenHangSX from HANGSANXUAT
end

GO
/****** Object:  StoredProcedure [dbo].[proc_searchKH]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_searchKH]
	@cmt nchar(12)
as begin
	select * from KHACHHANG where [CMND/TCCCD] like @cmt 
end
GO
/****** Object:  StoredProcedure [dbo].[proc_searchLoaiThuoc]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	create proc [dbo].[proc_searchLoaiThuoc]
	as
	begin
		select TenLoaiThuoc from LOAITHUOC
	end

GO
/****** Object:  StoredProcedure [dbo].[proc_searchNCC]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_searchNCC]
	@ten nvarchar(30)
as begin
	select * from NHACUNGCAP where TenNhaCungCap like '%'+@ten+'%'
end

GO
/****** Object:  StoredProcedure [dbo].[proc_searchNhaCungCap]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_searchNhaCungCap]
@tenNCC nvarchar(30)
as begin
	select MaNhaCungCap,ThongTinDaiDien from NHACUNGCAP where TenNhaCungCap like @tenNCC
end

GO
/****** Object:  StoredProcedure [dbo].[proc_searchNhanVien]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------------------form nhap thuoc-----------------------------
create proc [dbo].[proc_searchNhanVien] 
	@maNV char(15)
as begin
	select TenNhanVien, SoDienThoai from NHANVIEN where MaNhanVien like @maNV
end

GO
/****** Object:  StoredProcedure [dbo].[proc_searchTenNhaCungCap]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_searchTenNhaCungCap]
as begin
	select TenNhaCungCap from NHACUNGCAP
end

GO
/****** Object:  StoredProcedure [dbo].[proc_searchTenThuoc]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_searchTenThuoc]
as begin
	select TenThuoc from THUOC
end

GO
/****** Object:  StoredProcedure [dbo].[proc_SearchThuoc]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_SearchThuoc]
	@s nvarchar(max)
as begin
	select MaThuoc,TenThuoc,THUOC.MaLoThuoc,MaLoaiThuoc,MaHangSX,ThanhPhan,CongDung,NgaySanXuat,HanSuDung,SoLuongTon,DangThuoc
	from THUOC,LOTHUOC
	where THUOC.TenThuoc like '%'+@s+'%' and THUOC.MaLoThuoc=LOTHUOC.MaLoThuoc 
end

exec proc_SearchThuoc 'ca'


GO
/****** Object:  StoredProcedure [dbo].[proc_searchThuocBan]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_searchThuocBan]
	@tenThuoc nvarchar(max)
as begin
	select MaThuoc,ThanhPhan,CongDung,SoLuongTon,DonGia from THUOC where TenThuoc like @tenThuoc 
end
GO
/****** Object:  StoredProcedure [dbo].[proc_searchThuocDanhSachDGV]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_searchThuocDanhSachDGV]
	@ten nvarchar(50)
as begin
	select MaThuoc,MaLoThuoc,TenThuoc,MaLoaiThuoc,DonGia,SoLuongTon from THUOC 
	where THUOC.TenThuoc like N'%'+@ten+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[proc_searchThuocSua]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_searchThuocSua]
	@maT char(20)
as begin

select TenThuoc,THUOC.MaLoThuoc,MaLoaiThuoc,MaHangSX,ThanhPhan,CongDung,NgaySanXuat,HanSuDung,DonGia,SoLuongTon,DangThuoc
	from THUOC,LOTHUOC
	where THUOC.MaThuoc like @maT and THUOC.MaLoThuoc=LOTHUOC.MaLoThuoc 
end
GO
/****** Object:  StoredProcedure [dbo].[proc_selectLoaiThuoc]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_selectLoaiThuoc]
	@tenLoaiThuoc nvarchar(30)
as begin
	select MaLoaiThuoc from LOAITHUOC where TenLoaiThuoc like @tenLoaiThuoc
end

GO
/****** Object:  StoredProcedure [dbo].[proc_selectMaHangSX]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_selectMaHangSX]
	@tenHSX nvarchar(50)
as begin
	select MaHangSX from HANGSANXUAT where TenHangSX like @tenHSX
end

GO
/****** Object:  StoredProcedure [dbo].[proc_TimKiem]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_TimKiem] as begin
select TenThuoc,CongDung,ThanhPhan,DangThuoc,NgaySanXuat,HanSuDung,C1.DonGia,T.DonGia
from THUOC T
inner join LOTHUOC L on T.MaLoThuoc = L.MaLoThuoc
inner join CHITIETPHIEUNHAP C1 on T.MaThuoc = C1.MaThuoc
order by C1.DonGia asc
end

GO
/****** Object:  StoredProcedure [dbo].[proc_TimKiemTheoGia]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_TimKiemTheoGia](@giaTien int)
as begin
select TenThuoc,CongDung,ThanhPhan,DangThuoc,NgaySanXuat,HanSuDung,C1.DonGia,C2.DonGia
from THUOC T 
inner join LOTHUOC L on T.MaLoThuoc = L.MaLoThuoc
inner join CHITIETPHIEUNHAP C1 on T.MaThuoc = C1.MaThuoc 
inner join CHITIETPHIEUXUAT C2 on T.MaThuoc = C2.MaThuoc
where C1.DonGia = @giaTien
end

GO
/****** Object:  StoredProcedure [dbo].[proc_TimKiemTheoTen]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_TimKiemTheoTen](@ten nvarchar(max))
as begin
select TenThuoc,CongDung,ThanhPhan,DangThuoc,NgaySanXuat,HanSuDung,C1.DonGia,T.DonGia 
from THUOC T inner join LOTHUOC L on T.MaLoThuoc = L.MaLoThuoc
inner join CHITIETPHIEUNHAP C1 on T.MaThuoc = C1.MaThuoc 
where T.TenThuoc = @ten
end
GO
/****** Object:  StoredProcedure [dbo].[proc_TimKiemTheoTenVaThoiHan]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_TimKiemTheoTenVaThoiHan] (@ten nvarchar(max), @date1 datetime, @date2 datetime)
as begin
select TenThuoc,CongDung,ThanhPhan,DangThuoc,NgaySanXuat,HanSuDung,C1.DonGia,T.DonGia 
from THUOC T 
inner join LOTHUOC L on T.MaLoThuoc = L.MaLoThuoc
inner join CHITIETPHIEUNHAP C1 on T.MaThuoc = C1.MaThuoc 
where (NgaySanXuat <= @date1) and (HanSuDung >= @date2) and (T.TenThuoc = @ten)
end
GO
/****** Object:  StoredProcedure [dbo].[proc_TimKiemTheoThoiHan]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_TimKiemTheoThoiHan] (@date1 datetime, @date2 datetime)
as begin
select TenThuoc,CongDung,ThanhPhan,DangThuoc,NgaySanXuat,HanSuDung,C1.DonGia,T.DonGia 
from THUOC T 
inner join LOTHUOC L on T.MaLoThuoc = L.MaLoThuoc
inner join CHITIETPHIEUNHAP C1 on T.MaThuoc = C1.MaThuoc 
where (NgaySanXuat <= @date1) and (HanSuDung >= @date2)
end

GO
/****** Object:  StoredProcedure [dbo].[proc_TimKiemThuoc]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_TimKiemThuoc](@giaTien int) 
as begin
select * from THUOC T
inner join CHITIETPHIEUNHAP C1 on T.MaThuoc = C1.MaThuoc
inner join CHITIETPHIEUXUAT C2 on T.MaThuoc = C2.MaThuoc
where C1.DonGia = @giaTien
end

GO
/****** Object:  StoredProcedure [dbo].[proc_TimKiemThuoc2]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_TimKiemThuoc2](@ten nvarchar(max))
as begin
select * from THUOC T
inner join CHITIETPHIEUNHAP C1 on T.MaThuoc = C1.MaThuoc
inner join CHITIETPHIEUXUAT C2 on T.MaThuoc = C2.MaThuoc
where T.TenThuoc = @ten
end

GO
/****** Object:  StoredProcedure [dbo].[proc_ThemHSX]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_ThemHSX] (@ma char(30),@ten nvarchar(40),@quocgia nvarchar(20))
AS
BEGIN
INSERT INTO HANGSANXUAT (MaHangSX,TenHangSX,QuocGia) 
VALUES (@ma,@ten,@quocgia)
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ThongKeHetHan]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[proc_ThongKeHetHan] as begin
select T.MaLoThuoc,TenThuoc,DangThuoc,NgaySanXuat,HanSuDung,SoLuongTon
from THUOC T, LOTHUOC L
where T.MaLoThuoc = L.MaLoThuoc and datediff(day,GETDATE(),L.HanSuDung) < 30 
end

GO
/****** Object:  StoredProcedure [dbo].[proc_ThongKeTon]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[proc_ThongKeTon] as begin
select MaLoThuoc,TenNhaCungCap,TenThuoc,DangThuoc,C.DonGia,SoLuongTon
from THUOC T, PHIEUNHAP P, CHITIETPHIEUNHAP C, NHACUNGCAP N
where T.MaThuoc = C.MaThuoc and P.MaPhieuNhap = C.MaPhieuNhap and P.MaNhaCungCap = N.MaNhaCungCap
end

GO
/****** Object:  StoredProcedure [dbo].[proc_Thuoc_NCC]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[proc_Thuoc_NCC] (@ncc nvarchar(30))
AS
BEGIN
SELECT TenNhaCungCap,TenThuoc,SoLuong,NgayNhap
FROM THUOC,CHITIETPHIEUNHAP,PHIEUNHAP,NHACUNGCAP
WHERE THUOC.MaThuoc=CHITIETPHIEUNHAP.MaThuoc
AND PHIEUNHAP.MaPhieuNhap=CHITIETPHIEUNHAP.MaPhieuNhap
AND NHACUNGCAP.MaNhaCungCap=PHIEUNHAP.MaNhaCungCap
AND TenNhaCungCap = @ncc
END

GO
/****** Object:  StoredProcedure [dbo].[proc_ThuocBan]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_ThuocBan](@start date, @end date)
as begin
select MaLoThuoc,TenThuoc,DangThuoc,SoLuong,C.DonGia,SUM(C.DonGia*SoLuong) ThanhTien
from THUOC T, PHIEUXUAT P, CHITIETPHIEUXUAT C
where T.MaThuoc = C.MaThuoc and P.MaPhieuXuat = C.MaPhieuXuat and (NgayXuat between @start and @end)
group by MaLoThuoc, TenThuoc, DangThuoc, SoLuong, C.DonGia
end

GO
/****** Object:  StoredProcedure [dbo].[proc_ThuocNhap]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_ThuocNhap](@start date, @end date)
as begin
select MaLoThuoc,TenNhaCungCap,TenThuoc,DangThuoc,SoLuong,C.DonGia,SUM(C.DonGia*SoLuong) ThanhTien
from THUOC T, PHIEUNHAP P, CHITIETPHIEUNHAP C, NHACUNGCAP N
where T.MaThuoc = C.MaThuoc and P.MaPhieuNhap = C.MaPhieuNhap and P.MaNhaCungCap = N.MaNhaCungCap and (NgayNhap between @start and @end)
group by MaLoThuoc, TenNhaCungCap, TenThuoc, DangThuoc, SoLuong, C.DonGia
end

GO
/****** Object:  StoredProcedure [dbo].[proc_updateHSX]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_updateHSX]
	@ma char(30),
	@ten char(40),
	@quocgia char(20)
as begin
	update dbo.HANGSANXUAT set TenHangSX=@ten,QuocGia=@quocgia
	where MaHangSX=@ma
end

GO
/****** Object:  StoredProcedure [dbo].[proc_updateNCC]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_updateNCC]
	@ma char(15),
	@ten nvarchar(30),
	@diachi nvarchar(50),
	@tt nvarchar(50),
	@sdt nchar(11)
as begin
	update NHACUNGCAP set TenNhaCungCap = @ten, DiaChi = @diachi, ThongTinDaiDien = @tt, SoDienThoai = @sdt
	where MaNhaCungCap = @ma
end

GO
/****** Object:  StoredProcedure [dbo].[proc_UpdateThuoc]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[proc_UpdateThuoc]
	@mathuoc char(20),
	@malo char(15),
	@ten nvarchar(max),
	@tp nvarchar(max),
	@cd nvarchar(max),
	@nsx date,
	@hsd date,
	@slt int,
	@dt nvarchar(20),
	@dongia int
as begin
	update THUOC
	set TenThuoc=@ten,ThanhPhan=@tp,CongDung=@cd,SoLuongTon=@slt,DangThuoc=@dt,DonGia=@dongia
	where MaThuoc=@mathuoc

	update LOTHUOC 
	set HanSuDung=@hsd,NgaySanXuat=@nsx
	where MaLoThuoc=@malo
end

GO
/****** Object:  StoredProcedure [dbo].[proc_XemLoaiThuoc]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--4. Thủ tục đưa ra các loại thuốc nhập vào thuộc một lô thuốc
CREATE PROC [dbo].[proc_XemLoaiThuoc] (@malo char(30))
AS
BEGIN
SELECT TenLoaiThuoc,THUOC.MaLoThuoc
FROM LOAITHUOC,LOTHUOC,THUOC
WHERE LOAITHUOC.MaLoaiThuoc=THUOC.MaLoaiThuoc
AND THUOC.MaLoThuoc=LOTHUOC.MaLoThuoc
AND THUOC.MaLoThuoc=@malo
END

GO
/****** Object:  StoredProcedure [dbo].[proc_XemLoThuoc]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_XemLoThuoc]
AS
BEGIN
SELECT THUOC.MaThuoc,LOTHUOC.MaLoThuoc,TenThuoc,SoLuongTon
FROM THUOC,LOTHUOC
WHERE THUOC.MaLoThuoc=LOTHUOC.MaLoThuoc
AND SoLuongTon = 0
END

GO
/****** Object:  StoredProcedure [dbo].[proc_XemThuoc]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--1. Thủ tục đưa ra thuốc thuộc một lô thuốc nào đó
CREATE PROC [dbo].[proc_XemThuoc] (@lothuoc char(15))
AS
BEGIN
SELECT TenThuoc 
FROM THUOC,LOTHUOC 
WHERE THUOC.MaLoThuoc=LOTHUOC.MaLoThuoc 
AND THUOC.MaLoThuoc = @lothuoc
END

GO
/****** Object:  StoredProcedure [dbo].[TKKH1]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TKKH1]
as begin
	select TenKhachHang,TenThuoc,SoLuong
	into #tempTable
	from(select TenKhachHang ,TenThuoc,SoLuong
				from KHACHHANG,THUOC,(select MaKhachHang,MaThuoc,SoLuong from PHIEUXUAT,CHITIETPHIEUXUAT
							where CHITIETPHIEUXUAT.MaPhieuXuat=PHIEUXUAT.MaPhieuXuat) temp
		where KHACHHANG.MaKhachHang=temp.MaKhachHang and THUOC.MaThuoc=temp.MaThuoc) A

	select distinct t2.TenKhachHang as N'Tên khách hàng',
					(	select t1.TenThuoc +','as [text()]
						from #tempTable t1
						where t1.TenKhachHang=t2.TenKhachHang
						order by t1.TenKhachHang
						for XML Path(''))as N'Tên Thuốc'
	from #tempTable t2
end

GO
/****** Object:  StoredProcedure [dbo].[ThongKeThuoc]    Script Date: 6/3/2020 3:50:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ThongKeThuoc]
as begin
	SELECT TenThuoc as N'Tên Thuốc',CongDung as N'Công Dụng',dbo.THUOCDABAN(MaThuoc) as N'Đã Bán' 
	FROM THUOC
end

GO
USE [master]
GO
ALTER DATABASE [QLBanThuoc] SET  READ_WRITE 
GO
