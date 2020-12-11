CREATE TRIGGER ThemNguoiDung ON NguoiDung AFTER INSERT, UPDATE
AS
BEGIN
	UPDATE NguoiDung SET MatKhau = HASHBYTES('SHA2_512', I.TenDangNhap + '@!?#?' + I.MatKhau)
    FROM NguoiDung ND INNER JOIN Inserted I ON I.MaNguoiDung = ND.MaNguoiDung
END
GO