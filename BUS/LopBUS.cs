using DAO;
using DevComponents.DotNetBar.Controls;
using DevComponents.Editors;
using System.Windows.Forms;

namespace BUS
{
    public class LopBUS
    {
        public void HienThi
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
            bindingSource.DataSource = LopDAO.Instance.LayDanhSachKhoiLop();

            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;

            txtMaLop.DataBindings.Add("Text", bindingSource, "MaLop");
            txtTenLop.DataBindings.Add("Text", bindingSource, "TenLop");
            
            cmbKhoiLop.DataBindings.Add("SelectedValue", bindingSource, "MaKhoiLop");
            cmbNamHoc.DataBindings.Add("SelectedValue", bindingSource, "MaNamHoc");
            
            iniSiSo.DataBindings.Add("Text", bindingSource, "SiSo");
            cmbGiaoVien.DataBindings.Add("SelectedValue", bindingSource, "MaGiaoVien");
        }
    }
}
