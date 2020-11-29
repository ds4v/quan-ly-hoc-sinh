using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QuyDinhDAO
    {
        private static QuyDinhDAO instance;

        private QuyDinhDAO() { }

        public static QuyDinhDAO Instance
        {
            get => instance == null ? new QuyDinhDAO() : instance;
            private set => instance = value;
        }

        public DataTable LaySiSoQuyDinh()
        {
            string query = "SELECT SiSoCanDuoi, SiSoCanTren FROM QUYDINH";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
