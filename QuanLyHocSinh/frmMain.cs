﻿using DevComponents.DotNetBar;
using System;

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
            Helper.ShowForm("frmLop");
        }

        private void btnKhoiLop_Click(object sender, EventArgs e)
        {
            Helper.ShowForm("frmKhoiLop");
        }

        private void btnHocKy_Click(object sender, EventArgs e)
        {

        }

        private void btnNamHoc_Click(object sender, EventArgs e)
        {

        }

        private void btnMonHoc_Click(object sender, EventArgs e)
        {

        }

        private void btnDiem_Click(object sender, EventArgs e)
        {

        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {

        }

        private void btnHocLuc_Click(object sender, EventArgs e)
        {

        }

        private void btnHanhKiem_Click(object sender, EventArgs e)
        {

        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {

        }

        private void btnPhanLop_Click(object sender, EventArgs e)
        {

        }

        private void btnDanToc_Click(object sender, EventArgs e)
        {

        }

        private void btnTonGiao_Click(object sender, EventArgs e)
        {

        }

        private void btnNgheNghiep_Click(object sender, EventArgs e)
        {

        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {

        }

        private void btnPhanCong_Click(object sender, EventArgs e)
        {

        }

        private void btnKQHKTheoLop_Click(object sender, EventArgs e)
        {

        }

        private void btnKQHKTheoMon_Click(object sender, EventArgs e)
        {

        }

        private void btnKQCNTheoLop_Click(object sender, EventArgs e)
        {

        }

        private void btnKQCNTheoMon_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhSachHocSinh_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhSachGiaoVien_Click(object sender, EventArgs e)
        {

        }

        private void btnDanhSachLopHoc_Click(object sender, EventArgs e)
        {

        }

        private void btnDoTuoi_Click(object sender, EventArgs e)
        {

        }

        private void btnSiSo_Click(object sender, EventArgs e)
        {

        }

        private void btnThangDiem_Click(object sender, EventArgs e)
        {

        }
    }
}
