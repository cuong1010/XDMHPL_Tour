USE [QLTour]
GO
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
SET IDENTITY_INSERT [dbo].[DiaDiems] OFF
SET IDENTITY_INSERT [dbo].[LoaiDLs] ON 

INSERT [dbo].[LoaiDLs] ([Id], [TenGoi]) VALUES (1, N'Di động')
INSERT [dbo].[LoaiDLs] ([Id], [TenGoi]) VALUES (2, N'Xã hội và gia đình')
INSERT [dbo].[LoaiDLs] ([Id], [TenGoi]) VALUES (3, N'du lịch kết hợp nghề nghiệp')
SET IDENTITY_INSERT [dbo].[LoaiDLs] OFF
