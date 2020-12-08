using DevComponents.DotNetBar;
using System;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmDangNhap : Office2007Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) DialogResult = DialogResult.OK;
        }
    }
}
