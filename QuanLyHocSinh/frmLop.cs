using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace QuanLyHocSinh
{
    public partial class frmLop : Office2007Form
    {
        LopBUS lopBUS = new LopBUS();
        KhoiLopBUS khoiLopBUS = new KhoiLopBUS();
        NamHocBUS namHocBUS = new NamHocBUS();
        GiaoVienBUS giaoVienBUS = new GiaoVienBUS();
        QuyDinhBUS quyDinhBUS = new QuyDinhBUS();

        public frmLop()
        {
            InitializeComponent();
        }

        private void frmLop_Load(object sender, EventArgs e)
        {
            khoiLopBUS.HienThiComboBox(cmbKhoiLop);
            namHocBUS.HienThiComboBox(cmbNamHoc);
            giaoVienBUS.HienThiComboBox(cmbGiaoVien);

            khoiLopBUS.HienThiDgvCmbCol(colMaKhoiLop);
            namHocBUS.HienThiDgvCmbCol(colMaNamHoc);
            giaoVienBUS.HienThiDgvCmbCol(colMaGiaoVien);

            lopBUS.HienThi(
                dgvLop, 
                bindingNavigatorLop, 
                txtMaLop, 
                txtTenLop, 
                cmbKhoiLop, 
                cmbNamHoc, 
                iniSiSo, 
                cmbGiaoVien
            );
        }
    }
}
