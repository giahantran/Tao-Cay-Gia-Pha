USE [GIAPHA]
GO
/****** Object:  Table [dbo].CayGiP    Script Date: 12/13/2018 4:04:05 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CayGiP](
	[IDGP] [int] NULL,
	[ID] [int] NOT NULL,
	[ThếHệ] [smallint] NOT NULL,
	[ThuộcGiaPhả] [nvarchar](10) NULL,
	[HọvàTên] [nvarchar](50) NULL,
	[Giớitính] [nvarchar](5) NULL,
	[Ngàysinh] [date] NULL,
	[Ngàymất] [nvarchar](50) NULL,
	[Nơisinh] [nvarchar](50) NULL,
	[Nghềnghiệp] [nvarchar](50) NULL,
	[HọtênCha] [nvarchar](50) NULL,
	[HọtênMẹ] [nvarchar](50) NULL,
	[TênVợ_Chồng] [nvarchar](50) NULL,
	[HọtênCon] [nvarchar](200) NULL,
	[Ghichú] [nvarchar](200) NULL,
 CONSTRAINT [PK_CayGiP] PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[ThếHệ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 1, 1, N'Có', N'Lê Hồng Danh', N'Nam', CAST(N'1850-01-17' AS Date), N'1930-01-01', N'Gia Định', N'Thầy thuốc', N'Lê Ngọc Bảo', N'Bùi Bảo Ngọc', N'Lê Kim Đỉnh', N'Lê Minh Hiếu
Lê Trí Đức', N'')
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 2, 1, N'Không', N'Lê Kim Đỉnh', N'Nữ', CAST(N'1853-06-25' AS Date), N'1935-01-01', N'Gia Định', NULL, N'Lê Châu', N'Vũ Kim Huyền
', N'Lê Hồng Danh
', N'Lê Minh Hiếu
, Lê Trí Đức', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 3, 2, N'Có', N'Lê Minh Hiếu', N'Nam', CAST(N'1873-02-04' AS Date), N'1960-01-01', N'Gia Định', N'Giáo viên
', N'Lê Hồng Danh', N'Lê Kim Đỉnh
', N'Huỳnh Hiếu Thảo
', N'Lê Minh Tiến,
 Lê Tú V
i', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 4, 2, N'Có', N'Lê Trí Đức', N'Nam', CAST(N'1875-05-11' AS Date), N'1963-01-01', N'Gia Định', N'Thương gia
', N'Lê Hồng Danh', N'Lê Kim Đỉnh
', N'Nguyễn Ngọc Tiên
', N'Lê Hoàng Hiệp,
 Lê Hoàng Hà, 
Lê Ngọc Lon
g', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 5, 2, N'Không', N'Huỳnh Hiếu Thảo', N'Nữ', CAST(N'1873-12-09' AS Date), N'1662-01-01', N'Cần Thơ
', N'Buôn bán
', N'Huỳnh Hiếu Minh', N'Trần Tiểu Hà', N'Lê Minh Hiếu
', N'Lê Minh Tiến,
 Lê Tú Vi', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 6, 2, N'Không', N'Nguyễn Ngọc Tiên', N'Nữ', CAST(N'1876-10-03' AS Date), N'1959-01-01', N'Kiên Giang
', NULL, N'Nguyễn Tuân', N'Hồ Thanh Xuân
', N'Lê Trí Đức
', N'Lê Hoàng Hiệp,
 Lê Hoàng Hà, 
Lê Ngọc Long', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 7, 3, N'Có', N'Lê Minh Tiến', N'Nam', CAST(N'1898-09-15' AS Date), N'1980-01-01', N'Sài Gòn', N'Nông dân
', N'Lê Minh Hiếu', N'Huỳnh Hiếu Thảo
', N'Võ Kim Ngân
', N'Lê Hùng Duy,
 Lê Ánh Tuyết', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 8, 3, N'Có', N'Lê Tú Vi', N'Nữ', CAST(N'1900-06-06' AS Date), N'1975-01-01', N'Sài Gòn', N'Nông dân
', N'Lê Minh Hiếu', N'Huỳnh Hiếu Thảo
', N'Nguyễn Xuân Điền
', N'Nguyễn Lê Khánh', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 9, 3, N'Có', N'Lê Hoàng Hiệp', N'Nam', CAST(N'1899-08-14' AS Date), N'1978-01-01', N'Sài Gòn', N'Thầy thuốc', N'Lê Trí Đức', N'Nguyễn Ngọc Tiên
', NULL, NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 10, 3, N'Có', N'Lê Hoàng Hà', N'Nữ', CAST(N'1903-12-30' AS Date), N'1982-01-01', N'Sài Gòn', N'Buôn bán
', N'Lê Trí Đức', N'Nguyễn Ngọc Tiên
', N'Vũ Hiệp Hoàng
', N'Vũ Hoàng Hiệp,
 Vũ Anh Thư', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 11, 3, N'Có', N'Lê Ngọc Long', N'Nam', CAST(N'1905-11-23' AS Date), N'1980-01-01', N'Sài Gòn', N'Nông dân
', N'Lê Trí Đức', N'Nguyễn Ngọc Tiên
', N'Trần Khả Ái
', N'Lê Xuân Hoàng
', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 12, 3, N'Không', N'Võ Kim Ngân', N'Nữ', CAST(N'1900-12-03' AS Date), N'1967-01-01', N'Thanh Hóa
', NULL, N'Võ Hà Trang', N'Dương Tiểu Phụng
', N'Lê Minh Tiến
', N'Lê Hùng Duy,
 Lê Ánh Tuyết', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 13, 3, N'Không', N'Nguyễn Xuân Điền', N'Nam', CAST(N'1988-10-23' AS Date), N'1971-01-01', N'Hải Phòng
', N'Thương gia
', N'Nguyễn Quang', N'Ngọc Thanh Thanh
', N'Lê Tú Vi
', N'Nguyễn Lê khánh
', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 14, 3, N'Không', N'Vũ Hiệp Hoàng', N'Nam', CAST(N'1902-09-18' AS Date), N'1973-01-01', N'An Giang
', N'Nông dân
', N'Vũ Học', N'Đoàn Gia Hạnh
', N'Lê Hoàng Hà
', N'Vũ Hoàng Hiệp, 
Vũ Anh Thư', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 15, 3, N'Không', N'Trần Khả Ái', N'Nữ', CAST(N'1905-07-04' AS Date), N'1985-01-01', N'Sài Gòn', N'Giáo viên
', N'Trần Thanh Sơn', N'Hoàng Khả Ly
', N'Lê Ngọc Long
', N'Lê Xuân Hoàng
', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 16, 4, N'Có', N'Lê Ánh Tuyết', N'Nữ', CAST(N'1923-05-23' AS Date), N'2001-01-01', N'Sài Gòn', N'Chủ tịch Xã
', N'Lê Minh Tiến', N'Võ Kim Ngân
', N'Dương Khắc
', N'Dương Anh Tú
', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 17, 4, N'Có', N'Lê Hùng Duy', N'Nam', CAST(N'1925-08-07' AS Date), N'2004-01-01', N'Sài Gòn', N'Công nhân
', N'Lê Minh Tiến', N'Võ Kim Ngân
', N'Trần Uyên Thy
', N'Lê Trần Vinh,
 Lê Kim Phúc', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 18, 4, N'Không', N'Nguyễn Lê Khánh', N'Nữ', CAST(N'1926-09-18' AS Date), N'2002-01-01', N'Hải Phòng
', N'Nông dân
', N'Nguyễn Xuân Điền', N'Lê Tú Vi
', N'Võ Thành Văn
', NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 19, 4, N'Không', N'Vũ Hoàng Hiệp', N'Nam', CAST(N'1924-08-04' AS Date), N'2005-01-01', N'An Giang
', N'Chủ tịch Huyện
', N'Vũ Hiệp Hoàng', N'Lê Hoàng Hà
', NULL, NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 20, 4, N'Không', N'Vũ Anh Thư', N'Nữ', CAST(N'1930-07-12' AS Date), N'2010-01-01', N'An Giang
', N'Công nhân
', N'Vũ Hiệp Hoàng', N'Lê Hoàng Hà
', NULL, NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 21, 4, N'Có', N'Lê Xuân Hoàng', N'Nam', CAST(N'1931-12-04' AS Date), N'2012-01-01', N'Sài Gòn', N'Giáo viên
', N'Lê Ngọc Long', N'Trần Khả Ái
', N'Huỳnh Trúc Lan
', N'Lê Công Nhật
, Lê Hoàng Huân, Lê Thị Mai', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 22, 4, N'Không', N'Dương Khắc', N'Nam', CAST(N'1921-03-12' AS Date), N'2011-01-01', N'Bình Dương
', N'Giáo sư
', N'Dương Kha', N'Nguyễn Phúc Vi
', N'Lê Ánh Tuyết
', N'Dương Anh Tú
', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 23, 4, N'Không', N'Trần Uyên Thy', N'Nữ', CAST(N'1927-12-23' AS Date), N'2014-01-01', N'Vĩnh Long
', N' Buôn bán
', N'Trần Hoài', N'Vũ Phúc Nhân
', N'Lê Hùng Duy
', N'Lê Trần Vinh, 
Lê Kim Phúc', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 24, 4, N'Không', N'Võ Thành Văn', N'Nam', CAST(N'1925-01-01' AS Date), N'2015-01-01', N'Bình Định
', N'Công an
', N'Võ Minh Hiếu', N'Hà Kiều Trang
', N'Nguyễn Lê Khánh
', NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 25, 4, N'Không', N'Huỳnh Trúc Lan', N'Nữ', CAST(N'1933-11-12' AS Date), N'1999-01-01', N'Sài Gòn', N'Giáo viên
', N'Huỳnh Thái', N'Trịnh Thu Hường
', N'Lê Xuân Hoàng
', N' Lê Công Nhật
, Lê Hoàng Huân, Lê Thị Mai', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 26, 5, N'Có', N'Lê Trần Vinh', N'Nam', CAST(N'1950-04-06' AS Date), N'2016-06-05', N'Sài Gòn', N'Thương gia
', N'Lê Hùng Duy', N'Trần Uyên Thy
', N'Nguyễn Thị Hạnh
', N'Lê Văn Lộc, 
Lê Văn Công, Lê Văn Chí', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 27, 5, N'Có', N'Lê Kim Phúc', N'Nữ', CAST(N'1952-09-16' AS Date), N'', N'Sài Gòn', N'Công an
', N'Lê Hùng Duy', N'Trần Uyên Thy
', N'Hồ Xuân Trương
', NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 28, 5, N'Không', N'Dương Anh Tú', N'Nam', CAST(N'1945-05-07' AS Date), N'2017-10-06', N'Bình Dương
', N'Công nhân
', N'Dương Khắc', N'Lê Ánh Tuyết
', N'Võ Ngọc Lan
', N'Dương Khắc Vũ
', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 29, 5, N'Có', N'Lê Công Nhật', N'Nam', CAST(N'1955-08-04' AS Date), NULL, N'Sài Gòn', N'Tiến sĩ
', N'Lê Xuân Hoàng', N'Huỳnh Trúc Lan
', N'Bùi Dạ Yến', N'Lê Hoàng Trung, Lê Hoàng Lâm', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 30, 5, N'Không', N'Nguyễn Thị Hạnh', N'Nữ', CAST(N'1953-08-25' AS Date), N'2018-10-12', N'Kiên Giang
', N'Thương gia
', N'Nguyễn Khiêm', N'Ngô Thị Lan
', N'Lê Trần Vinh
', N'Lê Văn Lộc, 
Lê Văn Công, Lê Văn Chí', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 31, 5, N'Không', N'Võ Ngọc Lan', N'Nữ', CAST(N'1955-07-03' AS Date), NULL, N'Bình Thuận', N'Bác sĩ', N'Võ Hiếu', N'Lê Xuân Diệu', N'Dương Anh Tú', N'Dương Khắc Vũ', N'')
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 32, 5, N'Có', N'Lê Hoàng Huân', N'Nam', CAST(N'1956-12-12' AS Date), N'2018-04-03', N'Sài Gòn', N'Công nhân', N'Lê Xuân Hoàng', N'Huỳnh Trúc Lan', N'Huỳnh Khả Vân', N'Lê Lâm Trân, Lê Thu Như', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 33, 5, N'Có', N'Lê Thị Mai', N'Nữ', CAST(N'1957-11-06' AS Date), NULL, N'Sài Gòn', N'Thương nhân', N'Lê Xuân Hoàng', N'Huỳnh Trúc Lan', N'Đỗ Kim Hoàng', N'Đỗ Phủ, Đỗ Ngọc Quyên', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 34, 5, N'Không', N'Huỳnh Khả Vân', N'Nữ', CAST(N'1959-07-08' AS Date), NULL, N'Vũng Tàu', NULL, N'Huỳnh Lập', N'Bùi Gia Hân', N'Lê Xuân Hoàng', N'Lê Lâm Trân, Lê Thu Như', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 35, 5, N'Không', N'Bùi Dạ Yến', N'Nữ', CAST(N'1955-02-23' AS Date), N'2017-12-12', N'Đà Nẵng', N'Công nhân', N'Bùi Việt', N'Nguyễn Ngọc Ái', N'Lê Công Nhật', N'Lê Hoàng Trung, Lê Hoàng Lâm', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 36, 5, N'Không', N'Đỗ Kim Hoàng', N'Nam', CAST(N'1955-04-06' AS Date), NULL, N'Kiên Giang', N'Công an', N'Đỗ Trần An', N'Võ Lê Lan ', N'Lê Thị Mai', N'Đỗ Phủ, Đỗ Ngọc Quyên', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 37, 6, N'Có', N'Lê Văn Lộc', N'Nam', CAST(N'1970-01-06' AS Date), NULL, N'Sài Gòn', N'Công nhân', N'Lê Trần Vinh', N'Nguyễn Thị Hạnh', N'Huỳnh Như Hiền', N'Lê Huy, Lê Na', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 38, 6, N'Có', N'Lê Văn Công', N'Nam', CAST(N'1970-01-06' AS Date), NULL, N'Sài Gòn', N'Giáo viên', N'Lê Trần Vinh', N'Nguyễn Thị Hạnh', N'Trần Cát Phượng', N'Lê Diệp Vấn', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 39, 6, N'Có', N'Lê Văn Chí', N'Nam', CAST(N'1972-09-08' AS Date), NULL, N'Sài Gòn', NULL, N'Lê Trần Vinh', N'Nguyễn Thị Hạnh', N'Bùi Gia Nhung', N'Lê Văn Giang, Lê Đại Dương', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 40, 6, N'Có', N'Lê Lâm Trân', N'Nam', CAST(N'1974-12-05' AS Date), NULL, N'Sài Gòn', N'Bác sĩ', N'Lê Hoàng Huân', N'Trần Khả Vân', N'Võ Hồng Nhung', NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 41, 6, N'Có', N'Lê Thu Như', N'Nữ', CAST(N'1977-03-05' AS Date), NULL, N'Sài Gòn', N'Thương nhân', N'Lê Hoàng Huân', N'Trần Khả Vân', NULL, NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 42, 6, N'Có', N'Lê Hoàng Trung', N'Nam', CAST(N'1980-09-12' AS Date), NULL, N'Đồng Nai', N'Nông dân', N'Lê Công Nhật', N'Bùi Dạ Yến', N'Nguyễn Ngọc', NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 43, 6, N'Có', N'Lê Hoàng Lâm', N'Nam', CAST(N'1981-10-12' AS Date), NULL, N'Bình Dương', N'Giáo viên', N'Lê Công Nhật', N'Bùi Dạ Yến', N'Trần Vân Duyên', NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 44, 6, N'Không', N'Huỳnh Như Hiền', N'Nữ', CAST(N'1983-05-09' AS Date), NULL, N'Cà Mau', N'Nông dân', N'Huỳnh Phú Quốc', N'Nguyễn Hạ Trâm', N'Lê Văn Lộc', N'Lê Huy, Lê Na', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 45, 6, N'Không', N'Trần Cát Phượng', N'Nữ', CAST(N'1981-01-17' AS Date), NULL, N'Bình Phước', N'Thương gia', N'Trần Tâm', N'Võ Ngọc Châu', N'Lê Văn Công', N'Lê Diệp Vấn', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 46, 6, N'Không', N'Bùi Gia Nhung', N'Nữ', CAST(N'1983-08-04' AS Date), NULL, N'Bến Tre', NULL, N'Bùi Hiệp Hùng', N'Võ Yến Xuân', N'Lê Văn Chí', N'Lê Văn Giang, Lê Đại Dương', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 47, 6, N'Không', N'Võ Hồng Nhung', N'Nữ', CAST(N'1984-01-09' AS Date), NULL, N'Bình Thuận', NULL, N'Võ Phu', N'Lê Thu Phương', N'Lê Lâm Trân', NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 48, 6, N'Không', N'Nguyễn Ngọc', N'Nữ', CAST(N'1980-07-12' AS Date), NULL, N'Sài Gòn', N'Công nhân', N'Nguyễn Phước Long', N'Huỳnh Kim Ngân', N'Lê Hoàng Trung', NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 49, 6, N'Không', N'Trần Vân Uyên', N'Nữ', CAST(N'1978-09-01' AS Date), NULL, N'Bình Định', N'Giáo viên', N'Trần Đình Trọng', N'Võ Phương Thảo', N'Lê Hoàng Lâm', NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 50, 6, N'Không', N'Đỗ Ngọc Quyên', N'Nữ', CAST(N'1982-10-11' AS Date), NULL, N'Kiên Giang', N'Y tá', N'Đỗ Kim Hoàng', N'Lê Thị Mai', NULL, NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 51, 6, N'Không', N'Đỗ Phủ', N'Nam', CAST(N'1983-04-08' AS Date), NULL, N'Kiên Giang', N'Công nhân', N'Đỗ Kim Hoàng', N'Lê Thị Mai', NULL, NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 52, 7, N'Có', N'Lê Huy', N'Nam', CAST(N'1995-07-02' AS Date), NULL, N'Sài Gòn', N'Danh nhân', N'Lê Văn Lộc', N'Huỳnh Như Hiền', N'Nguyễn Thảo Trâm', N'Lê Huyền Đức, Lê Thanh Phong', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 53, 7, N'Có', N'Lê Na', N'Nữ', CAST(N'1997-12-02' AS Date), NULL, N'Sài Gòn', N'Công an', N'Lê Văn Lộc', N'Huỳnh Như Hiền', N'Dương Tấn Vỹ', NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 54, 7, N'Có', N'Lê Diệp Vấn', N'Nam', CAST(N'1996-10-05' AS Date), NULL, N'Sài Gòn', N'Công nhân', N'Lê Văn Công', N'Trần Cát Phượng', N'Trần Du Uyên', N'Lê Văn Quỳnh', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 55, 7, N'Có', N'Lê Văn Giang', N'Nam', CAST(N'1998-12-20' AS Date), NULL, N'Đồng Nai', N'Thầy giáo', N'Lê Văn Chí', N'Bùi Gia Nhung', N'Nguyễn An', N'Lê Quan, Lê Kiều Diễm', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 56, 7, N'Có', N'Lê Đại Dương', N'Nam', CAST(N'2000-12-04' AS Date), NULL, N'Đồng Nai', N'Công an', N'Lê Văn Chí', N'Bùi Gia Nhung', NULL, NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 57, 7, N'Có', N'Lê Phước Toàn', N'Nam', CAST(N'1996-04-19' AS Date), NULL, N'Sài Gòn', N'Công nhân', N'Lê Lâm Trân', N'Võ Hồng Nhung', N'Trịnh Ngọc Chương', N'Lê Thanh Anh, Lê Tú Duyên', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 58, 7, N'Có', N'Lê Kim Ái', N'Nữ', CAST(N'1998-05-15' AS Date), NULL, N'Sài Gòn', N'Buôn bán', N'Lê Lâm Trân', N'Võ Hồng Nhung', N'Trịnh Minh Nhật', N'Lê Hữu Thắng', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 59, 7, N'Có', N'Lê Kim Ngân', N'Nữ', CAST(N'2001-04-06' AS Date), NULL, N'Đồng Nai', N'Giáo viên', N'Lê Hoàng Trung', N'Nguyễn Ngọc', N'Trần Quang Việt', N'Lê Thanh Tú, Lê Thanh Bình', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 60, 7, N'Có', N'Lê Ngọc Hà', N'Nữ', CAST(N'2003-09-08' AS Date), NULL, N'Bình Dương', N'Buôn bán', N'Lê Hoàng Lâm', N'Trần Vân Duyên', N'Phan Sơn', N'Lê Hạ Huyền', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 61, 7, N'Không', N'Nguyễn Thảo Trâm', N'Nữ', CAST(N'1995-08-01' AS Date), NULL, N'Vũng Tàu', N'Danh nhân', N'Nguyễn Minh Trung', N'Đoàn Thị Thu Huyên', N'Lê Huy', N'Lê Huyền Đức, Lê Thanh Phong', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 62, 7, N'Không', N'Dương Tấn Vỹ', N'Nam', CAST(N'1993-01-06' AS Date), NULL, N'Bình Phước', N'Công nhân', N'Dương Anh VIệt', N'Trần Lê Ngọc Hương', N'Lê Na', NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 63, 7, N'Không', N'Trần Du Uyên', N'Nữ', CAST(N'1999-06-28' AS Date), NULL, N'Hà Nội', N'Danh nhân', N'Trần Du Dương', N'Huỳnh Mỹ Hiền', N'Lê Diệp Vấn', N'Lê Vân Quỳnh', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 64, 7, N'Không', N'Nguyễn An', N'Nữ', CAST(N'1997-07-07' AS Date), NULL, N'Ninh Thuận', N'Công an', N'Nguyễn Bình', N'Nguyễn Diễm Phúc', N'Lê Văn Giang', N'Lê Quan, Lê Kiều DIễm', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 65, 7, N'Không', N'Trịnh Ngọc Chương', N'Nữ', CAST(N'1999-10-12' AS Date), NULL, N'Bình Định', N'Buôn bán', N'Trịnh Quốc Đạt', N'Nguyễn Hạ Huyền', N'Lê Phước Toàn', N'Lê Thanh Anh, Lê Tú Duyên', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 66, 7, N'Không', N'Trịnh Minh Nhật', N'Nam', CAST(N'1996-02-04' AS Date), NULL, N'Phú Yên', N'Bác sĩ', N'Trịnh Thanh Tùng', N'Lê Khả Kiều Như', N'Lê Kim Ái', N'Lê Hữu Thắng', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 67, 7, N'Không', N'Trần Quang Việt', N'Nam', CAST(N'1995-10-18' AS Date), NULL, N'Nghệ An', N'Công nhân', N'Trần Tuấn', N'Đỗ Lan Ngọc', N'Lê Kim Ngân', N'Lê Thanh Tú, Lê Thanh Bình', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 68, 7, N'Không', N'Phan Sơn', N'Nam', CAST(N'1999-05-07' AS Date), NULL, N'Sài Gòn', N'Bác sĩ', N'Phan Thái Dương', N'Nguyễn Thanh Mai', N'Lê Kim Ngân', N'Phan Hạ Huyền', NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 69, 8, N'Có', N'Lê Huyền Đức', N'Nam', CAST(N'2015-10-08' AS Date), NULL, N'Sài Gòn', NULL, N'Lê Huy', N'Nguyễn Thảo Trâm', NULL, NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 70, 8, N'Có', N'Lê Thanh Phong', N'Nam', CAST(N'2016-11-06' AS Date), NULL, N'Sài Gòn', NULL, N'Lê Huy', N'Nguyễn Thảo Trâm', NULL, NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 71, 8, N'Có', N'Lê Vân Quỳnh', N'Nữ', CAST(N'2017-01-02' AS Date), NULL, N'Sài Gòn', NULL, N'Lê Diệp Vấn', N'Trần Du Uyên', NULL, NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 72, 8, N'Có', N'Lê Quan', N'Nam', CAST(N'2018-03-05' AS Date), NULL, N'Bình Dương', NULL, N'Lê Văn Giang', N'Nguyễn An', NULL, NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 73, 8, N'Có', N'Lê Kiều Diễm', N'Nữ', CAST(N'2018-03-05' AS Date), NULL, N'Bình Dương', NULL, N'Lê Văn Giang', N'Nguyễn An', NULL, NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 74, 8, N'Có', N'Lê Thanh Anh', N'Nam', CAST(N'2016-05-27' AS Date), NULL, N'Sài Gòn', NULL, N'Lê Phước Toàn', N'Trịnh Ngọc Chương', NULL, NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 75, 8, N'Có', N'Lê Tú Duyên', N'Nữ', CAST(N'2018-04-07' AS Date), NULL, N'Sài Gòn', NULL, N'Lê Phước Toàn', N'Trịnh Ngọc Chương', NULL, NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 76, 8, N'Có', N'Lê Hữu Thắng', N'Nam', CAST(N'2017-03-08' AS Date), NULL, N'Đồng Nai', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 77, 8, N'Không', N'Lê Thanh Tú', N'Nam', CAST(N'2018-05-03' AS Date), NULL, N'Nghệ An', NULL, N'Trần Quang Việt', N'Lê kim Ngân', NULL, NULL, NULL)
INSERT [dbo].CayGiP ([IDGP], [ID], [ThếHệ], [ThuộcGiaPhả], [HọvàTên], [Giớitính], [Ngàysinh], [Ngàymất], [Nơisinh], [Nghềnghiệp], [HọtênCha], [HọtênMẹ], [TênVợ_Chồng], [HọtênCon], [Ghichú]) VALUES (1, 78, 8, N'Không', N'Lê Thanh Bình', N'Nam', CAST(N'2018-05-03' AS Date), NULL, N'Nghệ An', NULL, N'Trần Quang Việt', N'Lê Kim Ngân', NULL, NULL, NULL)
