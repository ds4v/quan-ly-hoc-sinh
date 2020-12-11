using BUS;
using DevComponents.DotNetBar;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmNguoiDung : Office2007Form
    {
        public frmNguoiDung()
        {
            InitializeComponent();
        }

        private void frmNguoiDung_Load(object sender, EventArgs e)
        {
            LoaiNguoiDungBUS.Instance.HienThiDgvCmbCol(colMaLoai);
            NguoiDungBUS.Instance.HienThi(dgvNguoiDung, bindingNavigatorNguoiDung);
        }

        private void btnThemLoaiNguoiDung_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmLoaiNguoiDung");
            LoaiNguoiDungBUS.Instance.HienThiDgvCmbCol(colMaLoai);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvNguoiDung.RowCount == 0) bindingNavigatorDeleteItem.Enabled = true;

            BindingSource bindingSource = bindingNavigatorNguoiDung.BindingSource;
            DataTable dataTable = (DataTable)bindingSource.DataSource;
            DataRow dataRow = dataTable.NewRow();

            string stt = Utilities.LaySTT(dgvNguoiDung.Rows.Count + 1);
            dataRow["MaNguoiDung"] = "ND" + stt;
            dataRow["MaLoai"] = "";
            dataRow["TenNguoiDung"] = "";
            dataRow["TenDangNhap"] = "";
            dataRow["MatKhau"] = "";

            dataTable.Rows.Add(dataRow);
            bindingSource.MoveLast();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvNguoiDung.RowCount == 0) bindingNavigatorDeleteItem.Enabled = false;
            else if (
                MessageBox.Show(
                    "Bạn có chắc chắn xóa dòng này không ?",
                    "Xóa lớp học",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                ) == DialogResult.OK
            ) bindingNavigatorNguoiDung.BindingSource.RemoveCurrent();
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string[] colNames = { "colMaNguoiDung", "colMaLoai", "colTenNguoiDung", "colTenDangNhap", "colMatKhau" };
            if (KiemTraTruocKhiLuu.KiemTraDataGridView(dgvNguoiDung, colNames))
            {
                bindingNavigatorPositionItem.Focus();
                BindingSource bindingSource = bindingNavigatorNguoiDung.BindingSource;
                NguoiDungBUS.Instance.CapNhatNguoiDung((DataTable)bindingSource.DataSource);

                MessageBox.Show(
                    "Dữ liệu đã được lưu vào CSDL",
                    "Cập nhật thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            NguoiDungBUS.Instance.HienThi(dgvNguoiDung, bindingNavigatorNguoiDung);
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
