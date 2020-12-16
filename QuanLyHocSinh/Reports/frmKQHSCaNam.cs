using BUS;
using DevComponents.DotNetBar;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;

namespace QuanLyHocSinh
{
    public partial class frmKQHSCaNam : Office2007Form
    {
        public frmKQHSCaNam()
        {
            InitializeComponent();
        }

        private void frmKQHSCaNam_Load(object sender, EventArgs e)
        {
            NamHocBUS.Instance.HienThiComboBox(cmbNamHoc);
            if (cmbNamHoc.SelectedValue != null)
                LopBUS.Instance.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
        }

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                LopBUS.Instance.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            cmbLop.DataBindings.Clear();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("NgayLap", DateTime.Now.ToString("dd/MM/yyyy")));
            param.Add(new ReportParameter("NamHoc", cmbNamHoc.Text));
            param.Add(new ReportParameter("Lop", cmbLop.Text));

            bsKQHSCN.DataSource = null;
            if (cmbLop.SelectedValue != null && cmbNamHoc.SelectedValue != null)
                bsKQHSCN.DataSource = KQHSCaNamBUS.Instance.Report(
                    cmbLop.SelectedValue.ToString(),
                    cmbNamHoc.SelectedValue.ToString()
                );

            rpvKQHSCN.LocalReport.SetParameters(param);
            rpvKQHSCN.RefreshReport();
        }
    }
}
