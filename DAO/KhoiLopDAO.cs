using System.Data;

namespace DAO
{
    public class KhoiLopDAO
    {
        private static KhoiLopDAO instance;

        private KhoiLopDAO() { }

        public static KhoiLopDAO Instance
        {
            get
            {
                if (instance == null) instance = new KhoiLopDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachKhoiLop()
        {
            string query = "SELECT * FROM KHOILOP";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void CapNhatKhoiLop(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "KHOILOP");
        }
    }
}
