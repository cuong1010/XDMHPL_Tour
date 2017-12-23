
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/23/2017 07:46:46
-- Generated from EDMX file: C:\Users\PC\Documents\Visual Studio 2015\Projects\XDMHPL_Tour\QLTour\BusAndModel\Model\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [QLTour];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Tours'
CREATE TABLE [dbo].[Tours] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TenGoi] nvarchar(max)  NOT NULL,
    [DacDiem] nvarchar(max)  NOT NULL,
    [LoaiDLId] int  NOT NULL
);
GO

-- Creating table 'LoaiDLs'
CREATE TABLE [dbo].[LoaiDLs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TenGoi] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'GiaTours'
CREATE TABLE [dbo].[GiaTours] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Gia] int  NOT NULL,
    [NgayCapNhat] datetime  NOT NULL,
    [TourId] int  NOT NULL
);
GO

-- Creating table 'DiaDiems'
CREATE TABLE [dbo].[DiaDiems] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TenDiaDiem] nvarchar(max)  NOT NULL,
    [TinhThanhId] int  NOT NULL
);
GO

-- Creating table 'TinhThanhs'
CREATE TABLE [dbo].[TinhThanhs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [MaTinh] nvarchar(max)  NOT NULL,
    [TenTinh] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CTTours'
CREATE TABLE [dbo].[CTTours] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TourId] int  NOT NULL,
    [DiaDiemId] int  NOT NULL
);
GO

-- Creating table 'KhachHangs'
CREATE TABLE [dbo].[KhachHangs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [HoTen] nvarchar(max)  NOT NULL,
    [CMND] nvarchar(max)  NOT NULL,
    [DiaChi] nvarchar(max)  NOT NULL,
    [SDT] nvarchar(max)  NOT NULL,
    [GioiTinh] bit  NOT NULL
);
GO

-- Creating table 'DoanKhaches'
CREATE TABLE [dbo].[DoanKhaches] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TenGoi] nvarchar(max)  NOT NULL,
    [NgayKhoiHanh] datetime  NOT NULL,
    [NgayKetThuc] datetime  NOT NULL,
    [TongKS] int  NULL,
    [TongAn] int  NULL,
    [TongPT] int  NULL,
    [TongKhac] int  NULL,
    [TourId] int  NOT NULL,
    [SLCho] int  NOT NULL
);
GO

-- Creating table 'NhiemVus'
CREATE TABLE [dbo].[NhiemVus] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TenNhiemVu] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'DSKhachTheoDoans'
CREATE TABLE [dbo].[DSKhachTheoDoans] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DoanKhachId] int  NOT NULL,
    [KhachHangId] int  NOT NULL
);
GO

-- Creating table 'NhanViens'
CREATE TABLE [dbo].[NhanViens] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TenNhanVien] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'NhanVienTheoDoans'
CREATE TABLE [dbo].[NhanVienTheoDoans] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [idNhiemVu] int  NOT NULL,
    [idNhanVien] int  NOT NULL,
    [idDoanKhach] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Tours'
ALTER TABLE [dbo].[Tours]
ADD CONSTRAINT [PK_Tours]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'LoaiDLs'
ALTER TABLE [dbo].[LoaiDLs]
ADD CONSTRAINT [PK_LoaiDLs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'GiaTours'
ALTER TABLE [dbo].[GiaTours]
ADD CONSTRAINT [PK_GiaTours]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DiaDiems'
ALTER TABLE [dbo].[DiaDiems]
ADD CONSTRAINT [PK_DiaDiems]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TinhThanhs'
ALTER TABLE [dbo].[TinhThanhs]
ADD CONSTRAINT [PK_TinhThanhs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CTTours'
ALTER TABLE [dbo].[CTTours]
ADD CONSTRAINT [PK_CTTours]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'KhachHangs'
ALTER TABLE [dbo].[KhachHangs]
ADD CONSTRAINT [PK_KhachHangs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DoanKhaches'
ALTER TABLE [dbo].[DoanKhaches]
ADD CONSTRAINT [PK_DoanKhaches]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NhiemVus'
ALTER TABLE [dbo].[NhiemVus]
ADD CONSTRAINT [PK_NhiemVus]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'DSKhachTheoDoans'
ALTER TABLE [dbo].[DSKhachTheoDoans]
ADD CONSTRAINT [PK_DSKhachTheoDoans]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NhanViens'
ALTER TABLE [dbo].[NhanViens]
ADD CONSTRAINT [PK_NhanViens]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'NhanVienTheoDoans'
ALTER TABLE [dbo].[NhanVienTheoDoans]
ADD CONSTRAINT [PK_NhanVienTheoDoans]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [TinhThanhId] in table 'DiaDiems'
ALTER TABLE [dbo].[DiaDiems]
ADD CONSTRAINT [FK_TinhThanhDiaDiem]
    FOREIGN KEY ([TinhThanhId])
    REFERENCES [dbo].[TinhThanhs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TinhThanhDiaDiem'
CREATE INDEX [IX_FK_TinhThanhDiaDiem]
ON [dbo].[DiaDiems]
    ([TinhThanhId]);
GO

-- Creating foreign key on [LoaiDLId] in table 'Tours'
ALTER TABLE [dbo].[Tours]
ADD CONSTRAINT [FK_LoaiDLTour]
    FOREIGN KEY ([LoaiDLId])
    REFERENCES [dbo].[LoaiDLs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_LoaiDLTour'
CREATE INDEX [IX_FK_LoaiDLTour]
ON [dbo].[Tours]
    ([LoaiDLId]);
GO

-- Creating foreign key on [TourId] in table 'GiaTours'
ALTER TABLE [dbo].[GiaTours]
ADD CONSTRAINT [FK_TourGiaTour]
    FOREIGN KEY ([TourId])
    REFERENCES [dbo].[Tours]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TourGiaTour'
CREATE INDEX [IX_FK_TourGiaTour]
ON [dbo].[GiaTours]
    ([TourId]);
GO

-- Creating foreign key on [TourId] in table 'CTTours'
ALTER TABLE [dbo].[CTTours]
ADD CONSTRAINT [FK_TourCTTour]
    FOREIGN KEY ([TourId])
    REFERENCES [dbo].[Tours]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TourCTTour'
CREATE INDEX [IX_FK_TourCTTour]
ON [dbo].[CTTours]
    ([TourId]);
GO

-- Creating foreign key on [DiaDiemId] in table 'CTTours'
ALTER TABLE [dbo].[CTTours]
ADD CONSTRAINT [FK_DiaDiemCTTour]
    FOREIGN KEY ([DiaDiemId])
    REFERENCES [dbo].[DiaDiems]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DiaDiemCTTour'
CREATE INDEX [IX_FK_DiaDiemCTTour]
ON [dbo].[CTTours]
    ([DiaDiemId]);
GO

-- Creating foreign key on [DoanKhachId] in table 'DSKhachTheoDoans'
ALTER TABLE [dbo].[DSKhachTheoDoans]
ADD CONSTRAINT [FK_DoanKhachDSKhachTheoDoan]
    FOREIGN KEY ([DoanKhachId])
    REFERENCES [dbo].[DoanKhaches]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DoanKhachDSKhachTheoDoan'
CREATE INDEX [IX_FK_DoanKhachDSKhachTheoDoan]
ON [dbo].[DSKhachTheoDoans]
    ([DoanKhachId]);
GO

-- Creating foreign key on [KhachHangId] in table 'DSKhachTheoDoans'
ALTER TABLE [dbo].[DSKhachTheoDoans]
ADD CONSTRAINT [FK_KhachHangDSKhachTheoDoan]
    FOREIGN KEY ([KhachHangId])
    REFERENCES [dbo].[KhachHangs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KhachHangDSKhachTheoDoan'
CREATE INDEX [IX_FK_KhachHangDSKhachTheoDoan]
ON [dbo].[DSKhachTheoDoans]
    ([KhachHangId]);
GO

-- Creating foreign key on [TourId] in table 'DoanKhaches'
ALTER TABLE [dbo].[DoanKhaches]
ADD CONSTRAINT [FK_TourDoanKhach]
    FOREIGN KEY ([TourId])
    REFERENCES [dbo].[Tours]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TourDoanKhach'
CREATE INDEX [IX_FK_TourDoanKhach]
ON [dbo].[DoanKhaches]
    ([TourId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------