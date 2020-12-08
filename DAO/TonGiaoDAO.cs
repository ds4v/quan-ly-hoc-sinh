using System.Data;

namespace DAO
{
    public class TonGiaoDAO
    {
        private static TonGiaoDAO instance;

        private TonGiaoDAO() { }

        public static TonGiaoDAO Instance
        {
            get
            {
                if (instance == null) instance = new TonGiaoDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachTonGiao()
        {
            string query = "SELECT * FROM TONGIAO";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void CapNhatTonGiao(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "TONGIAO");
        }
    }
}
