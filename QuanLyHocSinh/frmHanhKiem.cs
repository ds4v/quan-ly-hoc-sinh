using BUS;
using DevComponents.DotNetBar;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmHanhKiem : Office2007Form
    {
        public frmHanhKiem()
        {
            InitializeComponent();
        }

        private void frmHanhKiem_Load(object sender, EventArgs e)
        {
            HanhKiemBUS.Instance.HienThi(dgvHanhKiem, bindingNavigatorHanhKiem);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string[] colNames = { "colMaHanhKiem", "colTenHanhKiem" };
            if (KiemTraTruocKhiLuu.KiemTraDataGridView(dgvHanhKiem, colNames))
            {
                bindingNavigatorPositionItem.Focus();
                BindingSource bindingSource = bindingNavigatorHanhKiem.BindingSource;
                HanhKiemBUS.Instance.CapNhatHanhKiem((DataTable)bindingSource.DataSource);

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
