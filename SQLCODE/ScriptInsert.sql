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

INSERT INTO NguyenLieus (TenNguyenLieu, DonViTinh, Gia, MaNhaCungCap) 
VALUES
	(N'Thịt Bò', N'kg', 220000, 1),        
	(N'Rau Xà Lách', N'kg', 35000, 2),     
	(N'Ớt Chuông', N'kg', 45000, 3),       
	(N'Tỏi Băm', N'gói', 15000, 1),        
	(N'Thịt Gà', N'kg', 150000, 2); 

INSERT INTO NhaCungCaps (TenNhaCungCap, DiaChi, SoDienThoai, Email)
VALUES 
	(N'Công Ty A', N'123 Đường ABC, Quận 1, TP.HCM', '0901234567', 'contact@congtyA.com'),
	(N'Công Ty B', N'456 Đường XYZ, Quận 3, TP.HCM', '0907654321', 'contact@congtyB.com'),
	(N'Công Ty C', N'789 Đường MNO, Quận 5, TP.HCM', '0912345678', 'contact@congtyC.com');

INSERT INTO KhuyenMais (TenKhuyenMai, MaKhachHang, DaDung, NgayHetHan) 
VALUES
	(N'Giảm 10% đơn đầu tiên', 1, 0, '2025-05-01'),
	(N'Miễn phí giao hàng', 2, 1, '2025-04-10'),
	(N'Giảm 50K cho đơn từ 200K', 1, 0, '2025-05-15'),
	(N'Quà tặng kèm', 3, 0, '2025-06-01'),
	(N'Voucher 100K sinh nhật', 3, 1, '2025-04-30');

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

INSERT INTO XuatKhos (MaNhanVien, MaNguyenLieu, SoLuong, NgayXuat, NguyenNhanXuatKho, MaLuuTru)
VALUES
    (1, 2, 5, '2025-04-19', N'Xuất kho để phục vụ sản xuất', 1),
    (2, 1, 2, '2025-04-19', N'Xuất kho cho đơn hàng', 2),
    (3, 3, 3, '2025-04-20', N'Xuất kho theo yêu cầu của quản lý', 3);

INSERT INTO LuuTrus (MaNhanVien, MaNguyenLieu, SoLuong, NgayHetHan)
VALUES
	(3, 4, 50, '2026-01-25'),
	(2, 1, 200, '2026-02-15'),
	(1, 2, 100, '2025-12-31'),
    (2, 1, 150, '2025-11-30'),
    (3, 3, 200, '2026-01-15');

INSERT INTO NhanViens (TenNhanVien, DiaChi, SoDienThoai, Email, MaChucVu)
VALUES
	(N'Bùi Hoàng Hưng', N'69 Nguyễn Gia Trí, Phường 25, Bình Thạnh, HCM', '0943518229', 'hhb041203@gmail.com', 1),
	('A01', 'a01', '0910', 'a01@gmail.com', 2),
	('A02', 'a02', '0911', 'a02@gmail.com', 2),
	('A03', 'a03', '0912', 'a03@gmail.com', 2),
	('A04', 'a04', '0913', 'a04@gmail.com', 2),
	('A05', 'a05', '0914', 'a05@gmail.com', 2),
	('A06', 'a06', '0915', 'a06@gmail.com', 3);

INSERT INTO TaiKhoanNhanViens (MaNhanVien, TaiKhoan, MatKhau)
VALUES
	(1, 'admin', '1'),
	(2, 'a01', 'a01'),
	(3, 'a03', 'a03'),
	(4, 'a02', 'a02'),
	(5, 'a04', 'a04'),
	(6, NULL, NULL),
	(7, NULL, NULL);

INSERT INTO NhaCungCaps (TenNhaCungCap, DiaChi, SoDienThoai, Email)
VALUES
	('Công Ty A', N'123 Đường ABC, Quận 1, TP.HCM', '0901234567', 'contact@congtyA.com'),
	('Công Ty B', N'456 Đường XYZ, Quận 3, TP.HCM', '0907654321', 'contact@congtyB.com'),
	('Công Ty C', N'789 Đường MNO, Quận 5, TP.HCM', '0912345678', 'contact@congtyC.com');

INSERT INTO MonAns (TenMonAn, Gia, SoLuongHienCo)
VALUES
	('Com tam', 45000, 150),
	('Pho bo', 60000, 50),
	('Banh mi', 25000, 150);