using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class KhoiLopDAO
    {
        private static KhoiLopDAO instance;

        private KhoiLopDAO() { }

        public static KhoiLopDAO Instance
        {
            get => instance == null ? new KhoiLopDAO() : instance;
            private set => instance = value;
        }

        public DataTable LayDanhSachKhoiLop()
        {
            string query = "SELECT * FROM KHOILOP";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
