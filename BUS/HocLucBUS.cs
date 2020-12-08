using DAO;
using DevComponents.DotNetBar.Controls;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class HocLucBUS
    {
        private static HocLucBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private HocLucBUS() { }

        public static HocLucBUS Instance
        {
            get
            {
                if (instance == null) instance = new HocLucBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridViewX dataGridViewX, BindingNavigator bindingNavigator)
        {

            bindingSource.DataSource = HocLucDAO.Instance.LayDanhSachHocLuc();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void CapNhatHocLuc(DataTable dataTable)
        {
            HocLucDAO.Instance.CapNhatHocLuc(dataTable);
        }
    }
}
