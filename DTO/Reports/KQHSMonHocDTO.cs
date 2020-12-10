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
            HocSinhDTO hocSinh,
            LopDTO lop,
            MonHocDTO monHoc,
            HocKyDTO hocKy,
            NamHocDTO namHoc, 
            float diemMiengTB, 
            float diem15PhutTB, 
            float diem45PhutTB, 
            float diemThi, 
            float diemTBHK)
        {
            this.hocSinh = hocSinh;
            this.lop = lop;
            this.monHoc = monHoc;
            this.hocKy = hocKy;
            this.namHoc = namHoc;
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

        public string HoTen
        {
            get => hocSinh.HoTen;
            set => hocSinh.HoTen = value;
        }
    }
}
