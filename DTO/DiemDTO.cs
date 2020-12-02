namespace DTO
{
    public class DiemDTO
    {
        private string maHocSinh; 
        private string maMonHoc; 
        private string maHocKy; 
        private string maNamHoc; 
        private string maLop;
        private string maLoaiDiem;
        private float diemSo;

        public DiemDTO(
            string maHocSinh, 
            string maMonHoc, 
            string maHocKy, 
            string maNamHoc, 
            string maLop, 
            string maLoaiDiem, 
            float diemSo)
        {
            this.maHocSinh = maHocSinh;
            this.maMonHoc = maMonHoc;
            this.maHocKy = maHocKy;
            this.maNamHoc = maNamHoc;
            this.maLop = maLop;
            this.maLoaiDiem = maLoaiDiem;
            this.diemSo = diemSo;
        }

        public string MaHocSinh { get => maHocSinh; set => maHocSinh = value; }
        public string MaMonHoc { get => maMonHoc; set => maMonHoc = value; }
        public string MaHocKy { get => maHocKy; set => maHocKy = value; }
        public string MaNamHoc { get => maNamHoc; set => maNamHoc = value; }
        public string MaLop { get => maLop; set => maLop = value; }
        public string MaLoaiDiem { get => maLoaiDiem; set => maLoaiDiem = value; }
        public float DiemSo { get => diemSo; set => diemSo = value; }
    }
}
