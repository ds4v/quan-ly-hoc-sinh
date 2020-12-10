using BUS;
using DevComponents.DotNetBar;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmPhanCong : Office2007Form
    {
        public frmPhanCong()
        {
            InitializeComponent();
        }

        private void frmPhanCong_Load(object sender, EventArgs e)
        {
            NamHocBUS.Instance.HienThiComboBox(cmbNamHoc);
            LopBUS.Instance.HienThiComboBox(cmbLop);
            MonHocBUS.Instance.HienThiComboBox(cmbMonHoc);
            GiaoVienBUS.Instance.HienThiComboBox(cmbGiaoVien);

            NamHocBUS.Instance.HienThiDgvCmbCol(colMaNamHoc);
            LopBUS.Instance.HienThiDgvCmbCol(colMaLop);
            MonHocBUS.Instance.HienThiDgvCmbCol(colMaMonHoc);
            GiaoVienBUS.Instance.HienThiDgvCmbCol(colMaGiaoVien);

            bindingNavigatorRefreshItem_Click(sender, e);
            cmbNamHoc_SelectedIndexChanged(sender, e);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvPhanCong.RowCount == 0) bindingNavigatorDeleteItem.Enabled = true;

            BindingSource bindingSource = bindingNavigatorPhanCong.BindingSource;
            DataTable dataTable = (DataTable)bindingSource.DataSource;
            DataRow dataRow = dataTable.NewRow();

            dataRow["STT"] = dgvPhanCong.RowCount + 1;
            dataRow["MaNamHoc"] = "";
            dataRow["MaLop"] = "";
            dataRow["MaMonHoc"] = "";
            dataRow["MaGiaoVien"] = "";

            dataTable.Rows.Add(dataRow);
            bindingSource.MoveLast();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            PhanCongBUS.Instance.HienThi(
                bindingNavigatorPhanCong,
                dgvPhanCong, 
                txtSTT, 
                cmbNamHoc, 
                cmbLop, 
                cmbMonHoc,
                cmbGiaoVien
            );
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvPhanCong.RowCount == 0) bindingNavigatorDeleteItem.Enabled = false;
            else if (
                MessageBox.Show(
                    "Bạn có chắc chắn xóa dòng này không ?",
                    "Xóa lớp học",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                ) == DialogResult.OK
            ) bindingNavigatorPhanCong.BindingSource.RemoveCurrent();
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string[] colNames = { "colMaNamHoc", "colMaLop", "colMaMonHoc", "colMaGiaoVien" };
            if (KiemTraTruocKhiLuu.KiemTraDataGridView(dgvPhanCong, colNames))
            {
                bindingNavigatorPositionItem.Focus();
                BindingSource bindingSource = bindingNavigatorPhanCong.BindingSource;
                PhanCongBUS.Instance.CapNhatPhanCong((DataTable)bindingSource.DataSource);

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

        private void btnThemNamHoc_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmNamHoc");
            NamHocBUS.Instance.HienThiDgvCmbCol(colMaNamHoc);
        }

        private void btnThemLop_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmLop");
            LopBUS.Instance.HienThiDgvCmbCol(colMaLop);
        }

        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmMonHoc");
            MonHocBUS.Instance.HienThiDgvCmbCol(colMaMonHoc);
        }


        private void btnThemGiaoVien_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmGiaoVien");
            GiaoVienBUS.Instance.HienThiDgvCmbCol(colMaGiaoVien);
        }

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                LopBUS.Instance.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            cmbLop.DataBindings.Clear();
        }

        private void btnLuuVaoDS_Click(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue == null || cmbLop.SelectedValue == null ||
                cmbMonHoc.SelectedValue == null || cmbGiaoVien.SelectedValue == null)
                MessageBox.Show(
                    "Giá trị của các ô không được rỗng !",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            else
            {
                PhanCongDTO phanCong = new PhanCongDTO(
                    cmbNamHoc.SelectedValue.ToString(),
                    cmbLop.SelectedValue.ToString(),
                    cmbMonHoc.SelectedValue.ToString(),
                    cmbGiaoVien.SelectedValue.ToString()
                );
                PhanCongBUS.Instance.ThemPhanCong(phanCong);
                bindingNavigatorRefreshItem_Click(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (chkTimTheoTenLop.Checked) PhanCongBUS.Instance.TimTheoTenLop(txtTimKiem.Text);
            else PhanCongBUS.Instance.TimTheoTenGiaoVien(txtTimKiem.Text);
        }

    }
}
