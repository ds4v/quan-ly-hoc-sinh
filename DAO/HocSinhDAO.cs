using System.Data;
namespace DAO
{
    public class HocSinhDAO
    {
        private static HocSinhDAO instance;

        private HocSinhDAO() { }

        public static HocSinhDAO Instance
        {
            get
            {
                if (instance == null) instance = new HocSinhDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachHocSinh()
        {
            string query = "SELECT * FROM HOCKY";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LayDanhSachHocSinh(string namHoc, string lop)
        {
            string query = $@"
                SELECT PL.MaHocSinh, HS.HoTen FROM HOCSINH HS 
                INNER JOIN PHANLOP PL ON HS.MaHocSinh = PL.MaHocSinh 
                INNER JOIN LOP L ON L.MaLop = PL.MaLop 
                WHERE PL.MaNamHoc = '{namHoc}' AND PL.MaLop = '{lop}'
            ";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
