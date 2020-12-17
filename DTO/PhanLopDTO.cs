namespace DTO
{
    public class PhanLopDTO
    {
        private string maNamHoc;
        private string maKhoiLop;
        private string maLop;
        private string maHocSinh;

        public PhanLopDTO(string maNamHoc, string maKhoiLop, string maLop, string maHocSinh)
        {
            this.maNamHoc = maNamHoc;
            this.maKhoiLop = maKhoiLop;
            this.maLop = maLop;
            this.maHocSinh = maHocSinh;
        }

        public string MaNamHoc { get => maNamHoc; set => maNamHoc = value; }
        public string MaKhoiLop { get => maKhoiLop; set => maKhoiLop = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public string MaHocSinh { get => maHocSinh; set => maHocSinh = value; }
    }
}
