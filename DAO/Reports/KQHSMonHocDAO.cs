using DTO;
using System;
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

        public DataTable Report(string maLop, string maMonHoc, string maHocKy, string maNamHoc)
        {
            string query = "EXEC ReportKQHSMonHoc @maLop , @maMonHoc , @maHocKy , @maNamHoc";
            object[] parameters = new object[] { maLop, maMonHoc, maHocKy, maNamHoc };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public void LuuKetQua(KQHSMonHocDTO ketQua)
        {
            string query = "EXEC ThemKQHSMonHoc @maHocSinh , @maLop , @maMonHoc , @maHocKy , @maNamHoc , @diemMiengTB , @diem15PhutTB , @diem45PhutTB , @diemThi , @diemTBHK";
            object[] parameters = new object[] {
                ketQua.HocSinh.MaHocSinh,
                ketQua.Lop.MaLop,
                ketQua.MonHoc.MaMonHoc,
                ketQua.HocKy.MaHocKy,
                ketQua.NamHoc.MaNamHoc,
                ketQua.DiemMiengTB,
                ketQua.Diem15PhutTB,
                ketQua.Diem45PhutTB,
                ketQua.DiemThi,
                ketQua.DiemTBHK 
            };
            DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public void XoaKetQua(string maHocSinh, string maLop, string maMonHoc, string maHocKy, string maNamHoc)
        {
            string query = "EXEC XoaKQHSMonHoc @maHocSinh , @maLop , @maMonHoc , @maHocKy , @maNamHoc";
            object[] parameters = new object[] {  maHocSinh, maLop, maMonHoc, maHocKy, maNamHoc };
            DataProvider.Instance.ExecuteQuery(query, parameters);
        }
    }
}
