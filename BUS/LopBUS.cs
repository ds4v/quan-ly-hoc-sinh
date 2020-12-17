using DAO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class LopBUS
    {
        private static LopBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private LopBUS() { }

        public static LopBUS Instance
        {
            get
            {
                if (instance == null) instance = new LopBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(
            BindingNavigator bindingNavigator,
            DataGridViewX dataGridViewX,
            TextBoxX txtMaLop,
            TextBoxX txtTenLop,
            ComboBoxEx cmbKhoiLop,
            ComboBoxEx cmbNamHoc,
            IntegerInput iniSiSo,
            ComboBoxEx cmbGiaoVien)
        {
            bindingSource.DataSource = LopDAO.Instance.LayDanhSachLop();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;

            txtMaLop.DataBindings.Clear();
            txtMaLop.DataBindings.Add("Text", bindingSource, "MaLop");

            txtTenLop.DataBindings.Clear();
            txtTenLop.DataBindings.Add("Text", bindingSource, "TenLop");

            cmbKhoiLop.DataBindings.Clear();
            cmbKhoiLop.DataBindings.Add("SelectedValue", bindingSource, "MaKhoiLop");

            cmbNamHoc.DataBindings.Clear();
            cmbNamHoc.DataBindings.Add("SelectedValue", bindingSource, "MaNamHoc");

            iniSiSo.DataBindings.Clear();
            iniSiSo.DataBindings.Add("Text", bindingSource, "SiSo");

            cmbGiaoVien.DataBindings.Clear();
            cmbGiaoVien.DataBindings.Add("SelectedValue", bindingSource, "MaGiaoVien");
        }

        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = LopDAO.Instance.LayDanhSachLop();
            comboBox.DisplayMember = "TenLop";
            comboBox.ValueMember = "MaLop";
        }

        public void HienThiComboBox(string namHoc, ComboBoxEx comboBox)
        {
            comboBox.DataSource = LopDAO.Instance.LayDanhSachLop(namHoc);
            comboBox.DisplayMember = "TenLop";
            comboBox.ValueMember = "MaLop";
        }

        public void HienThiComboBox(string khoiLop, string namHoc, ComboBoxEx comboBox)
        {
            comboBox.DataSource = LopDAO.Instance.LayDanhSachLop(khoiLop, namHoc);
            comboBox.DisplayMember = "TenLop";
            comboBox.ValueMember = "MaLop";
        }

        public void HienThiDgvCmbCol(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = LopDAO.Instance.LayDanhSachLop();
            cmbColumn.DisplayMember = "MaLop";
            cmbColumn.ValueMember = "MaLop";
            cmbColumn.DataPropertyName = "MaLop";
            cmbColumn.HeaderText = "Mã lớp";
        }

        public void CapNhatLop(DataTable dataTable)
        {
            LopDAO.Instance.CapNhatLop(dataTable);
        }

        public void ThemLop(LopDTO lop)
        {
            LopDAO.Instance.ThemLop(lop);
        }

        public DataTable TimTheoMa(ComboBoxEx cmbLop)
        {
            return LopDAO.Instance.TimTheoMa(cmbLop.SelectedValue.ToString());
        }

        public void TimTheoMa(string maLop)
        {
            bindingSource.DataSource = LopDAO.Instance.TimTheoMa(maLop);
        }

        public void TimTheoTen(string tenLop)
        {
            bindingSource.DataSource = LopDAO.Instance.TimTheoTen(tenLop);
        }
    }
}
