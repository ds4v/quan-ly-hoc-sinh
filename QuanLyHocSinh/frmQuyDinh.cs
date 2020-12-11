using BUS;
using DevComponents.DotNetBar;
using System;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmQuyDinh : Office2007Form
    {
        public frmQuyDinh()
        {
            InitializeComponent();
        }

        private void HienThi()
        {
            QuyDinhBUS.Instance.HienThi(
                txtSiSoCanDuoi,
                txtSiSoCanTren,
                txtDoTuoiCanDuoi,
                txtDoTuoiCanTren,
                ckbThang10,
                ckbThang100
            );
        }

        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (tabControlPanelSiSo.CanSelect)
            {
                if (txtSiSoCanDuoi.Value < 10 || txtSiSoCanTren.Value > 40)
                    MessageBoxEx.Show(
                        "Sỉ số phải nằm trong khoảng giới hạn 10 - 40 !", 
                        "ERROR", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                    );
                else
                {
                    QuyDinhBUS.Instance.CapNhatQuyDinhSiSo(txtSiSoCanDuoi.Value, txtSiSoCanTren.Value);
                    MessageBoxEx.Show(
                        "Cập nhật thành công quy định về sỉ số !", 
                        "COMPLETED", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information
                    );
                    HienThi();
                }
            }
            else if (tabControlPanelDoTuoi.CanSelect)
            {
                if (txtDoTuoiCanDuoi.Value < 15 || txtDoTuoiCanTren.Value > 20)
                    MessageBoxEx.Show(
                        "Độ tuổi phải nằm trong khoảng giới hạn 15 - 20 !", 
                        "ERROR", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                    );
                else
                {
                    QuyDinhBUS.Instance.CapNhatQuyDinhDoTuoi(txtDoTuoiCanDuoi.Value, txtDoTuoiCanTren.Value);
                    MessageBoxEx.Show(
                        "Cập nhật thành công quy định về độ tuổi !", 
                        "COMPLETED", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information
                    );
                    HienThi();
                }
            }
            else if (tabControlPanelThangDiem.CanSelect)
            {
                if (ckbThang10.Checked)
                {
                    QuyDinhBUS.Instance.CapNhatQuyDinhThangDiem(10);
                    MessageBoxEx.Show(
                        "Cập nhật thành công quy định về thang điểm !", 
                        "COMPLETED", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information
                    );
                    HienThi();
                }
                else
                {
                    QuyDinhBUS.Instance.CapNhatQuyDinhThangDiem(100);
                    MessageBoxEx.Show(
                        "Cập nhật thành công quy định về thang điểm !", 
                        "COMPLETED", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information
                    );
                    HienThi();
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
