using DAO;
using DevComponents.DotNetBar.Controls;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class MonHocBUS
    {
        private static MonHocBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private MonHocBUS() { }

        public static MonHocBUS Instance
        {
            get
            {
                if (instance == null) instance = new MonHocBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridViewX dataGridViewX, BindingNavigator bindingNavigator)
        {

            bindingSource.DataSource = MonHocDAO.Instance.LayDanhSachMonHoc();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = MonHocDAO.Instance.LayDanhSachMonHoc();
            comboBox.DisplayMember = "TenMonHoc";
            comboBox.ValueMember = "MaMonHoc";
        }

        public void HienThiComboBox(string namHoc, ComboBoxEx comboBox)
        {
            comboBox.DataSource = MonHocDAO.Instance.LayDanhSachMonHoc(namHoc);
            comboBox.DisplayMember = "TenMonHoc";
            comboBox.ValueMember = "MaMonHoc";
        }

        public void HienThiComboBox(string namHoc, string lop, ComboBoxEx comboBox)
        {
            comboBox.DataSource = MonHocDAO.Instance.LayDanhSachMonHoc(namHoc, lop);
            comboBox.DisplayMember = "TenMonHoc";
            comboBox.ValueMember = "MaMonHoc";
        }

        public void HienThiDgvCmbCol(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = MonHocDAO.Instance.LayDanhSachMonHoc();
            cmbColumn.DisplayMember = "TenMonHoc";
            cmbColumn.ValueMember = "MaMonHoc";
            cmbColumn.DataPropertyName = "MaMonHoc";
            cmbColumn.HeaderText = "Môn học";
        }


        public void CapNhatMonHoc(DataTable dataTable)
        {
            MonHocDAO.Instance.CapNhatMonHoc(dataTable);
        }
    }
}
