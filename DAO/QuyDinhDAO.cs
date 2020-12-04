using System;
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

        public DataTable LayDanhSachQuyDinh()
        {
            string query = "SELECT * FROM QUYDINH";
            return DataProvider.Instance.ExecuteQuery(query);
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

        public void CapNhatSiSoQuyDinh(int siSoCanDuoi, int siSoCanTren)
        {
            string query = "EXEC CapNhatSiSoQuyDinh @siSoCanDuoi , @siSoCanTren";
            object[] parameters = new object[] { siSoCanDuoi, siSoCanTren };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        public void CapNhatDoTuoiQuyDinh(int tuoiCanDuoi, int tuoiCanTren)
        {
            string query = "EXEC CapNhatDoTuoiQuyDinh @tuoiCanDuoi , @tuoiCanTren";
            object[] parameters = new object[] { tuoiCanDuoi, tuoiCanTren };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        public void CapNhatThangDiemQuyDinh(int thangDiem)
        {
            string query = "EXEC CapNhatThangDiemQuyDinh @thangDiem";
            object[] parameters = new object[] { thangDiem };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
    }
}
