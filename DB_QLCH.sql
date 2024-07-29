SELECT a.MaHang, b.TenHang, a.SoLuong, b.DonGiaBan, a.GiamGia,a.ThanhTien 
FROM tblChiTietHDBan a, tblHang b
WHERE a.MaHDBan = 'HDB001' AND a.MaHang=b.MaHang;

ALTER SESSION SET NLS_DATE_FORMAT = 'YYYY-MM-DD';
--HH.MI.SS

 --HH.MI.SSXFF AM

--HH.MI.SSXFF AM TZR


insert into tblHDban(mahdban, manhanvien, ngayban, makhach, tongtien) 
values('HDB004','NV002',date'2024-05-12','KH001',12312);


-- Tạo View
CREATE OR REPLACE VIEW View_PhieuSanPham AS
SELECT
    h.MaHang, 
    h.TenHang, 
    n.Manc, 
    h.SoLuong, 
    h.DonGiaNhap, 
    h.DonGiaBan, 
    l.MaLoai, 
    SUM(h.DonGiaNhap * h.SoLuong) AS TongTienNhaphang
FROM
    tblHang h
INNER JOIN
    tblNhaCungcap n ON h.Manc = n.Manc
INNER JOIN
    tblLoaiSanPham l ON h.MaLoai = l.MaLoai
GROUP BY
    h.MaHang, 
    h.TenHang, 
    n.Manc, 
    h.SoLuong, 
    h.DonGiaNhap, 
    h.DonGiaBan, 
    l.MaLoai;
