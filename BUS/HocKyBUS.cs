using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using System.Data;
using DAO;

namespace BUS
{
    public class HocKyBUS
    {
        private static HocKyBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private HocKyBUS() { }

        public static HocKyBUS Instance
        {
            get
            {
                if (instance == null) instance = new HocKyBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridViewX dataGridViewX, BindingNavigator bindingNavigator)
        {
            bindingSource.DataSource = HocKyDAO.Instance.LayDanhSachHocKy();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void LuuHocKy(DataTable dataTable)
        {
            HocKyDAO.Instance.LuuHocKy(dataTable);
        }
    }
}
