USE [QLtour]
GO
SET IDENTITY_INSERT [dbo].[KhachHangs] ON 

INSERT [dbo].[KhachHangs] ([Id], [HoTen], [CMND], [DiaChi], [SDT], [GioiTinh]) VALUES (1, N'KH1', N'111111', N'a', N'11111', 1)
INSERT [dbo].[KhachHangs] ([Id], [HoTen], [CMND], [DiaChi], [SDT], [GioiTinh]) VALUES (2, N'KH2', N'22222', N'b', N'22222', 1)
INSERT [dbo].[KhachHangs] ([Id], [HoTen], [CMND], [DiaChi], [SDT], [GioiTinh]) VALUES (3, N'KH3', N'33333', N'c', N'3333', 0)
INSERT [dbo].[KhachHangs] ([Id], [HoTen], [CMND], [DiaChi], [SDT], [GioiTinh]) VALUES (4, N'KH4', N'4444', N'd', N'4444', 1)
INSERT [dbo].[KhachHangs] ([Id], [HoTen], [CMND], [DiaChi], [SDT], [GioiTinh]) VALUES (5, N'KH5', N'5555', N'e', N'5555', 0)
INSERT [dbo].[KhachHangs] ([Id], [HoTen], [CMND], [DiaChi], [SDT], [GioiTinh]) VALUES (7, N'KH6', N'6666', N'f', N'6666', 0)
INSERT [dbo].[KhachHangs] ([Id], [HoTen], [CMND], [DiaChi], [SDT], [GioiTinh]) VALUES (8, N'Lê Minh Huy', N'123', N'123', N'123', 0)
SET IDENTITY_INSERT [dbo].[KhachHangs] OFF
SET IDENTITY_INSERT [dbo].[LoaiDLs] ON 

INSERT [dbo].[LoaiDLs] ([Id], [TenGoi]) VALUES (1, N'Di động')
INSERT [dbo].[LoaiDLs] ([Id], [TenGoi]) VALUES (2, N'Xã hội và gia đình')
INSERT [dbo].[LoaiDLs] ([Id], [TenGoi]) VALUES (3, N'du lịch kết hợp nghề nghiệp')
SET IDENTITY_INSERT [dbo].[LoaiDLs] OFF
SET IDENTITY_INSERT [dbo].[Tours] ON 

INSERT [dbo].[Tours] ([Id], [TenGoi], [DacDiem], [LoaiDLId]) VALUES (1, N'tour 1', N'test1', 2)
INSERT [dbo].[Tours] ([Id], [TenGoi], [DacDiem], [LoaiDLId]) VALUES (2, N'Tour 2', N'test2', 1)
SET IDENTITY_INSERT [dbo].[Tours] OFF
SET IDENTITY_INSERT [dbo].[DoanKhaches] ON 

INSERT [dbo].[DoanKhaches] ([Id], [TenGoi], [NgayKhoiHanh], [NgayKetThuc], [TourId], [SLCho], [TongChiPhi], [isEdit]) VALUES (1, N'Tour 1-Đoàn 1', CAST(N'2017-12-26T00:00:00.000' AS DateTime), CAST(N'2017-12-30T00:00:00.000' AS DateTime), 1, 20, 500000, 1)
INSERT [dbo].[DoanKhaches] ([Id], [TenGoi], [NgayKhoiHanh], [NgayKetThuc], [TourId], [SLCho], [TongChiPhi], [isEdit]) VALUES (2, N'Tour1-Đoan 2', CAST(N'2017-12-30T00:00:00.000' AS DateTime), CAST(N'2018-01-02T00:00:00.000' AS DateTime), 1, 20, 600000, 1)
INSERT [dbo].[DoanKhaches] ([Id], [TenGoi], [NgayKhoiHanh], [NgayKetThuc], [TourId], [SLCho], [TongChiPhi], [isEdit]) VALUES (3, N'Tour 2 -Doan 1', CAST(N'2018-01-01T00:00:00.000' AS DateTime), CAST(N'2018-01-03T00:00:00.000' AS DateTime), 2, 10, 300000, 1)
INSERT [dbo].[DoanKhaches] ([Id], [TenGoi], [NgayKhoiHanh], [NgayKetThuc], [TourId], [SLCho], [TongChiPhi], [isEdit]) VALUES (4, N'Tour 2-Doan 2', CAST(N'2017-12-27T00:00:00.000' AS DateTime), CAST(N'2019-12-01T00:00:00.000' AS DateTime), 2, 10, 200000, 1)
INSERT [dbo].[DoanKhaches] ([Id], [TenGoi], [NgayKhoiHanh], [NgayKetThuc], [TourId], [SLCho], [TongChiPhi], [isEdit]) VALUES (5, N'Đoàn Test Tiền', CAST(N'2017-12-01T23:40:13.000' AS DateTime), CAST(N'2017-12-11T23:40:15.000' AS DateTime), 2, 5, 35500000, 1)
SET IDENTITY_INSERT [dbo].[DoanKhaches] OFF
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
INSERT [dbo].[DSKhachTheoDoans] ([Id], [DoanKhachId], [KhachHangId]) VALUES (13, 5, 7)
INSERT [dbo].[DSKhachTheoDoans] ([Id], [DoanKhachId], [KhachHangId]) VALUES (14, 5, 5)
INSERT [dbo].[DSKhachTheoDoans] ([Id], [DoanKhachId], [KhachHangId]) VALUES (15, 5, 8)
INSERT [dbo].[DSKhachTheoDoans] ([Id], [DoanKhachId], [KhachHangId]) VALUES (16, 1, 8)
INSERT [dbo].[DSKhachTheoDoans] ([Id], [DoanKhachId], [KhachHangId]) VALUES (17, 4, 8)
SET IDENTITY_INSERT [dbo].[DSKhachTheoDoans] OFF
SET IDENTITY_INSERT [dbo].[NhiemVus] ON 

INSERT [dbo].[NhiemVus] ([Id], [TenNhiemVu]) VALUES (1, N'Lái Xe')
INSERT [dbo].[NhiemVus] ([Id], [TenNhiemVu]) VALUES (2, N'Hướng Dẫn Viên')
INSERT [dbo].[NhiemVus] ([Id], [TenNhiemVu]) VALUES (3, N'Phục Vụ')
INSERT [dbo].[NhiemVus] ([Id], [TenNhiemVu]) VALUES (4, N'Thông Dịch Viên')
INSERT [dbo].[NhiemVus] ([Id], [TenNhiemVu]) VALUES (5, N'Tiền Trạm')
SET IDENTITY_INSERT [dbo].[NhiemVus] OFF
SET IDENTITY_INSERT [dbo].[NhanViens] ON 

INSERT [dbo].[NhanViens] ([Id], [TenNhanVien]) VALUES (1, N'Phạm Thị Kim Ngân')
INSERT [dbo].[NhanViens] ([Id], [TenNhanVien]) VALUES (2, N'Nguyễn Mạnh Cường')
SET IDENTITY_INSERT [dbo].[NhanViens] OFF
SET IDENTITY_INSERT [dbo].[NhanVienTheoDoans] ON 

INSERT [dbo].[NhanVienTheoDoans] ([Id], [idNhiemVu], [idNhanVien], [idDoanKhach]) VALUES (1, 2, 1, 1)
INSERT [dbo].[NhanVienTheoDoans] ([Id], [idNhiemVu], [idNhanVien], [idDoanKhach]) VALUES (2, 1, 2, 1)
INSERT [dbo].[NhanVienTheoDoans] ([Id], [idNhiemVu], [idNhanVien], [idDoanKhach]) VALUES (3, 1, 1, 5)
INSERT [dbo].[NhanVienTheoDoans] ([Id], [idNhiemVu], [idNhanVien], [idDoanKhach]) VALUES (4, 1, 2, 5)
SET IDENTITY_INSERT [dbo].[NhanVienTheoDoans] OFF
SET IDENTITY_INSERT [dbo].[KhachSanTheoDoans] ON 

INSERT [dbo].[KhachSanTheoDoans] ([Id], [TenKs], [DoanKhachId], [GiaTien]) VALUES (1, N'Khách Sạn Ngàn Sao', 5, 5000000)
INSERT [dbo].[KhachSanTheoDoans] ([Id], [TenKs], [DoanKhachId], [GiaTien]) VALUES (2, N'Khách Sạn Hết Sao', 5, 3000000)
SET IDENTITY_INSERT [dbo].[KhachSanTheoDoans] OFF
SET IDENTITY_INSERT [dbo].[PhuongTienTheoDoans] ON 

INSERT [dbo].[PhuongTienTheoDoans] ([Id], [TenPT], [DoanKhachId], [GiaTien]) VALUES (1, N'Xe Khách 45 Chỗ', 5, 10000000)
SET IDENTITY_INSERT [dbo].[PhuongTienTheoDoans] OFF
SET IDENTITY_INSERT [dbo].[ChiPhiKhacTheoDoans] ON 

INSERT [dbo].[ChiPhiKhacTheoDoans] ([Id], [DoanKhachId], [TenGoi], [GiaTien]) VALUES (1, 5, N'Tiền Đồ Ăn Vặt', 500000)
SET IDENTITY_INSERT [dbo].[ChiPhiKhacTheoDoans] OFF
SET IDENTITY_INSERT [dbo].[TienAnTheoDoans] ON 

INSERT [dbo].[TienAnTheoDoans] ([Id], [TenGoi], [DoanKhachId], [GiaTien]) VALUES (1, N'Nhà Hàng Bến Lức', 5, 5000000)
INSERT [dbo].[TienAnTheoDoans] ([Id], [TenGoi], [DoanKhachId], [GiaTien]) VALUES (2, N'Nhà Hàng Thủy Tạ', 5, 12000000)
SET IDENTITY_INSERT [dbo].[TienAnTheoDoans] OFF
SET IDENTITY_INSERT [dbo].[GiaTours] ON 

INSERT [dbo].[GiaTours] ([Id], [Gia], [NgayCapNhat], [TourId]) VALUES (1, 150000, CAST(N'2017-12-25T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[GiaTours] ([Id], [Gia], [NgayCapNhat], [TourId]) VALUES (2, 300000, CAST(N'2017-12-31T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[GiaTours] ([Id], [Gia], [NgayCapNhat], [TourId]) VALUES (3, 300000, CAST(N'2017-12-26T00:00:00.000' AS DateTime), 2)
INSERT [dbo].[GiaTours] ([Id], [Gia], [NgayCapNhat], [TourId]) VALUES (4, 500000, CAST(N'2018-01-02T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[GiaTours] ([Id], [Gia], [NgayCapNhat], [TourId]) VALUES (5, 500000, CAST(N'2018-01-01T00:00:00.000' AS DateTime), 2)
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
