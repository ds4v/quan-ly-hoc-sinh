using System;
using System.Data;

namespace DAO
{
    public class NguoiDungDAO
    {
        private static NguoiDungDAO instance;

        private NguoiDungDAO() { }

        public static NguoiDungDAO Instance
        {
            get
            {
                if (instance == null) instance = new NguoiDungDAO();
                return instance;
            }
            private set => instance = value;
        }

        public object LayDanhSachNguoiDung()
        {
            string query = "SELECT * FROM NGUOIDUNG";
            return DataProvider.Instance.ExecuteQuery(query); ;
        }

        public DataTable DangNhap(string username, string password)
        {
            string query = "EXEC DangNhap @tenDangNhap , @matKhau";
            object[] parameters = new object[] { username, password };
            return DataProvider.Instance.ExecuteQuery(query, parameters);
        }

        public void DoiMatKhau(string username, string newPassword)
        {
            string query = "EXEC DoiMatKhau @tenDangNhap , @matKhau";
            object[] parameters = new object[] { username, newPassword };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
        }

        public void CapNhatNguoiDung(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "NGUOIDUNG");
        }

        public void SaoLuuCSDL(string fileName)
        {
            string query = $"BACKUP DATABASE QuanLyHocSinh TO DISK = '{fileName}'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void PhucHoiCSDL(string fileName)
        {
            string query = $"USE master RESTORE DATABASE QuanLyHocSinh FROM DISK = '{fileName}'";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
