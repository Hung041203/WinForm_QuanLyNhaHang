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
GRANT EXECUTE ON dbo.proc_LayThongTin TO PhucVuRole;

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