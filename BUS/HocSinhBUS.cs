using DevComponents.DotNetBar.Controls;
using System.Windows.Forms;
using DAO;
using System;

namespace BUS
{
    public class HocSinhBUS
    {
        private static HocSinhBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private HocSinhBUS() { }

        public static HocSinhBUS Instance
        {
            get
            {
                if (instance == null) instance = new HocSinhBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThiHocSinhTheoLop(
            BindingNavigator bindingNavigator,
            DataGridViewX dataGridViewX, 
            string namHoc, 
            string lop)
        {
            bindingSource.DataSource = HocSinhDAO.Instance.LayDanhSachHocSinh(namHoc, lop);
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void HienThiComboBox(string namHoc, string lop, ComboBoxEx comboBox)
        {
            comboBox.DataSource = HocSinhDAO.Instance.LayDanhSachHocSinh(namHoc, lop);
            comboBox.DisplayMember = "HoTen";
            comboBox.ValueMember = "MaHocSinh";
        }
    }
}
