using System.Data;

namespace DAO
{
    public class HocKyDAO
    {
        private static HocKyDAO instance;

        private HocKyDAO() { }

        public static HocKyDAO Instance
        {
            get
            {
                if (instance == null) instance = new HocKyDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachHocKy()
        {
            string query = "SELECT * FROM HOCKY";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void CapNhatHocKy(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "HOCKY");
        }
    }
}
