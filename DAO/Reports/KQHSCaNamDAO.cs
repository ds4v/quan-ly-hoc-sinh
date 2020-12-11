using DTO;
using System.Data;

namespace DAO
{
    public class KQHSCaNamDAO
    {
        private static KQHSCaNamDAO instance;

        private KQHSCaNamDAO() { }

        public static KQHSCaNamDAO Instance
        {
            get
            {
                if (instance == null) instance = new KQHSCaNamDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable Report(string maLop, string maNamHoc)
        {
            string query = "EXEC ReportKQHSCaNam @maLop , @maNamHoc";
            object[] parameters = new object[] { maLop, maNamHoc };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public void LuuKetQua(KQHSCaNamDTO ketQua)
        {
            string query = "EXEC ThemKQHSCaNam @maHocSinh , @maLop , @maNamHoc , @maHocLuc , @maHanhKiem , @maKetQua , @diemTBHK1 , @diemTBHK2 , @diemTBCN";
            object[] parameters = new object[] {
                ketQua.HocSinh.MaHocSinh,
                ketQua.Lop.MaLop,
                ketQua.NamHoc.MaNamHoc,
                ketQua.HocLuc.MaHocLuc,
                ketQua.HanhKiem.MaHanhKiem,
                ketQua.KetQua.MaKetQua,
                ketQua.DiemTBHK1,
                ketQua.DiemTBHK2,
                ketQua.DiemTBCN,
            };
            DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public void XoaKetQua(string maHocSinh, string maLop, string maNamHoc)
        {
            string query = "EXEC XoaKQHSCaNam @maHocSinh , @maLop , @maNamHoc";
            object[] parameters = new object[] { maHocSinh, maLop, maNamHoc };
            DataProvider.Instance.ExecuteQuery(query, parameters);
        }
    }
}
