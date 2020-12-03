using System.Data;

namespace DAO
{
    public class KQHSMonHocDAO
    {
        private static KQHSMonHocDAO instance;

        private KQHSMonHocDAO() { }

        public static KQHSMonHocDAO Instance
        {
            get
            {
                if (instance == null) instance = new KQHSMonHocDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable ReportKQHSMonHoc(string maLop, string maMonHoc, string maHocKy, string maNamHoc)
        {
            string query = "EXEC ReportKQHSMonHoc @maLop , @maMonHoc , @maHocKy , @maNamHoc";
            object[] parameters = new object[] { maLop, maMonHoc, maHocKy, maNamHoc };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }
    }
}
