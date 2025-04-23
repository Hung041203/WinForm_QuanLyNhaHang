-- View -- 
-- View hiển thị hóa đơn
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

--View xem thông tin nhân viên
CREATE VIEW View_NhanVien AS
SELECT 
    nv.MaNhanVien,
    nv.TenNhanVien,
    nv.DiaChi,
    nv.SoDienThoai,
    nv.Email,
    cv.TenChucVu
FROM NhanViens nv
LEFT JOIN ChucVus cv ON nv.MaChucVu = cv.MaChucVu;

-- View hiển thị thông tin khuyến mãi
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

-- View hiển thị danh mục nguyên liệu
CREATE VIEW View_NguyenLieu AS
SELECT 
    nl.MaNguyenLieu,
	nl.TenNguyenLieu,
	nl.DonViTinh,
	nl.Gia,
	ncc.TenNhaCungCap
FROM NguyenLieus nl
LEFT JOIN NhaCungCaps ncc ON nl.MaNhaCungCap = ncc.MaNhaCungCap;

-- View nhập kho
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

-- View xuất kho
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

-- View Lưu Trữ
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

-------------------------------------------------------------------------------
-- Procedure--
-- Đổi Mật Khẩu
CREATE PROCEDURE proc_DoiMatKhau
	@TaiKhoan NVARCHAR(MAX),
	@MatKhauMoi NVARCHAR(MAX)
AS
BEGIN 
	UPDATE TaiKhoanNhanViens
	SET MatKhau = @MatKhauMoi
	WHERE TaiKhoan = @TaiKhoan
END

-- Lấy Mật Khẩu
CREATE PROCEDURE proc_LayMatKhau
	@TaiKhoan NVARCHAR(MAX)
AS
BEGIN
	SELECT MatKhau FROM TaiKhoanNhanViens WHERE TaiKhoan = @TaiKhoan
END

-- Đăng Nhập
CREATE PROCEDURE proc_DangNhap
	@TaiKhoan NVARCHAR(MAX),
	@MatKhau NVARCHAR(MAX)
AS
BEGIN
	SELECT * FROM TaiKhoanNhanViens WHERE TaiKhoan = @TaiKhoan AND MatKhau = @MatKhau
END

-- Lấy Thông Tin Nhân Viên
CREATE PROCEDURE proc_LayThongTin
AS
BEGIN
	SELECT *
	FROM TaiKhoanNhanViens tk
	INNER JOIN NhanViens nv ON tk.MaNhanVien = nv.MaNhanVien
	INNER JOIN ChucVus cv ON nv.MaChucVu = cv.MaChucVu
END

-- Đăng Ký
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

-- NhanViens
-- Cập nhật thông tin nhân viên
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

-- Thêm Nhân Viên
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

-- Xóa Nhân Viên
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

-- NhaCungCaps
-- Thêm Nhà Cung Cấp
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

-- Cập Nhật Thông Tin Nhà Cung Cấp
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

-- Xóa Nhà Cung Cấp
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

-- MonAns
-- Thêm Món Ăn
CREATE PROCEDURE proc_ThemMonAn
    @TenMonAn NVARCHAR(100),
    @Gia FLOAT,
    @SoLuong INT
AS
BEGIN
    INSERT INTO MonAns (TenMonAn, Gia, SoLuongHienCo)
    VALUES (@TenMonAn, @Gia, @SoLuong);
END

-- Cập Nhật Thông Tin Món Ăn
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

-- Xóa Món Ăn
CREATE PROCEDURE proc_XoaMonAn
    @MaMonAn INT
AS
BEGIN
    DELETE FROM MonAns WHERE MaMonAn = @MaMonAn;
END

-- KhachHangs
-- Thêm Khách Hàng
CREATE PROCEDURE proc_ThemKhachHang
    @TenKhachHang NVARCHAR(100),
    @DiaChi NVARCHAR(100),
    @SoDienThoai NVARCHAR(100)
AS
BEGIN
    INSERT INTO KhachHangs (TenKhachHang, DiaChi, SoDienThoai)
    VALUES (@TenKhachHang, @DiaChi, @SoDienThoai);
END

-- Cập Nhật Thông Tin Khách Hàng
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

-- Xóa Khách Hàng
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

-- NguyenLieus
-- Cập Nhật Thông Tin Nguyên Liệu
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

-- Thêm Nguyên Liệu
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

-- Xóa Nguyên Liệu
CREATE PROCEDURE proc_XoaNguyenLieu
    @MaNguyenLieu INT
AS
BEGIN
    DELETE FROM NguyenLieus WHERE MaNguyenLieu = @MaNguyenLieu;
END

-- KhuyenMais
-- Cập Nhật Thông Tin Khuyến Mãi
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

-- Thêm Khuyến Mãi
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

-- Xóa Khuyến Mãi
CREATE PROCEDURE proc_XoaKhuyenMai
    @MaKhuyenMai INT
AS
BEGIN
    DELETE FROM KhuyenMais WHERE MaKhuyenMai = @MaKhuyenMai;
END

-- HoaDons
-- Cập Nhật Thông Tin Hóa Đơn
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

-- Thêm Hóa Đơn
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

-- Xóa Hơn Đơn
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

-- ChiTietHoaDons
-- Lấy Chi Tiết Hóa Đơn 
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

-- Cập Nhật Chi Tiết Hóa Đơn
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

-- Thêm Chi Tiết Hóa Đơn
CREATE PROCEDURE proc_ThemChiTietHoaDon
	@MaHoaDon INT,
    @MaMonAn INT,
    @SoLuong INT
AS
BEGIN
    INSERT INTO ChiTietHoaDons (MaHoaDon, MaMonAn, SoLuong, ThanhTien)
    VALUES (@MaHoaDon, @MaMonAn, @SoLuong, 0);
END

-- Xóa Chi Tiết Hóa Đơn
CREATE PROCEDURE proc_XoaChiTietHoaDon
    @MaChiTietHoaDon INT
AS
BEGIN
    DELETE FROM ChiTietHoaDons WHERE MaChiTietHoaDon = @MaChiTietHoaDon;
END

-- NhapKhos
-- Cập Nhật Thông Tin Nhập Kho
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

-- Thêm Nhập Kho
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

-- Xóa Nhập Kho
CREATE PROCEDURE proc_XoaNhapKho
    @MaNhapKho INT
AS
BEGIN
    DELETE FROM NhapKhos WHERE MaNhapKho = @MaNhapKho;
END

-- XuatKhos
-- Cập Nhật Thông Tin Xuất Kho
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

-- Thêm Xuất Kho
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

-- Xóa Xuất Kho
CREATE PROCEDURE proc_XoaXuatKho
    @MaXuatKho INT
AS
BEGIN
    DELETE FROM XuatKhos WHERE MaXuatKho = @MaXuatKho;
END

-- LuuTrus
-- Cập Nhật Thông Tin Lưu Trữ
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

-- Thêm Lưu Trữ
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

-- Xóa Lưu Trữ
CREATE PROCEDURE proc_XoaLuuTru
    @MaLuuTru INT
AS
BEGIN
    DELETE FROM LuuTrus WHERE MaLuuTru = @MaLuuTru;
END

--------------------------------------------------------------
-- Trigger --
-- HoaDons
-- Trigger kiểm tra số lượng món ăn trước khi thêm hóa đơn để ngănKha không cho tạo hóa đơn nếu món ăn đã hết hàng.
CREATE TRIGGER trg_Check_SoLuongMonAn_Before_Insert_HoaDon
ON HoaDons
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @MaHoaDon INT, @MaMonAn INT, @SoLuongDat INT;

    SELECT @MaHoaDon = inserted.MaHoaDon, @MaMonAn = MA.MaMonAn, @SoLuongDat = MA.SoLuongHienCo
    FROM inserted
    JOIN MonAns MA ON MA.MaMonAn = inserted.MaHoaDon;

    IF @SoLuongDat <= 0
    BEGIN
        PRINT 'Không thể tạo hóa đơn vì món ăn đã hết hàng!';
        ROLLBACK TRANSACTION;
        RETURN;
    END;

    INSERT INTO HoaDons (MaHoaDon, MaNhanVien, MaKhachHang, NgayLap, TongTien)
    SELECT MaHoaDon, MaNhanVien, MaKhachHang, NgayLap, TongTien FROM inserted;
END;
GO
DISABLE TRIGGER [dbo].[trg_Check_SoLuongMonAn_Before_Insert_HoaDon]
    ON [dbo].[HoaDons];

-- ChiTietHoaDons
-- Trigger Tăng số lượng món ăn nếu đã có trong hóa đơn đó
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

-- Trigger tự động cập nhật thành tiền trong chi tiết hóa đơn sau mỗi lần thêm món vào hóa đơn hoặc sửa số lượng món trong hóa đơn
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

-- Trigger cập nhật tổng tiền của hóa đơn dựa trên chi tiết hóa đơn
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


-- NhanViens
-- Trigger kiểm tra trùng lặp email và số điện thoại của nhân viên
CREATE TRIGGER trg_KiemTraTrungLapNhanVien
ON NhanViens
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ErrorMessage NVARCHAR(255);

    -- Kiểm tra trùng lặp số điện thoại
    IF EXISTS (
        SELECT I.SoDienThoai
        FROM inserted I
        JOIN NhanViens N ON I.SoDienThoai = N.SoDienThoai AND I.MaNhanVien <> N.MaNhanVien
    )
    BEGIN
        SET @ErrorMessage = N'Lỗi: Số điện thoại đã tồn tại!';
        THROW 51000, @ErrorMessage, 1;
    END

    -- Kiểm tra trùng lặp email
    IF EXISTS (
        SELECT I.Email
        FROM inserted I
        JOIN NhanViens N ON I.Email = N.Email AND I.MaNhanVien <> N.MaNhanVien
    )
    BEGIN
        SET @ErrorMessage = N'Lỗi: Email đã tồn tại!';
        THROW 51000, @ErrorMessage, 1;
    END
END;

-- KhuyenMais
-- Trigger tự chặn khuyến mãi nếu khuyến mãi tạo ra đã hết hạn hoặc đã dùng
CREATE TRIGGER trg_Block_Invalid_KhuyenMai
ON KhuyenMais
INSTEAD OF INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE DaDung = 1 OR NgayHetHan < CAST(GETDATE() AS DATE)
    )
    BEGIN
        THROW 50001, N'Lỗi: Không thể thêm khuyến mãi đã dùng hoặc đã hết hạn!', 1;
        RETURN;
    END

-- MonAns
-- Trigger kiểm tra trùng lặp món 
CREATE TRIGGER trg_KiemTraTrungLapMonAn
ON MonAns
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ErrorMessage NVARCHAR(255);

    -- Kiểm tra trùng lặp tên món ăn
    IF EXISTS (
        SELECT I.TenMonAn
        FROM inserted I
        JOIN MonAns M ON I.TenMonAn = M.TenMonAn AND I.MaMonAn <> M.MaMonAn
    )
    BEGIN
        SET @ErrorMessage = N'Lỗi: Tên món ăn đã tồn tại!';
        THROW 51000, @ErrorMessage, 1;
    END
END;

-- KhachHangs
-- Kiểm tra trùng lặp số điện thoại của khách hàng, nếu trùng thì sẽ không cho phép nhập
CREATE TRIGGER trg_KiemTraTrungLapSDT_KhachHang
ON KhachHangs
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @ErrorMessage NVARCHAR(255);

    -- Kiểm tra trùng số điện thoại
    IF EXISTS (
        SELECT I.SoDienThoai
        FROM inserted I
        JOIN KhachHangs K ON I.SoDienThoai = K.SoDienThoai AND I.MaKhachHang <> K.MaKhachHang
    )
    BEGIN
        SET @ErrorMessage = N'Lỗi: Số điện thoại đã tồn tại!';
        THROW 51000, @ErrorMessage, 1;
    END
END;

-- NhapKhos
--Trigger tự động tính tổng tiền khi nhập kho
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

-- XuatKhos
-- Trigger kiểm tra và cập nhật tồn kho khi xuất kho
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

-- Trigger kiểm tra và cập nhật tồn kho khi cập nhật thông tin xuất kho
CREATE TRIGGER trg_XuatKho_Update
ON XuatKhos
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Trừ số lượng cũ
    UPDATE lt
    SET lt.SoLuong = lt.SoLuong + d.SoLuongXuat
    FROM LuuTrus lt
    INNER JOIN deleted d ON lt.MaLuuTru = d.MaLuuTru;

    -- Trừ số lượng mới
    UPDATE lt
    SET lt.SoLuong = lt.SoLuong - i.SoLuongXuat
    FROM LuuTrus lt
    INNER JOIN inserted i ON lt.MaLuuTru = i.MaLuuTru;

    -- Kiểm tra không âm
    IF EXISTS (SELECT 1 FROM LuuTrus WHERE SoLuong < 0)
    BEGIN
        RAISERROR(N'Cập nhật không hợp lệ: Số lượng trong kho âm!', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;

-- Trigger khôi phục lại số lượng trong kho khi xoá phiếu xuất kho
CREATE TRIGGER trg_XuatKho_Delete
ON XuatKhos
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE lt
    SET lt.SoLuong = lt.SoLuong + d.SoLuongXuat
    FROM LuuTrus lt
    INNER JOIN deleted d ON lt.MaLuuTru = d.MaLuuTru;
END;

-- LuuTrus
-- Trigger tự động đặt số lượng nguyên liệu về 0 khi hết hạn
CREATE TRIGGER trg_LuuTrus_CheckExpiration
ON [dbo].[LuuTrus]
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    SET NOCOUNT ON;

    -- Cập nhật SoLuong = 0 cho các bản ghi đã hết hạn
    UPDATE [dbo].[LuuTrus]
    SET SoLuong = 0
    WHERE NgayHetHan < GETDATE()
    AND SoLuong > 0;
END;
GO
