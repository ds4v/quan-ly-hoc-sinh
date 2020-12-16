using BUS;
using DevComponents.DotNetBar;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;

namespace QuanLyHocSinh
{
    public partial class frmKQLHMonHoc : Office2007Form
    {
        public frmKQLHMonHoc()
        {
            InitializeComponent();
        }

        private void frmKQLHMonHoc_Load(object sender, EventArgs e)
        {
            NamHocBUS.Instance.HienThiComboBox(cmbNamHoc);
            HocKyBUS.Instance.HienThiComboBox(cmbHocKy);

            if (cmbNamHoc.SelectedValue != null)
                MonHocBUS.Instance.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbMonHoc);
        }

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                MonHocBUS.Instance.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbMonHoc);
            cmbMonHoc.DataBindings.Clear();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("NgayLap", DateTime.Now.ToString("dd/MM/yyyy")));
            param.Add(new ReportParameter("NamHoc", cmbNamHoc.Text));
            param.Add(new ReportParameter("HocKy", cmbHocKy.Text));
            param.Add(new ReportParameter("MonHoc", cmbMonHoc.Text));

            bsKQLHMH.DataSource = null;
            if (cmbMonHoc.SelectedValue != null && cmbHocKy.SelectedValue != null && cmbNamHoc.SelectedValue != null)
                bsKQLHMH.DataSource = KQLHMonHocBUS.Instance.Report(
                cmbNamHoc.SelectedValue.ToString(),
                cmbMonHoc.SelectedValue.ToString(),
                cmbHocKy.SelectedValue.ToString()
            );

            rpvKQLHMH.LocalReport.SetParameters(param);
            rpvKQLHMH.RefreshReport();
        }
    }
}
