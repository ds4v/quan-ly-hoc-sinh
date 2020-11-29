CREATE PROCEDURE ThemLop
	@maLop NVARCHAR(10), 
	@tenLop NVARCHAR(30), 
	@maKhoiLop NVARCHAR(6), 
	@maNamHoc NVARCHAR(6), 
	@siSo INT, 
	@maGiaoVien NVARCHAR(6)
AS
BEGIN
	INSERT LOP (MALOP, TenLop, MaKhoiLop, MaNamHoc, SiSo, MaGiaoVien)
	VALUES (@maLop, @tenLop, @maKhoiLop, @maNamHoc, @siSo, @maGiaoVien)
END
GO

