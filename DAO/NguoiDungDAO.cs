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

        public DataTable LayDanhSachNguoiDung(string username)
        {
            string query = $"SELECT * FROM NGUOIDUNG WHERE TenDangNhap = '{username}'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
