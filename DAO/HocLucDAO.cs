using System.Data;

namespace DAO
{
    public class HocLucDAO
    {
        private static HocLucDAO instance;

        private HocLucDAO() { }

        public static HocLucDAO Instance
        {
            get
            {
                if (instance == null) instance = new HocLucDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachHocLuc()
        {
            string query = "SELECT * FROM HOCLUC";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void CapNhatHocLuc(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "HOCLUC");
        }
    }
}
