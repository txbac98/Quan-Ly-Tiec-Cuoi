

USE [QuanLyTiecCuoi]
GO
/****** Object:  Table [dbo].[THAMSO]    Script Date: 07/10/2016 16:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THAMSO](
	[TenQuyDinh] [nvarchar](100) NOT NULL,
	[GiaTri] [float] NULL,
 CONSTRAINT [PK_THAMSO] PRIMARY KEY CLUSTERED 
(
	[TenQuyDinh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 07/10/2016 16:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[MaDichVu] [int] IDENTITY(1,1) NOT NULL,
	[TenDichVu] [nvarchar](100) NOT NULL,
	[DonGia] [decimal](18, 0) NOT NULL,
	[HinhAnh] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[MaDichVu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[DICHVU] ON
INSERT [dbo].[DICHVU] ([MaDichVu], [TenDichVu], [DonGia], [HinhAnh], [GhiChu]) VALUES (1, N'Ca sĩ ', CAST(1000000 AS Decimal(18, 0)), N'12434488_430947797102027_486618505_n.jpg', N'1 người ')
INSERT [dbo].[DICHVU] ([MaDichVu], [TenDichVu], [DonGia], [HinhAnh], [GhiChu]) VALUES (10, N'phú', CAST(234234 AS Decimal(18, 0)), N'MINI_20130915_200439.jpg', N'123')
INSERT [dbo].[DICHVU] ([MaDichVu], [TenDichVu], [DonGia], [HinhAnh], [GhiChu]) VALUES (11, N'23r23r', CAST(2323 AS Decimal(18, 0)), N'BuiCongDuy.jpg', N'23r23r')
INSERT [dbo].[DICHVU] ([MaDichVu], [TenDichVu], [DonGia], [HinhAnh], [GhiChu]) VALUES (12, N'Nghĩa dog', CAST(123 AS Decimal(18, 0)), N'12.jpg', N'lông dài')
INSERT [dbo].[DICHVU] ([MaDichVu], [TenDichVu], [DonGia], [HinhAnh], [GhiChu]) VALUES (13, N'Phúc 1cm', CAST(23 AS Decimal(18, 0)), N'13.jpg', N'Note: phải dùng nhíp')
SET IDENTITY_INSERT [dbo].[DICHVU] OFF
/****** Object:  Table [dbo].[MONAN]    Script Date: 07/10/2016 16:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MONAN](
	[MaMonAn] [int] IDENTITY(1,1) NOT NULL,
	[TenMonAn] [nvarchar](100) NOT NULL,
	[DonGia] [decimal](18, 0) NOT NULL,
	[HinhAnh] [nvarchar](100) NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_MonAn] PRIMARY KEY CLUSTERED 
(
	[MaMonAn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[MONAN] ON
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [DonGia], [HinhAnh], [GhiChu]) VALUES (1, N'Súp cua hột gà', CAST(10000 AS Decimal(18, 0)), N'1.png', N'1 chón')
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [DonGia], [HinhAnh], [GhiChu]) VALUES (3, N'Xúc xích chiên bơ', CAST(200000 AS Decimal(18, 0)), N'2.png', N'10 con')
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [DonGia], [HinhAnh], [GhiChu]) VALUES (4, N'Gỏi ngó sen tôm thịt', CAST(500000 AS Decimal(18, 0)), N'3.png', N'1 dĩa')
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [DonGia], [HinhAnh], [GhiChu]) VALUES (5, N'Cơm chiên dương châu', CAST(1000000 AS Decimal(18, 0)), N'4.png', N'1 đĩa')
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [DonGia], [HinhAnh], [GhiChu]) VALUES (6, N'Rau câu', CAST(50000 AS Decimal(18, 0)), N'5.png', N'10 phần')
INSERT [dbo].[MONAN] ([MaMonAn], [TenMonAn], [DonGia], [HinhAnh], [GhiChu]) VALUES (7, N'Ngoài kia inc', CAST(50000 AS Decimal(18, 0)), N'7', N'ok')
SET IDENTITY_INSERT [dbo].[MONAN] OFF
/****** Object:  Table [dbo].[LOAISANH]    Script Date: 07/10/2016 16:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAISANH](
	[MaLoaiSanh] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiSanh] [nvarchar](100) NULL,
	[DonGiaBanToiThieu] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_LoaiSanh_1] PRIMARY KEY CLUSTERED 
(
	[MaLoaiSanh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LOAISANH] ON
INSERT [dbo].[LOAISANH] ([MaLoaiSanh], [TenLoaiSanh], [DonGiaBanToiThieu]) VALUES (1, N'A', CAST(1000 AS Decimal(18, 0)))
INSERT [dbo].[LOAISANH] ([MaLoaiSanh], [TenLoaiSanh], [DonGiaBanToiThieu]) VALUES (2, N'B', CAST(200 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[LOAISANH] OFF
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 07/10/2016 16:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[MaChucVu] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [nvarchar](100) NOT NULL,
	[PhanQuyen] [int] NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CHUCVU] ON
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu], [PhanQuyen]) VALUES (1, N'Trưởng phòng', 4)
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu], [PhanQuyen]) VALUES (2, N'Thu ngân', 2)
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu], [PhanQuyen]) VALUES (3, N'Quản lý cơ sở vật chất', 3)
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu], [PhanQuyen]) VALUES (4, N'Trưởng bộ phận nhà hàng ', 4)
INSERT [dbo].[CHUCVU] ([MaChucVu], [TenChucVu], [PhanQuyen]) VALUES (5, N'Nhân viên phục vụ', 5)
SET IDENTITY_INSERT [dbo].[CHUCVU] OFF
/****** Object:  Table [dbo].[CA]    Script Date: 07/10/2016 16:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CA](
	[MaCa] [int] IDENTITY(1,1) NOT NULL,
	[TenCa] [nvarchar](100) NULL,
 CONSTRAINT [PK_Ca] PRIMARY KEY CLUSTERED 
(
	[MaCa] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CA] ON
INSERT [dbo].[CA] ([MaCa], [TenCa]) VALUES (3, N'Sáng')
INSERT [dbo].[CA] ([MaCa], [TenCa]) VALUES (4, N'Chiều ')
SET IDENTITY_INSERT [dbo].[CA] OFF
/****** Object:  UserDefinedFunction [dbo].[BoDau]    Script Date: 07/10/2016 16:21:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[BoDau](@inputVar NVARCHAR(MAX) )
RETURNS NVARCHAR(MAX)
AS
BEGIN   
    IF (@inputVar IS NULL OR @inputVar = '')  RETURN ''
  
    DECLARE @RT NVARCHAR(MAX)
    DECLARE @SIGN_CHARS NCHAR(256)
    DECLARE @UNSIGN_CHARS NCHAR (256)
    SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệếìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵýĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' + NCHAR(272) + NCHAR(208)
    SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeeeiiiiiooooooooooooooouuuuuuuuuuyyyyyAADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD'
    DECLARE @COUNTER int
    DECLARE @COUNTER1 int
  
    SET @COUNTER = 1
    WHILE (@COUNTER <= LEN(@inputVar))
    BEGIN 
        SET @COUNTER1 = 1
        WHILE (@COUNTER1 <= LEN(@SIGN_CHARS) + 1)
        BEGIN
            IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@inputVar,@COUNTER ,1))
            BEGIN         
                IF @COUNTER = 1
                    SET @inputVar = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)-1)     
                ELSE
                    SET @inputVar = SUBSTRING(@inputVar, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@inputVar, @COUNTER+1,LEN(@inputVar)- @COUNTER)
                BREAK
            END
            SET @COUNTER1 = @COUNTER1 +1
        END
        SET @COUNTER = @COUNTER +1
    END
    -- SET @inputVar = replace(@inputVar,' ','-')
   
    RETURN @inputVar
END
GO
/****** Object:  Table [dbo].[BAOCAOTHANG]    Script Date: 07/10/2016 16:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAOTHANG](
	[MaBCT] [int] IDENTITY(1,1) NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[TongSoLuongTiecCuoi] [int] NOT NULL,
	[TongDoanhThu] [int] NOT NULL,
 CONSTRAINT [PK_BaoCaoDoanhThu] PRIMARY KEY CLUSTERED 
(
	[MaBCT] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BAOCAONGAY]    Script Date: 07/10/2016 16:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOCAONGAY](
	[MABCT] [int] NOT NULL,
	[Ngay] [int] NOT NULL,
	[SoLuongTiecCuoi] [int] NULL,
	[DoanhThu] [decimal](18, 0) NULL,
	[TiLe] [float] NULL,
 CONSTRAINT [PK_BAOCAONGAY] PRIMARY KEY CLUSTERED 
(
	[MABCT] ASC,
	[Ngay] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 07/10/2016 16:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](100) NOT NULL,
	[DienThoai] [varchar](15) NOT NULL,
	[Username] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[MaChucVu] [int] NOT NULL,
	[TinhTrang] [nvarchar](5) NOT NULL,
	[AnhDaiDien] [varchar](50) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[NHANVIEN] ON
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [DiaChi], [DienThoai], [Username], [Password], [MaChucVu], [TinhTrang], [AnhDaiDien]) VALUES (1, N'HoangMinh', N'36/7B Mai Hắc Đế', N'0937934651', N'iams2b', N'01011995', 1, N'OK', NULL)
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [DiaChi], [DienThoai], [Username], [Password], [MaChucVu], [TinhTrang], [AnhDaiDien]) VALUES (2, N'Phạm Nguyễn Tâm Phú', N'324', N'45', N'manhboanheo', N'01642042959dq', 1, N'3', N'1.png')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [DiaChi], [DienThoai], [Username], [Password], [MaChucVu], [TinhTrang], [AnhDaiDien]) VALUES (3, N'Nguyễn Hoàng Minh', N'Quận 8', N'0123456789', N'iams2b', N'123456', 3, N'3', N'2.png')
INSERT [dbo].[NHANVIEN] ([MaNV], [HoTen], [DiaChi], [DienThoai], [Username], [Password], [MaChucVu], [TinhTrang], [AnhDaiDien]) VALUES (8, N'BOSS', N'a', N'1', N'1', N'1', 1, N'3', N'2.png')
SET IDENTITY_INSERT [dbo].[NHANVIEN] OFF
/****** Object:  Table [dbo].[SANH]    Script Date: 07/10/2016 16:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SANH](
	[MaSanh] [int] IDENTITY(1,1) NOT NULL,
	[TenSanh] [nvarchar](100) NOT NULL,
	[MaLoaiSanh] [int] NOT NULL,
	[SoLuongBanToiDa] [int] NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoaiSanh] PRIMARY KEY CLUSTERED 
(
	[MaSanh] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[SANH] ON
INSERT [dbo].[SANH] ([MaSanh], [TenSanh], [MaLoaiSanh], [SoLuongBanToiDa], [GhiChu]) VALUES (1, N'Ruby', 1, 1000, NULL)
INSERT [dbo].[SANH] ([MaSanh], [TenSanh], [MaLoaiSanh], [SoLuongBanToiDa], [GhiChu]) VALUES (2, N'Sapphire ', 2, 500, NULL)
INSERT [dbo].[SANH] ([MaSanh], [TenSanh], [MaLoaiSanh], [SoLuongBanToiDa], [GhiChu]) VALUES (3, N'VIP', 1, 100, N'Đám cưới tao')
INSERT [dbo].[SANH] ([MaSanh], [TenSanh], [MaLoaiSanh], [SoLuongBanToiDa], [GhiChu]) VALUES (4, N'test', 2, 110, N'')
INSERT [dbo].[SANH] ([MaSanh], [TenSanh], [MaLoaiSanh], [SoLuongBanToiDa], [GhiChu]) VALUES (6, N'11', 2, 11, N'11')
INSERT [dbo].[SANH] ([MaSanh], [TenSanh], [MaLoaiSanh], [SoLuongBanToiDa], [GhiChu]) VALUES (7, N'1', 1, 1, N'1')
INSERT [dbo].[SANH] ([MaSanh], [TenSanh], [MaLoaiSanh], [SoLuongBanToiDa], [GhiChu]) VALUES (8, N'1', 1, 1, N'1')
INSERT [dbo].[SANH] ([MaSanh], [TenSanh], [MaLoaiSanh], [SoLuongBanToiDa], [GhiChu]) VALUES (9, N'2', 1, 2, N'2')
INSERT [dbo].[SANH] ([MaSanh], [TenSanh], [MaLoaiSanh], [SoLuongBanToiDa], [GhiChu]) VALUES (10, N'4', 2, 4, N'4')
INSERT [dbo].[SANH] ([MaSanh], [TenSanh], [MaLoaiSanh], [SoLuongBanToiDa], [GhiChu]) VALUES (11, N'2132131', 1, 123, N'213213')
INSERT [dbo].[SANH] ([MaSanh], [TenSanh], [MaLoaiSanh], [SoLuongBanToiDa], [GhiChu]) VALUES (13, N'a', 1, 21, N'a')
SET IDENTITY_INSERT [dbo].[SANH] OFF
/****** Object:  Table [dbo].[TIECCUOI]    Script Date: 07/10/2016 16:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIECCUOI](
	[MaTiecCuoi] [int] IDENTITY(1,1) NOT NULL,
	[TenChuRe] [nvarchar](100) NOT NULL,
	[TenCoDau] [nvarchar](100) NOT NULL,
	[DienThoai] [nvarchar](12) NULL,
	[NgayDatTiec] [datetime] NOT NULL,
	[NgayDaiTiec] [datetime] NOT NULL,
	[MaCa] [int] NOT NULL,
	[MaSanh] [int] NOT NULL,
	[TienCoc] [decimal](18, 0) NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
	[MaNV] [int] NOT NULL,
	[TinhTrangTiec] [int] NULL,
 CONSTRAINT [PK_HoaDonTiecCuoi] PRIMARY KEY CLUSTERED 
(
	[MaTiecCuoi] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[TIECCUOI] ON
INSERT [dbo].[TIECCUOI] ([MaTiecCuoi], [TenChuRe], [TenCoDau], [DienThoai], [NgayDatTiec], [NgayDaiTiec], [MaCa], [MaSanh], [TienCoc], [GhiChu], [MaNV], [TinhTrangTiec]) VALUES (12, N'phú', N'quỳnh', N'01632654651', CAST(0x0000A5E100000000 AS DateTime), CAST(0x0000A63C00000000 AS DateTime), 3, 1, CAST(0 AS Decimal(18, 0)), N'kcg', 2, NULL)
INSERT [dbo].[TIECCUOI] ([MaTiecCuoi], [TenChuRe], [TenCoDau], [DienThoai], [NgayDatTiec], [NgayDaiTiec], [MaCa], [MaSanh], [TienCoc], [GhiChu], [MaNV], [TinhTrangTiec]) VALUES (13, N'phú', N'nhi', N'05465165515', CAST(0x0000A5E100000000 AS DateTime), CAST(0x0000A69800000000 AS DateTime), 3, 1, CAST(45 AS Decimal(18, 0)), N'hiihi', 2, NULL)
INSERT [dbo].[TIECCUOI] ([MaTiecCuoi], [TenChuRe], [TenCoDau], [DienThoai], [NgayDatTiec], [NgayDaiTiec], [MaCa], [MaSanh], [TienCoc], [GhiChu], [MaNV], [TinhTrangTiec]) VALUES (14, N'phúc nắc', N'nhơn dâm', N'01635668292', CAST(0x0000A5E100000000 AS DateTime), CAST(0x0000A6D500000000 AS DateTime), 4, 1, CAST(10000000 AS Decimal(18, 0)), N'đẹp đôi', 2, NULL)
INSERT [dbo].[TIECCUOI] ([MaTiecCuoi], [TenChuRe], [TenCoDau], [DienThoai], [NgayDatTiec], [NgayDaiTiec], [MaCa], [MaSanh], [TienCoc], [GhiChu], [MaNV], [TinhTrangTiec]) VALUES (15, N'Phú', N'thư', N'0165165121', CAST(0x0000A5E100000000 AS DateTime), CAST(0x0000A61E00000000 AS DateTime), 3, 1, CAST(45 AS Decimal(18, 0)), N'hahahaha', 2, NULL)
INSERT [dbo].[TIECCUOI] ([MaTiecCuoi], [TenChuRe], [TenCoDau], [DienThoai], [NgayDatTiec], [NgayDaiTiec], [MaCa], [MaSanh], [TienCoc], [GhiChu], [MaNV], [TinhTrangTiec]) VALUES (16, N'ưef', N'phú', N'01651532132', CAST(0x0000A5E100000000 AS DateTime), CAST(0x0000A5FF00000000 AS DateTime), 3, 1, CAST(23 AS Decimal(18, 0)), N'hahahaha', 2, NULL)
INSERT [dbo].[TIECCUOI] ([MaTiecCuoi], [TenChuRe], [TenCoDau], [DienThoai], [NgayDatTiec], [NgayDaiTiec], [MaCa], [MaSanh], [TienCoc], [GhiChu], [MaNV], [TinhTrangTiec]) VALUES (21, N'phú', N'thư', N'0165165121', CAST(0x0000A5E100000000 AS DateTime), CAST(0x0000A5FF00000000 AS DateTime), 3, 1, CAST(3434 AS Decimal(18, 0)), N'dam tac', 2, NULL)
INSERT [dbo].[TIECCUOI] ([MaTiecCuoi], [TenChuRe], [TenCoDau], [DienThoai], [NgayDatTiec], [NgayDaiTiec], [MaCa], [MaSanh], [TienCoc], [GhiChu], [MaNV], [TinhTrangTiec]) VALUES (23, N'phú', N'thư', N'05465165515', CAST(0x0000A5E100000000 AS DateTime), CAST(0x0000A5FF00000000 AS DateTime), 3, 1, CAST(45 AS Decimal(18, 0)), N'an la chet', 2, NULL)
INSERT [dbo].[TIECCUOI] ([MaTiecCuoi], [TenChuRe], [TenCoDau], [DienThoai], [NgayDatTiec], [NgayDaiTiec], [MaCa], [MaSanh], [TienCoc], [GhiChu], [MaNV], [TinhTrangTiec]) VALUES (24, N'werwer', N'ưerwer', N'01651532132', CAST(0x0000A63900000000 AS DateTime), CAST(0x0000A63D00000000 AS DateTime), 3, 1, CAST(23 AS Decimal(18, 0)), N'dam tac', 2, NULL)
INSERT [dbo].[TIECCUOI] ([MaTiecCuoi], [TenChuRe], [TenCoDau], [DienThoai], [NgayDatTiec], [NgayDaiTiec], [MaCa], [MaSanh], [TienCoc], [GhiChu], [MaNV], [TinhTrangTiec]) VALUES (25, N'minh', N'nghĩa', N'05465165515', CAST(0x0000A5E100000000 AS DateTime), CAST(0x0000A65B00000000 AS DateTime), 3, 1, CAST(23 AS Decimal(18, 0)), N'dam tac', 2, NULL)
INSERT [dbo].[TIECCUOI] ([MaTiecCuoi], [TenChuRe], [TenCoDau], [DienThoai], [NgayDatTiec], [NgayDaiTiec], [MaCa], [MaSanh], [TienCoc], [GhiChu], [MaNV], [TinhTrangTiec]) VALUES (26, N'phúc', N'mai', N'01635668292', CAST(0x0000A5E100000000 AS DateTime), CAST(0x0000A65B00000000 AS DateTime), 4, 1, CAST(23 AS Decimal(18, 0)), N'an la chet', 2, NULL)
INSERT [dbo].[TIECCUOI] ([MaTiecCuoi], [TenChuRe], [TenCoDau], [DienThoai], [NgayDatTiec], [NgayDaiTiec], [MaCa], [MaSanh], [TienCoc], [GhiChu], [MaNV], [TinhTrangTiec]) VALUES (29, N'phúc', N'nhi', N'01651532132', CAST(0x0000A63C00000000 AS DateTime), CAST(0x0000A6B700000000 AS DateTime), 3, 1, CAST(500 AS Decimal(18, 0)), N'an la chet', 2, NULL)
INSERT [dbo].[TIECCUOI] ([MaTiecCuoi], [TenChuRe], [TenCoDau], [DienThoai], [NgayDatTiec], [NgayDaiTiec], [MaCa], [MaSanh], [TienCoc], [GhiChu], [MaNV], [TinhTrangTiec]) VALUES (30, N'nghĩa', N'phúc', N'05465165515', CAST(0x0000A63C00000000 AS DateTime), CAST(0x0000A6D500000000 AS DateTime), 3, 1, CAST(67 AS Decimal(18, 0)), N'an la chet', 2, NULL)
INSERT [dbo].[TIECCUOI] ([MaTiecCuoi], [TenChuRe], [TenCoDau], [DienThoai], [NgayDatTiec], [NgayDaiTiec], [MaCa], [MaSanh], [TienCoc], [GhiChu], [MaNV], [TinhTrangTiec]) VALUES (31, N'Phúc', N'Mai', N'09373654654', CAST(0x0000A63F00000000 AS DateTime), CAST(0x0000A64200000000 AS DateTime), 4, 2, CAST(36000000 AS Decimal(18, 0)), N'', 8, 0)
INSERT [dbo].[TIECCUOI] ([MaTiecCuoi], [TenChuRe], [TenCoDau], [DienThoai], [NgayDatTiec], [NgayDaiTiec], [MaCa], [MaSanh], [TienCoc], [GhiChu], [MaNV], [TinhTrangTiec]) VALUES (32, N'nguyễn nghĩa', N'trần phúc', N'09349511', CAST(0x0000A63F00000000 AS DateTime), CAST(0x0000A64300000000 AS DateTime), 3, 1, CAST(500000 AS Decimal(18, 0)), N'', 8, 0)
INSERT [dbo].[TIECCUOI] ([MaTiecCuoi], [TenChuRe], [TenCoDau], [DienThoai], [NgayDatTiec], [NgayDaiTiec], [MaCa], [MaSanh], [TienCoc], [GhiChu], [MaNV], [TinhTrangTiec]) VALUES (33, N'Nguyễn Văn Nghĩa', N'Trần Văn Phúc', N'083113', CAST(0x0000A63F00000000 AS DateTime), CAST(0x0000A64000000000 AS DateTime), 3, 1, CAST(36000000 AS Decimal(18, 0)), N'', 8, 0)
SET IDENTITY_INSERT [dbo].[TIECCUOI] OFF
/****** Object:  Table [dbo].[PHIEUDATBAN]    Script Date: 07/10/2016 16:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHIEUDATBAN](
	[MaPhieuDatBan] [int] IDENTITY(1,1) NOT NULL,
	[MaTiecCuoi] [int] NOT NULL,
	[SoBan] [int] NOT NULL,
	[SoBanDuTru] [int] NOT NULL,
	[DonGiaBan] [decimal](18, 0) NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_PHIEUDATBAN] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDatBan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[PHIEUDATBAN] ON
INSERT [dbo].[PHIEUDATBAN] ([MaPhieuDatBan], [MaTiecCuoi], [SoBan], [SoBanDuTru], [DonGiaBan], [GhiChu]) VALUES (1, 12, 100, 5, CAST(1231271233 AS Decimal(18, 0)), N'')
INSERT [dbo].[PHIEUDATBAN] ([MaPhieuDatBan], [MaTiecCuoi], [SoBan], [SoBanDuTru], [DonGiaBan], [GhiChu]) VALUES (2, 13, 100, 5, CAST(1000100 AS Decimal(18, 0)), N'')
INSERT [dbo].[PHIEUDATBAN] ([MaPhieuDatBan], [MaTiecCuoi], [SoBan], [SoBanDuTru], [DonGiaBan], [GhiChu]) VALUES (4, 14, 100, 5, CAST(1242213 AS Decimal(18, 0)), N'')
INSERT [dbo].[PHIEUDATBAN] ([MaPhieuDatBan], [MaTiecCuoi], [SoBan], [SoBanDuTru], [DonGiaBan], [GhiChu]) VALUES (5, 15, 100, 5, CAST(1000100 AS Decimal(18, 0)), N'')
INSERT [dbo].[PHIEUDATBAN] ([MaPhieuDatBan], [MaTiecCuoi], [SoBan], [SoBanDuTru], [DonGiaBan], [GhiChu]) VALUES (7, 16, 100, 5, CAST(1000100 AS Decimal(18, 0)), N'')
INSERT [dbo].[PHIEUDATBAN] ([MaPhieuDatBan], [MaTiecCuoi], [SoBan], [SoBanDuTru], [DonGiaBan], [GhiChu]) VALUES (8, 21, 100, 5, CAST(1000100 AS Decimal(18, 0)), N'')
INSERT [dbo].[PHIEUDATBAN] ([MaPhieuDatBan], [MaTiecCuoi], [SoBan], [SoBanDuTru], [DonGiaBan], [GhiChu]) VALUES (10, 23, 110, 19, CAST(2000000 AS Decimal(18, 0)), NULL)
INSERT [dbo].[PHIEUDATBAN] ([MaPhieuDatBan], [MaTiecCuoi], [SoBan], [SoBanDuTru], [DonGiaBan], [GhiChu]) VALUES (11, 24, 150, 10, CAST(20000000 AS Decimal(18, 0)), NULL)
INSERT [dbo].[PHIEUDATBAN] ([MaPhieuDatBan], [MaTiecCuoi], [SoBan], [SoBanDuTru], [DonGiaBan], [GhiChu]) VALUES (12, 25, 200, 10, CAST(1520000 AS Decimal(18, 0)), NULL)
INSERT [dbo].[PHIEUDATBAN] ([MaPhieuDatBan], [MaTiecCuoi], [SoBan], [SoBanDuTru], [DonGiaBan], [GhiChu]) VALUES (13, 26, 220, 15, CAST(1200000 AS Decimal(18, 0)), NULL)
INSERT [dbo].[PHIEUDATBAN] ([MaPhieuDatBan], [MaTiecCuoi], [SoBan], [SoBanDuTru], [DonGiaBan], [GhiChu]) VALUES (14, 31, 490, 10, CAST(1450000 AS Decimal(18, 0)), N'')
INSERT [dbo].[PHIEUDATBAN] ([MaPhieuDatBan], [MaTiecCuoi], [SoBan], [SoBanDuTru], [DonGiaBan], [GhiChu]) VALUES (15, 32, 1000, 0, CAST(10000 AS Decimal(18, 0)), N'')
INSERT [dbo].[PHIEUDATBAN] ([MaPhieuDatBan], [MaTiecCuoi], [SoBan], [SoBanDuTru], [DonGiaBan], [GhiChu]) VALUES (16, 33, 1000, 0, CAST(700000 AS Decimal(18, 0)), N'')
SET IDENTITY_INSERT [dbo].[PHIEUDATBAN] OFF
/****** Object:  Table [dbo].[HOADON]    Script Date: 07/10/2016 16:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[SoHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[MaTiecCuoi] [int] NOT NULL,
	[NgayThanhToan] [datetime] NULL,
	[TongTienBan] [decimal](18, 0) NULL,
	[TongTienDichVu] [decimal](18, 0) NULL,
	[TongTienHoaDon] [decimal](18, 0) NULL,
	[ConLai] [decimal](18, 0) NULL,
	[TienDaThanhToan] [decimal](18, 0) NOT NULL, 
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[SoHoaDon] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_PHIEUDATDICHVU]    Script Date: 07/10/2016 16:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUDATDICHVU](
	[MaTiecCuoi] [int] NOT NULL,
	[MaDichVu] [int] NOT NULL,
	[SoLuong] [int] NULL,
	[DonGia] [decimal](18, 0) NULL,
 CONSTRAINT [PK_CT_PHIEUDATDICHVU] PRIMARY KEY CLUSTERED 
(
	[MaTiecCuoi] ASC,
	[MaDichVu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CT_PHIEUDATDICHVU] ([MaTiecCuoi], [MaDichVu], [SoLuong], [DonGia]) VALUES (12, 1, 2, CAST(40000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PHIEUDATDICHVU] ([MaTiecCuoi], [MaDichVu], [SoLuong], [DonGia]) VALUES (12, 11, 5, CAST(5000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PHIEUDATDICHVU] ([MaTiecCuoi], [MaDichVu], [SoLuong], [DonGia]) VALUES (13, 10, 8, CAST(20000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PHIEUDATDICHVU] ([MaTiecCuoi], [MaDichVu], [SoLuong], [DonGia]) VALUES (14, 1, 2, CAST(100 AS Decimal(18, 0)))
INSERT [dbo].[CT_PHIEUDATDICHVU] ([MaTiecCuoi], [MaDichVu], [SoLuong], [DonGia]) VALUES (14, 11, 3, CAST(5 AS Decimal(18, 0)))
INSERT [dbo].[CT_PHIEUDATDICHVU] ([MaTiecCuoi], [MaDichVu], [SoLuong], [DonGia]) VALUES (15, 10, 5, CAST(20000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PHIEUDATDICHVU] ([MaTiecCuoi], [MaDichVu], [SoLuong], [DonGia]) VALUES (16, 10, 2, CAST(400 AS Decimal(18, 0)))
INSERT [dbo].[CT_PHIEUDATDICHVU] ([MaTiecCuoi], [MaDichVu], [SoLuong], [DonGia]) VALUES (16, 11, 3, CAST(20000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PHIEUDATDICHVU] ([MaTiecCuoi], [MaDichVu], [SoLuong], [DonGia]) VALUES (21, 10, 5, CAST(300 AS Decimal(18, 0)))
INSERT [dbo].[CT_PHIEUDATDICHVU] ([MaTiecCuoi], [MaDichVu], [SoLuong], [DonGia]) VALUES (23, 1, 2, CAST(100 AS Decimal(18, 0)))
INSERT [dbo].[CT_PHIEUDATDICHVU] ([MaTiecCuoi], [MaDichVu], [SoLuong], [DonGia]) VALUES (24, 10, 2, CAST(10000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PHIEUDATDICHVU] ([MaTiecCuoi], [MaDichVu], [SoLuong], [DonGia]) VALUES (24, 11, 24, CAST(200000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PHIEUDATDICHVU] ([MaTiecCuoi], [MaDichVu], [SoLuong], [DonGia]) VALUES (25, 10, 20, NULL)
INSERT [dbo].[CT_PHIEUDATDICHVU] ([MaTiecCuoi], [MaDichVu], [SoLuong], [DonGia]) VALUES (31, 1, 1, CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PHIEUDATDICHVU] ([MaTiecCuoi], [MaDichVu], [SoLuong], [DonGia]) VALUES (33, 1, 1, CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PHIEUDATDICHVU] ([MaTiecCuoi], [MaDichVu], [SoLuong], [DonGia]) VALUES (33, 10, 3, CAST(1000000 AS Decimal(18, 0)))
INSERT [dbo].[CT_PHIEUDATDICHVU] ([MaTiecCuoi], [MaDichVu], [SoLuong], [DonGia]) VALUES (33, 12, 1, CAST(30000 AS Decimal(18, 0)))
/****** Object:  Table [dbo].[CT_PHIEUDATBAN]    Script Date: 07/10/2016 16:21:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PHIEUDATBAN](
	[MaPhieuDatBan] [int] NOT NULL,
	[MaMonAn] [int] NOT NULL,
	[DonGia] [decimal](18, 0) NULL,
	[SoLuong] [int] NULL,
	[GhiChu] [nvarchar](max) NULL,
 CONSTRAINT [PK_ChiTietThucDonTiecCuoi] PRIMARY KEY CLUSTERED 
(
	[MaPhieuDatBan] ASC,
	[MaMonAn] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CT_PHIEUDATBAN] ([MaPhieuDatBan], [MaMonAn], [DonGia], [SoLuong], [GhiChu]) VALUES (4, 1, CAST(100000 AS Decimal(18, 0)), 0, NULL)
INSERT [dbo].[CT_PHIEUDATBAN] ([MaPhieuDatBan], [MaMonAn], [DonGia], [SoLuong], [GhiChu]) VALUES (4, 3, CAST(19000 AS Decimal(18, 0)), 0, NULL)
INSERT [dbo].[CT_PHIEUDATBAN] ([MaPhieuDatBan], [MaMonAn], [DonGia], [SoLuong], [GhiChu]) VALUES (4, 5, CAST(1000000 AS Decimal(18, 0)), 0, NULL)
INSERT [dbo].[CT_PHIEUDATBAN] ([MaPhieuDatBan], [MaMonAn], [DonGia], [SoLuong], [GhiChu]) VALUES (4, 6, CAST(123213 AS Decimal(18, 0)), 0, NULL)
INSERT [dbo].[CT_PHIEUDATBAN] ([MaPhieuDatBan], [MaMonAn], [DonGia], [SoLuong], [GhiChu]) VALUES (5, 4, CAST(500000 AS Decimal(18, 0)), 50, N'')
INSERT [dbo].[CT_PHIEUDATBAN] ([MaPhieuDatBan], [MaMonAn], [DonGia], [SoLuong], [GhiChu]) VALUES (7, 1, CAST(5 AS Decimal(18, 0)), 50, N'')
INSERT [dbo].[CT_PHIEUDATBAN] ([MaPhieuDatBan], [MaMonAn], [DonGia], [SoLuong], [GhiChu]) VALUES (7, 3, CAST(5 AS Decimal(18, 0)), 50, N'')
INSERT [dbo].[CT_PHIEUDATBAN] ([MaPhieuDatBan], [MaMonAn], [DonGia], [SoLuong], [GhiChu]) VALUES (7, 5, CAST(5 AS Decimal(18, 0)), 50, N'')
INSERT [dbo].[CT_PHIEUDATBAN] ([MaPhieuDatBan], [MaMonAn], [DonGia], [SoLuong], [GhiChu]) VALUES (7, 6, CAST(50000 AS Decimal(18, 0)), 50, N'')
INSERT [dbo].[CT_PHIEUDATBAN] ([MaPhieuDatBan], [MaMonAn], [DonGia], [SoLuong], [GhiChu]) VALUES (8, 1, CAST(5 AS Decimal(18, 0)), 69, N'')
INSERT [dbo].[CT_PHIEUDATBAN] ([MaPhieuDatBan], [MaMonAn], [DonGia], [SoLuong], [GhiChu]) VALUES (8, 4, CAST(5 AS Decimal(18, 0)), 69, N'')
INSERT [dbo].[CT_PHIEUDATBAN] ([MaPhieuDatBan], [MaMonAn], [DonGia], [SoLuong], [GhiChu]) VALUES (8, 5, CAST(6900 AS Decimal(18, 0)), 69, N'')
INSERT [dbo].[CT_PHIEUDATBAN] ([MaPhieuDatBan], [MaMonAn], [DonGia], [SoLuong], [GhiChu]) VALUES (14, 4, CAST(500000 AS Decimal(18, 0)), 500, N'')
INSERT [dbo].[CT_PHIEUDATBAN] ([MaPhieuDatBan], [MaMonAn], [DonGia], [SoLuong], [GhiChu]) VALUES (14, 5, CAST(900000 AS Decimal(18, 0)), 500, N'')
INSERT [dbo].[CT_PHIEUDATBAN] ([MaPhieuDatBan], [MaMonAn], [DonGia], [SoLuong], [GhiChu]) VALUES (14, 6, CAST(50000 AS Decimal(18, 0)), 500, N'')
INSERT [dbo].[CT_PHIEUDATBAN] ([MaPhieuDatBan], [MaMonAn], [DonGia], [SoLuong], [GhiChu]) VALUES (15, 1, CAST(10000 AS Decimal(18, 0)), 1000, N'')
INSERT [dbo].[CT_PHIEUDATBAN] ([MaPhieuDatBan], [MaMonAn], [DonGia], [SoLuong], [GhiChu]) VALUES (16, 3, CAST(200000 AS Decimal(18, 0)), 1000, N'')
INSERT [dbo].[CT_PHIEUDATBAN] ([MaPhieuDatBan], [MaMonAn], [DonGia], [SoLuong], [GhiChu]) VALUES (16, 7, CAST(500000 AS Decimal(18, 0)), 1000, N'')
/****** Object:  ForeignKey [FK_BAOCAONGAY_BAOCAOTHANG]    Script Date: 07/10/2016 16:21:17 ******/
ALTER TABLE [dbo].[BAOCAONGAY]  WITH CHECK ADD  CONSTRAINT [FK_BAOCAONGAY_BAOCAOTHANG] FOREIGN KEY([MABCT])
REFERENCES [dbo].[BAOCAOTHANG] ([MaBCT])
GO
ALTER TABLE [dbo].[BAOCAONGAY] CHECK CONSTRAINT [FK_BAOCAONGAY_BAOCAOTHANG]
GO
/****** Object:  ForeignKey [FK_CT_PHIEUDATBAN_MonAn]    Script Date: 07/10/2016 16:21:17 ******/
ALTER TABLE [dbo].[CT_PHIEUDATBAN]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUDATBAN_MonAn] FOREIGN KEY([MaMonAn])
REFERENCES [dbo].[MONAN] ([MaMonAn])
GO
ALTER TABLE [dbo].[CT_PHIEUDATBAN] CHECK CONSTRAINT [FK_CT_PHIEUDATBAN_MonAn]
GO
/****** Object:  ForeignKey [FK_CT_PHIEUDATBAN_PHIEUDATBAN]    Script Date: 07/10/2016 16:21:17 ******/
ALTER TABLE [dbo].[CT_PHIEUDATBAN]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUDATBAN_PHIEUDATBAN] FOREIGN KEY([MaPhieuDatBan])
REFERENCES [dbo].[PHIEUDATBAN] ([MaPhieuDatBan])
GO
ALTER TABLE [dbo].[CT_PHIEUDATBAN] CHECK CONSTRAINT [FK_CT_PHIEUDATBAN_PHIEUDATBAN]
GO
/****** Object:  ForeignKey [FK_CT_PHIEUDATDICHVU_DichVu]    Script Date: 07/10/2016 16:21:17 ******/
ALTER TABLE [dbo].[CT_PHIEUDATDICHVU]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUDATDICHVU_DichVu] FOREIGN KEY([MaDichVu])
REFERENCES [dbo].[DICHVU] ([MaDichVu])
GO
ALTER TABLE [dbo].[CT_PHIEUDATDICHVU] CHECK CONSTRAINT [FK_CT_PHIEUDATDICHVU_DichVu]
GO
/****** Object:  ForeignKey [FK_CT_PHIEUDATDICHVU_TIECCUOI]    Script Date: 07/10/2016 16:21:17 ******/
ALTER TABLE [dbo].[CT_PHIEUDATDICHVU]  WITH CHECK ADD  CONSTRAINT [FK_CT_PHIEUDATDICHVU_TIECCUOI] FOREIGN KEY([MaTiecCuoi])
REFERENCES [dbo].[TIECCUOI] ([MaTiecCuoi])
GO
ALTER TABLE [dbo].[CT_PHIEUDATDICHVU] CHECK CONSTRAINT [FK_CT_PHIEUDATDICHVU_TIECCUOI]
GO
/****** Object:  ForeignKey [FK_HOADON_TIECCUOI]    Script Date: 07/10/2016 16:21:17 ******/
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_TIECCUOI] FOREIGN KEY([MaTiecCuoi])
REFERENCES [dbo].[TIECCUOI] ([MaTiecCuoi])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_TIECCUOI]
GO
/****** Object:  ForeignKey [FK_NhanVien_ChucVu]    Script Date: 07/10/2016 16:21:17 ******/
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[CHUCVU] ([MaChucVu])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
/****** Object:  ForeignKey [FK_PHIEUDATBAN_TIECCUOI]    Script Date: 07/10/2016 16:21:17 ******/
ALTER TABLE [dbo].[PHIEUDATBAN]  WITH CHECK ADD  CONSTRAINT [FK_PHIEUDATBAN_TIECCUOI] FOREIGN KEY([MaTiecCuoi])
REFERENCES [dbo].[TIECCUOI] ([MaTiecCuoi])
GO
ALTER TABLE [dbo].[PHIEUDATBAN] CHECK CONSTRAINT [FK_PHIEUDATBAN_TIECCUOI]
GO
/****** Object:  ForeignKey [FK_Sanh_LoaiSanh]    Script Date: 07/10/2016 16:21:17 ******/
ALTER TABLE [dbo].[SANH]  WITH CHECK ADD  CONSTRAINT [FK_Sanh_LoaiSanh] FOREIGN KEY([MaLoaiSanh])
REFERENCES [dbo].[LOAISANH] ([MaLoaiSanh])
GO
ALTER TABLE [dbo].[SANH] CHECK CONSTRAINT [FK_Sanh_LoaiSanh]
GO
/****** Object:  ForeignKey [FK_TIECCUOI_Ca]    Script Date: 07/10/2016 16:21:17 ******/
ALTER TABLE [dbo].[TIECCUOI]  WITH CHECK ADD  CONSTRAINT [FK_TIECCUOI_Ca] FOREIGN KEY([MaCa])
REFERENCES [dbo].[CA] ([MaCa])
GO
ALTER TABLE [dbo].[TIECCUOI] CHECK CONSTRAINT [FK_TIECCUOI_Ca]
GO
/****** Object:  ForeignKey [FK_TIECCUOI_NhanVien]    Script Date: 07/10/2016 16:21:17 ******/
ALTER TABLE [dbo].[TIECCUOI]  WITH CHECK ADD  CONSTRAINT [FK_TIECCUOI_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NHANVIEN] ([MaNV])
GO
ALTER TABLE [dbo].[TIECCUOI] CHECK CONSTRAINT [FK_TIECCUOI_NhanVien]
GO
/****** Object:  ForeignKey [FK_TIECCUOI_SANH]    Script Date: 07/10/2016 16:21:17 ******/
ALTER TABLE [dbo].[TIECCUOI]  WITH CHECK ADD  CONSTRAINT [FK_TIECCUOI_SANH] FOREIGN KEY([MaSanh])
REFERENCES [dbo].[SANH] ([MaSanh])
GO
ALTER TABLE [dbo].[TIECCUOI] CHECK CONSTRAINT [FK_TIECCUOI_SANH]
GO
