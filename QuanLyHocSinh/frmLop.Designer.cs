namespace QuanLyHocSinh
{
    partial class frmLop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLop));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.ctxMenu = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefesh = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.dgvLop = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaKhoiLop = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSiSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNamHoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaGiaoVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingNavigatorLop = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorExitItem = new System.Windows.Forms.ToolStripButton();
            this.navPaneRight = new DevComponents.DotNetBar.NavigationPane();
            this.navPanelNhapDuLieu = new DevComponents.DotNetBar.NavigationPanePanel();
            this.cmbNamHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbKhoiLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.iniSiSo = new DevComponents.Editors.IntegerInput();
            this.btnLuuVaoDS = new DevComponents.DotNetBar.ButtonX();
            this.btnThemKhoiLop = new DevComponents.DotNetBar.ButtonX();
            this.btnThemNamHoc = new DevComponents.DotNetBar.ButtonX();
            this.btnThemGiaoVien = new DevComponents.DotNetBar.ButtonX();
            this.label01 = new System.Windows.Forms.Label();
            this.label03 = new System.Windows.Forms.Label();
            this.cmbGiaoVien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label02 = new System.Windows.Forms.Label();
            this.txtMaLop = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label06 = new System.Windows.Forms.Label();
            this.label05 = new System.Windows.Forms.Label();
            this.label04 = new System.Windows.Forms.Label();
            this.txtTenLop = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonItemNhapDuLieu = new DevComponents.DotNetBar.ButtonItem();
            this.navPanelTimKiem = new DevComponents.DotNetBar.NavigationPanePanel();
            this.label07 = new System.Windows.Forms.Label();
            this.chkTimTheoTen = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkTimTheoMa = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonItemTimKiem = new DevComponents.DotNetBar.ButtonItem();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLop)).BeginInit();
            this.bindingNavigatorLop.SuspendLayout();
            this.navPaneRight.SuspendLayout();
            this.navPanelNhapDuLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iniSiSo)).BeginInit();
            this.navPanelTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.ctxMenu);
            this.groupBoxDanhSach.Controls.Add(this.dgvLop);
            this.groupBoxDanhSach.Controls.Add(this.bindingNavigatorLop);
            this.groupBoxDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDanhSach.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(527, 443);
            this.groupBoxDanhSach.TabIndex = 3;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách lớp";
            // 
            // ctxMenu
            // 
            this.ctxMenu.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.ctxMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenu});
            this.ctxMenu.Location = new System.Drawing.Point(279, 203);
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(75, 25);
            this.ctxMenu.Stretch = true;
            this.ctxMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenu.TabIndex = 4;
            this.ctxMenu.TabStop = false;
            this.ctxMenu.Text = "ctxMenu";
            // 
            // btnMenu
            // 
            this.btnMenu.AutoExpandOnClick = true;
            this.btnMenu.ImagePaddingHorizontal = 8;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnRefesh,
            this.btnDelete,
            this.btnSave,
            this.btnClose});
            this.btnMenu.Text = "Menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImagePaddingHorizontal = 8;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefesh.Image")));
            this.btnRefesh.ImagePaddingHorizontal = 8;
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnRefesh.Text = "Làm tươi danh dách";
            this.btnRefesh.Click += new System.EventHandler(this.bindingNavigatorRefreshItem_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImagePaddingHorizontal = 8;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btnDelete.Text = "Xóa dòng được chọn";
            this.btnDelete.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImagePaddingHorizontal = 8;
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Text = "Lưu danh sách";
            this.btnSave.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImagePaddingHorizontal = 8;
            this.btnClose.Name = "btnClose";
            this.btnClose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btnClose.Text = "Đóng cửa sổ này";
            this.btnClose.Click += new System.EventHandler(this.bindingNavigatorExitItem_Click);
            // 
            // dgvLop
            // 
            this.dgvLop.AllowUserToAddRows = false;
            this.dgvLop.AllowUserToResizeColumns = false;
            this.dgvLop.AllowUserToResizeRows = false;
            this.dgvLop.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvLop.ColumnHeadersHeight = 34;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaLop,
            this.colTenLop,
            this.colMaKhoiLop,
            this.colSiSo,
            this.colMaNamHoc,
            this.colMaGiaoVien});
            this.ctxMenu.SetContextMenuEx(this.dgvLop, this.btnMenu);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLop.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLop.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvLop.Location = new System.Drawing.Point(3, 51);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersWidth = 62;
            this.dgvLop.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvLop.Size = new System.Drawing.Size(521, 389);
            this.dgvLop.TabIndex = 5;
            // 
            // colMaLop
            // 
            this.colMaLop.DataPropertyName = "MaLop";
            this.colMaLop.HeaderText = "Mã lớp";
            this.colMaLop.MaxInputLength = 10;
            this.colMaLop.MinimumWidth = 8;
            this.colMaLop.Name = "colMaLop";
            this.colMaLop.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaLop.Width = 80;
            // 
            // colTenLop
            // 
            this.colTenLop.DataPropertyName = "TenLop";
            this.colTenLop.HeaderText = "Tên lớp";
            this.colTenLop.MaxInputLength = 30;
            this.colTenLop.MinimumWidth = 8;
            this.colTenLop.Name = "colTenLop";
            this.colTenLop.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTenLop.Width = 80;
            // 
            // colMaKhoiLop
            // 
            this.colMaKhoiLop.DataPropertyName = "MaKhoiLop";
            this.colMaKhoiLop.HeaderText = "Khối lớp";
            this.colMaKhoiLop.MinimumWidth = 8;
            this.colMaKhoiLop.Name = "colMaKhoiLop";
            this.colMaKhoiLop.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaKhoiLop.Width = 150;
            // 
            // colSiSo
            // 
            this.colSiSo.DataPropertyName = "SiSo";
            this.colSiSo.HeaderText = "Sỉ số";
            this.colSiSo.MaxInputLength = 2;
            this.colSiSo.MinimumWidth = 8;
            this.colSiSo.Name = "colSiSo";
            this.colSiSo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSiSo.Width = 60;
            // 
            // colMaNamHoc
            // 
            this.colMaNamHoc.DataPropertyName = "MaNamHoc";
            this.colMaNamHoc.HeaderText = "Năm học";
            this.colMaNamHoc.MinimumWidth = 8;
            this.colMaNamHoc.Name = "colMaNamHoc";
            this.colMaNamHoc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaNamHoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMaNamHoc.Width = 150;
            // 
            // colMaGiaoVien
            // 
            this.colMaGiaoVien.DataPropertyName = "MaGiaoVien";
            this.colMaGiaoVien.HeaderText = "Giáo viên chủ nhiệm";
            this.colMaGiaoVien.MinimumWidth = 8;
            this.colMaGiaoVien.Name = "colMaGiaoVien";
            this.colMaGiaoVien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaGiaoVien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colMaGiaoVien.Width = 150;
            // 
            // bindingNavigatorLop
            // 
            this.bindingNavigatorLop.AddNewItem = null;
            this.bindingNavigatorLop.AutoSize = false;
            this.bindingNavigatorLop.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorLop.CountItemFormat = "của {0}";
            this.bindingNavigatorLop.DeleteItem = null;
            this.bindingNavigatorLop.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.bindingNavigatorLop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorRefreshItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorExitItem});
            this.bindingNavigatorLop.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigatorLop.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorLop.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorLop.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorLop.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorLop.Name = "bindingNavigatorLop";
            this.bindingNavigatorLop.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.bindingNavigatorLop.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorLop.Size = new System.Drawing.Size(521, 35);
            this.bindingNavigatorLop.TabIndex = 4;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 32);
            this.bindingNavigatorCountItem.Text = "của {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Tổng số dòng trong danh sách";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::QuanLyHocSinh.Properties.Resources.dong_dau;
            this.bindingNavigatorMoveFirstItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Đến đầu danh sách";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::QuanLyHocSinh.Properties.Resources.dong_truoc;
            this.bindingNavigatorMovePreviousItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Trở lại dòng trước";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Vị trí hiện tại";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::QuanLyHocSinh.Properties.Resources.dong_truoc;
            this.bindingNavigatorMoveNextItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveNextItem.Text = "Tới dòng kế tiếp";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::QuanLyHocSinh.Properties.Resources.dong_dau;
            this.bindingNavigatorMoveLastItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveLastItem.Text = "Đến cuối danh sách";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorAddNewItem.Text = "Thêm";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorRefreshItem
            // 
            this.bindingNavigatorRefreshItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorRefreshItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorRefreshItem.Image")));
            this.bindingNavigatorRefreshItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorRefreshItem.Name = "bindingNavigatorRefreshItem";
            this.bindingNavigatorRefreshItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorRefreshItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorRefreshItem.Text = "Làm tươi danh sách";
            this.bindingNavigatorRefreshItem.Click += new System.EventHandler(this.bindingNavigatorRefreshItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorSaveItem.Text = "Lưu";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorExitItem
            // 
            this.bindingNavigatorExitItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorExitItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorExitItem.Image")));
            this.bindingNavigatorExitItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorExitItem.Name = "bindingNavigatorExitItem";
            this.bindingNavigatorExitItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorExitItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorExitItem.Text = "Thoát";
            this.bindingNavigatorExitItem.Click += new System.EventHandler(this.bindingNavigatorExitItem_Click);
            // 
            // navPaneRight
            // 
            this.navPaneRight.CanCollapse = true;
            this.navPaneRight.Controls.Add(this.navPanelNhapDuLieu);
            this.navPaneRight.Controls.Add(this.navPanelTimKiem);
            this.navPaneRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.navPaneRight.ItemPaddingBottom = 2;
            this.navPaneRight.ItemPaddingTop = 2;
            this.navPaneRight.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemNhapDuLieu,
            this.buttonItemTimKiem});
            this.navPaneRight.Location = new System.Drawing.Point(527, 0);
            this.navPaneRight.Name = "navPaneRight";
            this.navPaneRight.NavigationBarHeight = 86;
            this.navPaneRight.Padding = new System.Windows.Forms.Padding(1);
            this.navPaneRight.Size = new System.Drawing.Size(267, 443);
            this.navPaneRight.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPaneRight.TabIndex = 0;
            this.navPaneRight.TitleButtonAlignment = DevComponents.DotNetBar.eTitleButtonAlignment.Left;
            // 
            // 
            // 
            this.navPaneRight.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPaneRight.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPaneRight.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPaneRight.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.navPaneRight.TitlePanel.Name = "panelTitle";
            this.navPaneRight.TitlePanel.Size = new System.Drawing.Size(265, 24);
            this.navPaneRight.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navPaneRight.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.navPaneRight.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.navPaneRight.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPaneRight.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.navPaneRight.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navPaneRight.TitlePanel.Style.GradientAngle = 90;
            this.navPaneRight.TitlePanel.Style.MarginLeft = 4;
            this.navPaneRight.TitlePanel.TabIndex = 0;
            this.navPaneRight.TitlePanel.Text = "    Nhập liệu thông tin";
            // 
            // navPanelNhapDuLieu
            // 
            this.navPanelNhapDuLieu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPanelNhapDuLieu.Controls.Add(this.cmbNamHoc);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbKhoiLop);
            this.navPanelNhapDuLieu.Controls.Add(this.iniSiSo);
            this.navPanelNhapDuLieu.Controls.Add(this.btnLuuVaoDS);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemKhoiLop);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemNamHoc);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemGiaoVien);
            this.navPanelNhapDuLieu.Controls.Add(this.label01);
            this.navPanelNhapDuLieu.Controls.Add(this.label03);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbGiaoVien);
            this.navPanelNhapDuLieu.Controls.Add(this.label02);
            this.navPanelNhapDuLieu.Controls.Add(this.txtMaLop);
            this.navPanelNhapDuLieu.Controls.Add(this.label06);
            this.navPanelNhapDuLieu.Controls.Add(this.label05);
            this.navPanelNhapDuLieu.Controls.Add(this.label04);
            this.navPanelNhapDuLieu.Controls.Add(this.txtTenLop);
            this.navPanelNhapDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanelNhapDuLieu.Location = new System.Drawing.Point(1, 25);
            this.navPanelNhapDuLieu.Margin = new System.Windows.Forms.Padding(2);
            this.navPanelNhapDuLieu.Name = "navPanelNhapDuLieu";
            this.navPanelNhapDuLieu.ParentItem = this.buttonItemNhapDuLieu;
            this.navPanelNhapDuLieu.Size = new System.Drawing.Size(265, 331);
            this.navPanelNhapDuLieu.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navPanelNhapDuLieu.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navPanelNhapDuLieu.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navPanelNhapDuLieu.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPanelNhapDuLieu.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navPanelNhapDuLieu.Style.GradientAngle = 90;
            this.navPanelNhapDuLieu.TabIndex = 1;
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.DisplayMember = "Text";
            this.cmbNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.ItemHeight = 14;
            this.cmbNamHoc.Location = new System.Drawing.Point(16, 204);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(208, 20);
            this.cmbNamHoc.TabIndex = 6;
            // 
            // cmbKhoiLop
            // 
            this.cmbKhoiLop.DisplayMember = "Text";
            this.cmbKhoiLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKhoiLop.FormattingEnabled = true;
            this.cmbKhoiLop.ItemHeight = 14;
            this.cmbKhoiLop.Location = new System.Drawing.Point(16, 159);
            this.cmbKhoiLop.Name = "cmbKhoiLop";
            this.cmbKhoiLop.Size = new System.Drawing.Size(208, 20);
            this.cmbKhoiLop.TabIndex = 4;
            // 
            // iniSiSo
            // 
            // 
            // 
            // 
            this.iniSiSo.BackgroundStyle.Class = "DateTimeInputBackground";
            this.iniSiSo.InputHorizontalAlignment = DevComponents.Editors.eHorizontalAlignment.Left;
            this.iniSiSo.Location = new System.Drawing.Point(16, 115);
            this.iniSiSo.MaxValue = 100;
            this.iniSiSo.MinValue = 0;
            this.iniSiSo.Name = "iniSiSo";
            this.iniSiSo.ShowUpDown = true;
            this.iniSiSo.Size = new System.Drawing.Size(209, 20);
            this.iniSiSo.TabIndex = 8;
            // 
            // btnLuuVaoDS
            // 
            this.btnLuuVaoDS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuVaoDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnLuuVaoDS.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnLuuVaoDS.Location = new System.Drawing.Point(16, 291);
            this.btnLuuVaoDS.Name = "btnLuuVaoDS";
            this.btnLuuVaoDS.Size = new System.Drawing.Size(233, 23);
            this.btnLuuVaoDS.TabIndex = 11;
            this.btnLuuVaoDS.Text = "Lưu vào danh sách";
            this.btnLuuVaoDS.Click += new System.EventHandler(this.btnLuuVaoDS_Click);
            // 
            // btnThemKhoiLop
            // 
            this.btnThemKhoiLop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemKhoiLop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemKhoiLop.Image = ((System.Drawing.Image)(resources.GetObject("btnThemKhoiLop.Image")));
            this.btnThemKhoiLop.Location = new System.Drawing.Point(229, 159);
            this.btnThemKhoiLop.Name = "btnThemKhoiLop";
            this.btnThemKhoiLop.Size = new System.Drawing.Size(20, 20);
            this.btnThemKhoiLop.TabIndex = 5;
            this.btnThemKhoiLop.Click += new System.EventHandler(this.btnThemKhoiLop_Click);
            // 
            // btnThemNamHoc
            // 
            this.btnThemNamHoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemNamHoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemNamHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNamHoc.Image")));
            this.btnThemNamHoc.Location = new System.Drawing.Point(229, 204);
            this.btnThemNamHoc.Name = "btnThemNamHoc";
            this.btnThemNamHoc.Size = new System.Drawing.Size(20, 20);
            this.btnThemNamHoc.TabIndex = 7;
            this.btnThemNamHoc.Click += new System.EventHandler(this.btnThemNamHoc_Click);
            // 
            // btnThemGiaoVien
            // 
            this.btnThemGiaoVien.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemGiaoVien.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemGiaoVien.Image = ((System.Drawing.Image)(resources.GetObject("btnThemGiaoVien.Image")));
            this.btnThemGiaoVien.Location = new System.Drawing.Point(229, 250);
            this.btnThemGiaoVien.Name = "btnThemGiaoVien";
            this.btnThemGiaoVien.Size = new System.Drawing.Size(20, 20);
            this.btnThemGiaoVien.TabIndex = 10;
            this.btnThemGiaoVien.Click += new System.EventHandler(this.btnThemGiaoVien_Click);
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Location = new System.Drawing.Point(13, 10);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(42, 13);
            this.label01.TabIndex = 0;
            this.label01.Text = "Mã lớp:";
            // 
            // label03
            // 
            this.label03.AutoSize = true;
            this.label03.Location = new System.Drawing.Point(13, 144);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(48, 13);
            this.label03.TabIndex = 0;
            this.label03.Text = "Khối lớp:";
            // 
            // cmbGiaoVien
            // 
            this.cmbGiaoVien.DisplayMember = "Text";
            this.cmbGiaoVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGiaoVien.FormattingEnabled = true;
            this.cmbGiaoVien.ItemHeight = 14;
            this.cmbGiaoVien.Location = new System.Drawing.Point(16, 250);
            this.cmbGiaoVien.Name = "cmbGiaoVien";
            this.cmbGiaoVien.Size = new System.Drawing.Size(208, 20);
            this.cmbGiaoVien.TabIndex = 9;
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Location = new System.Drawing.Point(13, 55);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(46, 13);
            this.label02.TabIndex = 0;
            this.label02.Text = "Tên lớp:";
            // 
            // txtMaLop
            // 
            // 
            // 
            // 
            this.txtMaLop.Border.Class = "TextBoxBorder";
            this.txtMaLop.Location = new System.Drawing.Point(16, 25);
            this.txtMaLop.MaxLength = 10;
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(209, 20);
            this.txtMaLop.TabIndex = 2;
            // 
            // label06
            // 
            this.label06.AutoSize = true;
            this.label06.Location = new System.Drawing.Point(13, 235);
            this.label06.Name = "label06";
            this.label06.Size = new System.Drawing.Size(107, 13);
            this.label06.TabIndex = 0;
            this.label06.Text = "Giáo viên chủ nhiệm:";
            // 
            // label05
            // 
            this.label05.AutoSize = true;
            this.label05.Location = new System.Drawing.Point(13, 100);
            this.label05.Name = "label05";
            this.label05.Size = new System.Drawing.Size(50, 13);
            this.label05.TabIndex = 0;
            this.label05.Text = "Sỉ số lớp:";
            // 
            // label04
            // 
            this.label04.AutoSize = true;
            this.label04.Location = new System.Drawing.Point(13, 189);
            this.label04.Name = "label04";
            this.label04.Size = new System.Drawing.Size(53, 13);
            this.label04.TabIndex = 0;
            this.label04.Text = "Năm học:";
            // 
            // txtTenLop
            // 
            // 
            // 
            // 
            this.txtTenLop.Border.Class = "TextBoxBorder";
            this.txtTenLop.Location = new System.Drawing.Point(16, 70);
            this.txtTenLop.MaxLength = 30;
            this.txtTenLop.Name = "txtTenLop";
            this.txtTenLop.Size = new System.Drawing.Size(209, 20);
            this.txtTenLop.TabIndex = 3;
            // 
            // buttonItemNhapDuLieu
            // 
            this.buttonItemNhapDuLieu.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemNhapDuLieu.Checked = true;
            this.buttonItemNhapDuLieu.Image = global::QuanLyHocSinh.Properties.Resources.thong_tin;
            this.buttonItemNhapDuLieu.ImagePaddingHorizontal = 8;
            this.buttonItemNhapDuLieu.Name = "buttonItemNhapDuLieu";
            this.buttonItemNhapDuLieu.OptionGroup = "navBar";
            this.buttonItemNhapDuLieu.Text = "    Nhập liệu thông tin";
            // 
            // navPanelTimKiem
            // 
            this.navPanelTimKiem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPanelTimKiem.Controls.Add(this.label07);
            this.navPanelTimKiem.Controls.Add(this.chkTimTheoTen);
            this.navPanelTimKiem.Controls.Add(this.chkTimTheoMa);
            this.navPanelTimKiem.Controls.Add(this.btnTimKiem);
            this.navPanelTimKiem.Controls.Add(this.txtTimKiem);
            this.navPanelTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanelTimKiem.Location = new System.Drawing.Point(1, 1);
            this.navPanelTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.navPanelTimKiem.Name = "navPanelTimKiem";
            this.navPanelTimKiem.ParentItem = this.buttonItemTimKiem;
            this.navPanelTimKiem.Size = new System.Drawing.Size(265, 441);
            this.navPanelTimKiem.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navPanelTimKiem.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navPanelTimKiem.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navPanelTimKiem.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPanelTimKiem.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navPanelTimKiem.Style.GradientAngle = 90;
            this.navPanelTimKiem.TabIndex = 2;
            // 
            // label07
            // 
            this.label07.AutoSize = true;
            this.label07.Location = new System.Drawing.Point(8, 10);
            this.label07.Name = "label07";
            this.label07.Size = new System.Drawing.Size(121, 13);
            this.label07.TabIndex = 0;
            this.label07.Text = "Nhập thông tin tìm kiếm:";
            // 
            // chkTimTheoTen
            // 
            this.chkTimTheoTen.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkTimTheoTen.Location = new System.Drawing.Point(8, 75);
            this.chkTimTheoTen.Name = "chkTimTheoTen";
            this.chkTimTheoTen.Size = new System.Drawing.Size(163, 23);
            this.chkTimTheoTen.TabIndex = 5;
            this.chkTimTheoTen.Text = "Tìm theo tên lớp";
            // 
            // chkTimTheoMa
            // 
            this.chkTimTheoMa.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkTimTheoMa.Checked = true;
            this.chkTimTheoMa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTimTheoMa.CheckValue = "Y";
            this.chkTimTheoMa.Location = new System.Drawing.Point(8, 50);
            this.chkTimTheoMa.Name = "chkTimTheoMa";
            this.chkTimTheoMa.Size = new System.Drawing.Size(163, 23);
            this.chkTimTheoMa.TabIndex = 4;
            this.chkTimTheoMa.Text = "Tìm theo mã lớp";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnTimKiem.Location = new System.Drawing.Point(11, 105);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(160, 23);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Location = new System.Drawing.Point(11, 25);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(160, 20);
            this.txtTimKiem.TabIndex = 3;
            this.txtTimKiem.WatermarkText = "Nhập thông tin cần tìm vào đây";
            // 
            // buttonItemTimKiem
            // 
            this.buttonItemTimKiem.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemTimKiem.Image = global::QuanLyHocSinh.Properties.Resources.thong_tin;
            this.buttonItemTimKiem.ImagePaddingHorizontal = 8;
            this.buttonItemTimKiem.Name = "buttonItemTimKiem";
            this.buttonItemTimKiem.OptionGroup = "navBar";
            this.buttonItemTimKiem.Text = "    Tìm kiếm thông tin";
            // 
            // frmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 443);
            this.ctxMenu.SetContextMenuEx(this, this.btnMenu);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Controls.Add(this.navPaneRight);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLop";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LỚP";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmLop_Load);
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorLop)).EndInit();
            this.bindingNavigatorLop.ResumeLayout(false);
            this.bindingNavigatorLop.PerformLayout();
            this.navPaneRight.ResumeLayout(false);
            this.navPanelNhapDuLieu.ResumeLayout(false);
            this.navPanelNhapDuLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iniSiSo)).EndInit();
            this.navPanelTimKiem.ResumeLayout(false);
            this.navPanelTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Components
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private DevComponents.Editors.IntegerInput iniSiSo;
        private DevComponents.DotNetBar.ContextMenuBar ctxMenu;
        private DevComponents.DotNetBar.ButtonItem btnMenu;
        private DevComponents.DotNetBar.NavigationPane navPaneRight;
        private DevComponents.DotNetBar.NavigationPanePanel navPanelNhapDuLieu;
        private DevComponents.DotNetBar.ButtonItem buttonItemNhapDuLieu;
        private DevComponents.DotNetBar.NavigationPanePanel navPanelTimKiem;
        private DevComponents.DotNetBar.ButtonItem buttonItemTimKiem;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.DotNetBar.ButtonX btnLuuVaoDS;
        private DevComponents.DotNetBar.ButtonX btnThemGiaoVien;
        private DevComponents.DotNetBar.ButtonX btnThemKhoiLop;
        private DevComponents.DotNetBar.ButtonX btnThemNamHoc;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvLop;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbGiaoVien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaLop;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenLop;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkTimTheoTen;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkTimTheoMa;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKhoiLop;
        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Label label06;
        private System.Windows.Forms.Label label04;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.Label label03;
        private System.Windows.Forms.Label label05;
        private System.Windows.Forms.Label label07;
        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigatorLop;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorExitItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenLop;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaKhoiLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiSo;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaNamHoc;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaGiaoVien;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnRefesh;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnClose;
    }
}