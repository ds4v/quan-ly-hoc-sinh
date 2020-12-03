using System.Data;

namespace DAO
{
    public class QuyDinhDAO
    {
        private static QuyDinhDAO instance;

        private QuyDinhDAO() { }

        public static QuyDinhDAO Instance
        {
            get
            {
                if (instance == null) instance = new QuyDinhDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LaySiSoQuyDinh()
        {
            string query = "SELECT SiSoCanDuoi, SiSoCanTren FROM QUYDINH";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LayDoTuoiQuyDinh()
        {
            string query = "SELECT TuoiCanDuoi, TuoiCanTren FROM QUYDINH";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LayThangDiemQuyDinh()
        {
            string query = "SELECT ThangDiem FROM QUYDINH";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
