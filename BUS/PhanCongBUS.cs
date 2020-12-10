using DAO;
using DevComponents.DotNetBar.Controls;
using DTO;
using System.Data;
using System.Windows.Forms;

namespace BUS
{
    public class PhanCongBUS
    {
        private static PhanCongBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private PhanCongBUS() { }

        public static PhanCongBUS Instance
        {
            get
            {
                if (instance == null) instance = new PhanCongBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(
            BindingNavigator bindingNavigator,
            DataGridViewX dataGridViewX,
            TextBoxX txtSTT,
            ComboBoxEx cmbNamHoc,
            ComboBoxEx cmbLop,
            ComboBoxEx cmbMonHoc,
            ComboBoxEx cmbGiaoVien)
        {
            bindingSource.DataSource = PhanCongDAO.Instance.LayDanhSachPhanCong();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;

            txtSTT.DataBindings.Clear();
            txtSTT.DataBindings.Add("Text", bindingSource, "STT");

            cmbNamHoc.DataBindings.Clear();
            cmbNamHoc.DataBindings.Add("SelectedValue", bindingSource, "MaNamHoc");

            cmbLop.DataBindings.Clear();
            cmbLop.DataBindings.Add("SelectedValue", bindingSource, "MaLop");

            cmbMonHoc.DataBindings.Clear();
            cmbMonHoc.DataBindings.Add("SelectedValue", bindingSource, "MaMonHoc");

            cmbGiaoVien.DataBindings.Clear();
            cmbGiaoVien.DataBindings.Add("SelectedValue", bindingSource, "MaGiaoVien");
        }

        public void CapNhatPhanCong(DataTable dataTable)
        {
            PhanCongDAO.Instance.CapNhatPhanCong(dataTable);
        }

        public void ThemPhanCong(PhanCongDTO PhanCong)
        {
            PhanCongDAO.Instance.ThemPhanCong(PhanCong);
        }

        public void TimTheoTenLop(string tenLop)
        {
            bindingSource.DataSource = PhanCongDAO.Instance.TimTheoTenLop(tenLop);
        }

        public void TimTheoTenGiaoVien(string tenGiaoVien)
        {
            bindingSource.DataSource = PhanCongDAO.Instance.TimTheoTenGiaoVien(tenGiaoVien);
        }
    }
}
