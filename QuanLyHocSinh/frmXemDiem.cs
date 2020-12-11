using BUS;
using DevComponents.DotNetBar;
using System;
using System.Collections;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmXemDiem : Office2007Form
    {
        public frmXemDiem()
        {
            InitializeComponent();
        }

        private void frmXemDiem_Load(object sender, EventArgs e)
        {
            NamHocBUS.Instance.HienThiComboBox(cmbNamHoc);
            HocKyBUS.Instance.HienThiComboBox(cmbHocKy);

            if (cmbNamHoc.SelectedValue != null)
                LopBUS.Instance.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);

            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null)
            {
                MonHocBUS.Instance.HienThiComboBox(
                    cmbNamHoc.SelectedValue.ToString(), 
                    cmbLop.SelectedValue.ToString(), 
                    cmbMonHoc
                );
                HocSinhBUS.Instance.HienThiComboBox(
                    cmbNamHoc.SelectedValue.ToString(), 
                    cmbLop.SelectedValue.ToString(), 
                    cmbHocSinh
                );
            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Bạn có muốn xóa dòng này không ?", 
                    "DELETE", 
                    MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Question
                ) == DialogResult.OK)
            {
                IEnumerator iEnumerator = lvXemDiem.SelectedItems.GetEnumerator();
                while (iEnumerator.MoveNext())
                {
                    ListViewItem item = (ListViewItem)iEnumerator.Current;
                    int stt = Convert.ToInt32(item.SubItems[0].Text);
                    DiemBUS.Instance.XoaDiem(stt);
                    lvXemDiem.Items.Remove(item);
                }
            }

            string maHocSinh = cmbHocSinh.SelectedValue.ToString();
            string maMonHoc = cmbMonHoc.SelectedValue.ToString();
            string maHocKy = cmbHocKy.SelectedValue.ToString();
            string maNamHoc = cmbNamHoc.SelectedValue.ToString();
            string maLop = cmbLop.SelectedValue.ToString();

            KQHSMonHocBUS.Instance.LuuKetQua(maHocSinh, maLop, maNamHoc, maMonHoc, maHocKy);
            KQHSCaNamBUS.Instance.LuuKetQua(maHocSinh, maLop, maNamHoc);

            frmDiem frm = (frmDiem)Application.OpenForms["frmDiem"];
            if (frm != null) frm.btnHienThiClicked(sender, e);
        }

        private void bindingNavigatorExitItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                LopBUS.Instance.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            cmbLop.DataBindings.Clear();
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null)
            {
                MonHocBUS.Instance.HienThiComboBox(
                    cmbNamHoc.SelectedValue.ToString(),
                    cmbLop.SelectedValue.ToString(),
                    cmbMonHoc
                );
                HocSinhBUS.Instance.HienThiComboBox(
                    cmbNamHoc.SelectedValue.ToString(),
                    cmbLop.SelectedValue.ToString(),
                    cmbHocSinh
                );
            }

            cmbMonHoc.DataBindings.Clear();
            cmbHocSinh.DataBindings.Clear();
        }

        private void btnHienThiDanhSach_Click(object sender, EventArgs e)
        {
            DiemBUS.Instance.HienThiDanhSachXemDiem(
                lvXemDiem,
                cmbHocSinh.SelectedValue.ToString(),
                cmbMonHoc.SelectedValue.ToString(),
                cmbHocKy.SelectedValue.ToString(),
                cmbNamHoc.SelectedValue.ToString(),
                cmbLop.SelectedValue.ToString()
            );
        }

        internal void btnHienThiClicked(object sender, EventArgs e)
        {
            btnHienThiDanhSach_Click(sender, e);
        }
    }
}
