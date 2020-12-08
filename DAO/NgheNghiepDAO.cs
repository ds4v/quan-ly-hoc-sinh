using System.Data;

namespace DAO
{
    public class NgheNghiepDAO
    {
        private static NgheNghiepDAO instance;

        private NgheNghiepDAO() { }

        public static NgheNghiepDAO Instance
        {
            get
            {
                if (instance == null) instance = new NgheNghiepDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachNgheNghiep()
        {
            string query = "SELECT * FROM NGHENGHIEP";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void CapNhatNgheNghiep(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "NGHENGHIEP");
        }
    }
}
