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
                txtTuoiCanDuoi,
                txtTuoiCanTren,
                txtSiSoCanDuoi,
                txtSiSoCanTren,
                txtDiemDat
            );
        }


        private void frmQuyDinh_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (tabControlPanelDoTuoi.CanSelect)
            {
                if (txtTuoiCanDuoi.Value > txtTuoiCanTren.Value)
                    MessageBox.Show(
                        "Đổ tuổi cận dưới phải nhỏ hơn độ tuổi cận trên !", 
                        "ERROR", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                    );
                else
                {
                    QuyDinhBUS.Instance.CapNhatQuyDinhDoTuoi(txtTuoiCanDuoi.Value, txtTuoiCanTren.Value);
                    MessageBox.Show(
                        "Cập nhật thành công quy định về độ tuổi !", 
                        "COMPLETED", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Information
                    );
                    HienThi();
                }
            }
            else if (tabControlPanelSiSo.CanSelect)
            {
                if (txtSiSoCanDuoi.Value > txtSiSoCanTren.Value)
                    MessageBox.Show(
                        "Sỉ số cận dưới phải nhỏ hơn sỉ số cận trên !",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                else
                {
                    QuyDinhBUS.Instance.CapNhatQuyDinhSiSo(txtSiSoCanDuoi.Value, txtSiSoCanTren.Value);
                    MessageBox.Show(
                        "Cập nhật thành công quy định về sỉ số !",
                        "COMPLETED",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                    HienThi();
                }
            }
            else if (tabControlPanelDiemDat.CanSelect)
            {
                QuyDinhBUS.Instance.CapNhatQuyDinhDiemDat(txtDiemDat.Value);
                MessageBox.Show(
                    "Cập nhật thành công quy định về điểm đạt !", 
                    "COMPLETED", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information
                );
                HienThi();
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
