namespace DTO
{
    public class KQHSMonHocDTO
    {
        private HocSinhDTO hocSinh;
        private LopDTO lop;
        private MonHocDTO monHoc;
        private HocKyDTO hocKy;
        private NamHocDTO namHoc;
        private float diemMiengTB;
        private float diem15PhutTB;
        private float diem45PhutTB;
        private float diemThi;
        private float diemTBHK;

        public KQHSMonHocDTO() {  }

        public KQHSMonHocDTO(
            string maHocSinh, 
            string maLop,
            string maMonHoc,
            string maHocKy,
            string maNamHoc, 
            float diemMiengTB, 
            float diem15PhutTB, 
            float diem45PhutTB, 
            float diemThi, 
            float diemTBHK)
        {
            this.hocSinh.MaHocSinh = maHocSinh;
            this.lop.MaLop = maLop;
            this.monHoc.MaMonHoc = maMonHoc;
            this.hocKy.MaHocKy = maHocKy;
            this.namHoc.MaNamHoc = maNamHoc;
            this.diemMiengTB = diemMiengTB;
            this.diem15PhutTB = diem15PhutTB;
            this.diem45PhutTB = diem45PhutTB;
            this.diemThi = diemThi;
            this.diemTBHK = diemTBHK;
        }

        public HocSinhDTO HocSinh { get => hocSinh; set => hocSinh = value; }
        public LopDTO Lop { get => lop; set => lop = value; }
        public MonHocDTO MonHoc { get => monHoc; set => monHoc = value; }
        public HocKyDTO HocKy { get => hocKy; set => hocKy = value; }
        public NamHocDTO NamHoc { get => namHoc; set => namHoc = value; }
        public float DiemMiengTB { get => diemMiengTB; set => diemMiengTB = value; }
        public float Diem15PhutTB { get => diem15PhutTB; set => diem15PhutTB = value; }
        public float Diem45PhutTB { get => diem45PhutTB; set => diem45PhutTB = value; }
        public float DiemThi { get => diemThi; set => diemThi = value; }
        public float DiemTBHK { get => diemTBHK; set => diemTBHK = value; }

        public string MaHocSinh 
        { 
            get => hocSinh.MaHocSinh; 
            set => hocSinh.MaHocSinh = value; 
        }

        public string MaLop
        {
            get => lop.MaLop;
            set => lop.MaLop = value;
        }

        public string MaMonHoc
        {
            get => monHoc.MaMonHoc;
            set => monHoc.MaMonHoc = value;
        }

        public string MaHocKy
        {
            get => hocKy.MaHocKy;
            set => hocKy.MaHocKy = value;
        }

        public string MaNamHoc
        {
            get => namHoc.MaNamHoc;
            set => namHoc.MaNamHoc = value;
        }

        public string HoTen
        {
            get => hocSinh.HoTen;
            set => hocSinh.HoTen = value;
        }
    }
}
