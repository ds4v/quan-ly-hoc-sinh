namespace DTO
{
    public class LoaiNguoiDungDTO
    {
        private string maLoai;
        private string tenLoai;

        public LoaiNguoiDungDTO() { }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
    }
}
