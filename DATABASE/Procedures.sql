CREATE PROCEDURE ThemLop
	@maLop NVARCHAR(10), 
	@tenLop NVARCHAR(30), 
	@maKhoiLop NVARCHAR(6), 
	@maNamHoc NVARCHAR(6), 
	@siSo INT, 
	@maGiaoVien NVARCHAR(6)
AS
BEGIN
	INSERT INTO LOP VALUES (@maLop, @tenLop, @maKhoiLop, @maNamHoc, @siSo, @maGiaoVien)
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
	INSERT INTO DIEM VALUES(@maHocSinh, @maMonHoc, @maHocKy, @maNamHoc, @maLop, @maLoaiDiem, @diemSo)
END
GO

CREATE PROCEDURE XoaDiem @STT INT
AS
BEGIN
	DELETE FROM DIEM WHERE STT = @stt
END
GO