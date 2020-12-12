namespace QuanLyHocSinh.Reports
{
    partial class frmKQLHMonHoc
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
            this.bsKQLHMH = new System.Windows.Forms.BindingSource(this.components);
            this.groupPanelDS = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnXem = new DevComponents.DotNetBar.ButtonX();
            this.cmbMonHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.cmbHocKy = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmbNamHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX0 = new DevComponents.DotNetBar.LabelX();
            this.rpvKQLHMH = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.bsKQLHMH)).BeginInit();
            this.groupPanelDS.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsKQLHMH
            // 
            this.bsKQLHMH.DataSource = typeof(DTO.KQLHMonHocDTO);
            // 
            // groupPanelDS
            // 
            this.groupPanelDS.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelDS.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelDS.Controls.Add(this.btnXem);
            this.groupPanelDS.Controls.Add(this.cmbMonHoc);
            this.groupPanelDS.Controls.Add(this.labelX3);
            this.groupPanelDS.Controls.Add(this.cmbHocKy);
            this.groupPanelDS.Controls.Add(this.labelX1);
            this.groupPanelDS.Controls.Add(this.cmbNamHoc);
            this.groupPanelDS.Controls.Add(this.labelX0);
            this.groupPanelDS.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelDS.Location = new System.Drawing.Point(0, 0);
            this.groupPanelDS.Margin = new System.Windows.Forms.Padding(6);
            this.groupPanelDS.Name = "groupPanelDS";
            this.groupPanelDS.Size = new System.Drawing.Size(1452, 107);
            // 
            // 
            // 
            this.groupPanelDS.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelDS.Style.BackColorGradientAngle = 90;
            this.groupPanelDS.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelDS.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDS.Style.BorderBottomWidth = 1;
            this.groupPanelDS.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelDS.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDS.Style.BorderLeftWidth = 1;
            this.groupPanelDS.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDS.Style.BorderRightWidth = 1;
            this.groupPanelDS.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelDS.Style.BorderTopWidth = 1;
            this.groupPanelDS.Style.CornerDiameter = 4;
            this.groupPanelDS.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelDS.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelDS.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanelDS.TabIndex = 1;
            // 
            // btnXem
            // 
            this.btnXem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXem.Location = new System.Drawing.Point(1006, 30);
            this.btnXem.Margin = new System.Windows.Forms.Padding(6);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(138, 37);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "Xem";
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DisplayMember = "Text";
            this.cmbMonHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.ItemHeight = 14;
            this.cmbMonHoc.Location = new System.Drawing.Point(765, 30);
            this.cmbMonHoc.Margin = new System.Windows.Forms.Padding(6);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(198, 20);
            this.cmbMonHoc.TabIndex = 4;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(671, 30);
            this.labelX3.Margin = new System.Windows.Forms.Padding(6);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(99, 37);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Môn học:";
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DisplayMember = "Text";
            this.cmbHocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.ItemHeight = 14;
            this.cmbHocKy.Location = new System.Drawing.Point(433, 30);
            this.cmbHocKy.Margin = new System.Windows.Forms.Padding(6);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(198, 20);
            this.cmbHocKy.TabIndex = 2;
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(356, 30);
            this.labelX1.Margin = new System.Windows.Forms.Padding(6);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(83, 37);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Học kỳ:";
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.DisplayMember = "Text";
            this.cmbNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.ItemHeight = 14;
            this.cmbNamHoc.Location = new System.Drawing.Point(117, 30);
            this.cmbNamHoc.Margin = new System.Windows.Forms.Padding(6);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(198, 20);
            this.cmbNamHoc.TabIndex = 1;
            this.cmbNamHoc.SelectedIndexChanged += new System.EventHandler(this.cmbNamHoc_SelectedIndexChanged);
            // 
            // labelX0
            // 
            this.labelX0.BackColor = System.Drawing.Color.Transparent;
            this.labelX0.Location = new System.Drawing.Point(22, 30);
            this.labelX0.Margin = new System.Windows.Forms.Padding(6);
            this.labelX0.Name = "labelX0";
            this.labelX0.Size = new System.Drawing.Size(101, 37);
            this.labelX0.TabIndex = 0;
            this.labelX0.Text = "Năm học:";
            // 
            // rpvKQLHMH
            // 
            this.rpvKQLHMH.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "KQLHMonHocDTO";
            reportDataSource1.Value = this.bsKQLHMH;
            this.rpvKQLHMH.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvKQLHMH.LocalReport.ReportEmbeddedResource = "QuanLyHocSinh.Reports.rptKQLHMonHoc.rdlc";
            this.rpvKQLHMH.Location = new System.Drawing.Point(0, 107);
            this.rpvKQLHMH.Margin = new System.Windows.Forms.Padding(6);
            this.rpvKQLHMH.Name = "rpvKQLHMH";
            this.rpvKQLHMH.ServerReport.BearerToken = null;
            this.rpvKQLHMH.Size = new System.Drawing.Size(1452, 753);
            this.rpvKQLHMH.TabIndex = 2;
            // 
            // frmKQLHMonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1452, 860);
            this.Controls.Add(this.rpvKQLHMH);
            this.Controls.Add(this.groupPanelDS);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmKQLHMonHoc";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KẾT QUẢ HỌC KỲ THEO MÔN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmKQLHMonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsKQLHMH)).EndInit();
            this.groupPanelDS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelDS;
        private DevComponents.DotNetBar.ButtonX btnXem;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHoc;
        private DevComponents.DotNetBar.LabelX labelX0;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHocKy;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMonHoc;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.BindingSource bsKQLHMH;
        private Microsoft.Reporting.WinForms.ReportViewer rpvKQLHMH;
    }
}