namespace DTO
{
    public class KQHSCaNamDTO
    {
        private HocSinhDTO hocSinh;
        private LopDTO lop;
        private NamHocDTO namHoc;
        private HocLucDTO hocLuc;
        private HanhKiemDTO hanhKiem;
        private KetQuaDTO ketQua;
        private float diemTBHK1;
        private float diemTBHK2;
        private float diemTBCN;

        public KQHSCaNamDTO(
            HocSinhDTO hocSinh, 
            LopDTO lop, 
            NamHocDTO namHoc, 
            HocLucDTO hocLuc, 
            HanhKiemDTO hanhKiem, 
            KetQuaDTO ketQua, 
            float diemTBHK1, 
            float diemTBHK2, 
            float diemTBCN)
        {
            this.hocSinh = hocSinh;
            this.lop = lop;
            this.namHoc = namHoc;
            this.hocLuc = hocLuc;
            this.hanhKiem = hanhKiem;
            this.ketQua = ketQua;
            this.diemTBHK1 = diemTBHK1;
            this.diemTBHK2 = diemTBHK2;
            this.diemTBCN = diemTBCN;
        }

        public HocSinhDTO HocSinh { get => hocSinh; set => hocSinh = value; }
        public LopDTO Lop { get => lop; set => lop = value; }
        public NamHocDTO NamHoc { get => namHoc; set => namHoc = value; }
        public HocLucDTO HocLuc { get => hocLuc; set => hocLuc = value; }
        public HanhKiemDTO HanhKiem { get => hanhKiem; set => hanhKiem = value; }
        public KetQuaDTO KetQua { get => ketQua; set => ketQua = value; }
        public float DiemTBHK1 { get => diemTBHK1; set => diemTBHK1 = value; }
        public float DiemTBHK2 { get => diemTBHK2; set => diemTBHK2 = value; }
        public float DiemTBCN { get => diemTBCN; set => diemTBCN = value; }

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

        public string TenHocLuc
        {
            get => hocLuc.TenHocLuc;
            set => hocLuc.TenHocLuc = value;
        }

        public string TenHanhKiem
        {
            get => hanhKiem.TenHanhKiem;
            set => hanhKiem.TenHanhKiem = value;
        }

        public string TenKetQua
        {
            get => ketQua.TenKetQua;
            set => ketQua.TenKetQua = value;
        }
    }
}
