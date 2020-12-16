using BUS;
using DevComponents.DotNetBar;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyHocSinh
{
    public partial class frmHoSoLopHoc : Office2007Form
    {
        public frmHoSoLopHoc()
        {
            InitializeComponent();
        }

        private void frmHoSoLopHoc_Load(object sender, EventArgs e)
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

            DataTable dataTable = LopBUS.Instance.TimTheoMa(cmbLop);
            param.Add(new ReportParameter("SiSo", dataTable.Rows[0]["SiSo"].ToString()));

            bsHSLH.DataSource = null;
            if (cmbLop.SelectedValue != null && cmbNamHoc.SelectedValue != null)
                bsHSLH.DataSource = HocSinhBUS.Instance.Report(
                    cmbNamHoc.SelectedValue.ToString(),
                    cmbLop.SelectedValue.ToString()
                );

            rpvHSLH.LocalReport.SetParameters(param);
            rpvHSLH.RefreshReport();
        }
    }
}
