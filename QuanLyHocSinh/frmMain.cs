﻿using DevComponents.DotNetBar;
using System;
using System.Windows.Forms;

namespace QuanLyHocSinh
{
    public partial class frmMain : Office2007RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ribbonControl.QatFrequentCommands.Add(btnDangNhap);
            ribbonControl.QatFrequentCommands.Add(btnDangXuat);
            ribbonControl.QatFrequentCommands.Add(btnThoat);
        }

        private void btnLopHoc_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmLop");
        }

        private void btnKhoiLop_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmKhoiLop");
        }

        private void btnHocKy_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmHocKy");
        }

        private void btnNamHoc_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmNamHoc");
        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmMonHoc");
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmDiem");
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmKetQua");
        }

        private void btnHocLuc_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmHocLuc");
        }

        private void btnHanhKiem_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmHanhKiem");
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmHocSinh");
        }

        private void btnDanToc_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmDanToc");
        }

        private void btnTonGiao_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmTonGiao");
        }

        private void btnNgheNghiep_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmNgheNghiep");
        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmGiaoVien");
        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmPhanCong");
        }

        private void btnKQHSMonHoc_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("Reports.frmKQHSMonHoc");
        }

        private void btnKQHSHocKy_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("Reports.frmKQHSCaNam");
        }

        private void btnKQLHMonHoc_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("Reports.frmKQLHMonHoc");
        }

        private void btnKQLHHocKy_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("Reports.frmKQLHHocKy");
        }

        private void btnDanhSachHocSinh_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmDanhSachHocSinh");
        }

        private void btnDanhSachGiaoVien_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmDanhSachGiaoVien");
        }

        private void btnDanhSachLopHoc_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmDanhSachLopHoc");
        }

        private void btnDoTuoi_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmDoTuoi");
        }

        private void btnSiSo_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmSiSo");
        }

        private void btnThangDiem_Click(object sender, EventArgs e)
        {
            Utilities.ShowForm("frmThangDiem");
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

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

        }
    }
}
