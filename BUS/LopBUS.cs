using DAO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using System;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public static class LopBUS
    {
        public static void HienThi
        (
            DataGridViewX dataGridViewX,
            BindingNavigator bindingNavigator,
            TextBoxX txtMaLop,
            TextBoxX txtTenLop,
            ComboBoxEx cmbKhoiLop,
            ComboBoxEx cmbNamHoc,
            IntegerInput iniSiSo,
            ComboBoxEx cmbGiaoVien
        )
        {
            BindingSource bindingSource = new BindingSource();
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

        public static void LuuLop(DataTable dataTable)
        {
            LopDAO.Instance.LuuLop(dataTable);
        }

        public static void ThemLop(string maLop, string tenLop, string maKhoiLop, string maNamHoc, int siSo, string maGiaoVien)
        {
            LopDAO.Instance.ThemLop(maLop, tenLop, maKhoiLop, maNamHoc, siSo, maGiaoVien);
        }
    }
}
