namespace DTO
{
    public class HanhKiemDTO
    {
        private string maHanhKiem;
        private string tenHanhKiem;

        public HanhKiemDTO() { }
        public string MaHanhKiem { get => maHanhKiem; set => maHanhKiem = value; }
        public string TenHanhKiem { get => tenHanhKiem; set => tenHanhKiem = value; }
    }
}
