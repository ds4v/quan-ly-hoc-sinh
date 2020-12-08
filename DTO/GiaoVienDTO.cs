namespace DTO
{
    public class GiaoVienDTO
    {
        private string maGiaoVien;
        private string tenGiaoVien;
        private string diaChi;
        private string dienThoai;
        private string chuyenMon;

        public GiaoVienDTO(
            string maGiaoVien, 
            string tenGiaoVien, 
            string diaChi, 
            string dienThoai, 
            string chuyenMon)
        {
            this.maGiaoVien = maGiaoVien;
            this.tenGiaoVien = tenGiaoVien;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
            this.chuyenMon = chuyenMon;
        }

        public string MaGiaoVien { get => maGiaoVien; set => maGiaoVien = value; }
        public string TenGiaoVien { get => tenGiaoVien; set => tenGiaoVien = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string DienThoai { get => dienThoai; set => dienThoai = value; }
        public string ChuyenMon { get => chuyenMon; set => chuyenMon = value; }
    }
}
