using BUS;
using DevComponents.DotNetBar;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;

namespace QuanLyHocSinh
{
    public partial class frmDanhSachHocSinh : Office2007Form
    {
        public frmDanhSachHocSinh()
        {
            InitializeComponent();
        }

        private void frmDanhSachHocSinh_Load(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("NgayLap", DateTime.Now.ToString("dd/MM/yyyy")));

            bsDSHS.DataSource = HocSinhBUS.Instance.Report();
            rpvDSHS.LocalReport.SetParameters(param);
            rpvDSHS.RefreshReport();
        }
    }
}
