using DAO;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;

namespace BUS
{
    public class KhoiLopBUS
    {
        public static void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = KhoiLopDAO.Instance.LayDanhSachKhoiLop();
            comboBox.DisplayMember = "TenKhoiLop";
            comboBox.ValueMember = "MaKhoiLop";
        }

        public static void HienThiDgvCmbCol(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = KhoiLopDAO.Instance.LayDanhSachKhoiLop();
            cmbColumn.DisplayMember = "TenKhoiLop";
            cmbColumn.ValueMember = "MaKhoiLop";
            cmbColumn.DataPropertyName = "MaKhoiLop";
            cmbColumn.HeaderText = "Khối lớp";
        }
    }
}
