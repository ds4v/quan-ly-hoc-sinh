namespace QuanLyHocSinh
{
    partial class frmDanhSachHocSinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bsDSHS = new System.Windows.Forms.BindingSource(this.components);
            this.rpvDSHS = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.bsDSHS)).BeginInit();
            this.SuspendLayout();
            // 
            // bsDSHS
            // 
            this.bsDSHS.DataSource = typeof(DTO.HocSinhDTO);
            // 
            // rpvDSHS
            // 
            this.rpvDSHS.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "HocSinhDTO";
            reportDataSource1.Value = this.bsDSHS;
            this.rpvDSHS.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvDSHS.LocalReport.ReportEmbeddedResource = "QuanLyHocSinh.Reports.rptDanhSachHocSinh.rdlc";
            this.rpvDSHS.Location = new System.Drawing.Point(0, 0);
            this.rpvDSHS.Name = "rpvDSHS";
            this.rpvDSHS.ServerReport.BearerToken = null;
            this.rpvDSHS.Size = new System.Drawing.Size(792, 466);
            this.rpvDSHS.TabIndex = 1;
            // 
            // frmDanhSachHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 466);
            this.Controls.Add(this.rpvDSHS);
            this.DoubleBuffered = true;
            this.Name = "frmDanhSachHocSinh";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DANH SÁCH HỌC SINH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhSachHocSinh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsDSHS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvDSHS;
        private System.Windows.Forms.BindingSource bsDSHS;
    }
}