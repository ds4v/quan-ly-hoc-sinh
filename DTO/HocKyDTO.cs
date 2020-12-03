namespace DTO
{
    public class HocKyDTO
    {
        private string maHocKy;
        private string tenHocKy;
        private int heSo;

        public HocKyDTO() { }
        public string MaHocKy { get => maHocKy; set => maHocKy = value; }
        public string TenHocKy { get => tenHocKy; set => tenHocKy = value; }
        public int HeSo { get => heSo; set => heSo = value; }
    }
}
