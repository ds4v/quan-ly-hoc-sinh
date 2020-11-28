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

        public DataTable LayDanhSachKhoiLop()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM KHOILOP"); ;
        }

        //public void InsertStudent(int idBill, int idFood, int count)
        //{
        //    DataProvider.Instance.ExecuteNonQuery("InsertStudent @idBill , @idFood , @count", new object[] { idBill, idFood, count });
        //}
    }
}
