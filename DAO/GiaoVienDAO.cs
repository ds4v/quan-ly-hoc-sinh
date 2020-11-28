using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GiaoVienDAO
    {
        private static GiaoVienDAO instance;

        private GiaoVienDAO() { }

        public static GiaoVienDAO Instance
        {
            get => instance == null ? new GiaoVienDAO() : instance;
            private set => instance = value;
        }

        public DataTable LayDanhSachGiaoVien()
        {
            string query = "SELECT * FROM GIAOVIEN";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
