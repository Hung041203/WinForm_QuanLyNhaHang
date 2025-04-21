-- Doi MatKhau
CREATE PROCEDURE proc_DoiMatKhau
	@TaiKhoan NVARCHAR(MAX),
	@MatKhauMoi NVARCHAR(MAX)
AS
BEGIN 
	UPDATE TaiKhoanNhanViens
	SET MatKhau = @MatKhauMoi
	WHERE TaiKhoan = @TaiKhoan
END

-- Lay MatKhau
CREATE PROCEDURE proc_LayMatKhau
	@TaiKhoan NVARCHAR(MAX)
AS
BEGIN
	SELECT MatKhau FROM TaiKhoanNhanViens WHERE TaiKhoan = @TaiKhoan
END

-- DangNhap
CREATE PROCEDURE proc_DangNhap
	@TaiKhoan NVARCHAR(MAX),
	@MatKhau NVARCHAR(MAX)
AS
BEGIN
	SELECT * FROM TaiKhoanNhanViens WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau
END

-- Lay Thong Tin Nhan Vien
CREATE PROCEDURE proc_LayThongTin
AS
BEGIN
	SELECT *
	FROM TaiKhoanNhanViens tk
	INNER JOIN NhanViens nv ON tk.MaNhanVien = nv.MaNhanVien
	INNER JOIN ChucVus cv ON nv.MaChucVu = cv.MaChucVu
END

-- DangKy
CREATE PROCEDURE proc_DangKy
    @MaNhanVien INT,
    @TaiKhoan NVARCHAR(MAX),
    @MatKhau NVARCHAR(MAX)
AS
BEGIN
    SET XACT_ABORT ON;

	IF EXISTS (SELECT 1 FROM TaiKhoanNhanViens WHERE TaiKhoan = @TaiKhoan)
    BEGIN
        RAISERROR('Tên tài khoản đã được sử dụng!', 16, 1);
        RETURN;
    END

    IF EXISTS (SELECT 1 FROM TaiKhoanNhanViens WHERE MaNhanVien = @MaNhanVien AND TaiKhoan IS NOT NULL)
    BEGIN
        RAISERROR('Nhân viên này đã có tài khoản!', 16, 1);
        RETURN;
    END

    UPDATE TaiKhoanNhanViens
    SET TaiKhoan = @TaiKhoan,
        MatKhau = @MatKhau
    WHERE MaNhanVien = @MaNhanVien;
END
GO


-- Nhan Vien
CREATE PROCEDURE proc_CapNhatThongTinNhanVien
    @MaNhanVien INT,
    @TenNhanVien NVARCHAR(100),
    @MaChucVu NVARCHAR(50),
    @SoDienThoai NVARCHAR(15),
    @DiaChi NVARCHAR(200),
    @Email NVARCHAR(100)
AS
BEGIN
    UPDATE NhanViens
    SET 
        TenNhanVien = @TenNhanVien,
        MaChucVu = @MaChucVu,
        SoDienThoai = @SoDienThoai,
        DiaChi = @DiaChi,
        Email = @Email
    WHERE MaNhanVien = @MaNhanVien;
END

CREATE PROCEDURE proc_ThemNhanVien
    @TenNhanVien NVARCHAR(100),
    @MaChucVu NVARCHAR(50),
    @SoDienThoai NVARCHAR(15),
    @DiaChi NVARCHAR(200),
    @Email NVARCHAR(100)
AS
BEGIN
    INSERT INTO NhanViens (TenNhanVien, MaChucVu, SoDienThoai, DiaChi, Email)
    VALUES (@TenNhanVien, @MaChucVu, @SoDienThoai, @DiaChi, @Email);

	DECLARE @MaNhanVienMoi INT = SCOPE_IDENTITY();

	INSERT INTO TaiKhoanNhanViens (MaNhanVien, TaiKhoan, MatKhau)
	VALUES (@MaNhanVienMoi, Null, Null);
END

DROP PROCEDURE proc_ThemNhanVien

CREATE PROCEDURE proc_XoaNhanVien
    @MaNhanVien INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM TaiKhoanNhanViens WHERE MaNhanVien = @MaNhanVien)
    BEGIN
        DELETE FROM TaiKhoanNhanViens WHERE MaNhanVien = @MaNhanVien;
    END

    DELETE FROM NhanViens WHERE MaNhanVien = @MaNhanVien;
END

INSERT INTO [dbo].[NhaCungCaps] ([TenNhaCungCap], [DiaChi], [SoDienThoai], [Email])
VALUES 
('Công Ty A', '123 Đường ABC, Quận 1, TP.HCM', '0901234567', 'contact@congtyA.com'),
('Công Ty B', '456 Đường XYZ, Quận 3, TP.HCM', '0907654321', 'contact@congtyB.com'),
('Công Ty C', '789 Đường MNO, Quận 5, TP.HCM', '0912345678', 'contact@congtyC.com');

-- Nha cung cap
CREATE PROCEDURE proc_ThemNhaCungCap
    @TenNhaCungCap NVARCHAR(100),
    @SoDienThoai NVARCHAR(15),
    @DiaChi NVARCHAR(200),
    @Email NVARCHAR(100)
AS
BEGIN
    INSERT INTO NhaCungCaps (TenNhaCungCap, SoDienThoai, DiaChi, Email)
    VALUES (@TenNhaCungCap, @SoDienThoai, @DiaChi, @Email);
END

CREATE PROCEDURE proc_CapNhatThongTinNhaCungCap
    @MaNhaCungCap INT,
    @TenNhaCungCap NVARCHAR(100),
    @SoDienThoai NVARCHAR(15),
    @DiaChi NVARCHAR(200),
    @Email NVARCHAR(100)
AS
BEGIN
    UPDATE NhaCungCaps
    SET 
        TenNhaCungCap = @TenNhaCungCap,
        SoDienThoai = @SoDienThoai,
        DiaChi = @DiaChi,
        Email = @Email
    WHERE MaNhaCungCap = @MaNhaCungCap;
END

CREATE PROCEDURE proc_XoaNhaCungCap
    @MaNhaCungCap INT
AS
BEGIN
	IF EXISTS (SELECT 1 FROM NguyenLieus WHERE MaNhaCungCap = @MaNhaCungCap)
    BEGIN
        DELETE FROM NguyenLieus WHERE MaNhaCungCap = @MaNhaCungCap;
    END

    DELETE FROM NhaCungCaps WHERE MaNhaCungCap = @MaNhaCungCap;
END

-- Mon An
CREATE PROCEDURE proc_ThemMonAn
    @TenMonAn NVARCHAR(100),
    @Gia FLOAT,
    @SoLuong INT
AS
BEGIN
    INSERT INTO MonAns (TenMonAn, Gia, SoLuongHienCo)
    VALUES (@TenMonAn, @Gia, @SoLuong);
END

CREATE PROCEDURE proc_CapNhatThongTinMonAn
    @MaMonAn INT,
    @TenMonAn NVARCHAR(100),
    @Gia FLOAT,
    @SoLuong INT
AS
BEGIN
    UPDATE MonAns
    SET 
        TenMonAn = @TenMonAn,
		Gia = @Gia,
		SoLuongHienCo = @SoLuong
    WHERE MaMonAn = @MaMonAn;
END

CREATE PROCEDURE proc_XoaMonAn
    @MaMonAn INT
AS
BEGIN
    DELETE FROM MonAns WHERE MaMonAn = @MaMonAn;
END

-- Khach Hang
CREATE PROCEDURE proc_ThemKhachHang
    @TenKhachHang NVARCHAR(100),
    @DiaChi NVARCHAR(100),
    @SoDienThoai NVARCHAR(100)
AS
BEGIN
    INSERT INTO KhachHangs (TenKhachHang, DiaChi, SoDienThoai)
    VALUES (@TenKhachHang, @DiaChi, @SoDienThoai);
END

CREATE PROCEDURE proc_CapNhatThongTinKhachHang
    @MaKhachHang INT,
    @TenKhachHang NVARCHAR(100),
    @DiaChi NVARCHAR(100),
    @SoDienThoai NVARCHAR(100)
AS
BEGIN
    UPDATE KhachHangs
    SET 
        TenKhachHang = @TenKhachHang,
		DiaChi = @DiaChi,
		SoDienThoai = @SoDienThoai
    WHERE MaKhachHang = @MaKhachHang;
END

CREATE PROCEDURE proc_XoaKhachHang
    @MaKhachHang INT
AS
BEGIN
	IF EXISTS (SELECT 1 FROM KhuyenMais WHERE MaKhachHang = @MaKhachHang)
    BEGIN
        DELETE FROM KhuyenMais WHERE MaKhachHang = @MaKhachHang;
    END
	IF EXISTS (SELECT 1 FROM HoaDons WHERE MaKhachHang = @MaKhachHang)
    BEGIN
        DELETE FROM HoaDons WHERE MaKhachHang = @MaKhachHang;
    END

    DELETE FROM KhachHangs WHERE MaKhachHang = @MaKhachHang;
END

-- Nguyen Lieu
INSERT INTO NguyenLieus (TenNguyenLieu, DonViTinh, Gia, MaNhaCungCap) VALUES
(N'Thịt Bò', N'kg', 220000, 1),        
(N'Rau Xà Lách', N'kg', 35000, 2),     
(N'Ớt Chuông', N'kg', 45000, 3),       
(N'Tỏi Băm', N'gói', 15000, 1),        
(N'Thịt Gà', N'kg', 150000, 2); 

CREATE VIEW View_NguyenLieu AS
SELECT 
    nl.MaNguyenLieu,
	nl.TenNguyenLieu,
	nl.DonViTinh,
	nl.Gia,
	ncc.TenNhaCungCap
FROM NguyenLieus nl
LEFT JOIN NhaCungCaps ncc ON nl.MaNhaCungCap = ncc.MaNhaCungCap;

CREATE PROCEDURE proc_CapNhatThongTinNguyenLieu
    @MaNguyenLieu INT,
    @TenNguyenLieu NVARCHAR(100),
    @DonViTinh NVARCHAR(50),
    @Gia FLOAT,
    @MaNhaCungCap INT
AS
BEGIN
    UPDATE NguyenLieus
    SET 
        TenNguyenLieu = @TenNguyenLieu,
        DonViTinh = @DonViTinh,
        Gia = @Gia,
        MaNhaCungCap = @MaNhaCungCap
    WHERE MaNguyenLieu = @MaNguyenLieu;
END

CREATE PROCEDURE proc_ThemNguyenLieu
    @TenNguyenLieu NVARCHAR(100),
    @DonViTinh NVARCHAR(50),
    @Gia FLOAT,
    @MaNhaCungCap INT
AS
BEGIN
    INSERT INTO NguyenLieus(TenNguyenLieu, DonViTinh, Gia, MaNhaCungCap)
    VALUES (@TenNguyenLieu, @DonViTinh, @Gia, @MaNhaCungCap);
END

CREATE PROCEDURE proc_XoaNguyenLieu
    @MaNguyenLieu INT
AS
BEGIN
    DELETE FROM NguyenLieus WHERE MaNguyenLieu = @MaNguyenLieu;
END

select * From HoaDons
select * From ChiTietHoaDons

select * From KhachHangs
INSERT INTO KhachHangs (TenKhachHang, DiaChi, SoDienThoai)
VALUES (N'Le Hoa', N'789 DEF, Q3, HCM', '0988123456');

INSERT INTO KhuyenMais (TenKhuyenMai, MaKhachHang, DaDung, NgayHetHan) 
VALUES
	(N'Giảm 10% đơn đầu tiên', 1, 0, '2025-05-01'), -- Nguyen An
	(N'Miễn phí giao hàng', 2, 1, '2025-04-10'),    -- Tran Binh
	(N'Giảm 50K cho đơn từ 200K', 1, 0, '2025-05-15'), -- Nguyen An
	(N'Quà tặng kèm', 3, 0, '2025-06-01'),          -- Le Hoa
	(N'Voucher 100K sinh nhật', 3, 1, '2025-04-30');-- Le Hoa

-- khuyen mai
CREATE VIEW View_KhuyenMai AS
SELECT 
    km.MaKhuyenMai,
    km.TenKhuyenMai,
    kh.TenKhachHang,
    CASE km.DaDung 
        WHEN 1 THEN N'Đã dùng'
        WHEN 0 THEN N'Chưa dùng'
    END AS TinhTrang,
    km.NgayHetHan
FROM 
    KhuyenMais km
LEFT JOIN 
    KhachHangs kh ON KM.MaKhachHang = KH.MaKhachHang;


-- Khuyen Mai
CREATE PROCEDURE proc_CapNhatThongTinKhuyenMai
    @MaKhuyenMai INT,
    @TenKhuyenMai NVARCHAR(100),
    @DaDung BIT,
    @NgayHetHan DATETIME2(7),
    @MaKhachHang INT
AS
BEGIN
    UPDATE KhuyenMais
    SET 
        TenKhuyenMai = @TenKhuyenMai,
        DaDung = @DaDung,
        NgayHetHan = @NgayHetHan,
        MaKhachHang = @MaKhachHang
    WHERE MaKhuyenMai = @MaKhuyenMai;
END

DROP PROCEDURE proc_CapNhatThongTinKhuyenMai

CREATE PROCEDURE proc_ThemKhuyenMai
    @TenKhuyenMai NVARCHAR(100),
    @DaDung BIT,
    @NgayHetHan DATETIME2(7),
    @MaKhachHang INT
AS
BEGIN
    INSERT INTO KhuyenMais(TenKhuyenMai, DaDung, NgayHetHan, MaKhachHang)
    VALUES (@TenKhuyenMai, @DaDung, @NgayHetHan, @MaKhachHang);
END

CREATE PROCEDURE proc_XoaKhuyenMai
    @MaKhuyenMai INT
AS
BEGIN
    DELETE FROM KhuyenMais WHERE MaKhuyenMai = @MaKhuyenMai;
END

-- Khuyen Mai 2
-- Thêm Khuyến Mãi
CREATE PROCEDURE sp_ThemKhuyenMai
    @TenKhuyenMai NVARCHAR(100),
    @MaKhachHang INT,
    @DaDung BIT,
    @NgayHetHan DATE
AS
BEGIN
    INSERT INTO KhuyenMais (TenKhuyenMai, MaKhachHang, DaDung, NgayHetHan)
    VALUES (@TenKhuyenMai, @MaKhachHang, @DaDung, @NgayHetHan)
END

-- Xóa Khuyến Mãi
CREATE PROCEDURE sp_XoaKhuyenMai
    @MaKhuyenMai INT
AS
BEGIN
    DELETE FROM KhuyenMais
    WHERE MaKhuyenMai = @MaKhuyenMai
END

-- Sửa Khuyến Mãi
CREATE PROCEDURE sp_SuaKhuyenMai
    @MaKhuyenMai INT,
    @TenKhuyenMai NVARCHAR(100),
    @MaKhachHang INT,
    @DaDung BIT,
    @NgayHetHan DATE
AS
BEGIN
    UPDATE KhuyenMais
    SET 
        TenKhuyenMai = @TenKhuyenMai,
        MaKhachHang = @MaKhachHang,
        DaDung = @DaDung,
        NgayHetHan = @NgayHetHan
    WHERE MaKhuyenMai = @MaKhuyenMai
END

-- Hoa Don
CREATE VIEW View_HoaDon AS
SELECT 
	hd.MaHoaDon,
	nv.TenNhanVien,
	kh.TenKhachHang,
	hd.NgayLap,
	hd.TongTien
FROM HoaDons hd
INNER JOIN NhanViens nv ON hd.MaNhanVien = nv.MaNhanVien
INNER JOIN KhachHangs kh ON hd.MaKhachHang = kh.MaKhachHang

---
CREATE PROCEDURE proc_CapNhatThongTinHoaDon
    @MaNhanVien INT,
    @MaHoaDon INT,
    @MaKhachHang INT,
    @NgayLap DATETIME2(7)
AS
BEGIN
    UPDATE HoaDons
    SET 
        MaNhanVien = @MaNhanVien,
        MaKhachHang = @MaKhachHang,
        NgayLap = @NgayLap
    WHERE MaHoaDon = @MaHoaDon;
END

CREATE PROCEDURE proc_ThemHoaDon
    @MaNhanVien INT,
    @MaKhachHang INT,
    @NgayLap DATETIME2(7)
AS
BEGIN
    INSERT INTO HoaDons (MaNhanVien, MaKhachHang, NgayLap, TongTien)
    VALUES (@MaNhanVien, @MaKhachHang, @NgayLap, 0);
END

DROP PROCEDURE proc_CapNhatThongTinHoaDon
DROP PROCEDURE proc_ThemHoaDon
---

CREATE PROCEDURE proc_XoaHoaDon
    @MaHoaDon INT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM ChiTietHoaDons WHERE MaHoaDon = @MaHoaDon)
    BEGIN
        DELETE FROM ChiTietHoaDons WHERE MaHoaDon = @MaHoaDon;
    END

    DELETE FROM HoaDons WHERE MaHoaDon = @MaHoaDon;
END

INSERT INTO [dbo].[HoaDons] ([MaNhanVien], [MaKhachHang], [NgayLap], [TongTien])
VALUES 
(1, 1, '2025-04-01', 250000),
(2, 1, '2025-04-02', 145000),
(1, 2, '2025-04-03', 387000),
(3, 2, '2025-04-04', 72000),
(2, 1, '2025-04-05', 510000);
(1, 2, '2025-04-06', 198000),
(5, 1, '2025-04-07', 325000),
(4, 2, '2025-04-08', 274000);

DBCC CHECKIDENT ('ChiTietHoaDons', RESEED, 0)

-- Chi Tiet Hoa Don

CREATE VIEW  View_ChiTietHoaDon AS
SELECT 
	cthd.MaChiTietHoaDon,
	cthd.MaHoaDon,
	ma.TenMonAn,
	cthd.SoLuong,
	ma.Gia,
	cthd.ThanhTien
FROM ChiTietHoaDons cthd
INNER JOIN MonAns ma ON cthd.MaMonAn = ma.MaMonAn

DROP VIEW View_ChiTietHoaDon

CREATE PROCEDURE proc_LayCTHD_MaHoaDon
	@MaHoaDon INT
AS
BEGIN
	SELECT 
		cthd.MaChiTietHoaDon,
		cthd.MaHoaDon,
		ma.TenMonAn,
		cthd.SoLuong,
		ma.Gia,
		cthd.ThanhTien
	FROM ChiTietHoaDons cthd
	INNER JOIN MonAns ma ON cthd.MaMonAn = ma.MaMonAn
	WHERE cthd.MaHoaDon = @MaHoaDon
END

CREATE PROCEDURE proc_CapNhatThongTinChiTietHoaDon
	@MaChiTietHoaDon INT,
    @SoLuong INT
AS
BEGIN
    UPDATE ChiTietHoaDons
    SET 
        SoLuong = @SoLuong
    WHERE MaChiTietHoaDon = @MaChiTietHoaDon;
END

CREATE PROCEDURE proc_ThemChiTietHoaDon
	@MaHoaDon INT,
    @MaMonAn INT,
    @SoLuong INT
AS
BEGIN
    INSERT INTO ChiTietHoaDons (MaHoaDon, MaMonAn, SoLuong, ThanhTien)
    VALUES (@MaHoaDon, @MaMonAn, @SoLuong, 0);
END

drop procedure proc_XoaChiTietHoaDon

CREATE PROCEDURE proc_XoaChiTietHoaDon
    @MaChiTietHoaDon INT
AS
BEGIN
    DELETE FROM ChiTietHoaDons WHERE MaChiTietHoaDon = @MaChiTietHoaDon;
END

-- NhapKho
CREATE PROCEDURE proc_CapNhatThongTinNhapKho
	@MaNhapKho INT,
    @SoLuong INT
AS
BEGIN
    UPDATE NhapKhos
    SET 
        SoLuong = @SoLuong
    WHERE MaNhapKho = @MaNhapKho;
END

CREATE PROCEDURE proc_ThemNhapKho
	@MaNhanVien INT,
    @MaNguyenLieu INT,
    @SoLuong INT,
	@NgayNhap DATETIME2(7),
	@SoNgayHetHan INT
AS
BEGIN
    INSERT INTO NhapKhos(MaNhanVien, MaNguyenLieu, NgayNhap, SoLuong, TongTien, SoNgayHetHan)
    VALUES (@MaNhanVien, @MaNguyenLieu, @NgayNhap, @SoLuong, 0, @SoNgayHetHan);
END

DROP PROCEDURE proc_ThemNhapKho

SELECT * FROM View_NhapKho
SELECT * FROM NhanViens
SELECT * FROM NguyenLieus

CREATE PROCEDURE proc_XoaNhapKho
    @MaNhapKho INT
AS
BEGIN
    DELETE FROM NhapKhos WHERE MaNhapKho = @MaNhapKho;
END

-- XuatKho
CREATE PROCEDURE proc_CapNhatThongTinXuatKho
	@MaXuatKho INT,
    @SoLuong INT,
	@NguyenNhan NVARCHAR(MAX)
AS
BEGIN
    UPDATE XuatKhos
    SET 
        SoLuong = @SoLuong,
		NguyenNhanXuatKho = @NguyenNhan 
    WHERE MaXuatKho = @MaXuatKho;
END

EXEC proc_CapNhatThongTinXuatKho @MaXuatKho = 1, @SoLuong = 10, @NguyenNhan = 'Nguyên nhân test';

CREATE PROCEDURE proc_ThemXuatKho
	@MaNhanVien INT,
    @MaNguyenLieu INT,
    @SoLuong INT,
	@NgayXuat DATETIME2(7),
	@NguyenNhan NVARCHAR(MAX),
	@MaLuuTru INT
AS
BEGIN
    INSERT INTO XuatKhos(MaNhanVien, MaNguyenLieu, SoLuong, NgayXuat, NguyenNhanXuatKho, MaLuuTru)
    VALUES (@MaNhanVien, @MaNguyenLieu, @SoLuong, @NgayXuat, @NguyenNhan, @MaLuuTru);
END

CREATE PROCEDURE proc_XoaXuatKho
    @MaXuatKho INT
AS
BEGIN
    DELETE FROM XuatKhos WHERE MaXuatKho = @MaXuatKho;
END


-- LuuTru
CREATE PROCEDURE proc_CapNhatThongTinLuuTru
	@MaLuuTru INT,
    @SoLuong INT,
	@NgayHetHan DATETIME2(7)
AS
BEGIN
    UPDATE LuuTrus
    SET 
        SoLuong = @SoLuong,
		NgayHetHan = @NgayHetHan 
    WHERE MaLuuTru = @MaLuuTru;
END

CREATE PROCEDURE proc_ThemLuuTru
	@MaNhanVien INT,
    @MaNguyenLieu INT,
    @SoLuong INT,
	@NgayHetHan DATETIME2(7)
AS
BEGIN
    INSERT INTO LuuTrus(MaNhanVien, MaNguyenLieu, SoLuong, NgayHetHan)
    VALUES (@MaNhanVien, @MaNguyenLieu, @SoLuong, @NgayHetHan);
END

CREATE PROCEDURE proc_XoaLuuTru
    @MaLuuTru INT
AS
BEGIN
    DELETE FROM LuuTrus WHERE MaLuuTru = @MaLuuTru;
END


---------------------------- VIEW
--view khuyen mai
CREATE VIEW View_KhuyenMai AS
SELECT 
    km.MaKhuyenMai,
    km.TenKhuyenMai,
    kh.MaKhachHang,
    kh.TenKhachHang,
    km.DaDung,
    km.NgayHetHan,
    -- Trạng thái khuyến mãi hiển thị dễ hiểu
    CASE 
        WHEN km.DaDung = 1 THEN N'Đã dùng'
        WHEN km.NgayHetHan < GETDATE() THEN N'Hết hạn'
        ELSE N'Còn hạn'
    END AS TrangThai
FROM KhuyenMais km
JOIN KhachHangs kh ON km.MaKhachHang = kh.MaKhachHang;

DROP VIEW View_KhuyenMai

--view nhap kho
CREATE VIEW View_NhapKho AS
SELECT 
	nk.MaNhapKho,
	nv.TenNhanVien,
	nl.TenNguyenLieu,
	nl.Gia,
	nk.NgayNhap,
	nk.SoLuong,
	nk.TongTien,
	nk.SoNgayHetHan
FROM NhapKhos nk
INNER JOIN NhanViens nv ON nk.MaNhanVien = nv.MaNhanVien
INNER JOIN NguyenLieus nl ON nl.MaNguyenLieu = nk.MaNguyenLieu

--view xuat kho
CREATE VIEW View_XuatKho AS
SELECT 
	nk.MaXuatKho,
	nv.TenNhanVien,
	nl.TenNguyenLieu,
	nk.NgayXuat,
	nk.SoLuong,
	nk.NguyenNhanXuatKho,
	nk.MaLuuTru
FROM XuatKhos nk
INNER JOIN NhanViens nv ON nk.MaNhanVien = nv.MaNhanVien
INNER JOIN NguyenLieus nl ON nl.MaNguyenLieu = nk.MaNguyenLieu

--view luu tru
CREATE VIEW View_LuuTru AS
SELECT 
	lt.MaLuuTru,
	lt.MaNguyenLieu,
	nv.TenNhanVien,
	nl.TenNguyenLieu,
	lt.NgayHetHan,
	lt.SoLuong
FROM LuuTrus lt
INNER JOIN NhanViens nv ON lt.MaNhanVien = nv.MaNhanVien
INNER JOIN NguyenLieus nl ON nl.MaNguyenLieu = lt.MaNguyenLieu

drop view View_LuuTru
SELECT * FROM View_LuuTru

INSERT INTO NhapKhos (MaNhanVien, MaNguyenLieu, NgayNhap, SoLuong, TongTien, SoNgayHetHan)
VALUES
(1, 1, GETDATE(), 10, 10 * 220000, 60), -- Thịt Bò
(2, 2, GETDATE(), 5, 5 * 35000, 7),     -- Rau Xà Lách
(3, 3, GETDATE(), 3, 3 * 45000, 10),    -- Ớt Chuông
(1, 4, GETDATE(), 20, 20 * 15000, 30),  -- Tỏi Băm
(2, 5, GETDATE(), 8, 8 * 150000, 90);

INSERT INTO [dbo].[XuatKhos] 
    ([MaNhanVien], [MaNguyenLieu], [SoLuong], [NgayXuat], [NguyenNhanXuatKho], [MaLuuTru])
VALUES
    (1, 2, 5, '2025-04-19 08:00:00', N'Xuất kho để phục vụ sản xuất', 1),
    (2, 1, 2, '2025-04-19 09:30:00', N'Xuất kho cho đơn hàng', 2),
    (3, 3, 3, '2025-04-20 10:15:00', N'Xuất kho theo yêu cầu của quản lý', 3);



INSERT INTO [dbo].[LuuTrus] 
    ([MaNhanVien], [MaNguyenLieu], [SoLuong], [NgayHetHan])
VALUES
	(3, 4, 50, '2026-01-25 23:59:59'),
	(2, 1, 200, '2026-02-15 23:59:59'),
	(1, 2, 100, '2025-12-31 23:59:59'),
    (2, 1, 150, '2025-11-30 23:59:59'),
    (3, 3, 200, '2026-01-15 23:59:59');

select * from LuuTrus

-- TRIGGER

CREATE TRIGGER trg_UpdateThanhTien
ON ChiTietHoaDons
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE cthd
    SET cthd.ThanhTien = cthd.SoLuong * ma.Gia
    FROM ChiTietHoaDons cthd
    INNER JOIN inserted i ON cthd.MaChiTietHoaDon = i.MaChiTietHoaDon
    INNER JOIN MonAns ma ON i.MaMonAn = ma.MaMonAn;
END;

CREATE TRIGGER trg_UpdateTongTien_NhapKho
ON NhapKhos
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE nk
    SET nk.TongTien = nk.SoLuong * nl.Gia
    FROM NhapKhos nk
    INNER JOIN inserted i ON nk.MaNhapKho = i.MaNhapKho
    INNER JOIN NguyenLieus nl ON i.MaNguyenLieu = nl.MaNguyenLieu;
END;

DBCC CHECKIDENT ('ChiTietHoaDons', RESEED, 0)

INSERT INTO ChiTietHoaDons (MaHoaDon, MaMonAn, SoLuong, ThanhTien)
VALUES (1, 2, 3, 0); 
INSERT INTO ChiTietHoaDons (MaHoaDon, MaMonAn, SoLuong, ThanhTien)
VALUES (2, 1, 4, 0); 
INSERT INTO ChiTietHoaDons (MaHoaDon, MaMonAn, SoLuong, ThanhTien)
VALUES (1, 3, 10, 0); 

--Trigger Tăng số lượng món ăn nếu đã có trong hóa đơn đó
CREATE TRIGGER trg_MergeChiTietHoaDonIfExist
ON ChiTietHoaDons
INSTEAD OF INSERT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @MaHoaDon INT,
            @MaMonAn INT,
            @SoLuong INT,
            @Gia FLOAT,
            @ThanhTien FLOAT;

    SELECT 
        @MaHoaDon = MaHoaDon,
        @MaMonAn = MaMonAn,
        @SoLuong = SoLuong
    FROM inserted;

    SELECT @Gia = Gia FROM MonAns WHERE MaMonAn = @MaMonAn;
    SET @ThanhTien = @SoLuong * @Gia;

    IF EXISTS (
        SELECT 1 FROM ChiTietHoaDons 
        WHERE MaHoaDon = @MaHoaDon AND MaMonAn = @MaMonAn
    )
    BEGIN
        UPDATE ChiTietHoaDons
        SET SoLuong = SoLuong + @SoLuong,
            ThanhTien = (SoLuong + @SoLuong) * @Gia
        WHERE MaHoaDon = @MaHoaDon AND MaMonAn = @MaMonAn;
    END
    ELSE
    BEGIN
        INSERT INTO ChiTietHoaDons (MaHoaDon, MaMonAn, SoLuong, ThanhTien)
        VALUES (@MaHoaDon, @MaMonAn, @SoLuong, @ThanhTien);
    END
END;

-- trigger cập nhật tổng tiền của hóa đơn dựa trên cthd
CREATE TRIGGER trg_UpdateTongTien
ON ChiTietHoaDons
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @MaHoaDonTable TABLE (MaHoaDon INT);

    -- Trường hợp INSERT và UPDATE
    INSERT INTO @MaHoaDonTable(MaHoaDon)
    SELECT DISTINCT MaHoaDon FROM inserted;

    -- Trường hợp DELETE
    INSERT INTO @MaHoaDonTable(MaHoaDon)
    SELECT DISTINCT MaHoaDon FROM deleted;

    -- Cập nhật lại tổng tiền trong bảng HoaDons
    UPDATE hd
    SET TongTien = ISNULL((
        SELECT SUM(ThanhTien)
        FROM ChiTietHoaDons cthd
        WHERE cthd.MaHoaDon = hd.MaHoaDon
    ), 0)
    FROM HoaDons hd
    WHERE hd.MaHoaDon IN (SELECT MaHoaDon FROM @MaHoaDonTable);
END;

DROP TRIGGER trg_UpdateTongTien_HoaDon

-- cap nhat Xuat kho thi so luong trong luu tru thay doi
CREATE TRIGGER trg_XuatKho_Update
ON XuatKhos
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Trừ số lượng cũ
    UPDATE lt
    SET lt.SoLuong = lt.SoLuong + d.SoLuong
    FROM LuuTrus lt
    INNER JOIN deleted d ON lt.MaLuuTru = d.MaLuuTru;

    -- Trừ số lượng mới
    UPDATE lt
    SET lt.SoLuong = lt.SoLuong - i.SoLuong
    FROM LuuTrus lt
    INNER JOIN inserted i ON lt.MaLuuTru = i.MaLuuTru;

    -- Kiểm tra không âm
    IF EXISTS (SELECT 1 FROM LuuTrus WHERE SoLuong < 0)
    BEGIN
        RAISERROR(N'Cập nhật không hợp lệ: Số lượng trong kho âm!', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;

-- xoa Xuat kho thi so luong trong luu tru tang
CREATE TRIGGER trg_XuatKho_Delete
ON XuatKhos
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE lt
    SET lt.SoLuong = lt.SoLuong + d.SoLuong
    FROM LuuTrus lt
    INNER JOIN deleted d ON lt.MaLuuTru = d.MaLuuTru;
END;

-- them Xuat kho thi so luong trong luu tru giam
CREATE TRIGGER trg_XuatKho_Insert
ON XuatKhos
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE lt
    SET lt.SoLuong = lt.SoLuong - i.SoLuong
    FROM LuuTrus lt
    INNER JOIN inserted i ON lt.MaLuuTru = i.MaLuuTru;

    IF EXISTS (SELECT 1 FROM LuuTrus WHERE SoLuong < 0)
    BEGIN
        RAISERROR(N'Số lượng trong kho không đủ để xuất!', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;

select * from TaiKhoanNhanViens

GO
-- Tạo login
CREATE LOGIN NhanVienPhucVuLogin WITH PASSWORD = 'PhucVu@2025';
CREATE LOGIN NhanVienQuanLyKhoLogin WITH PASSWORD = 'QuanLyKho@2025';
CREATE LOGIN AdminLogin WITH PASSWORD = 'Admin@2025';
GO
-- Tạo user trong cơ sở dữ liệu cho các login
CREATE USER NhanVienPhucVuUser FOR LOGIN NhanVienPhucVuLogin;
CREATE USER NhanVienQuanLyKhoUser FOR LOGIN NhanVienQuanLyKhoLogin;
CREATE USER AdminUser FOR LOGIN AdminLogin;
GO
-- Tạo role trong cơ sở dữ liệu để quản lý quyền
CREATE ROLE PhucVuRole;
CREATE ROLE QuanLyKhoRole;
CREATE ROLE AdminRole;
GO
-- Gán user vào các role tương ứng
EXEC sp_addrolemember 'PhucVuRole', 'NhanVienPhucVuUser';
EXEC sp_addrolemember 'QuanLyKhoRole', 'NhanVienQuanLyKhoUser';
EXEC sp_addrolemember 'AdminRole', 'AdminUser';
GO
---- Phân quyền cho PhucVuRole
GRANT SELECT ON [dbo].[MonAns] TO PhucVuRole;
GRANT SELECT, INSERT ON [dbo].[HoaDons] TO PhucVuRole;
GRANT SELECT, INSERT ON [dbo].[ChiTietHoaDons] TO PhucVuRole;
GO
---- Phân quyền Procedure cho PhucVuRole
-- MonAns
GRANT EXECUTE ON dbo.proc_ThemMonAn TO PhucVuRole;
GRANT EXECUTE ON dbo.proc_CapNhatThongTinMonAn TO PhucVuRole;
GRANT EXECUTE ON dbo.proc_XoaMonAn TO PhucVuRole;
-- HoaDons
GRANT EXECUTE ON dbo.proc_ThemHoaDon TO PhucVuRole;
GRANT EXECUTE ON dbo.proc_CapNhatThongTinHoaDon TO PhucVuRole;
GRANT EXECUTE ON dbo.proc_XoaHoaDon TO PhucVuRole;
-- ChiTietHoaDons
GRANT EXECUTE ON dbo.proc_ThemChiTietHoaDon TO PhucVuRole;
GRANT EXECUTE ON dbo.proc_CapNhatThongTinChiTietHoaDon TO PhucVuRole;
GRANT EXECUTE ON dbo.proc_XoaChiTietHoaDon TO PhucVuRole;
GRANT EXECUTE ON dbo.proc_LayCTHD_MaHoaDon TO PhucVuRole;
GO
---- Phân quyền View cho PhucVuRole
GRANT SELECT ON dbo.View_HoaDon TO PhucVuRole;
GRANT SELECT ON dbo.View_ChiTietHoaDon TO PhucVuRole;

GO
---- Phân quyền cho QuanLyKhoRole
GRANT SELECT, INSERT, UPDATE ON [dbo].[NguyenLieus] TO QuanLyKhoRole;
GRANT SELECT, INSERT, UPDATE ON [dbo].[NhapKhos] TO QuanLyKhoRole;
GRANT SELECT, INSERT, UPDATE ON [dbo].[XuatKhos] TO QuanLyKhoRole;
GRANT SELECT, INSERT, UPDATE ON [dbo].[LuuTrus] TO QuanLyKhoRole;
GO
---- Phân quyền Procedure cho QuanLyKhoRole
-- NguyenLieus
GRANT EXECUTE ON dbo.proc_ThemNguyenLieu TO QuanLyKhoRole;
GRANT EXECUTE ON dbo.proc_CapNhatThongTinNguyenLieu TO QuanLyKhoRole;
GRANT EXECUTE ON dbo.proc_XoaNguyenLieu TO QuanLyKhoRole;
-- NhapKhos
GRANT EXECUTE ON dbo.proc_ThemNhapKho TO QuanLyKhoRole;
GRANT EXECUTE ON dbo.proc_CapNhatThongTinNhapKho TO QuanLyKhoRole;
GRANT EXECUTE ON dbo.proc_XoaNhapKho TO QuanLyKhoRole;
-- XuatKhos
GRANT EXECUTE ON dbo.proc_ThemXuatKho TO QuanLyKhoRole;
GRANT EXECUTE ON dbo.proc_CapNhatThongTinXuatKho TO QuanLyKhoRole;
GRANT EXECUTE ON dbo.proc_XoaXuatKho TO QuanLyKhoRole;
-- LuuTrus
GRANT EXECUTE ON dbo.proc_ThemLuuTru TO QuanLyKhoRole;
GRANT EXECUTE ON dbo.proc_CapNhatThongTinLuuTru TO QuanLyKhoRole;
GRANT EXECUTE ON dbo.proc_XoaLuuTru TO QuanLyKhoRole;
GO
---- Phân quyền View cho QuanLyKhoRole
GRANT SELECT ON dbo.View_NguyenLieu TO QuanLyKhoRole;
GRANT SELECT ON dbo.View_XuatKho TO QuanLyKhoRole;
GRANT SELECT ON dbo.View_NhapKho TO QuanLyKhoRole;
GRANT SELECT ON dbo.View_LuuTru TO QuanLyKhoRole;

GO
---- Phân quyền cho AdminRole (toàn quyền trên tất cả bảng)
GRANT SELECT, INSERT, UPDATE, DELETE ON SCHEMA::[dbo] TO AdminRole;
GO
---- Phân quyền Procedure cho AdminRole(toàn quyền trên tất cả procedure)
DECLARE @sql NVARCHAR(MAX) = '';
SELECT @sql = @sql + 'GRANT EXECUTE ON dbo.' + name + ' TO AdminRole;' + CHAR(13)
FROM sys.objects
WHERE type = 'P';
EXEC sp_executesql @sql;
GO
---- Phân quyền View cho AdminRole(toàn quyền trên tất cả view)
DECLARE @sql NVARCHAR(MAX) = '';
SELECT @sql += 'GRANT SELECT ON [' + s.name + '].[' + v.name + '] TO AdminRole;' + CHAR(13)
FROM sys.views v
JOIN sys.schemas s ON v.schema_id = s.schema_id;
EXEC sp_executesql @sql;


