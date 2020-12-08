using System.Data;

namespace DAO
{
    public class HanhKiemDAO
    {
        private static HanhKiemDAO instance;

        private HanhKiemDAO() { }

        public static HanhKiemDAO Instance
        {
            get
            {
                if (instance == null) instance = new HanhKiemDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachHanhKiem()
        {
            string query = "SELECT * FROM HANHKIEM";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void CapNhatHanhKiem(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "HANHKIEM");
        }
    }
}
