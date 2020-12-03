namespace DTO
{
    public class KQHSMonHocDTO
    {
        private HocSinhDTO hocSinh;
        private LopDTO lop;
        private MonHocDTO monHoc;
        private HocKyDTO hocKy;
        private NamHocDTO namHoc;
        private float diem15Phut;
        private float diem45Phut;
        private float diemThi;
        private float diemTB;

        public KQHSMonHocDTO() { }
        public HocSinhDTO HocSinh { get => hocSinh; set => hocSinh = value; }
        public LopDTO Lop { get => lop; set => lop = value; }
        public MonHocDTO MonHoc { get => monHoc; set => monHoc = value; }
        public HocKyDTO HocKy { get => hocKy; set => hocKy = value; }
        public NamHocDTO NamHoc { get => namHoc; set => namHoc = value; }
        public float Diem15Phut { get => diem15Phut; set => diem15Phut = value; }
        public float Diem45Phut { get => diem45Phut; set => diem45Phut = value; }
        public float DiemThi { get => diemThi; set => diemThi = value; }
        public float DiemTB { get => diemTB; set => diemTB = value; }
    }
}
