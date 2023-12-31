USE [QLCF]
GO
/****** Object:  Table [dbo].[CaSangTheoNgay]    Script Date: 19/10/2022 1:05:30 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CaSangTheoNgay](
	[CaSang] [nchar](10) NOT NULL,
	[NVPC] [nchar](10) NOT NULL,
	[NVPV] [nchar](10) NOT NULL,
	[NVBV] [nchar](10) NOT NULL,
	[SoGioLam] [int] NOT NULL,
 CONSTRAINT [PK_CaSangTheoNgay] PRIMARY KEY CLUSTERED 
(
	[CaSang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CaToiTheoNgay]    Script Date: 19/10/2022 1:05:30 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CaToiTheoNgay](
	[CaToi] [nchar](10) NOT NULL,
	[NVPC] [nchar](10) NOT NULL,
	[NVPV] [nchar](10) NOT NULL,
	[NVBV] [nchar](10) NOT NULL,
	[SoGioLam] [int] NOT NULL,
 CONSTRAINT [PK_CaToiTheoNgay] PRIMARY KEY CLUSTERED 
(
	[CaToi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CaTruaTheoNgay]    Script Date: 19/10/2022 1:05:30 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CaTruaTheoNgay](
	[CaTrua] [nchar](10) NOT NULL,
	[NVPC] [nchar](10) NOT NULL,
	[NVPV] [nchar](10) NOT NULL,
	[NVBV] [nchar](10) NOT NULL,
	[SoGioLam] [int] NOT NULL,
 CONSTRAINT [PK_CaTruaTheoNgay] PRIMARY KEY CLUSTERED 
(
	[CaTrua] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LichTheoNgay]    Script Date: 19/10/2022 1:05:30 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LichTheoNgay](
	[MaLichTheoNgay] [nchar](8) NOT NULL,
	[NgayLap] [smalldatetime] NOT NULL,
	[NguoiLap] [nchar](10) NOT NULL,
	[CaSang] [nchar](10) NOT NULL,
	[CaTrua] [nchar](10) NOT NULL,
	[CaToi] [nchar](10) NOT NULL,
 CONSTRAINT [PK_LichTheoNgay] PRIMARY KEY CLUSTERED 
(
	[MaLichTheoNgay] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 19/10/2022 1:05:30 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[MaNV] [nchar](10) NOT NULL,
	[UserName] [nchar](50) NOT NULL,
	[Password] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LuongTheoNgay]    Script Date: 19/10/2022 1:05:30 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LuongTheoNgay](
	[MaLichTheoNgay] [nchar](8) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](100) NOT NULL,
	[SoGioLam] [int] NOT NULL,
	[Luong] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 19/10/2022 1:05:30 SA ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](100) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[LuongTheoGio] [money] NOT NULL,
	[GioiTinh] [bit] NOT NULL,
	[SDT] [nchar](12) NOT NULL,
	[Email] [nchar](50) NOT NULL,
	[Anh] [nchar](300) NOT NULL,
	[ChucVu] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CaSangTheoNgay] ([CaSang], [NVPC], [NVPV], [NVBV], [SoGioLam]) VALUES (N'17102022_1', N'NVPC01    ', N'NVPV01    ', N'NVBV01    ', 5)
INSERT [dbo].[CaSangTheoNgay] ([CaSang], [NVPC], [NVPV], [NVBV], [SoGioLam]) VALUES (N'18102022_1', N'NVPC02    ', N'NVPV02    ', N'NVBV02    ', 4)
GO
INSERT [dbo].[CaToiTheoNgay] ([CaToi], [NVPC], [NVPV], [NVBV], [SoGioLam]) VALUES (N'17102022_3', N'NVPC01    ', N'NVPV01    ', N'NVBV01    ', 5)
INSERT [dbo].[CaToiTheoNgay] ([CaToi], [NVPC], [NVPV], [NVBV], [SoGioLam]) VALUES (N'18102022_3', N'NVPC02    ', N'NVPV02    ', N'NVBV02    ', 5)
GO
INSERT [dbo].[CaTruaTheoNgay] ([CaTrua], [NVPC], [NVPV], [NVBV], [SoGioLam]) VALUES (N'17102022_2', N'NVPC02    ', N'NVPV02    ', N'NVBV02    ', 7)
INSERT [dbo].[CaTruaTheoNgay] ([CaTrua], [NVPC], [NVPV], [NVBV], [SoGioLam]) VALUES (N'18102022_2', N'NVPC01    ', N'NVPV01    ', N'NVBV01    ', 4)
GO
INSERT [dbo].[LichTheoNgay] ([MaLichTheoNgay], [NgayLap], [NguoiLap], [CaSang], [CaTrua], [CaToi]) VALUES (N'17102022', CAST(N'2022-10-16T00:00:00' AS SmallDateTime), N'NVQL01    ', N'17102022_1', N'17102022_2', N'17102022_3')
INSERT [dbo].[LichTheoNgay] ([MaLichTheoNgay], [NgayLap], [NguoiLap], [CaSang], [CaTrua], [CaToi]) VALUES (N'18102022', CAST(N'2022-10-17T00:00:00' AS SmallDateTime), N'NVQL02    ', N'18102022_1', N'18102022_2', N'18102022_3')
GO
INSERT [dbo].[Login] ([MaNV], [UserName], [Password]) VALUES (N'Admin     ', N'admin                                             ', N'admin                                             ')
INSERT [dbo].[Login] ([MaNV], [UserName], [Password]) VALUES (N'NVBV01    ', N'bv1                                               ', N'bv1                                               ')
INSERT [dbo].[Login] ([MaNV], [UserName], [Password]) VALUES (N'NVBV02    ', N'bv2                                               ', N'bv2                                               ')
INSERT [dbo].[Login] ([MaNV], [UserName], [Password]) VALUES (N'NVPC01    ', N'pc1                                               ', N'pc1                                               ')
INSERT [dbo].[Login] ([MaNV], [UserName], [Password]) VALUES (N'NVPC02    ', N'pc2                                               ', N'pc2                                               ')
INSERT [dbo].[Login] ([MaNV], [UserName], [Password]) VALUES (N'NVPV01    ', N'pv1                                               ', N'pv1                                               ')
INSERT [dbo].[Login] ([MaNV], [UserName], [Password]) VALUES (N'NVPV02    ', N'pv2                                               ', N'pv2                                               ')
INSERT [dbo].[Login] ([MaNV], [UserName], [Password]) VALUES (N'NVQL01    ', N'ql1                                               ', N'ql1                                               ')
INSERT [dbo].[Login] ([MaNV], [UserName], [Password]) VALUES (N'NVQL02    ', N'ql2                                               ', N'ql2                                               ')
GO
INSERT [dbo].[LuongTheoNgay] ([MaLichTheoNgay], [MaNV], [TenNV], [SoGioLam], [Luong]) VALUES (N'17102022', N'NVBV01    ', N'E', 10, 216000.0000)
INSERT [dbo].[LuongTheoNgay] ([MaLichTheoNgay], [MaNV], [TenNV], [SoGioLam], [Luong]) VALUES (N'17102022', N'NVBV02    ', N'f', 7, 144000.0000)
INSERT [dbo].[LuongTheoNgay] ([MaLichTheoNgay], [MaNV], [TenNV], [SoGioLam], [Luong]) VALUES (N'17102022', N'NVPC01    ', N'C', 10, 225000.0000)
INSERT [dbo].[LuongTheoNgay] ([MaLichTheoNgay], [MaNV], [TenNV], [SoGioLam], [Luong]) VALUES (N'17102022', N'NVPC02    ', N'D', 7, 150000.0000)
INSERT [dbo].[LuongTheoNgay] ([MaLichTheoNgay], [MaNV], [TenNV], [SoGioLam], [Luong]) VALUES (N'17102022', N'NVPV01    ', N'G', 10, 216000.0000)
INSERT [dbo].[LuongTheoNgay] ([MaLichTheoNgay], [MaNV], [TenNV], [SoGioLam], [Luong]) VALUES (N'17102022', N'NVPV02    ', N'H ', 7, 144000.0000)
INSERT [dbo].[LuongTheoNgay] ([MaLichTheoNgay], [MaNV], [TenNV], [SoGioLam], [Luong]) VALUES (N'18102022', N'NVBV01    ', N'E', 4, 120000.0000)
INSERT [dbo].[LuongTheoNgay] ([MaLichTheoNgay], [MaNV], [TenNV], [SoGioLam], [Luong]) VALUES (N'18102022', N'NVBV02    ', N'f', 9, 240000.0000)
INSERT [dbo].[LuongTheoNgay] ([MaLichTheoNgay], [MaNV], [TenNV], [SoGioLam], [Luong]) VALUES (N'18102022', N'NVPC01    ', N'C', 4, 125000.0000)
INSERT [dbo].[LuongTheoNgay] ([MaLichTheoNgay], [MaNV], [TenNV], [SoGioLam], [Luong]) VALUES (N'18102022', N'NVPC02    ', N'D', 9, 250000.0000)
INSERT [dbo].[LuongTheoNgay] ([MaLichTheoNgay], [MaNV], [TenNV], [SoGioLam], [Luong]) VALUES (N'18102022', N'NVPV01    ', N'G', 4, 120000.0000)
INSERT [dbo].[LuongTheoNgay] ([MaLichTheoNgay], [MaNV], [TenNV], [SoGioLam], [Luong]) VALUES (N'18102022', N'NVPV02    ', N'H ', 9, 240000.0000)
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [LuongTheoGio], [GioiTinh], [SDT], [Email], [Anh], [ChucVu]) VALUES (N'Admin     ', N'I', CAST(N'2000-10-20' AS Date), 25001.0000, 0, N'12463665426 ', N'kjrg@gmail.com                                    ', N'vuheguieh                                                                                                                                                                                                                                                                                                   ', N'Admin')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [LuongTheoGio], [GioiTinh], [SDT], [Email], [Anh], [ChucVu]) VALUES (N'NVBV01    ', N'E', CAST(N'2000-09-21' AS Date), 24000.0000, 0, N'1231521534  ', N'aegjeab@gmail.com                                 ', N'jgnarjrn                                                                                                                                                                                                                                                                                                    ', N'Nhân Viên Bảo Vệ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [LuongTheoGio], [GioiTinh], [SDT], [Email], [Anh], [ChucVu]) VALUES (N'NVBV02    ', N'f', CAST(N'2001-03-18' AS Date), 24000.0000, 1, N'123123121   ', N'jghre@gmail.com                                   ', N'rbiurher                                                                                                                                                                                                                                                                                                    ', N'Nhân Viên Bảo Vệ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [LuongTheoGio], [GioiTinh], [SDT], [Email], [Anh], [ChucVu]) VALUES (N'NVPC01    ', N'C', CAST(N'2009-11-20' AS Date), 25000.0000, 1, N'1249124-91  ', N'djgnreo@gmail.com                                 ', N'rogneroig                                                                                                                                                                                                                                                                                                   ', N'Nhân Viên Pha Chế')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [LuongTheoGio], [GioiTinh], [SDT], [Email], [Anh], [ChucVu]) VALUES (N'NVPC02    ', N'D', CAST(N'2003-08-21' AS Date), 25000.0000, 0, N'41203124    ', N'elgj@gmail.com                                    ', N'ogehgouehg                                                                                                                                                                                                                                                                                                  ', N'Nhân Viên Pha Chế')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [LuongTheoGio], [GioiTinh], [SDT], [Email], [Anh], [ChucVu]) VALUES (N'NVPV01    ', N'G', CAST(N'2005-06-19' AS Date), 24000.0000, 0, N'123123123   ', N'friugre@gmail.com                                 ', N'riuveiuehg                                                                                                                                                                                                                                                                                                  ', N'Nhân Viên Phục Vụ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [LuongTheoGio], [GioiTinh], [SDT], [Email], [Anh], [ChucVu]) VALUES (N'NVPV02    ', N'H ', CAST(N'2004-03-16' AS Date), 24000.0000, 1, N'12312536324 ', N'fojejgou@gmail.com                                ', N'egjerbgeughr                                                                                                                                                                                                                                                                                                ', N'Nhân Viên Phục Vụ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [LuongTheoGio], [GioiTinh], [SDT], [Email], [Anh], [ChucVu]) VALUES (N'NVQL01    ', N'A', CAST(N'2012-09-04' AS Date), 26000.0000, 1, N'2414123     ', N'wgr@gmail.com                                     ', N'rwognrgierg                                                                                                                                                                                                                                                                                                 ', N'Quản Lý')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [NgaySinh], [LuongTheoGio], [GioiTinh], [SDT], [Email], [Anh], [ChucVu]) VALUES (N'NVQL02    ', N'B', CAST(N'2008-10-20' AS Date), 25000.0000, 0, N'1294814-914 ', N'dgjrng@gmail.com                                  ', N'jnoerioergjreoig                                                                                                                                                                                                                                                                                            ', N'Quản Lý')
GO
ALTER TABLE [dbo].[LichTheoNgay]  WITH CHECK ADD  CONSTRAINT [FK_LichTheoNgay_CaSangTheoNgay] FOREIGN KEY([CaSang])
REFERENCES [dbo].[CaSangTheoNgay] ([CaSang])
GO
ALTER TABLE [dbo].[LichTheoNgay] CHECK CONSTRAINT [FK_LichTheoNgay_CaSangTheoNgay]
GO
ALTER TABLE [dbo].[LichTheoNgay]  WITH CHECK ADD  CONSTRAINT [FK_LichTheoNgay_CaToiTheoNgay] FOREIGN KEY([CaToi])
REFERENCES [dbo].[CaToiTheoNgay] ([CaToi])
GO
ALTER TABLE [dbo].[LichTheoNgay] CHECK CONSTRAINT [FK_LichTheoNgay_CaToiTheoNgay]
GO
ALTER TABLE [dbo].[LichTheoNgay]  WITH CHECK ADD  CONSTRAINT [FK_LichTheoNgay_CaTruaTheoNgay] FOREIGN KEY([CaTrua])
REFERENCES [dbo].[CaTruaTheoNgay] ([CaTrua])
GO
ALTER TABLE [dbo].[LichTheoNgay] CHECK CONSTRAINT [FK_LichTheoNgay_CaTruaTheoNgay]
GO
ALTER TABLE [dbo].[LichTheoNgay]  WITH CHECK ADD  CONSTRAINT [FK_LichTheoNgay_NhanVien] FOREIGN KEY([NguoiLap])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[LichTheoNgay] CHECK CONSTRAINT [FK_LichTheoNgay_NhanVien]
GO
ALTER TABLE [dbo].[Login]  WITH CHECK ADD  CONSTRAINT [FK__Login__MaNV__1DE57479] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Login] CHECK CONSTRAINT [FK__Login__MaNV__1DE57479]
GO
ALTER TABLE [dbo].[LuongTheoNgay]  WITH CHECK ADD  CONSTRAINT [FK_LuongTheoNgay_LichTheoNgay] FOREIGN KEY([MaLichTheoNgay])
REFERENCES [dbo].[LichTheoNgay] ([MaLichTheoNgay])
GO
ALTER TABLE [dbo].[LuongTheoNgay] CHECK CONSTRAINT [FK_LuongTheoNgay_LichTheoNgay]
GO
ALTER TABLE [dbo].[CaSangTheoNgay]  WITH CHECK ADD CHECK  (([NVBV] like 'NVBV%'))
GO
ALTER TABLE [dbo].[CaSangTheoNgay]  WITH CHECK ADD CHECK  (([NVPC] like 'NVPC%'))
GO
ALTER TABLE [dbo].[CaSangTheoNgay]  WITH CHECK ADD CHECK  (([NVPV] like 'NVPV%'))
GO
ALTER TABLE [dbo].[CaToiTheoNgay]  WITH CHECK ADD CHECK  (([NVBV] like 'NVBV%'))
GO
ALTER TABLE [dbo].[CaToiTheoNgay]  WITH CHECK ADD CHECK  (([NVPC] like 'NVPC%'))
GO
ALTER TABLE [dbo].[CaToiTheoNgay]  WITH CHECK ADD CHECK  (([NVPV] like 'NVPV%'))
GO
ALTER TABLE [dbo].[CaTruaTheoNgay]  WITH CHECK ADD CHECK  (([NVBV] like 'NVBV%'))
GO
ALTER TABLE [dbo].[CaTruaTheoNgay]  WITH CHECK ADD CHECK  (([NVPC] like 'NVPC%'))
GO
ALTER TABLE [dbo].[CaTruaTheoNgay]  WITH CHECK ADD CHECK  (([NVPV] like 'NVPV%'))
GO
ALTER TABLE [dbo].[LichTheoNgay]  WITH CHECK ADD CHECK  (([NguoiLap] like 'NVQL%'))
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [CK__NhanVien__ChucVu__286302EC] CHECK  (([ChucVu]='Admin' OR [ChucVu]=N'Nhân Viên Bảo Vệ' OR [ChucVu]=N'Nhân Viên Phục Vụ' OR [ChucVu]=N'Nhân Viên Pha Chế' OR [ChucVu]=N'Quản Lý'))
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [CK__NhanVien__ChucVu__286302EC]
GO
