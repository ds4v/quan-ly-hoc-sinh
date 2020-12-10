using BUS;
using DevComponents.DotNetBar;
using DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmGiaoVien : Office2007Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            MonHocBUS.Instance.HienThiComboBox(cmbMonHoc);
            MonHocBUS.Instance.HienThiDgvCmbCol(colMaMonHoc);
            bindingNavigatorRefreshItem_Click(sender, e);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvGiaoVien.RowCount == 0) bindingNavigatorDeleteItem.Enabled = true;

            BindingSource bindingSource = bindingNavigatorGiaoVien.BindingSource;
            DataTable dataTable = (DataTable)bindingSource.DataSource;
            DataRow dataRow = dataTable.NewRow();

            string stt = Utilities.LaySTT(dgvGiaoVien.Rows.Count + 1);
            dataRow["MaGiaoVien"] = "GV" + stt;
            dataRow["TenGiaoVien"] = "";
            dataRow["DiaChi"] = "";
            dataRow["DienThoai"] = "";
            dataRow["MaMonHoc"] = "";

            dataTable.Rows.Add(dataRow);
            bindingSource.MoveLast();
        }

        private void bindingNavigatorRefreshItem_Click(object sender, EventArgs e)
        {
            GiaoVienBUS.Instance.HienThi(
                bindingNavigatorGiaoVien,
                dgvGiaoVien,
                txtMaGiaoVien,
                txtTenGiaoVien,
                txtDiaChi,
                txtDienThoai,
                cmbMonHoc
            );
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvGiaoVien.RowCount == 0) bindingNavigatorDeleteItem.Enabled = false;
            else if (
                MessageBox.Show(
                    "Bạn có chắc chắn xóa dòng này không ?",
                    "Xóa lớp học",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                ) == DialogResult.OK
            ) bindingNavigatorGiaoVien.BindingSource.RemoveCurrent();
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string[] colNames = { "colMaGiaoVien", "colTenGiaoVien", "colDiaChi", "colDienThoai", "colMaMonHoc" };
            if (KiemTraTruocKhiLuu.KiemTraDataGridView(dgvGiaoVien, colNames))
            {
                bindingNavigatorPositionItem.Focus();
                BindingSource bindingSource = bindingNavigatorGiaoVien.BindingSource;
                GiaoVienBUS.Instance.CapNhatGiaoVien((DataTable)bindingSource.DataSource);

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

        private void btnThemMonHoc_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmMonHoc");
            MonHocBUS.Instance.HienThiDgvCmbCol(colMaMonHoc);
        }

        private void btnLuuVaoDS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenGiaoVien.Text) ||
                string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                string.IsNullOrWhiteSpace(txtDienThoai.Text) ||
                cmbMonHoc.SelectedValue == null)
                MessageBox.Show(
                    "Giá trị của các ô không được rỗng !",
                    "ERROR",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            else
            {
                GiaoVienDTO giaoVien = new GiaoVienDTO(
                    txtMaGiaoVien.Text, 
                    txtTenGiaoVien.Text, 
                    txtDiaChi.Text, 
                    txtDienThoai.Text, 
                    cmbMonHoc.SelectedValue.ToString()
                );
                GiaoVienBUS.Instance.ThemGiaoVien(giaoVien);
                bindingNavigatorRefreshItem_Click(sender, e);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (chkTimTheoMa.Checked) GiaoVienBUS.Instance.TimTheoMa(txtTimKiem.Text);
            else GiaoVienBUS.Instance.TimTheoTen(txtTimKiem.Text);
        }
    }
}
