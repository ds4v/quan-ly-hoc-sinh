using System;
using System.Data;

namespace DAO
{
    public class KhoiLopDAO
    {
        private static KhoiLopDAO instance;

        private KhoiLopDAO() { }

        public static KhoiLopDAO Instance
        {
            get
            {
                if (instance == null) instance = new KhoiLopDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachKhoiLop()
        {
            string query = "SELECT * FROM KHOILOP";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable LayDanhSachKhoiLop(string khoiLop)
        {
            string query = $"SELECT * FROM KHOILOP WHERE MaKhoiLop = '{khoiLop}'";
            if (khoiLop == "KHOI10") query += "OR MaKhoiLop = 'KHOI11'";
            else if (khoiLop == "KHOI11") query += "OR MaKhoiLop = 'KHOI12'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void CapNhatKhoiLop(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "KHOILOP");
        }
    }
}
