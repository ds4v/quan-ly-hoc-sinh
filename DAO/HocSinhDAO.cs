using DTO;
using System;
using System.Data;

namespace DAO
{
    public class HocSinhDAO
    {
        private static HocSinhDAO instance;

        private HocSinhDAO() { }

        public static HocSinhDAO Instance
        {
            get
            {
                if (instance == null) instance = new HocSinhDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachHocSinh()
        {
            string query = "SELECT * FROM HOCSINH";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LayDanhSachHocSinh(string namHoc, string lop, bool tatCaCot = false)
        {
            string query = "EXEC LayDanhSachHocSinh @maNamHoc , @maLop , @tatCaCot";
            object[] parameters = new object[] { namHoc, lop, tatCaCot };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public DataTable LayDanhSachHocSinhTheoLop(string namHoc, string khoiLop, string lop)
        {
            string query = "EXEC LayDanhSachHocSinhTheoLop @maNamHoc , @maKhoiLop , @maLop";
            object[] parameters = new object[] { namHoc, khoiLop, lop };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public DataTable LayDanhSachHocSinhTheoNamHoc(string namHoc)
        {
            string query = "EXEC LayDanhSachHocSinhTheoNamHoc @maNamHoc";
            object[] parameters = new object[] { namHoc };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }


        public void CapNhatHocSinh(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "HOCSINH");
        }

        public void ThemHocSinh(HocSinhDTO hocSinh)
        {
            string query = "EXEC ThemHocSinh @maHocSinh , @hoTen , @gioiTinh , @ngaySinh , @diaChi , @maDanToc , @maTonGiao , @hoTenCha , @maNgheCha , @hoTenMe , @maNgheMe , @email";
            object[] parameters = new object[] {
                hocSinh.MaHocSinh,
                hocSinh.HoTen,
                hocSinh.GioiTinh,
                hocSinh.NgaySinh,
                hocSinh.DiaChi,
                hocSinh.MaDanToc,
                hocSinh.MaTonGiao,
                hocSinh.HoTenCha,
                hocSinh.MaNgheCha,
                hocSinh.HoTenMe,
                hocSinh.MaNgheMe,
                hocSinh.Email
            };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        public DataTable TimTheoMa(string maHocSinh)
        {
            string query = $"SELECT * FROM HOCSINH WHERE MaHocSinh LIKE '%{maHocSinh}%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable TimTheoTen(string tenHocSinh)
        {
            string query = $"SELECT * FROM HOCSINH WHERE HoTen LIKE '%{tenHocSinh}%'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
