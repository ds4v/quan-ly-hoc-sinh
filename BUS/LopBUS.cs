using DAO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
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

        public void LuuLop(DataTable dataTable)
        {
            LopDAO.Instance.LuuLop(dataTable);
        }

        public void ThemLop(string maLop, string tenLop, string maKhoiLop, string maNamHoc, int siSo, string maGiaoVien)
        {
            LopDAO.Instance.ThemLop(maLop, tenLop, maKhoiLop, maNamHoc, siSo, maGiaoVien);
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
