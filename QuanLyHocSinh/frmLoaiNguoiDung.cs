using BUS;
using DevComponents.DotNetBar;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmLoaiNguoiDung : Office2007Form
    {
        public frmLoaiNguoiDung()
        {
            InitializeComponent();
        }

        private void frmLoaiNguoiDung_Load(object sender, EventArgs e)
        {
            LoaiNguoiDungBUS.Instance.HienThi(dgvLoaiNguoiDung, bindingNavigatorLoaiNguoiDung);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string[] colNames = { "colMaLoai", "colTenLoai" };
            if (KiemTraTruocKhiLuu.KiemTraDataGridView(dgvLoaiNguoiDung, colNames))
            {
                bindingNavigatorPositionItem.Focus();
                BindingSource bindingSource = bindingNavigatorLoaiNguoiDung.BindingSource;
                LoaiNguoiDungBUS.Instance.CapNhatLoaiNguoiDung((DataTable)bindingSource.DataSource);

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
    }
}
