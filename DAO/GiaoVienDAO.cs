using System.Data;

namespace DAO
{
    public class GiaoVienDAO
    {
        private static GiaoVienDAO instance;

        private GiaoVienDAO() { }

        public static GiaoVienDAO Instance
        {
            get
            {
                if (instance == null) instance = new GiaoVienDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachGiaoVien()
        {
            string query = "SELECT * FROM GIAOVIEN";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
