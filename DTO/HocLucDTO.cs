namespace DTO
{
    public class HocLucDTO
    {
        private string maHocLuc;
        private string tenHocLuc;
        private float diemCanDuoi;
        private float diemCanTren;
        private float diemKhongChe;

        public HocLucDTO() { }
        public string MaHocLuc { get => maHocLuc; set => maHocLuc = value; }
        public string TenHocLuc { get => tenHocLuc; set => tenHocLuc = value; }
        public float DiemCanDuoi { get => diemCanDuoi; set => diemCanDuoi = value; }
        public float DiemCanTren { get => diemCanTren; set => diemCanTren = value; }
        public float DiemKhongChe { get => diemKhongChe; set => diemKhongChe = value; }
    }
}
