using DAO;
using DevComponents.DotNetBar.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class KhoiLopBUS
    {
        private static KhoiLopBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private KhoiLopBUS() { }

        public static KhoiLopBUS Instance
        {
            get
            {
                if (instance == null) instance = new KhoiLopBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridViewX dataGridViewX, BindingNavigator bindingNavigator)
        {

            bindingSource.DataSource = KhoiLopDAO.Instance.LayDanhSachKhoiLop();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = KhoiLopDAO.Instance.LayDanhSachKhoiLop();
            comboBox.DisplayMember = "TenKhoiLop";
            comboBox.ValueMember = "MaKhoiLop";
        }

        public void HienThiComboBox(string khoiLop, ComboBoxEx comboBox)
        {
            comboBox.DataSource = KhoiLopDAO.Instance.LayDanhSachKhoiLop(khoiLop);
            comboBox.DisplayMember = "TenKhoiLop";
            comboBox.ValueMember = "MaKhoiLop";
        }

        public void HienThiDgvCmbCol(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = KhoiLopDAO.Instance.LayDanhSachKhoiLop();
            cmbColumn.DisplayMember = "TenKhoiLop";
            cmbColumn.ValueMember = "MaKhoiLop";
            cmbColumn.DataPropertyName = "MaKhoiLop";
            cmbColumn.HeaderText = "Khối lớp";
        }

        public void CapNhatKhoiLop(DataTable dataTable)
        {
            KhoiLopDAO.Instance.CapNhatKhoiLop(dataTable);
        }
    }
}
