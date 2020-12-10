using DevComponents.DotNetBar;
using System;
using System.Data;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyHocSinh
{
    public partial class frmLop : Office2007Form
    {

        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            KhoiLopBUS.Instance.HienThiComboBox(cmbKhoiLop);
            NamHocBUS.Instance.HienThiComboBox(cmbNamHoc);
            GiaoVienBUS.Instance.HienThiComboBox(cmbGiaoVien);

            KhoiLopBUS.Instance.HienThiDgvCmbCol(colMaKhoiLop);
            NamHocBUS.Instance.HienThiDgvCmbCol(colMaNamHoc);
            GiaoVienBUS.Instance.HienThiDgvCmbCol(colMaGiaoVien);

            bindingNavigatorRefreshItem_Click(sender, e);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvLop.RowCount == 0) bindingNavigatorDeleteItem.Enabled = true;
            
            BindingSource bindingSource = bindingNavigatorLop.BindingSource;
            DataTable dataTable = (DataTable)bindingSource.DataSource;
            DataRow dataRow = dataTable.NewRow();

            dataRow["MaLop"] = "";
            dataRow["TenLop"] = "";
            dataRow["MaKhoiLop"] = "";
            dataRow["MaNamHoc"] = "";
            dataRow["SiSo"] = 0;
            dataRow["MaGiaoVien"] = "";

            dataTable.Rows.Add(dataRow);
            bindingSource.MoveLast();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            LopBUS.Instance.HienThi(
                bindingNavigatorLop,
                dgvLop,
                txtMaLop,
                txtTenLop,
                cmbKhoiLop,
                cmbNamHoc,
                iniSiSo,
                cmbGiaoVien
            );
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvLop.RowCount == 0) bindingNavigatorDeleteItem.Enabled = false;
            else if (
                MessageBox.Show(
                    "Bạn có chắc chắn xóa dòng này không ?", 
                    "Xóa lớp học", 
                    MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Question
                ) == DialogResult.OK
            ) bindingNavigatorLop.BindingSource.RemoveCurrent();
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string[] colNames = { "colMaLop", "colTenLop", "colMaKhoiLop", "colMaNamHoc", "colMaGiaoVien" };
            if (KiemTraTruocKhiLuu.KiemTraDataGridView(dgvLop, colNames) &&
                KiemTraTruocKhiLuu.KiemTraSiSo(dgvLop, "colSiSo"))
            {
                bindingNavigatorPositionItem.Focus();
                BindingSource bindingSource = bindingNavigatorLop.BindingSource;
                LopBUS.Instance.CapNhatLop((DataTable) bindingSource.DataSource);

                MessageBox.Show(
                    "Dữ liệu đã được lưu vào CSDL",
                    "Cập nhật thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThemKhoiLop_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmKhoiLop");
            KhoiLopBUS.Instance.HienThiDgvCmbCol(colMaKhoiLop);
        }

        private void btnThemNamHoc_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmNamHoc");
            NamHocBUS.Instance.HienThiDgvCmbCol(colMaNamHoc);

        }

        private void btnThemGiaoVien_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmGiaoVien");
            GiaoVienBUS.Instance.HienThiDgvCmbCol(colMaGiaoVien);
        }

        private void btnLuuVaoDS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaLop.Text) ||
                string.IsNullOrWhiteSpace(txtTenLop.Text)  ||
                cmbKhoiLop.SelectedValue == null ||
                cmbNamHoc.SelectedValue == null ||
                cmbGiaoVien.SelectedValue == null ||
                !QuyDinhBUS.Instance.KiemTraSiSo(iniSiSo.Value))
                MessageBox.Show(
                    "Giá trị của các ô không được rỗng và sỉ số phải theo quy định !", 
                    "ERROR", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Error
                );
            else
            {
                LopDTO lop = new LopDTO(
                    txtMaLop.Text, 
                    txtTenLop.Text,
                    cmbKhoiLop.SelectedValue.ToString(),
                    cmbNamHoc.SelectedValue.ToString(), 
                    iniSiSo.Value,
                    cmbGiaoVien.SelectedValue.ToString()
                );
                LopBUS.Instance.ThemLop(lop);
                bindingNavigatorRefreshItem_Click(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (chkTimTheoMa.Checked) LopBUS.Instance.TimTheoMa(txtTimKiem.Text);
            else LopBUS.Instance.TimTheoTen(txtTimKiem.Text);
        }
    }
}
