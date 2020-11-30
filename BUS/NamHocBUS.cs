using DAO;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;

namespace BUS
{
    public class NamHocBUS
    {
        private static NamHocBUS instance;

        private NamHocBUS() { }

        public static NamHocBUS Instance
        {
            get
            {
                if (instance == null) instance = new NamHocBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = NamHocDAO.Instance.LayDanhSachNamHoc();
            comboBox.DisplayMember = "TenNamHoc";
            comboBox.ValueMember = "MaNamHoc";
        }

        public void HienThiDgvCmbCol(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = NamHocDAO.Instance.LayDanhSachNamHoc();
            cmbColumn.DisplayMember = "TenNamHoc";
            cmbColumn.ValueMember = "MaNamHoc";
            cmbColumn.DataPropertyName = "MaNamHoc";
            cmbColumn.HeaderText = "Năm học";
        }
    }
}
