using BUS;
using DevComponents.DotNetBar;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;

namespace QuanLyHocSinh
{
    public partial class frmKQLHHocKy : Office2007Form
    {
        public frmKQLHHocKy()
        {
            InitializeComponent();
        }

        private void frmKQLHHocKy_Load(object sender, EventArgs e)
        {
            NamHocBUS.Instance.HienThiComboBox(cmbNamHoc);
            HocKyBUS.Instance.HienThiComboBox(cmbHocKy);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("NgayLap", DateTime.Now.ToString("dd/MM/yyyy")));
            param.Add(new ReportParameter("NamHoc", cmbNamHoc.Text));
            param.Add(new ReportParameter("HocKy", cmbHocKy.Text));

            bsKQLHHK.DataSource = null;
            if (cmbHocKy.SelectedValue != null && cmbNamHoc.SelectedValue != null)
                bsKQLHHK.DataSource = KQLHHocKyBUS.Instance.Report(
                cmbNamHoc.SelectedValue.ToString(),
                cmbHocKy.SelectedValue.ToString()
            );

            rpvKQLHHK.LocalReport.SetParameters(param);
            rpvKQLHHK.RefreshReport();
        }
    }
}
