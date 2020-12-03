using DAO;
using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;

namespace BUS
{
    public class NgheNghiepBUS
    {
        private static NgheNghiepBUS instance;

        private NgheNghiepBUS() { }

        public static NgheNghiepBUS Instance
        {
            get
            {
                if (instance == null) instance = new NgheNghiepBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = NgheNghiepDAO.Instance.LayDanhSachNgheNghiep();
            comboBox.DisplayMember = "TenNghe";
            comboBox.ValueMember = "MaNghe";
        }

        public void HienThiDgvCmbColCha(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = NgheNghiepDAO.Instance.LayDanhSachNgheNghiep();
            cmbColumn.DisplayMember = "TenNghe";
            cmbColumn.ValueMember = "MaNghe";
            cmbColumn.DataPropertyName = "MaNNghiepCha";
            cmbColumn.HeaderText = "Nghề nghiệp cha";
        }

        public void HienThiDgvCmbColMe(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = NgheNghiepDAO.Instance.LayDanhSachNgheNghiep();
            cmbColumn.DisplayMember = "TenNghe";
            cmbColumn.ValueMember = "MaNghe";
            cmbColumn.DataPropertyName = "MaNNghiepMe";
            cmbColumn.HeaderText = "Nghề nghiệp mẹ";
        }
    }
}
