using DTO;
using System.Data;

namespace DAO
{
    public class GiaoVienDAO
    {
        private static GiaoVienDAO instance;

        private GiaoVienDAO() { }

        public static GiaoVienDAO Instance
        {
            get
            {
                if (instance == null) instance = new GiaoVienDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachGiaoVien()
        {
            string query = "SELECT * FROM GIAOVIEN";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void CapNhatGiaoVien(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "GIAOVIEN");
        }

        public void ThemGiaoVien(GiaoVienDTO GiaoVien)
        {
            string query = "EXEC ThemGiaoVien @maGiaoVien , @tenGiaoVien , @diaChi , @dienThoai , @chuyenMon";
            object[] parameters = new object[] {
                GiaoVien.MaGiaoVien, GiaoVien.TenGiaoVien, GiaoVien.DiaChi, GiaoVien.DienThoai, GiaoVien.ChuyenMon
            };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        public DataTable TimTheoMa(string maGiaoVien)
        {
            string query = $"SELECT * FROM GIAOVIEN WHERE MaGiaoVien LIKE '%{maGiaoVien}%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TimTheoTen(string tenGiaoVien)
        {
            string query = $"SELECT * FROM GIAOVIEN WHERE TenGiaoVien LIKE '%{tenGiaoVien}%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
