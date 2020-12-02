using System;
using System.Data;

namespace DAO
{
    public class MonHocDAO
    {
        private static MonHocDAO instance;

        private MonHocDAO() { }

        public static MonHocDAO Instance
        {
            get
            {
                if (instance == null) instance = new MonHocDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachMonHoc()
        {
            string query = "SELECT * FROM MONHOC";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public object LayDanhSachMonHoc(string namHoc, string lop)
        {
            string query = $@"
                SELECT MH.MaMonHoc, MH.TenMonHoc, MH.HeSo FROM MONHOC MH, PHANCONG PC 
                WHERE MH.MaMonHoc = PC.MaMonHoc AND PC.MaNamHoc = '{namHoc}' AND PC.MaLop = '{lop}'
            ";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void LuuMonHoc(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable);
        }
    }
}
