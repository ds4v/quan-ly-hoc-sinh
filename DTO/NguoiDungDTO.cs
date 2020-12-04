namespace DTO
{
    public class NguoiDungDTO
    {
        private string maNguoiDung; 
        private LoaiNguoiDungDTO loaiNguoiDung;
        private string tenNguoiDung;
        private string tenDangNhap;
        private string matKhau;

        public string MaNguoiDung { get => maNguoiDung; set => maNguoiDung = value; }
        public LoaiNguoiDungDTO LoaiNguoiDung { get => loaiNguoiDung; set => loaiNguoiDung = value; }
        public string TenNguoiDung { get => tenNguoiDung; set => tenNguoiDung = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
    }
}
