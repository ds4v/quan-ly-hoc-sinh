using DAO;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;

namespace BUS
{
    public class GiaoVienBUS
    {
        private static GiaoVienBUS instance;

        private GiaoVienBUS() { }

        public static GiaoVienBUS Instance
        {
            get
            {
                if (instance == null) instance = new GiaoVienBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = GiaoVienDAO.Instance.LayDanhSachGiaoVien();
            comboBox.DisplayMember = "TenGiaoVien";
            comboBox.ValueMember = "MaGiaoVien";
        }

        public void HienThiDgvCmbCol(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = GiaoVienDAO.Instance.LayDanhSachGiaoVien();
            cmbColumn.DisplayMember = "TenGiaoVien";
            cmbColumn.ValueMember = "MaGiaoVien";
            cmbColumn.DataPropertyName = "MaGiaoVien";
            cmbColumn.HeaderText = "Giáo viên";
        }
    }
}
