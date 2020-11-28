using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NamHocDAO
    {
        private static NamHocDAO instance;

        private NamHocDAO() { }

        public static NamHocDAO Instance
        {
            get => instance == null ? new NamHocDAO() : instance;
            private set => instance = value;
        }

        public DataTable LayDanhSachNamHoc()
        {
            string query = "SELECT * FROM NAMHOC";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
