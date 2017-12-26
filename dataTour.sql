USE [QLTour]
GO
SET IDENTITY_INSERT [dbo].[LoaiDLs] ON 

INSERT [dbo].[LoaiDLs] ([Id], [TenGoi]) VALUES (1, N'Di động')
INSERT [dbo].[LoaiDLs] ([Id], [TenGoi]) VALUES (2, N'Xã hội và gia đình')
INSERT [dbo].[LoaiDLs] ([Id], [TenGoi]) VALUES (3, N'du lịch kết hợp nghề nghiệp')
SET IDENTITY_INSERT [dbo].[LoaiDLs] OFF
SET IDENTITY_INSERT [dbo].[Tours] ON 

INSERT [dbo].[Tours] ([Id], [TenGoi], [DacDiem], [LoaiDLId]) VALUES (1, N'tour 1', N'test1', 2)
INSERT [dbo].[Tours] ([Id], [TenGoi], [DacDiem], [LoaiDLId]) VALUES (2, N'Tour 2', N'test2', 1)
SET IDENTITY_INSERT [dbo].[Tours] OFF
SET IDENTITY_INSERT [dbo].[GiaTours] ON 

INSERT [dbo].[GiaTours] ([Id], [Gia], [NgayCapNhat], [TourId]) VALUES (1, 150000, CAST(0x0000A85400000000 AS DateTime), 1)
INSERT [dbo].[GiaTours] ([Id], [Gia], [NgayCapNhat], [TourId]) VALUES (2, 300000, CAST(0x0000A85A00000000 AS DateTime), 1)
INSERT [dbo].[GiaTours] ([Id], [Gia], [NgayCapNhat], [TourId]) VALUES (3, 300000, CAST(0x0000A85500000000 AS DateTime), 2)
INSERT [dbo].[GiaTours] ([Id], [Gia], [NgayCapNhat], [TourId]) VALUES (4, 500000, CAST(0x0000A85C00000000 AS DateTime), 1)
INSERT [dbo].[GiaTours] ([Id], [Gia], [NgayCapNhat], [TourId]) VALUES (5, 500000, CAST(0x0000A85B00000000 AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[GiaTours] OFF
SET IDENTITY_INSERT [dbo].[TinhThanhs] ON 

INSERT [dbo].[TinhThanhs] ([Id], [MaTinh], [TenTinh]) VALUES (1, N'01', N'TP,HCM')
INSERT [dbo].[TinhThanhs] ([Id], [MaTinh], [TenTinh]) VALUES (2, N'02', N'Hà Nội')
INSERT [dbo].[TinhThanhs] ([Id], [MaTinh], [TenTinh]) VALUES (3, N'DN', N'Đà Nẵng')
INSERT [dbo].[TinhThanhs] ([Id], [MaTinh], [TenTinh]) VALUES (4, N'BD', N'Bình Dương')
SET IDENTITY_INSERT [dbo].[TinhThanhs] OFF
SET IDENTITY_INSERT [dbo].[DiaDiems] ON 

INSERT [dbo].[DiaDiems] ([Id], [TenDiaDiem], [TinhThanhId]) VALUES (1, N'Vũng Tàu', 1)
INSERT [dbo].[DiaDiems] ([Id], [TenDiaDiem], [TinhThanhId]) VALUES (2, N'Hồ Gươm', 2)
INSERT [dbo].[DiaDiems] ([Id], [TenDiaDiem], [TinhThanhId]) VALUES (3, N'Đại Nam', 4)
INSERT [dbo].[DiaDiems] ([Id], [TenDiaDiem], [TinhThanhId]) VALUES (4, N'Phố đi bộ Nguyễn Huệ', 1)
INSERT [dbo].[DiaDiems] ([Id], [TenDiaDiem], [TinhThanhId]) VALUES (5, N'Cầu ánh sao', 1)
INSERT [dbo].[DiaDiems] ([Id], [TenDiaDiem], [TinhThanhId]) VALUES (6, N'Chùa 1 cột', 2)
INSERT [dbo].[DiaDiems] ([Id], [TenDiaDiem], [TinhThanhId]) VALUES (7, N'Chợ Hàn', 3)
SET IDENTITY_INSERT [dbo].[DiaDiems] OFF
SET IDENTITY_INSERT [dbo].[CTTours] ON 

INSERT [dbo].[CTTours] ([Id], [TourId], [DiaDiemId], [ThuTuThamQuan]) VALUES (1, 1, 1, 1)
INSERT [dbo].[CTTours] ([Id], [TourId], [DiaDiemId], [ThuTuThamQuan]) VALUES (2, 1, 3, 2)
INSERT [dbo].[CTTours] ([Id], [TourId], [DiaDiemId], [ThuTuThamQuan]) VALUES (3, 1, 6, 3)
INSERT [dbo].[CTTours] ([Id], [TourId], [DiaDiemId], [ThuTuThamQuan]) VALUES (4, 2, 3, 1)
INSERT [dbo].[CTTours] ([Id], [TourId], [DiaDiemId], [ThuTuThamQuan]) VALUES (5, 2, 5, 2)
INSERT [dbo].[CTTours] ([Id], [TourId], [DiaDiemId], [ThuTuThamQuan]) VALUES (6, 2, 4, 3)
SET IDENTITY_INSERT [dbo].[CTTours] OFF
SET IDENTITY_INSERT [dbo].[DoanKhaches] ON 

INSERT [dbo].[DoanKhaches] ([Id], [TenGoi], [NgayKhoiHanh], [NgayKetThuc], [TourId], [SLCho], [TongChiPhi], [isEdit]) VALUES (1, N'Tour 1-Đoàn 1', CAST(0x0000A85500000000 AS DateTime), CAST(0x0000A85900000000 AS DateTime), 1, 20, 500000, 1)
INSERT [dbo].[DoanKhaches] ([Id], [TenGoi], [NgayKhoiHanh], [NgayKetThuc], [TourId], [SLCho], [TongChiPhi], [isEdit]) VALUES (2, N'Tour1-Đoan 2', CAST(0x0000A85900000000 AS DateTime), CAST(0x0000A85C00000000 AS DateTime), 1, 20, 600000, 1)
INSERT [dbo].[DoanKhaches] ([Id], [TenGoi], [NgayKhoiHanh], [NgayKetThuc], [TourId], [SLCho], [TongChiPhi], [isEdit]) VALUES (3, N'Tour 2 -Doan 1', CAST(0x0000A85B00000000 AS DateTime), CAST(0x0000A85D00000000 AS DateTime), 2, 10, 300000, 1)
INSERT [dbo].[DoanKhaches] ([Id], [TenGoi], [NgayKhoiHanh], [NgayKetThuc], [TourId], [SLCho], [TongChiPhi], [isEdit]) VALUES (4, N'Tour 2-Doan 2', CAST(0x0000A85600000000 AS DateTime), CAST(0x0000AB1600000000 AS DateTime), 2, 10, 200000, 1)
SET IDENTITY_INSERT [dbo].[DoanKhaches] OFF
SET IDENTITY_INSERT [dbo].[KhachHangs] ON 

INSERT [dbo].[KhachHangs] ([Id], [HoTen], [CMND], [DiaChi], [SDT], [GioiTinh]) VALUES (1, N'KH1', N'111111', N'a', N'11111', 1)
INSERT [dbo].[KhachHangs] ([Id], [HoTen], [CMND], [DiaChi], [SDT], [GioiTinh]) VALUES (2, N'KH2', N'22222', N'b', N'22222', 1)
INSERT [dbo].[KhachHangs] ([Id], [HoTen], [CMND], [DiaChi], [SDT], [GioiTinh]) VALUES (3, N'KH3', N'33333', N'c', N'3333', 0)
INSERT [dbo].[KhachHangs] ([Id], [HoTen], [CMND], [DiaChi], [SDT], [GioiTinh]) VALUES (4, N'KH4', N'4444', N'd', N'4444', 1)
INSERT [dbo].[KhachHangs] ([Id], [HoTen], [CMND], [DiaChi], [SDT], [GioiTinh]) VALUES (5, N'KH5', N'5555', N'e', N'5555', 0)
INSERT [dbo].[KhachHangs] ([Id], [HoTen], [CMND], [DiaChi], [SDT], [GioiTinh]) VALUES (7, N'KH6', N'6666', N'f', N'6666', 0)
SET IDENTITY_INSERT [dbo].[KhachHangs] OFF
SET IDENTITY_INSERT [dbo].[DSKhachTheoDoans] ON 

INSERT [dbo].[DSKhachTheoDoans] ([Id], [DoanKhachId], [KhachHangId]) VALUES (3, 1, 1)
INSERT [dbo].[DSKhachTheoDoans] ([Id], [DoanKhachId], [KhachHangId]) VALUES (4, 1, 2)
INSERT [dbo].[DSKhachTheoDoans] ([Id], [DoanKhachId], [KhachHangId]) VALUES (5, 1, 3)
INSERT [dbo].[DSKhachTheoDoans] ([Id], [DoanKhachId], [KhachHangId]) VALUES (6, 1, 4)
INSERT [dbo].[DSKhachTheoDoans] ([Id], [DoanKhachId], [KhachHangId]) VALUES (8, 2, 7)
INSERT [dbo].[DSKhachTheoDoans] ([Id], [DoanKhachId], [KhachHangId]) VALUES (9, 2, 5)
INSERT [dbo].[DSKhachTheoDoans] ([Id], [DoanKhachId], [KhachHangId]) VALUES (10, 3, 1)
INSERT [dbo].[DSKhachTheoDoans] ([Id], [DoanKhachId], [KhachHangId]) VALUES (11, 3, 3)
INSERT [dbo].[DSKhachTheoDoans] ([Id], [DoanKhachId], [KhachHangId]) VALUES (12, 4, 4)
SET IDENTITY_INSERT [dbo].[DSKhachTheoDoans] OFF
