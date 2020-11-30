using System;
using System.Data;

namespace DAO
{
    public class LopDAO
    {
        private static LopDAO instance;

        private LopDAO() { }

        public static LopDAO Instance
        {
            get => instance == null ? new LopDAO() : instance;
            private set => instance = value;
        }

        public DataTable LayDanhSachLop()
        {
            string query = "SELECT * FROM LOP";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void LuuLop(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable);
        }

        public void ThemLop(string maLop, string tenLop, string maKhoiLop, string maNamHoc, int siSo, string maGiaoVien)
        {
            string query = "EXEC ThemLop @maLop , @tenLop , @maKhoiLop , @maNamHoc , @siSo , @maGiaoVien";
            object[] parameters = new object[] { maLop, tenLop, maKhoiLop, maNamHoc, siSo, maGiaoVien };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        public DataTable TimTheoMa(string maLop)
        {
            string query = $"SELECT * FROM LOP WHERE MaLop LIKE '%{maLop}%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TimTheoTen(string tenLop)
        {
            string query = $"SELECT * FROM LOP WHERE TenLop LIKE '%{tenLop}%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
