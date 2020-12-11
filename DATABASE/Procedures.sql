USE QuanLyHocSinh
GO

CREATE PROCEDURE ThemGiaoVien
	@maGiaoVien NVARCHAR(6), 
    @tenGiaoVien NVARCHAR(30), 
    @diaChi NVARCHAR(50), 
    @dienThoai NVARCHAR(15), 
    @chuyenMon NVARCHAR(6)
AS
BEGIN
	INSERT INTO GiaoVien (MaGiaoVien, TenGiaoVien, DiaChi, DienThoai, MaMonHoc) 
	VALUES (@maGiaoVien, @tenGiaoVien, @diaChi, @dienThoai, @chuyenMon)
END
GO

--===================================================================================================================================================

CREATE PROCEDURE LayDanhSachHocSinh
	@maNamHoc NVARCHAR(6),
	@maLop NVARCHAR(10)
AS
BEGIN
	SELECT PL.MaHocSinh, HS.HoTen FROM HOCSINH HS 
	INNER JOIN PHANLOP PL ON HS.MaHocSinh = PL.MaHocSinh 
	INNER JOIN LOP L ON L.MaLop = PL.MaLop 
	WHERE PL.MaNamHoc = @maNamHoc AND PL.MaLop = @maLop
END
GO

CREATE PROCEDURE ThemHocSinh
	@maHocSinh NVARCHAR(6), 
    @hoTen NVARCHAR(30), 
    @gioiTinh BIT, 
    @ngaySinh DATETIME, 
    @diaChi NVARCHAR(50), 
    @maDanToc NVARCHAR(6), 
    @maTonGiao NVARCHAR(6), 
    @hoTenCha NVARCHAR(30), 
    @maNgheCha NVARCHAR(6), 
    @hoTenMe NVARCHAR(30), 
    @maNgheMe NVARCHAR(6), 
    @email NVARCHAR(50)
AS
BEGIN
	INSERT INTO HOCSINH (MaHocSinh, HoTen, GioiTinh, NgaySinh, DiaChi, MaDanToc, MaTonGiao, HoTenCha, MaNNghiepCha, HoTenMe, MaNNghiepMe, Email) 
	VALUES (@maHocSinh, @hoTen, @gioiTinh, @ngaySinh, @diaChi, @maDanToc, @maTonGiao, @hoTenCha, @maNgheCha, @hoTenMe, @maNgheMe, @email)
END
GO

--===================================================================================================================================================

CREATE PROCEDURE LayDanhSachDiem
	@maHocSinh NVARCHAR(6), 
	@maMonHoc NVARCHAR(6), 
	@maHocKy NVARCHAR(3), 
	@maNamHoc NVARCHAR(6), 
	@maLop NVARCHAR(10)
AS
BEGIN
	SELECT * FROM DIEM, LOP, HOCSINH, MONHOC, LOAIDIEM
	WHERE DIEM.MaHocSinh = HOCSINH.MaHocSinh 
	  AND DIEM.MaMonHoc = MONHOC.MaMonHoc 
	  AND DIEM.MaLoai = LOAIDIEM.MaLoai 
	  AND DIEM.MaLop = LOP.MaLop 
	  AND HOCSINH.MaHocSinh = @maHocSinh
	  AND MONHOC.MaMonHoc = @maMonHoc
	  AND DIEM.MaHocKy = @maHocKy
	  AND DIEM.MaNamHoc = @maNamHoc
	  AND LOP.MaLop = @maLop
END
GO

CREATE PROCEDURE LayDanhSachDiemHocSinh
	@maHocSinh NVARCHAR(6), 
	@maMonHoc NVARCHAR(6), 
	@maHocKy NVARCHAR(3), 
	@maNamHoc NVARCHAR(6), 
	@maLop NVARCHAR(10)
AS
BEGIN
	SELECT * FROM DIEM, LOAIDIEM 
	WHERE DIEM.MaLoai = LOAIDIEM.MaLoai 
	  AND DIEM.MaHocSinh = @maHocSinh
	  AND DIEM.MaMonHoc = @maMonHoc
	  AND DIEM.MaHocKy = @maHocKy 
	  AND DIEM.MaNamHoc = @maNamHoc
	  AND DIEM.MaLop = @maLop
END
GO

CREATE PROCEDURE ThemDiem
	@maHocSinh NVARCHAR(6), 
	@maMonHoc NVARCHAR(6), 
	@maHocKy NVARCHAR(3), 
	@maNamHoc NVARCHAR(6), 
	@maLop NVARCHAR(10), 
	@maLoaiDiem NVARCHAR(6),
	@diemSo FLOAT
AS
BEGIN
	INSERT INTO DIEM (MaHocSinh, MaMonHoc, MaHocKy, MaNamHoc, MaLop, MaLoai, Diem)
	VALUES (@maHocSinh, @maMonHoc, @maHocKy, @maNamHoc, @maLop, @maLoaiDiem, @diemSo)
END
GO

CREATE PROCEDURE XoaDiem @STT INT
AS
BEGIN
	DELETE FROM DIEM WHERE STT = @stt
END
GO

--===================================================================================================================================================

CREATE PROCEDURE ThemLop
	@maLop NVARCHAR(10), 
	@tenLop NVARCHAR(30), 
	@maKhoiLop NVARCHAR(6), 
	@maNamHoc NVARCHAR(6), 
	@siSo INT, 
	@maGiaoVien NVARCHAR(6)
AS
BEGIN
	INSERT INTO LOP (MaLop, TenLop, MaKhoiLop, MaNamHoc, SiSo, MaGiaoVien)
	VALUES (@maLop, @tenLop, @maKhoiLop, @maNamHoc, @siSo, @maGiaoVien)
END
GO

--===================================================================================================================================================

CREATE PROCEDURE LayDanhSachMonHoc
	@maNamHoc NVARCHAR(6),
	@maLop NVARCHAR(10)
AS
BEGIN
	SELECT MH.MaMonHoc, MH.TenMonHoc, MH.HeSo FROM MONHOC MH, PHANCONG PC 
	WHERE MH.MaMonHoc = PC.MaMonHoc AND PC.MaNamHoc = @maNamHoc AND PC.MaLop = @maLop
END
GO

--===================================================================================================================================================

CREATE PROCEDURE ThemPhanCong
	@maNamHoc NVARCHAR(6), 
	@maLop NVARCHAR(10), 
	@maMonHoc NVARCHAR(6), 
	@maGiaoVien NVARCHAR(6)
AS
BEGIN
	INSERT INTO PHANCONG (MaNamHoc, MaLop, MaMonHoc, MaGiaoVien)
	VALUES (@maNamHoc, @maLop, @maMonHoc, @maGiaoVien)
END
GO

--===================================================================================================================================================

CREATE PROCEDURE ReportKQHSMonHoc
	@maLop NVARCHAR(10), 
	@maNamHoc NVARCHAR(6),
	@maMonHoc NVARCHAR(6), 
	@maHocKy NVARCHAR(3)
AS
BEGIN
	SELECT * FROM HOCSINH HS 
	INNER JOIN KQ_HOCSINH_MONHOC KQ ON KQ.MaHocSinh = HS.MaHocSinh 
	INNER JOIN LOP ON KQ.MaLop = LOP.MaLop 
	INNER JOIN NAMHOC NH ON KQ.MaNamHoc = NH.MaNamHoc 
	INNER JOIN MONHOC MH ON KQ.MaMonHoc = MH.MaMonHoc 
	INNER JOIN HOCKY HK ON KQ.MaHocKy = HK.MaHocKy 
	WHERE KQ.MaLop = @maLop
	  AND KQ.MaNamHoc = @maNamHoc
	  AND KQ.MaMonHoc = @maMonHoc
	  AND KQ.MaHocKy = @maHocKy
END 
GO

CREATE PROCEDURE ThemKQHSMonHoc
	@maHocSinh NVARCHAR(6),
	@maLop NVARCHAR(10), 
	@maNamHoc NVARCHAR(6),
	@maMonHoc NVARCHAR(6), 
	@maHocKy NVARCHAR(3), 
	@diemMiengTB FLOAT,
	@diem15PhutTB FLOAT,
	@diem45PhutTB FLOAT,
	@diemThi FLOAT,
	@diemTBHK FLOAT
AS
BEGIN
	INSERT INTO KQ_HOCSINH_MONHOC (MaHocSinh, MaLop, MaNamHoc, MaMonHoc, MaHocKy, DiemMiengTB, Diem15PhutTB, Diem45PhutTB, DiemThi, DiemTBHK)
	VALUES (@maHocSinh, @maLop, @maNamHoc, @maMonHoc, @maHocKy, @diemMiengTB, @diem15PhutTB, @diem45PhutTB, @diemThi, @diemTBHK)
END
GO

CREATE PROCEDURE XoaKQHSMonHoc
	@maHocSinh NVARCHAR(6),
	@maLop NVARCHAR(10), 
	@maNamHoc NVARCHAR(6),
	@maMonHoc NVARCHAR(6), 
	@maHocKy NVARCHAR(3)
AS
BEGIN
	DELETE FROM KQ_HOCSINH_MONHOC 
	WHERE MaHocSinh = @maHocSinh 
	  AND MaLop = @maLop 
	  AND MaNamHoc = @maNamHoc
	  AND MaMonHoc = @maMonHoc 
	  AND MaHocKy = @maHocKy 
END 
GO

--===================================================================================================================================================

CREATE PROCEDURE ReportKQHSCaNam
	@maLop NVARCHAR(10), 
	@maNamHoc NVARCHAR(6)
AS
BEGIN
	SELECT * FROM HOCSINH HS 
	INNER JOIN KQ_HOCSINH_CANAM KQ ON KQ.MaHocSinh = HS.MaHocSinh 
	INNER JOIN LOP ON KQ.MaLop = LOP.MaLop 
    INNER JOIN NAMHOC NH ON KQ.MaNamHoc = NH.MaNamHoc 
	INNER JOIN HOCLUC HL ON KQ.MaHocLuc = HL.MaHocLuc
	INNER JOIN HANHKIEM HK ON KQ.MaHanhKiem = HK.MaHanhKiem 
	INNER JOIN KETQUA KQUA ON KQ.MaKetQua = KQUA.MaKetQua
    WHERE KQ.MaLop = @maLop AND KQ.MaNamHoc = @maNamHoc
END 
GO

CREATE PROCEDURE ThemKQHSCaNam
	@maHocSinh NVARCHAR(6), 
	@maLop NVARCHAR(10), 
	@maNamHoc NVARCHAR(6), 
	@maHocLuc NVARCHAR(6), 
	@maHanhKiem NVARCHAR(6), 
	@maKetQua NVARCHAR(6), 
	@diemTBHK1 FLOAT, 
	@diemTBHK2 FLOAT, 
	@diemTBCN FLOAT
AS
BEGIN
	INSERT INTO KQ_HOCSINH_CANAM (MaHocSinh, MaLop, MaNamHoc, MaHocLuc, MaHanhKiem, MaKetQua, DiemTBHK1, DiemTBHK2, DiemTBCN)
	VALUES (@maHocSinh, @maLop, @maNamHoc, @maHocLuc, @maHanhKiem, @maKetQua, @diemTBHK1, @diemTBHK2, @diemTBCN)
END
GO

CREATE PROCEDURE XoaKQHSCaNam
	@maHocSinh NVARCHAR(6),
	@maLop NVARCHAR(10), 
	@maNamHoc NVARCHAR(6)
AS
BEGIN
	DELETE FROM KQ_HOCSINH_CANAM 
	WHERE MaHocSinh = @maHocSinh 
	  AND MaLop = @maLop 
	  AND MaNamHoc = @maNamHoc
END 
GO

--===================================================================================================================================================

CREATE PROCEDURE CapNhatQuyDinhSiSo
	@siSoCanDuoi INT,
	@siSoCanTren INT 
AS
BEGIN
	UPDATE QUYDINH SET SiSoCanDuoi = @siSoCanDuoi, SiSoCanTren = @siSoCanTren
END
GO

CREATE PROCEDURE CapNhatQuyDinhDoTuoi
	@tuoiCanDuoi INT,
	@tuoiCanTren INT 
AS
BEGIN
	UPDATE QUYDINH SET TuoiCanDuoi = @tuoiCanDuoi, TuoiCanTren = @tuoiCanTren
END
GO

CREATE PROCEDURE CapNhatQuyDinhThangDiem @thangDiem INT 
AS
BEGIN
	UPDATE QUYDINH SET ThangDiem = @thangDiem
END
GO

--===================================================================================================================================================

CREATE PROCEDURE DangNhap
	@tenDangNhap NVARCHAR(30),
	@matKhau VARCHAR(64)
AS
BEGIN
	SELECT * FROM NGUOIDUNG 
	WHERE TenDangNhap = @tendangnhap
	  AND MatKhau = HASHBYTES('SHA2_512', @tenDangNhap + '@!?#?' + @matKhau)
END
GO

CREATE PROCEDURE DoiMatKhau
	@tenDangNhap NVARCHAR(30),
	@matKhau VARCHAR(64) 
AS
BEGIN
	UPDATE NGUOIDUNG SET MatKhau = @matkhau WHERE TenDangNhap = @tendangnhap
END
GO
