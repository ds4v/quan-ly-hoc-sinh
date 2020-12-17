using BUS;
using DevComponents.DotNetBar;
using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmPhanLop : Office2007Form
    {
        public frmPhanLop()
        {
            InitializeComponent();
        }

        private void frmPhanLop_Load(object sender, EventArgs e)
        {
            NamHocBUS.Instance.HienThiComboBox(cmbNamHocCu);
            NamHocBUS.Instance.HienThiComboBox(cmbNamHocMoi);
            KhoiLopBUS.Instance.HienThiComboBox(cmbKhoiLopCu);

            cmbKhoiLopCu_SelectedIndexChanged(sender, e);
            cmbKhoiLopMoi_SelectedIndexChanged(sender, e);

            cmbLopCu_SelectedIndexChanged(sender, e);
            cmbLopMoi_SelectedIndexChanged(sender, e);
        }

        private void cmbNamHocCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKhoiLopCu.DataBindings.Clear();
            cmbLopCu.DataBindings.Clear();
        }

        private void cmbNamHocMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKhoiLopMoi.DataBindings.Clear();
            cmbLopMoi.DataBindings.Clear();
        }

        private void cmbKhoiLopCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHocCu.SelectedValue != null && cmbKhoiLopCu.SelectedValue != null)
            {
                LopBUS.Instance.HienThiComboBox(cmbKhoiLopCu.SelectedValue.ToString(), cmbNamHocCu.SelectedValue.ToString(), cmbLopCu);
                KhoiLopBUS.Instance.HienThiComboBox(cmbKhoiLopCu.SelectedValue.ToString(), cmbKhoiLopMoi);
                cmbLopCu.DataBindings.Clear();
                lvLopCu.Items.Clear();
            }
        }

        private void cmbKhoiLopMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHocMoi.SelectedValue != null && cmbKhoiLopMoi.SelectedValue != null)
            {
                LopBUS.Instance.HienThiComboBox(cmbKhoiLopMoi.SelectedValue.ToString(), cmbNamHocMoi.SelectedValue.ToString(), cmbLopMoi);
                cmbLopMoi.DataBindings.Clear();
                lvLopMoi.Items.Clear();
            }
        }

        private void cmbLopCu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLopCu.SelectedValue != null && cmbNamHocCu.SelectedValue != null && cmbKhoiLopCu.SelectedValue != null)
                HocSinhBUS.Instance.HienThiHocSinhTheoLop(
                    cmbNamHocCu.SelectedValue.ToString(), 
                    cmbKhoiLopCu.SelectedValue.ToString(), 
                    cmbLopCu.SelectedValue.ToString(), 
                    lvLopCu
                );
        }

        private void cmbLopMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLopMoi.SelectedValue != null && cmbNamHocMoi.SelectedValue != null && cmbKhoiLopMoi.SelectedValue != null)
                HocSinhBUS.Instance.HienThiHocSinhTheoLop(
                    cmbNamHocMoi.SelectedValue.ToString(), 
                    cmbKhoiLopMoi.SelectedValue.ToString(), 
                    cmbLopMoi.SelectedValue.ToString(), 
                    lvLopMoi
                );
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            IEnumerator ie = lvLopCu.SelectedItems.GetEnumerator();
            while (ie.MoveNext())
            {
                ListViewItem olditem = (ListViewItem)ie.Current;
                ListViewItem newitem = new ListViewItem();

                bool state = false;
                foreach (ListViewItem item in lvLopMoi.Items)
                {
                    if (item.SubItems[0].Text == olditem.SubItems[0].Text)
                    {
                        MessageBox.Show(
                            $"Học sinh {item.SubItems[1].Text} hiện đang học trong lớp {cmbLopMoi.Text}",
                            "ERROR", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error
                        );
                        state = true;
                        break;
                    }
                }
                if (state == true) break;

                DataTable dataTable = new DataTable();
                if (cmbNamHocMoi.SelectedValue != null)
                    dataTable = HocSinhBUS.Instance.LayDanhSachHocSinhTheoNamHoc(cmbNamHocMoi.SelectedValue.ToString());

                foreach (DataRow row in dataTable.Rows)
                {
                    if (olditem.SubItems[0].Text.ToString() == row["MaHocSinh"].ToString())
                    {
                        MessageBox.Show(
                            $"Học sinh {row["HoTen"]} hiện đang học trong lớp {row["TenLop"]}", 
                            "ERROR", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error
                        );
                        state = true;
                        break;
                    }
                }
                if (state == true) break;

                newitem.SubItems.Add(olditem.SubItems[1].Text);
                newitem.Tag = olditem.Tag;

                lvLopMoi.Items.Add(newitem);
                lvLopMoi.Items[lvLopMoi.Items.IndexOf(newitem)].Text = olditem.SubItems[0].Text;
                lvLopCu.Items.Remove(olditem);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa học sinh này khỏi lớp mới không ?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                IEnumerator ie = lvLopMoi.SelectedItems.GetEnumerator();
                while (ie.MoveNext())
                {
                    ListViewItem item = (ListViewItem)ie.Current;
                    lvLopMoi.Items.Remove(item);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cmbNamHocCu.SelectedValue != null && cmbKhoiLopCu.SelectedValue != null &&
                cmbLopCu.SelectedValue != null && cmbNamHocMoi.SelectedValue != null &&
                cmbKhoiLopMoi.SelectedValue != null && cmbLopMoi.SelectedValue != null)
            {
                PhanLopBUS.Instance.XoaHocSinhKhoiBangPhanLop(
                    cmbNamHocCu.SelectedValue.ToString(),
                    cmbKhoiLopCu.SelectedValue.ToString(),
                    cmbLopCu.SelectedValue.ToString(),
                    lvLopMoi
                );
                PhanLopBUS.Instance.LuuHocSinhVaoBangPhanLop(
                    cmbNamHocMoi.SelectedValue.ToString(),
                    cmbKhoiLopMoi.SelectedValue.ToString(),
                    cmbLopMoi.SelectedValue.ToString(),
                    lvLopMoi
                );
                MessageBox.Show("Đã lưu vào bảng phân lớp !", "COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Giá trị của các ô không được rỗng !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
