-- Tạo database RestaurantManagement
CREATE DATABASE RestaurantManagement;
GO

-- Cho phép đọc snapshot để tăng concurrency
IF SERVERPROPERTY('EngineEdition') <> 5
BEGIN
    ALTER DATABASE RestaurantManagement SET READ_COMMITTED_SNAPSHOT ON;
END;
GO

-- Sử dụng database vừa tạo
USE RestaurantManagement;
GO

-- Bảng Chức Vụ
CREATE TABLE ChucVus (
    MaChucVu INT IDENTITY PRIMARY KEY,
    TenChucVu NVARCHAR(100) NOT NULL
);

-- Bảng Khách Hàng
CREATE TABLE KhachHangs (
    MaKhachHang INT IDENTITY PRIMARY KEY,
    TenKhachHang NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(MAX),
    SoDienThoai NVARCHAR(20) NOT NULL
);

-- Bảng Món Ăn
CREATE TABLE MonAns (
    MaMonAn INT IDENTITY PRIMARY KEY,
    TenMonAn NVARCHAR(100) NOT NULL,
    Gia FLOAT NOT NULL,
    SoLuongHienCo INT NOT NULL
);

-- Bảng Nhà Cung Cấp
CREATE TABLE NhaCungCaps (
    MaNhaCungCap INT IDENTITY PRIMARY KEY,
    TenNhaCungCap NVARCHAR(100) NOT NULL,
    DiaChi NVARCHAR(100) NOT NULL,
    SoDienThoai NVARCHAR(20) NOT NULL,
    Email NVARCHAR(100) NOT NULL
);

-- Bảng Nhân Viên
CREATE TABLE NhanViens (
    MaNhanVien INT IDENTITY PRIMARY KEY,
    TenNhanVien NVARCHAR(MAX) NOT NULL,
    DiaChi NVARCHAR(MAX) NOT NULL,
    SoDienThoai NVARCHAR(MAX) NOT NULL,
    Email NVARCHAR(MAX) NOT NULL,
    MaChucVu INT,
    FOREIGN KEY (MaChucVu) REFERENCES ChucVus(MaChucVu)
);

-- Bảng Khuyến Mãi
CREATE TABLE KhuyenMais (
    MaKhuyenMai INT IDENTITY PRIMARY KEY,
    TenKhuyenMai NVARCHAR(100) NOT NULL,
    MaKhachHang INT NOT NULL,
    DaDung BIT NOT NULL,
    NgayHetHan DATETIME2 NOT NULL,
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHangs(MaKhachHang)
);

-- Bảng Nguyên Liệu
CREATE TABLE NguyenLieus (
    MaNguyenLieu INT IDENTITY PRIMARY KEY,
    TenNguyenLieu NVARCHAR(100) NOT NULL,
    DonViTinh NVARCHAR(20) NOT NULL,
    Gia FLOAT NOT NULL,
    MaNhaCungCap INT NOT NULL,
    FOREIGN KEY (MaNhaCungCap) REFERENCES NhaCungCaps(MaNhaCungCap)
);

-- Bảng Hóa Đơn
CREATE TABLE HoaDons (
    MaHoaDon INT IDENTITY PRIMARY KEY,
    MaNhanVien INT NOT NULL,
    MaKhachHang INT NOT NULL,
    NgayLap DATETIME2 NOT NULL,
    TongTien FLOAT NOT NULL,
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHangs(MaKhachHang),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanViens(MaNhanVien)
);

-- Bảng Lưu Trữ
CREATE TABLE LuuTrus (
    MaLuuTru INT IDENTITY PRIMARY KEY,
    MaNhanVien INT NOT NULL,
    MaNguyenLieu INT NOT NULL,
    SoLuong INT NOT NULL,
    NgayHetHan DATETIME2 NOT NULL,
    FOREIGN KEY (MaNguyenLieu) REFERENCES NguyenLieus(MaNguyenLieu),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanViens(MaNhanVien)
);

-- Bảng Nhập Kho
CREATE TABLE NhapKhos (
    MaNhapKho INT IDENTITY PRIMARY KEY,
    MaNhanVien INT NOT NULL,
    MaNguyenLieu INT NOT NULL,
    NgayNhap DATETIME2 NOT NULL,
    SoLuong INT NOT NULL,
    TongTien FLOAT NOT NULL,
    SoNgayHetHan INT NOT NULL,
    FOREIGN KEY (MaNguyenLieu) REFERENCES NguyenLieus(MaNguyenLieu),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanViens(MaNhanVien)
);

-- Bảng Chi Tiết Hóa Đơn
CREATE TABLE ChiTietHoaDons (
    MaChiTietHoaDon INT IDENTITY PRIMARY KEY,
    MaHoaDon INT NOT NULL,
    MaMonAn INT NOT NULL,
    SoLuong INT NOT NULL,
    ThanhTien FLOAT NOT NULL,
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDons(MaHoaDon),
    FOREIGN KEY (MaMonAn) REFERENCES MonAns(MaMonAn)
);

-- Bảng Xuất Kho
CREATE TABLE XuatKhos (
    MaXuatKho INT IDENTITY PRIMARY KEY,
    MaNhanVien INT NOT NULL,
    MaNguyenLieu INT NOT NULL,
    SoLuong INT NOT NULL,
    NgayXuat DATETIME2 NOT NULL,
    NguyenNhanXuatKho NVARCHAR(MAX) NOT NULL,
    MaLuuTru INT NOT NULL,
    FOREIGN KEY (MaLuuTru) REFERENCES LuuTrus(MaLuuTru),
    FOREIGN KEY (MaNguyenLieu) REFERENCES NguyenLieus(MaNguyenLieu),
    FOREIGN KEY (MaNhanVien) REFERENCES NhanViens(MaNhanVien)
);

-- Tài Khoản Nhân Viên
CREATE TABLE [dbo].[TaiKhoanNhanViens] (
    [MaTaiKhoan] INT            IDENTITY (1, 1) NOT NULL,
    [MaNhanVien] INT            NOT NULL,
    [TaiKhoan]   NVARCHAR (MAX) NULL,
    [MatKhau]    NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_TaiKhoanNhanViens] PRIMARY KEY CLUSTERED ([MaTaiKhoan] ASC),
    CONSTRAINT [FK_TaiKhoanNhanViens_NhanViens_MaNhanVien] FOREIGN KEY ([MaNhanVien]) REFERENCES [dbo].[NhanViens] ([MaNhanVien])
);

-- Các chỉ mục hỗ trợ truy vấn
CREATE INDEX IX_ChiTietHoaDons_MaHoaDon ON ChiTietHoaDons(MaHoaDon);
CREATE INDEX IX_ChiTietHoaDons_MaMonAn ON ChiTietHoaDons(MaMonAn);
CREATE INDEX IX_HoaDons_MaKhachHang ON HoaDons(MaKhachHang);
CREATE INDEX IX_HoaDons_MaNhanVien ON HoaDons(MaNhanVien);
CREATE INDEX IX_KhuyenMais_MaKhachHang ON KhuyenMais(MaKhachHang);
CREATE INDEX IX_LuuTrus_MaNguyenLieu ON LuuTrus(MaNguyenLieu);
CREATE INDEX IX_LuuTrus_MaNhanVien ON LuuTrus(MaNhanVien);
CREATE INDEX IX_NguyenLieus_MaNhaCungCap ON NguyenLieus(MaNhaCungCap);
CREATE INDEX IX_NhanViens_MaChucVu ON NhanViens(MaChucVu);
CREATE INDEX IX_NhapKhos_MaNguyenLieu ON NhapKhos(MaNguyenLieu);
CREATE INDEX IX_NhapKhos_MaNhanVien ON NhapKhos(MaNhanVien);
CREATE INDEX IX_XuatKhos_MaLuuTru ON XuatKhos(MaLuuTru);
CREATE INDEX IX_XuatKhos_MaNguyenLieu ON XuatKhos(MaNguyenLieu);
CREATE INDEX IX_XuatKhos_MaNhanVien ON XuatKhos(MaNhanVien);


-- Insert dữ liệu
USE [RestaurantManagement]
GO

INSERT INTO ChiTietHoaDons (MaHoaDon, MaMonAn, SoLuong, ThanhTien)
VALUES
	(1, 2, 8, 480000),
	(2, 1, 8, 180000),
	(1, 3, 8, 125000),
	(1, 1, 8, 225000),
	(2, 2, 8, 240000),
	(2, 3, 8, 50000),
	(3, 1, 8, 45000),
	(3, 3, 8, 125000),
	(5, 1, 8, 90000),
	(1, 2, 3, 0),
	(2, 1, 4, 0),
	(1, 3, 10, 0);
GO

INSERT INTO KhuyenMais (TenKhuyenMai, MaKhachHang, DaDung, NgayHetHan) 
VALUES
	(N'Giảm 10% đơn đầu tiên', 1, 0, '2025-05-01'),
	(N'Miễn phí giao hàng', 2, 1, '2025-04-10'),    
	(N'Giảm 50K cho đơn từ 200K', 1, 0, '2025-05-15'),
	(N'Quà tặng kèm', 3, 0, '2025-06-01'),          
	(N'Voucher 100K sinh nhật', 3, 1, '2025-04-30');
GO

INSERT INTO NguyenLieus (TenNguyenLieu, DonViTinh, Gia, MaNhaCungCap) 
VALUES
	(N'Thịt Bò', N'kg', 220000, 1),        
	(N'Rau Xà Lách', N'kg', 35000, 2),     
	(N'Ớt Chuông', N'kg', 45000, 3),       
	(N'Tỏi Băm', N'gói', 15000, 1),        
	(N'Thịt Gà', N'kg', 150000, 2); 
GO

INSERT INTO KhuyenMais (TenKhuyenMai, MaKhachHang, DaDung, NgayHetHan) 
VALUES
	(N'Giảm 10% đơn đầu tiên', 1, 0, '2025-05-01'),
	(N'Miễn phí giao hàng', 2, 1, '2025-04-10'),
	(N'Giảm 50K cho đơn từ 200K', 1, 0, '2025-05-15'),
	(N'Quà tặng kèm', 3, 0, '2025-06-01'),
	(N'Voucher 100K sinh nhật', 3, 1, '2025-04-30');
GO

INSERT INTO HoaDons (MaNhanVien, MaKhachHang, NgayLap, TongTien)
VALUES 
	(1, 1, '2025-04-01', 250000),
	(2, 1, '2025-04-02', 145000),
	(1, 2, '2025-04-03', 387000),
	(3, 2, '2025-04-04', 72000),
	(2, 1, '2025-04-05', 510000),
	(1, 2, '2025-04-06', 198000),
	(5, 1, '2025-04-07', 325000),
	(4, 2, '2025-04-08', 274000);
GO

INSERT INTO NhapKhos (MaNhanVien, MaNguyenLieu, NgayNhap, SoLuong, TongTien, SoNgayHetHan)
VALUES
	(1, 1, '2025-04-20', 10, 2200000, 60),
	(2, 2, '2025-04-20', 5, 175000, 7),
	(3, 3, '2025-04-20', 3, 135000, 10),
	(1, 4, '2025-04-20', 20, 300000, 30),
	(2, 5, '2025-04-20', 8, 1200000, 90),
	(1, 2, '2025-04-18', 50, 175000, 30),
	(1, 3, '2025-04-21', 30, 135000, 30),
	(2, 3, '2025-04-22', 30, 135000, 30),
	(3, 3, '2025-04-22', 30, 135000, 30);
GO

INSERT INTO XuatKhos (MaNhanVien, MaNguyenLieu, SoLuong, NgayXuat, NguyenNhanXuatKho, MaLuuTru)
VALUES
    (1, 2, 5, '2025-04-19', N'Xuất kho để phục vụ sản xuất', 1),
    (2, 1, 2, '2025-04-19', N'Xuất kho cho đơn hàng', 2),
    (3, 3, 3, '2025-04-20', N'Xuất kho theo yêu cầu của quản lý', 3);

GO

INSERT INTO LuuTrus (MaNhanVien, MaNguyenLieu, SoLuong, NgayHetHan)
VALUES
	(3, 4, 50, '2026-01-25'),
	(2, 1, 200, '2026-02-15'),
	(1, 2, 100, '2025-12-31'),
    (2, 1, 150, '2025-11-30'),
    (3, 3, 200, '2026-01-15');
GO

INSERT INTO NhanViens (TenNhanVien, DiaChi, SoDienThoai, Email, MaChucVu)
VALUES
	(N'Bùi Hoàng Hưng', N'69 Nguyễn Gia Trí, Phường 25, Bình Thạnh, HCM', '0943518229', 'hhb041203@gmail.com', 1),
	('A01', 'a01', '0910', 'a01@gmail.com', 2),
	('A02', 'a02', '0911', 'a02@gmail.com', 2),
	('A03', 'a03', '0912', 'a03@gmail.com', 2),
	('A04', 'a04', '0913', 'a04@gmail.com', 2),
	('A05', 'a05', '0914', 'a05@gmail.com', 2),
	('A06', 'a06', '0915', 'a06@gmail.com', 3);
GO

INSERT INTO TaiKhoanNhanViens (MaNhanVien, TaiKhoan, MatKhau)
VALUES
	(1, 'admin', '1'),
	(2, 'a01', 'a01'),
	(3, 'a03', 'a03'),
	(4, 'a02', 'a02'),
	(5, 'a04', 'a04'),
	(6, NULL, NULL),
	(7, 'a06', 'a06');
GO

INSERT INTO NhaCungCaps (TenNhaCungCap, DiaChi, SoDienThoai, Email)
VALUES
	('Công Ty A', N'123 Đường ABC, Quận 1, TP.HCM', '0901234567', 'contact@congtyA.com'),
	('Công Ty B', N'456 Đường XYZ, Quận 3, TP.HCM', '0907654321', 'contact@congtyB.com'),
	('Công Ty C', N'789 Đường MNO, Quận 5, TP.HCM', '0912345678', 'contact@congtyC.com');
GO

INSERT INTO MonAns (TenMonAn, Gia, SoLuongHienCo)
VALUES
	('Com tam', 45000, 150),
	('Pho bo', 60000, 50),
	('Banh mi', 25000, 150);
GO

INSERT INTO ChucVus (TenChucVu)
VALUES
(N'Quản lý'),
(N'Nhân viên phục vụ'),
(N'Nhân viên quản lý kho');
GO

