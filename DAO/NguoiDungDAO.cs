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

        public DataTable LayNguoiDung(string username)
        {
            string query = $"SELECT * FROM NGUOIDUNG WHERE TenDangNhap = '{username}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void DoiMatKhau(string username, string newPassword)
        {
            string query = "EXEC DoiMatKhau @tenDangNhap , @matKhau";
            object[] parameters = new object[] { username, newPassword };
            DataProvider.Instance.ExecuteNonQuery(query, parameters);
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
