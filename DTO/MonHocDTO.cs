namespace DTO
{
    public class MonHocDTO
    {
        private string maMonHoc;
        private string tenMonHoc;
        private int soTiet;
        private int heSo;

        public MonHocDTO() { }
        public string MaMonHoc { get => maMonHoc; set => maMonHoc = value; }
        public string TenMonHoc { get => tenMonHoc; set => tenMonHoc = value; }
        public int SoTiet { get => soTiet; set => soTiet = value; }
        public int HeSo { get => heSo; set => heSo = value; }
    }
}
