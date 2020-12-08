using BUS;
using DevComponents.DotNetBar;
using System;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmMain : Office2007RibbonForm
    {
        frmDangNhap frmLogin = null;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Show();
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
        private void btnDanToc_Click(object sender, EventArgs e) { Utilities.ShowForm("frmDanToc"); }
        private void btnTonGiao_Click(object sender, EventArgs e) { Utilities.ShowForm("frmTonGiao"); }
        private void btnNgheNghiep_Click(object sender, EventArgs e) { Utilities.ShowForm("frmNgheNghiep"); }
        private void btnGiaoVien_Click(object sender, EventArgs e) { Utilities.ShowForm("frmGiaoVien"); }
        private void btnPhanCong_Click(object sender, EventArgs e) {  Utilities.ShowForm("frmPhanCong"); }
        private void btnKQHSMonHoc_Click(object sender, EventArgs e) { Utilities.ShowForm("Reports.frmKQHSMonHoc"); }
        private void btnKQHSCaNam_Click(object sender, EventArgs e) { Utilities.ShowForm("Reports.frmKQHSCaNam"); }
        private void btnKQLHMonHoc_Click(object sender, EventArgs e) { Utilities.ShowForm("Reports.frmKQLHMonHoc"); }
        private void btnKQLHHocKy_Click(object sender, EventArgs e) { Utilities.ShowForm("Reports.frmKQLHHocKy"); }
        private void btnDanhSachHocSinh_Click(object sender, EventArgs e) { Utilities.ShowForm("frmDanhSachHocSinh"); }
        private void btnDanhSachGiaoVien_Click(object sender, EventArgs e) { Utilities.ShowForm("frmDanhSachGiaoVien"); }
        private void btnDanhSachLopHoc_Click(object sender, EventArgs e) { Utilities.ShowForm("frmDanhSachLopHoc"); }
        private void btnDoTuoi_Click(object sender, EventArgs e) { Utilities.ShowForm("frmQuyDinh"); }
        private void btnSiSo_Click(object sender, EventArgs e) { Utilities.ShowForm("frmQuyDinh"); }
        private void btnThangDiem_Click(object sender, EventArgs e) { Utilities.ShowForm("frmQuyDinh"); }

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

                switch (NguoiDungBUS.Instance.DangNhap(username, password))
                {
                    case 0:
                        frmLogin.lblPassError.Text = "";
                        frmLogin.lblUserError.Text = "Người dùng này không tồn tại !";
                        continue;
                    case 1:
                        frmLogin.lblUserError.Text = "";
                        frmLogin.lblPassError.Text = "Mật khẩu không hợp lệ !";
                        continue;
                    case 2:
                        string maLoai = NguoiDungBUS.Instance.LoaiNguoiDung.MaLoai;
                        if (maLoai == "LND001") ShowGiaoDienBGH();
                        else if (maLoai == "LND002") ShowGiaoDienGiaoVien();
                        else if (maLoai == "LND003") ShowGiaoDienGiaoVu();
                        else ShowGiaoDienMacDinh();

                        string tenNguoiDung = NguoiDungBUS.Instance.NguoiDung.TenNguoiDung;
                        lblTenNguoiDung.Text = tenNguoiDung;

                        frmLogin.txtUsername.Text = "";
                        frmLogin.txtPassword.Text = "";
                        frmLogin.lblUserError.Text = "";
                        frmLogin.lblPassError.Text = "";
                        return;
                }
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            lblTenNguoiDung.Text = "Không có";
            ShowGiaoDienMacDinh();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void btnQLNguoiDung_Click(object sender, EventArgs e)
        {

        }

        private void btnSaoLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnPhucHoi_Click(object sender, EventArgs e)
        {

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
            btnDanhSachGiaoVien.Enabled = false;
            btnDanhSachLopHoc.Enabled = false;

            btnSiSo.Enabled = false;
            btnThangDiem.Enabled = false;
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
            btnDanhSachGiaoVien.Enabled = true;
            btnDanhSachLopHoc.Enabled = true;

            btnSiSo.Enabled = true;
            btnThangDiem.Enabled = true;
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
            btnDanhSachGiaoVien.Enabled = true;
            btnDanhSachLopHoc.Enabled = true;

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
            btnTonGiao.Enabled = false;
            btnDanToc.Enabled = false;
            btnNgheNghiep.Enabled = false;
            btnGiaoVien.Enabled = false;
            btnPhanCong.Enabled = false;

            btnSiSo.Enabled = false;
            btnThangDiem.Enabled = false;
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
            btnTonGiao.Enabled = true;
            btnDanToc.Enabled = true;
            btnNgheNghiep.Enabled = true;

            btnKQHSMonHoc.Enabled = true;
            btnKQHSCaNam.Enabled = true;
            btnKQLHMonHoc.Enabled = true;
            btnKQLHHocKy.Enabled = true;
            btnDanhSachHocSinh.Enabled = true;
            btnDanhSachGiaoVien.Enabled = true;
            btnDanhSachLopHoc.Enabled = true;

            //False
            btnDangNhap.Enabled = false;
            btnDangNhapContext.Enabled = false;
            btnQLNguoiDung.Enabled = false;
            btnSaoLuu.Enabled = false;
            btnPhucHoi.Enabled = false;

            btnGiaoVien.Enabled = false;
            btnPhanCong.Enabled = false;

            btnSiSo.Enabled = false;
            btnThangDiem.Enabled = false;
            btnDoTuoi.Enabled = false;
        }
        #endregion
    }
}
