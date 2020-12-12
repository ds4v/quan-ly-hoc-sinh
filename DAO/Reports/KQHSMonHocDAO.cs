using DTO;
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

        public DataTable Report(string maLop, string maNamHoc, string maMonHoc, string maHocKy)
        {
            string query = "EXEC ReportKQHSMonHoc @maLop , @maNamHoc , @maMonHoc , @maHocKy";
            object[] parameters = new object[] { maLop, maNamHoc, maMonHoc, maHocKy };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public void LuuKetQua(KQHSMonHocDTO ketQua)
        {
            string query = "EXEC ThemKQHSMonHoc @maHocSinh , @maLop , @maNamHoc , @maMonHoc , @maHocKy , @diemMiengTB , @diem15PhutTB , @diem45PhutTB , @diemThi , @diemTBHK";
            object[] parameters = new object[] {
                ketQua.HocSinh.MaHocSinh,
                ketQua.Lop.MaLop,
                ketQua.NamHoc.MaNamHoc,
                ketQua.MonHoc.MaMonHoc,
                ketQua.HocKy.MaHocKy,
                ketQua.DiemMiengTB,
                ketQua.Diem15PhutTB,
                ketQua.Diem45PhutTB,
                ketQua.DiemThi,
                ketQua.DiemTBHK 
            };
            DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public void XoaKetQua(string maHocSinh, string maLop, string maNamHoc, string maMonHoc, string maHocKy)
        {
            string query = "EXEC XoaKQHSMonHoc @maHocSinh , @maLop , @maNamHoc , @maMonHoc , @maHocKy";
            object[] parameters = new object[] {  maHocSinh, maLop, maNamHoc, maMonHoc, maHocKy };
            DataProvider.Instance.ExecuteQuery(query, parameters);
        }
    }
}
