using DevComponents.DotNetBar;
using System;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmDoiMatKhau : Office2007Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            txtNewPassword.Focus();
            DialogResult = DialogResult.OK;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
