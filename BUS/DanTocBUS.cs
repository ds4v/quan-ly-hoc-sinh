using DAO;
using DevComponents.DotNetBar.Controls;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class DanTocBUS
    {
        private static DanTocBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private DanTocBUS() { }

        public static DanTocBUS Instance
        {
            get
            {
                if (instance == null) instance = new DanTocBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridViewX dataGridViewX, BindingNavigator bindingNavigator)
        {

            bindingSource.DataSource = DanTocDAO.Instance.LayDanhSachDanToc();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = DanTocDAO.Instance.LayDanhSachDanToc();
            comboBox.DisplayMember = "TenDanToc";
            comboBox.ValueMember = "MaDanToc";
        }

        public void HienThiDgvCmbCol(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = DanTocDAO.Instance.LayDanhSachDanToc();
            cmbColumn.DisplayMember = "TenDanToc";
            cmbColumn.ValueMember = "MaDanToc";
            cmbColumn.DataPropertyName = "MaDanToc";
            cmbColumn.HeaderText = "Dân tộc";
        }

        public void CapNhatDanToc(DataTable dataTable)
        {
            DanTocDAO.Instance.CapNhatDanToc(dataTable);
        }
    }
}
