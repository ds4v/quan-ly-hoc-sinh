using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuyDinhBUS
    {
        private static QuyDinhBUS instance;

        private QuyDinhBUS() { }

        public static QuyDinhBUS Instance
        {
            get
            {
                if (instance == null) instance = new QuyDinhBUS();
                return instance;
            }
            private set => instance = value;
        }

        public bool KiemTraSiSo(int siSo)
        {
            DataTable dataTable = QuyDinhDAO.Instance.LaySiSoQuyDinh();

            int siSoMin = Convert.ToInt32(dataTable.Rows[0]["SiSoCanDuoi"]);
            int siSoMax = Convert.ToInt32(dataTable.Rows[0]["SiSoCanTren"]);

            if (siSo >= siSoMin && siSo <= siSoMax) return true;
            else return false;
        }
    }
}
