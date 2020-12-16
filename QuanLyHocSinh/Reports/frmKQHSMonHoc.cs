using BUS;
using DevComponents.DotNetBar;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;

namespace QuanLyHocSinh
{
    public partial class frmKQHSMonHoc : Office2007Form
    {
        public frmKQHSMonHoc()
        {
            InitializeComponent();
        }

        private void frmKQHSMonHoc_Load(object sender, EventArgs e)
        {
            NamHocBUS.Instance.HienThiComboBox(cmbNamHoc);
            HocKyBUS.Instance.HienThiComboBox(cmbHocKy);

            if (cmbNamHoc.SelectedValue != null)
                LopBUS.Instance.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null)
                MonHocBUS.Instance.HienThiComboBox(
                    cmbNamHoc.SelectedValue.ToString(), 
                    cmbLop.SelectedValue.ToString(), 
                    cmbMonHoc
                );
        }

        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                LopBUS.Instance.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            cmbLop.DataBindings.Clear();
        }

        private void cmbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null && cmbLop.SelectedValue != null)
                MonHocBUS.Instance.HienThiComboBox(
                    cmbNamHoc.SelectedValue.ToString(), 
                    cmbLop.SelectedValue.ToString(), 
                    cmbMonHoc
                );
            cmbMonHoc.DataBindings.Clear();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            IList<ReportParameter> param = new List<ReportParameter>();
            param.Add(new ReportParameter("NgayLap", DateTime.Now.ToString("dd/MM/yyyy")));
            param.Add(new ReportParameter("NamHoc", cmbNamHoc.Text));
            param.Add(new ReportParameter("HocKy", cmbHocKy.Text));
            param.Add(new ReportParameter("Lop", cmbLop.Text));
            param.Add(new ReportParameter("MonHoc", cmbMonHoc.Text));

            bsKQHSMH.DataSource = null;
            if (cmbLop.SelectedValue != null && cmbMonHoc.SelectedValue != null &&
                cmbHocKy.SelectedValue != null && cmbNamHoc.SelectedValue != null)
                bsKQHSMH.DataSource = KQHSMonHocBUS.Instance.Report(
                cmbLop.SelectedValue.ToString(),
                cmbNamHoc.SelectedValue.ToString(),
                cmbMonHoc.SelectedValue.ToString(),
                cmbHocKy.SelectedValue.ToString()
            );

            rpvKQHSMH.LocalReport.SetParameters(param);
            rpvKQHSMH.RefreshReport();
        }
    }
}
