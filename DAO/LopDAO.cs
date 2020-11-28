using System.Data;

namespace DAO
{
    public class LopDAO
    {
        private static LopDAO instance;

        private LopDAO() { }

        public static LopDAO Instance
        {
            get => instance == null ? new LopDAO() : instance;
            private set => instance = value;
        }

        public DataTable LayDanhSachKhoiLop()
        {
            string query = "SELECT * FROM LOP";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
