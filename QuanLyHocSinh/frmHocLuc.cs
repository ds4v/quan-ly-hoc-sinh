using BUS;
using DevComponents.DotNetBar;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmHocLuc : Office2007Form
    {
        public frmHocLuc()
        {
            InitializeComponent();
        }

        private void frmHocLuc_Load(object sender, EventArgs e)
        {
            HocLucBUS.Instance.HienThi(dgvHocLuc, bindingNavigatorHocLuc);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string[] colDgvNames = { "colMaHocLuc", "colTenHocLuc" };
            string[] colDiemNames = { "colDiemCanTren", "colDiemCanDuoi", "colDiemKhongChe" };

            if (KiemTraTruocKhiLuu.KiemTraDataGridView(dgvHocLuc, colDgvNames) &&
                KiemTraTruocKhiLuu.KiemTraDiem(dgvHocLuc, colDiemNames))
            {
                bindingNavigatorPositionItem.Focus();
                BindingSource bindingSource = bindingNavigatorHocLuc.BindingSource;
                HocLucBUS.Instance.CapNhatHocLuc((DataTable)bindingSource.DataSource);

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
