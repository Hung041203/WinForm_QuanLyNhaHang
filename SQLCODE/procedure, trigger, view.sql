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
(N'Thịt Bò', N'kg', 220000, 1),        -- Công Ty A
(N'Rau Xà Lách', N'kg', 35000, 2),     -- Công Ty B
(N'Ớt Chuông', N'kg', 45000, 3),       -- Công Ty C
(N'Tỏi Băm', N'gói', 15000, 1),        -- Công Ty A
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

CREATE PROCEDURE proc_CapNhatThongTinHoaDon
    @MaNhanVien INT,
    @MaHoaDon INT,
    @MaKhachHang INT,
    @NgayLap DATETIME2(7),
	@TongTien INT
AS
BEGIN
    UPDATE HoaDons
    SET 
        MaNhanVien = @MaNhanVien,
        MaKhachHang = @MaKhachHang,
        NgayLap = @NgayLap,
		TongTien = TongTien
    WHERE MaHoaDon = @MaHoaDon;
END

CREATE PROCEDURE proc_ThemHoaDon
    @MaNhanVien INT,
    @MaKhachHang INT,
    @NgayLap DATETIME2(7),
	@TongTien INT
AS
BEGIN
    INSERT INTO HoaDons (MaNhanVien, MaKhachHang, NgayLap, TongTien)
    VALUES (@MaNhanVien, @MaKhachHang, @NgayLap, @TongTien);
END

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

INSERT INTO [dbo].[HoaDons] ([MaNhanVien], [MaKhachHang], [NgayLap], [TongTien])
VALUES 
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

DBCC CHECKIDENT ('ChiTietHoaDons', RESEED, 0)

INSERT INTO ChiTietHoaDons (MaHoaDon, MaMonAn, SoLuong, ThanhTien)
VALUES (1, 2, 3, 0); 
INSERT INTO ChiTietHoaDons (MaHoaDon, MaMonAn, SoLuong, ThanhTien)
VALUES (2, 1, 4, 0); 
INSERT INTO ChiTietHoaDons (MaHoaDon, MaMonAn, SoLuong, ThanhTien)
VALUES (1, 3, 10, 0); 
