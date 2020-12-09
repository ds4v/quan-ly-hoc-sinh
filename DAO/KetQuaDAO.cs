using System.Data;

namespace DAO
{
    public class KetQuaDAO
    {
        private static KetQuaDAO instance;

        private KetQuaDAO() { }

        public static KetQuaDAO Instance
        {
            get
            {
                if (instance == null) instance = new KetQuaDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachKetQua()
        {
            string query = "SELECT * FROM KETQUA";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void CapNhatKetQua(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "KETQUA");
        }
    }
}
