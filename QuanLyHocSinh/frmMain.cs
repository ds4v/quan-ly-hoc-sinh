using BUS;
using DevComponents.DotNetBar;
using Squirrel;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmMain : Office2007RibbonForm
    {
        frmDangNhap frmLogin = null;
        frmDoiMatKhau frmChangePass= null;

        public frmMain()
        {
            InitializeComponent();
            HienThiVersion();
            _ = CapNhatPhanMem();
        }

        private void HienThiVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            Text += $" v.{ versionInfo.FileVersion }";
        }

        private static async Task CapNhatPhanMem()
        {
            string url = @"https://github.com/18520339/quan-ly-hoc-sinh";
            using (var manager = await UpdateManager.GitHubUpdateManager(url))
            {
                ReleaseEntry releaseEntry = await manager.UpdateApp();
                if (releaseEntry?.Version.ToString() != null)
                {
                    MessageBox.Show(
                        "Đã có bản cập nhật mới. Vui lòng khởi động lại phần mềm !",
                        "Cập nhật phiên bản mới",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Show();
            CenterToScreen();
            ShowGiaoDienMacDinh();
            btnDangNhap_Click(sender, e);

            ribbonControl.QatFrequentCommands.Add(btnDangNhap);
            ribbonControl.QatFrequentCommands.Add(btnDangXuat);
            ribbonControl.QatFrequentCommands.Add(btnThoat);
        }

        private void btnLopHoc_Click(object sender, EventArgs e) { Utilities.ShowForm("frmLop"); }
        private void btnKhoiLop_Click(object sender, EventArgs e) { Utilities.ShowForm("frmKhoiLop"); }

        private void btnHocKy_Click(object sender, EventArgs e) { Utilities.ShowForm("frmHocKy"); }
        private void btnNamHoc_Click(object sender, EventArgs e) { Utilities.ShowForm("frmNamHoc"); }

        private void btnMonHoc_Click(object sender, EventArgs e) { Utilities.ShowForm("frmMonHoc"); }
        private void btnDiem_Click(object sender, EventArgs e) { Utilities.ShowForm("frmDiem"); }

        private void btnKetQua_Click(object sender, EventArgs e) { Utilities.ShowForm("frmKetQua"); }
        private void btnHocLuc_Click(object sender, EventArgs e) { Utilities.ShowForm("frmHocLuc"); }
        private void btnHanhKiem_Click(object sender, EventArgs e) { Utilities.ShowForm("frmHanhKiem"); }

        private void btnHocSinh_Click(object sender, EventArgs e) { Utilities.ShowForm("frmHocSinh"); }
        private void btnPhanLop_Click(object sender, EventArgs e) { Utilities.ShowForm("frmPhanLop"); }
        private void btnDanToc_Click(object sender, EventArgs e) { Utilities.ShowForm("frmDanToc"); }
        private void btnTonGiao_Click(object sender, EventArgs e) { Utilities.ShowForm("frmTonGiao"); }
        private void btnNgheNghiep_Click(object sender, EventArgs e) { Utilities.ShowForm("frmNgheNghiep"); }

        private void btnGiaoVien_Click(object sender, EventArgs e) { Utilities.ShowForm("frmGiaoVien"); }
        private void btnPhanCong_Click(object sender, EventArgs e) {  Utilities.ShowForm("frmPhanCong"); }

        private void btnKQHSMonHoc_Click(object sender, EventArgs e) { Utilities.ShowForm("frmKQHSMonHoc"); }
        private void btnKQHSCaNam_Click(object sender, EventArgs e) { Utilities.ShowForm("frmKQHSCaNam"); }
        private void btnKQLHMonHoc_Click(object sender, EventArgs e) { Utilities.ShowForm("frmKQLHMonHoc"); }
        private void btnKQLHHocKy_Click(object sender, EventArgs e) { Utilities.ShowForm("frmKQLHHocKy"); }
        private void btnDanhSachHocSinh_Click(object sender, EventArgs e) { Utilities.ShowForm("frmDanhSachHocSinh"); }
        private void btnDanhSachLopHoc_Click(object sender, EventArgs e) { Utilities.ShowForm("frmHoSoLopHoc"); }

        private void btnDoTuoi_Click(object sender, EventArgs e) { Utilities.ShowForm("frmQuyDinh", false); }
        private void btnSiSo_Click(object sender, EventArgs e) { Utilities.ShowForm("frmQuyDinh", false); }
        private void btnDiemDat_Click(object sender, EventArgs e) { Utilities.ShowForm("frmQuyDinh", false); }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (frmLogin == null || frmLogin.IsDisposed) frmLogin = new frmDangNhap();
                if (frmLogin.ShowDialog() != DialogResult.OK) return;

                string username = frmLogin.txtUsername.Text;
                string password = frmLogin.txtPassword.Text;

                if (string.IsNullOrWhiteSpace(username))
                {
                    frmLogin.lblPassError.Text = "";
                    frmLogin.lblUserError.Text = "Bạn chưa nhập tên!";
                    continue;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    frmLogin.lblUserError.Text = "";
                    frmLogin.lblPassError.Text = "Bạn chưa nhập mật khẩu !";
                    continue;
                }

                if (NguoiDungBUS.Instance.DangNhap(username, password))
                {
                    string maLoai = NguoiDungBUS.Instance.NguoiDung.LoaiNguoiDung.MaLoai;
                    if (maLoai == "LND001") ShowGiaoDienBGH();
                    else if (maLoai == "LND002") ShowGiaoDienGiaoVien();
                    else if (maLoai == "LND003") ShowGiaoDienGiaoVu();
                    else ShowGiaoDienMacDinh();

                    string tenNguoiDung = NguoiDungBUS.Instance.NguoiDung.TenNguoiDung;
                    lblTenNguoiDung.Text = tenNguoiDung;
                    frmLogin.lblUserError.Text = "";
                    frmLogin.lblPassError.Text = "";
                    return;
                } 
                else
                {
                    frmLogin.lblUserError.Text = "Thông tin không chính xác !";
                    frmLogin.lblPassError.Text = "Thông tin không chính xác !";
                    continue;
                }
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            frmLogin.txtUsername.Text = "";
            frmLogin.txtPassword.Text = "";
            lblTenNguoiDung.Text = "Không có";

            foreach (Form form in MdiChildren) form.Close();
            ShowGiaoDienMacDinh();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            while (true)
            {
                if (frmChangePass == null || frmChangePass.IsDisposed) frmChangePass = new frmDoiMatKhau();
                if (frmChangePass.ShowDialog() != DialogResult.OK) return;

                string username = frmLogin.txtUsername.Text;
                string password = frmLogin.txtPassword.Text;

                string oldPassword = frmChangePass.txtOldPassword.Text;
                string newPassword = frmChangePass.txtNewPassword.Text;
                string confirmPassword = frmChangePass.txtConfirmPassword.Text;

                if (string.IsNullOrWhiteSpace(oldPassword))
                {
                    frmChangePass.lblOldPassError.Text = "Chưa nhập mật khẩu hiện tại!";
                    frmChangePass.lblNewPassError.Text = "";
                    frmChangePass.lblConfirmPassError.Text = "";
                    continue;
                }

                if (string.IsNullOrWhiteSpace(newPassword))
                {
                    frmChangePass.lblOldPassError.Text = "";
                    frmChangePass.lblNewPassError.Text = "Chưa nhập mật khẩu mới!";
                    frmChangePass.lblConfirmPassError.Text = "";
                    continue;
                }

                if (string.IsNullOrWhiteSpace(confirmPassword))
                {
                    frmChangePass.lblOldPassError.Text = "";
                    frmChangePass.lblNewPassError.Text = "";
                    frmChangePass.lblConfirmPassError.Text = "Chưa nhập xác nhận mật khẩu!";
                    continue;
                }

                if (password != oldPassword)
                {
                    frmChangePass.lblOldPassError.Text = "Nhập sai mật khẩu cũ!";
                    frmChangePass.lblNewPassError.Text = "";
                    frmChangePass.lblConfirmPassError.Text = "";
                    continue;
                }
                else if (newPassword != confirmPassword)
                {
                    frmChangePass.lblOldPassError.Text = "";
                    frmChangePass.lblNewPassError.Text = "";
                    frmChangePass.lblConfirmPassError.Text = "Nhập xác nhận không khớp!";
                    continue;
                }
                else
                {
                    NguoiDungBUS.Instance.DoiMatKhau(username, newPassword);
                    MessageBox.Show("Đổi mật khẩu thành công!", "PASSWORD CHANGED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmChangePass.txtOldPassword.Text = "";
                    frmChangePass.txtNewPassword.Text = "";
                    frmChangePass.txtConfirmPassword.Text = "";
                    frmChangePass.lblOldPassError.Text = "";
                    frmChangePass.lblNewPassError.Text = "";
                    frmChangePass.lblConfirmPassError.Text = "";
                    return;
                }
            }
        }

        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmNguoiDung");
        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {
            if (backupDialog.ShowDialog() != DialogResult.OK) return;
            NguoiDungBUS.Instance.SaoLuuCSDL(backupDialog.FileName.ToString());
            MessageBox.Show("Sao lưu dữ liệu thành công!", "BACKUP COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {
            if (restoreDialog.ShowDialog() != DialogResult.OK) return;
            NguoiDungBUS.Instance.SaoLuuCSDL(restoreDialog.FileName.ToString());
            MessageBox.Show("Phục hồi dữ liệu thành công!", "RESTORE COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        #region Giao diện mặc định
        public void ShowGiaoDienMacDinh()
        {
            //True
            btnDangNhap.Enabled = true;
            btnDangNhapContext.Enabled = true;
            btnThoat.Enabled = true;
            btnThoatContext.Enabled = true;

            //False
            btnDangXuat.Enabled = false;
            btnDangXuatContext.Enabled = false;
            btnDoiMatKhau.Enabled = false;
            btnDoiMatKhauContext.Enabled = false;
            btnQLNguoiDung.Enabled = false;
            btnSaoLuu.Enabled = false;
            btnPhucHoi.Enabled = false;

            btnLopHoc.Enabled = false;
            btnKhoiLop.Enabled = false;
            btnHocKy.Enabled = false;
            btnNamHoc.Enabled = false;
            ribbonBarMonHoc.Enabled = false;
            btnMonHoc.Enabled = false;
            btnDiem.Enabled = false;
            btnKetQua.Enabled = false;
            btnHocLuc.Enabled = false;
            btnHanhKiem.Enabled = false;
            btnHocSinh.Enabled = false;
            btnPhanLop.Enabled = false;
            btnTonGiao.Enabled = false;
            btnDanToc.Enabled = false;
            btnNgheNghiep.Enabled = false;
            btnGiaoVien.Enabled = false;
            btnPhanCong.Enabled = false;

            btnKQHSMonHoc.Enabled = false;
            btnKQHSCaNam.Enabled = false;
            btnKQLHMonHoc.Enabled = false;
            btnKQLHHocKy.Enabled = false;
            btnDanhSachHocSinh.Enabled = false;
            btnHoSoLopHoc.Enabled = false;

            btnSiSo.Enabled = false;
            btnDiemDat.Enabled = false;
            btnDoTuoi.Enabled = false;
        }
        #endregion

        #region Giao diện khi đăng nhập với quyền BGH
        public void ShowGiaoDienBGH()
        {
            //False
            btnDangNhap.Enabled = false;
            btnDangNhapContext.Enabled = false;

            //True
            btnDangXuat.Enabled = true;
            btnDangXuatContext.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnDoiMatKhauContext.Enabled = true;
            btnQLNguoiDung.Enabled = true;
            btnSaoLuu.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnThoat.Enabled = true;
            btnThoatContext.Enabled = true;

            btnLopHoc.Enabled = true;
            btnKhoiLop.Enabled = true;
            btnHocKy.Enabled = true;
            btnNamHoc.Enabled = true;
            ribbonBarMonHoc.Enabled = true;
            btnMonHoc.Enabled = true;
            btnDiem.Enabled = true;
            btnKetQua.Enabled = true;
            btnHocLuc.Enabled = true;
            btnHanhKiem.Enabled = true;
            btnHocSinh.Enabled = true;
            btnPhanLop.Enabled = true;
            btnTonGiao.Enabled = true;
            btnDanToc.Enabled = true;
            btnNgheNghiep.Enabled = true;
            btnGiaoVien.Enabled = true;
            btnPhanCong.Enabled = true;

            btnKQHSMonHoc.Enabled = true;
            btnKQHSCaNam.Enabled = true;
            btnKQLHMonHoc.Enabled = true;
            btnKQLHHocKy.Enabled = true;
            btnDanhSachHocSinh.Enabled = true;
            btnHoSoLopHoc.Enabled = true;

            btnSiSo.Enabled = true;
            btnDiemDat.Enabled = true;
            btnDoTuoi.Enabled = true;
        }
        #endregion

        #region Giao diện khi đăng nhập với quyền Giáo viên
        public void ShowGiaoDienGiaoVien()
        {
            //True
            btnDangXuat.Enabled = true;
            btnDangXuatContext.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnDoiMatKhauContext.Enabled = true;
            btnThoat.Enabled = true;
            btnThoatContext.Enabled = true;

            ribbonBarMonHoc.Enabled = true;
            btnMonHoc.Enabled = true;
            btnDiem.Enabled = true;

            btnKQHSMonHoc.Enabled = true;
            btnKQHSCaNam.Enabled = true;
            btnKQLHMonHoc.Enabled = true;
            btnKQLHHocKy.Enabled = true;
            btnDanhSachHocSinh.Enabled = true;
            btnHoSoLopHoc.Enabled = true;

            //False
            btnDangNhap.Enabled = false;
            btnDangNhapContext.Enabled = false;
            btnQLNguoiDung.Enabled = false;
            btnSaoLuu.Enabled = false;
            btnPhucHoi.Enabled = false;

            btnLopHoc.Enabled = false;
            btnKhoiLop.Enabled = false;
            btnHocKy.Enabled = false;
            btnNamHoc.Enabled = false;
            btnKetQua.Enabled = false;
            btnHocLuc.Enabled = false;
            btnHanhKiem.Enabled = false;
            btnHocSinh.Enabled = false;
            btnPhanLop.Enabled = false;
            btnTonGiao.Enabled = false;
            btnDanToc.Enabled = false;
            btnNgheNghiep.Enabled = false;
            btnGiaoVien.Enabled = false;
            btnPhanCong.Enabled = false;

            btnSiSo.Enabled = false;
            btnDiemDat.Enabled = false;
            btnDoTuoi.Enabled = false;
        }
        #endregion

        #region Giao diện khi đăng nhập với quyền Giáo vụ
        public void ShowGiaoDienGiaoVu()
        {
            //True
            btnDangXuat.Enabled = true;
            btnDangXuatContext.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnDoiMatKhauContext.Enabled = true;
            btnThoat.Enabled = true;
            btnThoatContext.Enabled = true;

            btnLopHoc.Enabled = true;
            btnKhoiLop.Enabled = true;
            btnHocKy.Enabled = true;
            btnNamHoc.Enabled = true;
            btnKetQua.Enabled = true;
            btnHocLuc.Enabled = true;
            btnHanhKiem.Enabled = true;
            ribbonBarMonHoc.Enabled = true;
            btnMonHoc.Enabled = true;
            btnDiem.Enabled = true;
            btnHocSinh.Enabled = true;
            btnPhanLop.Enabled = true;
            btnTonGiao.Enabled = true;
            btnDanToc.Enabled = true;
            btnNgheNghiep.Enabled = true;

            btnKQHSMonHoc.Enabled = true;
            btnKQHSCaNam.Enabled = true;
            btnKQLHMonHoc.Enabled = true;
            btnKQLHHocKy.Enabled = true;
            btnDanhSachHocSinh.Enabled = true;
            btnHoSoLopHoc.Enabled = true;

            //False
            btnDangNhap.Enabled = false;
            btnDangNhapContext.Enabled = false;
            btnQLNguoiDung.Enabled = false;
            btnSaoLuu.Enabled = false;
            btnPhucHoi.Enabled = false;

            btnGiaoVien.Enabled = false;
            btnPhanCong.Enabled = false;

            btnSiSo.Enabled = false;
            btnDiemDat.Enabled = false;
            btnDoTuoi.Enabled = false;
        }
        #endregion
    }
}
