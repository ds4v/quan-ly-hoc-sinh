namespace QuanLyHocSinh
{
    partial class frmPhanLop
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
            this.splitContainerPhanLop = new System.Windows.Forms.SplitContainer();
            this.panelChaTrai = new System.Windows.Forms.Panel();
            this.lvLopCu = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMaHSCu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTenCu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListPhanLop = new System.Windows.Forms.ImageList(this.components);
            this.panelConTren = new System.Windows.Forms.Panel();
            this.groupPanelLopCu = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbLopCu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbKhoiLopCu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbNamHocCu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.panelConPhai = new System.Windows.Forms.Panel();
            this.btnThoat = new DevComponents.DotNetBar.ButtonX();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnChuyen = new DevComponents.DotNetBar.ButtonX();
            this.lvLopMoi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMaHSMoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTenMoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupPanelLopMoi = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbLopMoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cmbKhoiLopMoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cmbNamHocMoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPhanLop)).BeginInit();
            this.splitContainerPhanLop.Panel1.SuspendLayout();
            this.splitContainerPhanLop.Panel2.SuspendLayout();
            this.splitContainerPhanLop.SuspendLayout();
            this.panelChaTrai.SuspendLayout();
            this.panelConTren.SuspendLayout();
            this.groupPanelLopCu.SuspendLayout();
            this.panelConPhai.SuspendLayout();
            this.groupPanelLopMoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerPhanLop
            // 
            this.splitContainerPhanLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPhanLop.Location = new System.Drawing.Point(0, 0);
            this.splitContainerPhanLop.Name = "splitContainerPhanLop";
            // 
            // splitContainerPhanLop.Panel1
            // 
            this.splitContainerPhanLop.Panel1.Controls.Add(this.panelChaTrai);
            // 
            // splitContainerPhanLop.Panel2
            // 
            this.splitContainerPhanLop.Panel2.Controls.Add(this.lvLopMoi);
            this.splitContainerPhanLop.Panel2.Controls.Add(this.groupPanelLopMoi);
            this.splitContainerPhanLop.Size = new System.Drawing.Size(794, 468);
            this.splitContainerPhanLop.SplitterDistance = 430;
            this.splitContainerPhanLop.TabIndex = 0;
            // 
            // panelChaTrai
            // 
            this.panelChaTrai.Controls.Add(this.lvLopCu);
            this.panelChaTrai.Controls.Add(this.panelConTren);
            this.panelChaTrai.Controls.Add(this.panelConPhai);
            this.panelChaTrai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChaTrai.Location = new System.Drawing.Point(0, 0);
            this.panelChaTrai.Name = "panelChaTrai";
            this.panelChaTrai.Size = new System.Drawing.Size(430, 468);
            this.panelChaTrai.TabIndex = 0;
            // 
            // lvLopCu
            // 
            // 
            // 
            // 
            this.lvLopCu.Border.Class = "ListViewBorder";
            this.lvLopCu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHSCu,
            this.colHoTenCu});
            this.lvLopCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLopCu.FullRowSelect = true;
            this.lvLopCu.Location = new System.Drawing.Point(0, 120);
            this.lvLopCu.Name = "lvLopCu";
            this.lvLopCu.Size = new System.Drawing.Size(360, 348);
            this.lvLopCu.SmallImageList = this.imageListPhanLop;
            this.lvLopCu.TabIndex = 2;
            this.lvLopCu.UseCompatibleStateImageBehavior = false;
            this.lvLopCu.View = System.Windows.Forms.View.Details;
            // 
            // colMaHSCu
            // 
            this.colMaHSCu.Text = "Mã học sinh";
            this.colMaHSCu.Width = 90;
            // 
            // colHoTenCu
            // 
            this.colHoTenCu.Text = "Họ và tên";
            this.colHoTenCu.Width = 267;
            // 
            // imageListPhanLop
            // 
            this.imageListPhanLop.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageListPhanLop.ImageSize = new System.Drawing.Size(1, 18);
            this.imageListPhanLop.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panelConTren
            // 
            this.panelConTren.Controls.Add(this.groupPanelLopCu);
            this.panelConTren.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConTren.Location = new System.Drawing.Point(0, 0);
            this.panelConTren.Name = "panelConTren";
            this.panelConTren.Size = new System.Drawing.Size(360, 120);
            this.panelConTren.TabIndex = 0;
            // 
            // groupPanelLopCu
            // 
            this.groupPanelLopCu.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelLopCu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelLopCu.Controls.Add(this.cmbLopCu);
            this.groupPanelLopCu.Controls.Add(this.cmbKhoiLopCu);
            this.groupPanelLopCu.Controls.Add(this.cmbNamHocCu);
            this.groupPanelLopCu.Controls.Add(this.labelX3);
            this.groupPanelLopCu.Controls.Add(this.labelX2);
            this.groupPanelLopCu.Controls.Add(this.labelX1);
            this.groupPanelLopCu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanelLopCu.Location = new System.Drawing.Point(0, 0);
            this.groupPanelLopCu.Name = "groupPanelLopCu";
            this.groupPanelLopCu.Size = new System.Drawing.Size(360, 120);
            // 
            // 
            // 
            this.groupPanelLopCu.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelLopCu.Style.BackColorGradientAngle = 90;
            this.groupPanelLopCu.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelLopCu.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopCu.Style.BorderBottomWidth = 1;
            this.groupPanelLopCu.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelLopCu.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopCu.Style.BorderLeftWidth = 1;
            this.groupPanelLopCu.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopCu.Style.BorderRightWidth = 1;
            this.groupPanelLopCu.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopCu.Style.BorderTopWidth = 1;
            this.groupPanelLopCu.Style.CornerDiameter = 4;
            this.groupPanelLopCu.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelLopCu.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelLopCu.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelLopCu.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanelLopCu.TabIndex = 1;
            this.groupPanelLopCu.Text = "Thông tin lớp cũ";
            // 
            // cmbLopCu
            // 
            this.cmbLopCu.DisplayMember = "Text";
            this.cmbLopCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLopCu.FormattingEnabled = true;
            this.cmbLopCu.ItemHeight = 14;
            this.cmbLopCu.Location = new System.Drawing.Point(120, 70);
            this.cmbLopCu.Name = "cmbLopCu";
            this.cmbLopCu.Size = new System.Drawing.Size(121, 20);
            this.cmbLopCu.TabIndex = 3;
            this.cmbLopCu.SelectedIndexChanged += new System.EventHandler(this.cmbLopCu_SelectedIndexChanged);
            // 
            // cmbKhoiLopCu
            // 
            this.cmbKhoiLopCu.DisplayMember = "Text";
            this.cmbKhoiLopCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKhoiLopCu.FormattingEnabled = true;
            this.cmbKhoiLopCu.ItemHeight = 14;
            this.cmbKhoiLopCu.Location = new System.Drawing.Point(120, 40);
            this.cmbKhoiLopCu.Name = "cmbKhoiLopCu";
            this.cmbKhoiLopCu.Size = new System.Drawing.Size(121, 20);
            this.cmbKhoiLopCu.TabIndex = 2;
            this.cmbKhoiLopCu.SelectedIndexChanged += new System.EventHandler(this.cmbKhoiLopCu_SelectedIndexChanged);
            // 
            // cmbNamHocCu
            // 
            this.cmbNamHocCu.DisplayMember = "Text";
            this.cmbNamHocCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHocCu.FormattingEnabled = true;
            this.cmbNamHocCu.ItemHeight = 14;
            this.cmbNamHocCu.Location = new System.Drawing.Point(120, 10);
            this.cmbNamHocCu.Name = "cmbNamHocCu";
            this.cmbNamHocCu.Size = new System.Drawing.Size(121, 20);
            this.cmbNamHocCu.TabIndex = 1;
            this.cmbNamHocCu.SelectedIndexChanged += new System.EventHandler(this.cmbNamHocCu_SelectedIndexChanged);
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(50, 70);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(57, 19);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Lớp:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(50, 40);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(57, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Khối lớp:";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(50, 10);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(57, 20);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Năm học:";
            // 
            // panelConPhai
            // 
            this.panelConPhai.Controls.Add(this.btnThoat);
            this.panelConPhai.Controls.Add(this.btnLuu);
            this.panelConPhai.Controls.Add(this.btnXoa);
            this.panelConPhai.Controls.Add(this.btnChuyen);
            this.panelConPhai.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelConPhai.Location = new System.Drawing.Point(360, 0);
            this.panelConPhai.Name = "panelConPhai";
            this.panelConPhai.Size = new System.Drawing.Size(70, 468);
            this.panelConPhai.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThoat.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThoat.Image = global::QuanLyHocSinh.Properties.Resources.thoat_phan_lop;
            this.btnThoat.Location = new System.Drawing.Point(9, 370);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(55, 55);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Tooltip = "Đóng bảng phân lớp";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Image = global::QuanLyHocSinh.Properties.Resources.luu_chuyen_lop;
            this.btnLuu.Location = new System.Drawing.Point(9, 300);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(55, 55);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Tooltip = "Lưu bảng phân lớp";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Image = global::QuanLyHocSinh.Properties.Resources.xoa_chuyen_lop;
            this.btnXoa.Location = new System.Drawing.Point(9, 230);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(55, 55);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Tooltip = "Xóa học sinh khỏi lớp mới";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChuyen
            // 
            this.btnChuyen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChuyen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChuyen.Image = global::QuanLyHocSinh.Properties.Resources.chuyen_lop;
            this.btnChuyen.Location = new System.Drawing.Point(9, 160);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(55, 55);
            this.btnChuyen.TabIndex = 1;
            this.btnChuyen.Tooltip = "Chuyển lớp";
            this.btnChuyen.Click += new System.EventHandler(this.btnChuyen_Click);
            // 
            // lvLopMoi
            // 
            // 
            // 
            // 
            this.lvLopMoi.Border.Class = "ListViewBorder";
            this.lvLopMoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHSMoi,
            this.colHoTenMoi});
            this.lvLopMoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLopMoi.FullRowSelect = true;
            this.lvLopMoi.Location = new System.Drawing.Point(0, 120);
            this.lvLopMoi.Name = "lvLopMoi";
            this.lvLopMoi.Size = new System.Drawing.Size(360, 348);
            this.lvLopMoi.SmallImageList = this.imageListPhanLop;
            this.lvLopMoi.TabIndex = 5;
            this.lvLopMoi.UseCompatibleStateImageBehavior = false;
            this.lvLopMoi.View = System.Windows.Forms.View.Details;
            // 
            // colMaHSMoi
            // 
            this.colMaHSMoi.Text = "Mã học sinh";
            this.colMaHSMoi.Width = 90;
            // 
            // colHoTenMoi
            // 
            this.colHoTenMoi.Text = "Họ và tên";
            this.colHoTenMoi.Width = 267;
            // 
            // groupPanelLopMoi
            // 
            this.groupPanelLopMoi.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelLopMoi.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelLopMoi.Controls.Add(this.cmbLopMoi);
            this.groupPanelLopMoi.Controls.Add(this.labelX5);
            this.groupPanelLopMoi.Controls.Add(this.cmbKhoiLopMoi);
            this.groupPanelLopMoi.Controls.Add(this.labelX4);
            this.groupPanelLopMoi.Controls.Add(this.cmbNamHocMoi);
            this.groupPanelLopMoi.Controls.Add(this.labelX6);
            this.groupPanelLopMoi.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanelLopMoi.Location = new System.Drawing.Point(0, 0);
            this.groupPanelLopMoi.Name = "groupPanelLopMoi";
            this.groupPanelLopMoi.Size = new System.Drawing.Size(360, 120);
            // 
            // 
            // 
            this.groupPanelLopMoi.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelLopMoi.Style.BackColorGradientAngle = 90;
            this.groupPanelLopMoi.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelLopMoi.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopMoi.Style.BorderBottomWidth = 1;
            this.groupPanelLopMoi.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelLopMoi.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopMoi.Style.BorderLeftWidth = 1;
            this.groupPanelLopMoi.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopMoi.Style.BorderRightWidth = 1;
            this.groupPanelLopMoi.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopMoi.Style.BorderTopWidth = 1;
            this.groupPanelLopMoi.Style.CornerDiameter = 4;
            this.groupPanelLopMoi.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelLopMoi.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelLopMoi.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelLopMoi.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanelLopMoi.TabIndex = 4;
            this.groupPanelLopMoi.Text = "Thông tin lớp mới";
            // 
            // cmbLopMoi
            // 
            this.cmbLopMoi.DisplayMember = "Text";
            this.cmbLopMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLopMoi.FormattingEnabled = true;
            this.cmbLopMoi.ItemHeight = 14;
            this.cmbLopMoi.Location = new System.Drawing.Point(120, 70);
            this.cmbLopMoi.Name = "cmbLopMoi";
            this.cmbLopMoi.Size = new System.Drawing.Size(121, 20);
            this.cmbLopMoi.TabIndex = 3;
            this.cmbLopMoi.SelectedIndexChanged += new System.EventHandler(this.cmbLopMoi_SelectedIndexChanged);
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(50, 40);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(57, 23);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Khối lớp:";
            // 
            // cmbKhoiLopMoi
            // 
            this.cmbKhoiLopMoi.DisplayMember = "Text";
            this.cmbKhoiLopMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKhoiLopMoi.FormattingEnabled = true;
            this.cmbKhoiLopMoi.ItemHeight = 14;
            this.cmbKhoiLopMoi.Location = new System.Drawing.Point(120, 40);
            this.cmbKhoiLopMoi.Name = "cmbKhoiLopMoi";
            this.cmbKhoiLopMoi.Size = new System.Drawing.Size(121, 20);
            this.cmbKhoiLopMoi.TabIndex = 2;
            this.cmbKhoiLopMoi.SelectedIndexChanged += new System.EventHandler(this.cmbKhoiLopMoi_SelectedIndexChanged);
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(50, 10);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(57, 20);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Năm học:";
            // 
            // cmbNamHocMoi
            // 
            this.cmbNamHocMoi.DisplayMember = "Text";
            this.cmbNamHocMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHocMoi.FormattingEnabled = true;
            this.cmbNamHocMoi.ItemHeight = 14;
            this.cmbNamHocMoi.Location = new System.Drawing.Point(120, 10);
            this.cmbNamHocMoi.Name = "cmbNamHocMoi";
            this.cmbNamHocMoi.Size = new System.Drawing.Size(121, 20);
            this.cmbNamHocMoi.TabIndex = 1;
            this.cmbNamHocMoi.SelectedIndexChanged += new System.EventHandler(this.cmbNamHocMoi_SelectedIndexChanged);
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Location = new System.Drawing.Point(50, 70);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(57, 19);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Lớp:";
            // 
            // frmPhanLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 468);
            this.Controls.Add(this.splitContainerPhanLop);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPhanLop";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHÂN LỚP HỌC SINH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhanLop_Load);
            this.splitContainerPhanLop.Panel1.ResumeLayout(false);
            this.splitContainerPhanLop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPhanLop)).EndInit();
            this.splitContainerPhanLop.ResumeLayout(false);
            this.panelChaTrai.ResumeLayout(false);
            this.panelConTren.ResumeLayout(false);
            this.groupPanelLopCu.ResumeLayout(false);
            this.panelConPhai.ResumeLayout(false);
            this.groupPanelLopMoi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        #region Components
        private System.Windows.Forms.SplitContainer splitContainerPhanLop;
        private System.Windows.Forms.Panel panelChaTrai;
        private System.Windows.Forms.Panel panelConPhai;
        private System.Windows.Forms.Panel panelConTren;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelLopMoi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKhoiLopMoi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHocMoi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLopMoi;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelLopCu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLopCu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKhoiLopCu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHocCu;
        private DevComponents.DotNetBar.Controls.ListViewEx lvLopCu;
        private DevComponents.DotNetBar.Controls.ListViewEx lvLopMoi;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnChuyen;
        private DevComponents.DotNetBar.ButtonX btnThoat;
        private System.Windows.Forms.ColumnHeader colMaHSCu;
        private System.Windows.Forms.ColumnHeader colHoTenCu;
        private System.Windows.Forms.ColumnHeader colMaHSMoi;
        private System.Windows.Forms.ColumnHeader colHoTenMoi;
        private System.Windows.Forms.ImageList imageListPhanLop;
        #endregion
    }
}