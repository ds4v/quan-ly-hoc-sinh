using DTO;
using System.Data;

namespace DAO
{
    public class PhanCongDAO
    {
        private static PhanCongDAO instance;

        private PhanCongDAO() { }

        public static PhanCongDAO Instance
        {
            get
            {
                if (instance == null) instance = new PhanCongDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachPhanCong()
        {
            string query = "SELECT * FROM PHANCONG";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void CapNhatPhanCong(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "PHANCONG");
        }

        public void ThemPhanCong(PhanCongDTO PhanCong)
        {
            string query = "EXEC ThemPhanCong @maNamHoc , @maLop , @maMonHoc , @maGiaoVien";
            object[] parameters = new object[] {
                PhanCong.MaNamHoc, PhanCong.MaLop, PhanCong.MaMonHoc, PhanCong.MaGiaoVien
            };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        public DataTable TimTheoTenLop(string tenLop)
        {
            string query = $@"
                SELECT PC.* FROM PHANCONG PC, LOP 
                WHERE PC.MaLop = LOP.MaLop 
                  AND LOP.TenLop LIKE '%{tenLop}%'
            ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TimTheoTenGiaoVien(string tenGiaoVien)
        {
            string query = $@"
                SELECT PC.* FROM PHANCONG PC, GIAOVIEN GV 
                WHERE PC.MaGiaoVien = GV.MaGiaoVien 
                  AND GV.TenGiaoVien LIKE '%{tenGiaoVien}%'
            ";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
