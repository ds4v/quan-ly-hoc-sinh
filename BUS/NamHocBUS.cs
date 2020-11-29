using DAO;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;

namespace BUS
{
    public static class NamHocBUS
    {
        public static void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = NamHocDAO.Instance.LayDanhSachNamHoc();
            comboBox.DisplayMember = "TenNamHoc";
            comboBox.ValueMember = "MaNamHoc";
        }

        public static void HienThiDgvCmbCol(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = NamHocDAO.Instance.LayDanhSachNamHoc();
            cmbColumn.DisplayMember = "TenNamHoc";
            cmbColumn.ValueMember = "MaNamHoc";
            cmbColumn.DataPropertyName = "MaNamHoc";
            cmbColumn.HeaderText = "Năm học";
        }
    }
}
