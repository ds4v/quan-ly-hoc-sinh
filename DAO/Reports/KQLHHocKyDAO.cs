using DTO;
using System.Data;

namespace DAO
{
    public class KQLHHocKyDAO
    {
        private static KQLHHocKyDAO instance;

        private KQLHHocKyDAO() { }

        public static KQLHHocKyDAO Instance
        {
            get
            {
                if (instance == null) instance = new KQLHHocKyDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable Report(string maNamHoc, string maHocKy)
        {
            string query = "EXEC ReportKQLHHocKy @maNamHoc , @maHocKy";
            object[] parameters = new object[] { maNamHoc, maHocKy };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public void LuuKetQua(KQLHHocKyDTO ketQua)
        {
            string query = "EXEC ThemKQLHHocKy @maLop , @maNamHoc , @maHocKy , @soLuongDat , @tiLe";
            object[] parameters = new object[] {
                ketQua.Lop.MaLop,
                ketQua.NamHoc.MaNamHoc,
                ketQua.HocKy.MaHocKy,
                ketQua.SoLuongDat,
                ketQua.TiLe
            };
            DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public void XoaKetQua(string maLop, string maNamHoc, string maHocKy)
        {
            string query = "EXEC XoaKQLHHocKy @maLop , @maNamHoc , @maHocKy";
            object[] parameters = new object[] { maLop, maNamHoc, maHocKy };
            DataProvider.Instance.ExecuteQuery(query, parameters);
        }
    }
}
