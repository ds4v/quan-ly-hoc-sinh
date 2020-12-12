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

        public DataTable LayDoTuoiQuyDinh()
        {
            string query = "SELECT TuoiCanDuoi, TuoiCanTren FROM QUYDINH";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LaySiSoQuyDinh()
        {
            string query = "SELECT SiSoCanDuoi, SiSoCanTren FROM QUYDINH";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int LayDiemDatQuyDinh()
        {
            string query = "SELECT DiemDat FROM QUYDINH";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            return Convert.ToInt32(dataTable.Rows[0]["DiemDat"]);
        }

        public void CapNhatQuyDinhDoTuoi(int tuoiCanDuoi, int tuoiCanTren)
        {
            string query = "EXEC CapNhatQuyDinhDoTuoi @tuoiCanDuoi , @tuoiCanTren";
            object[] parameters = new object[] { tuoiCanDuoi, tuoiCanTren };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        public void CapNhatQuyDinhSiSo(int siSoCanDuoi, int siSoCanTren)
        {
            string query = "EXEC CapNhatQuyDinhSiSo @siSoCanDuoi , @siSoCanTren";
            object[] parameters = new object[] { siSoCanDuoi, siSoCanTren };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        public void CapNhatQuyDinhDiemDat(int diemDat)
        {
            string query = "EXEC CapNhatQuyDinhDiemDat @diemDat";
            object[] parameters = new object[] { diemDat };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }
    }
}
