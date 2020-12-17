namespace QuanLyHocSinh
{
    partial class frmHocSinh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHocSinh));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.ctxMenu = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefesh = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.dgvHocSinh = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioiTinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNgaySinh = new QuanLyHocSinh.Components.CalendarColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaDanToc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaTonGiao = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colHoTenCha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNgheCha = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colHoTenMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNgheMe = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorHocSinh = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.groupPanelGioiTinh = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.ckbGTinhNam = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ckbGTinhNu = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lblBuffer = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.btnLuuVaoDS = new DevComponents.DotNetBar.ButtonX();
            this.btnThemNgheMe = new DevComponents.DotNetBar.ButtonX();
            this.btnThemNgheCha = new DevComponents.DotNetBar.ButtonX();
            this.btnThemDanToc = new DevComponents.DotNetBar.ButtonX();
            this.btnThemTonGiao = new DevComponents.DotNetBar.ButtonX();
            this.label02 = new System.Windows.Forms.Label();
            this.label04 = new System.Windows.Forms.Label();
            this.cmbNgheNghiepMe = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbNgheNghiepCha = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbDanToc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbTonGiao = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label03 = new System.Windows.Forms.Label();
            this.txtMaHocSinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label08 = new System.Windows.Forms.Label();
            this.label06 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label09 = new System.Windows.Forms.Label();
            this.txtHoTenMe = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label07 = new System.Windows.Forms.Label();
            this.txtHoTenCha = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label05 = new System.Windows.Forms.Label();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenHocSinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtGioiTinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonItemNhapDuLieu = new DevComponents.DotNetBar.ButtonItem();
            this.navPanelTimKiem = new DevComponents.DotNetBar.NavigationPanePanel();
            this.label01 = new System.Windows.Forms.Label();
            this.chkTimTheoTen = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkTimTheoMa = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonItemTimKiem = new DevComponents.DotNetBar.ButtonItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendarColumn1 = new QuanLyHocSinh.Components.CalendarColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocSinh)).BeginInit();
            this.bindingNavigatorHocSinh.SuspendLayout();
            this.navPaneRight.SuspendLayout();
            this.navPanelNhapDuLieu.SuspendLayout();
            this.groupPanelGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh)).BeginInit();
            this.navPanelTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.ctxMenu);
            this.groupBoxDanhSach.Controls.Add(this.dgvHocSinh);
            this.groupBoxDanhSach.Controls.Add(this.bindingNavigatorHocSinh);
            this.groupBoxDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDanhSach.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(996, 536);
            this.groupBoxDanhSach.TabIndex = 3;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách học sinh";
            // 
            // ctxMenu
            // 
            this.ctxMenu.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.ctxMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenu});
            this.ctxMenu.Location = new System.Drawing.Point(354, 222);
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
            this.btnAdd.Image = global::QuanLyHocSinh.Properties.Resources.them;
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
            // dgvHocSinh
            // 
            this.dgvHocSinh.AllowUserToAddRows = false;
            this.dgvHocSinh.AllowUserToResizeRows = false;
            this.dgvHocSinh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHocSinh,
            this.colHoTen,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colDiaChi,
            this.colMaDanToc,
            this.colMaTonGiao,
            this.colHoTenCha,
            this.colMaNgheCha,
            this.colHoTenMe,
            this.colMaNgheMe,
            this.colEmail});
            this.ctxMenu.SetContextMenuEx(this.dgvHocSinh, this.btnMenu);
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHocSinh.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvHocSinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocSinh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvHocSinh.Location = new System.Drawing.Point(3, 51);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.Size = new System.Drawing.Size(990, 482);
            this.dgvHocSinh.TabIndex = 5;
            // 
            // colMaHocSinh
            // 
            this.colMaHocSinh.DataPropertyName = "MaHocSinh";
            this.colMaHocSinh.HeaderText = "Mã học sinh";
            this.colMaHocSinh.MaxInputLength = 6;
            this.colMaHocSinh.Name = "colMaHocSinh";
            this.colMaHocSinh.Width = 80;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.MaxInputLength = 30;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 150;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.DataPropertyName = "GioiTinh";
            this.colGioiTinh.HeaderText = "Giới tính nữ";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Width = 70;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.colNgaySinh.DefaultCellStyle = dataGridViewCellStyle4;
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Width = 85;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.MaxInputLength = 50;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Width = 150;
            // 
            // colMaDanToc
            // 
            this.colMaDanToc.DataPropertyName = "MaDanToc";
            this.colMaDanToc.HeaderText = "Dân tộc";
            this.colMaDanToc.Name = "colMaDanToc";
            // 
            // colMaTonGiao
            // 
            this.colMaTonGiao.DataPropertyName = "MaTonGiao";
            this.colMaTonGiao.HeaderText = "Tôn giáo";
            this.colMaTonGiao.Name = "colMaTonGiao";
            // 
            // colHoTenCha
            // 
            this.colHoTenCha.DataPropertyName = "HoTenCha";
            this.colHoTenCha.HeaderText = "Họ tên cha";
            this.colHoTenCha.MaxInputLength = 30;
            this.colHoTenCha.Name = "colHoTenCha";
            this.colHoTenCha.Width = 150;
            // 
            // colMaNgheCha
            // 
            this.colMaNgheCha.DataPropertyName = "MaNgheCha";
            this.colMaNgheCha.HeaderText = "Nghề nghiệp cha";
            this.colMaNgheCha.Name = "colMaNgheCha";
            // 
            // colHoTenMe
            // 
            this.colHoTenMe.DataPropertyName = "HoTenMe";
            this.colHoTenMe.HeaderText = "Họ tên mẹ";
            this.colHoTenMe.MaxInputLength = 30;
            this.colHoTenMe.Name = "colHoTenMe";
            this.colHoTenMe.Width = 150;
            // 
            // colMaNgheMe
            // 
            this.colMaNgheMe.DataPropertyName = "MaNgheMe";
            this.colMaNgheMe.HeaderText = "Nghề nghiệp mẹ";
            this.colMaNgheMe.Name = "colMaNgheMe";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 150;
            // 
            // bindingNavigatorHocSinh
            // 
            this.bindingNavigatorHocSinh.AddNewItem = null;
            this.bindingNavigatorHocSinh.AutoSize = false;
            this.bindingNavigatorHocSinh.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorHocSinh.CountItemFormat = "của {0}";
            this.bindingNavigatorHocSinh.DeleteItem = null;
            this.bindingNavigatorHocSinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorHocSinh.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigatorHocSinh.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorHocSinh.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorHocSinh.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorHocSinh.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorHocSinh.Name = "bindingNavigatorHocSinh";
            this.bindingNavigatorHocSinh.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorHocSinh.Size = new System.Drawing.Size(990, 35);
            this.bindingNavigatorHocSinh.TabIndex = 4;
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
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Đến đầu danh sách";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::QuanLyHocSinh.Properties.Resources.dong_truoc;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
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
            this.bindingNavigatorRefreshItem.Name = "bindingNavigatorRefreshItem";
            this.bindingNavigatorRefreshItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorRefreshItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorRefreshItem.Text = "Làm tươi danh dách";
            this.bindingNavigatorRefreshItem.Click += new System.EventHandler(this.bindingNavigatorRefreshItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
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
            this.navPaneRight.Location = new System.Drawing.Point(996, 0);
            this.navPaneRight.Name = "navPaneRight";
            this.navPaneRight.NavigationBarHeight = 86;
            this.navPaneRight.Padding = new System.Windows.Forms.Padding(1);
            this.navPaneRight.Size = new System.Drawing.Size(267, 536);
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
            this.navPanelNhapDuLieu.AutoScroll = true;
            this.navPanelNhapDuLieu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPanelNhapDuLieu.Controls.Add(this.label1);
            this.navPanelNhapDuLieu.Controls.Add(this.txtEmail);
            this.navPanelNhapDuLieu.Controls.Add(this.groupPanelGioiTinh);
            this.navPanelNhapDuLieu.Controls.Add(this.lblBuffer);
            this.navPanelNhapDuLieu.Controls.Add(this.dtpNgaySinh);
            this.navPanelNhapDuLieu.Controls.Add(this.btnLuuVaoDS);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemNgheMe);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemNgheCha);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemDanToc);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemTonGiao);
            this.navPanelNhapDuLieu.Controls.Add(this.label02);
            this.navPanelNhapDuLieu.Controls.Add(this.label04);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbNgheNghiepMe);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbNgheNghiepCha);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbDanToc);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbTonGiao);
            this.navPanelNhapDuLieu.Controls.Add(this.label03);
            this.navPanelNhapDuLieu.Controls.Add(this.txtMaHocSinh);
            this.navPanelNhapDuLieu.Controls.Add(this.label12);
            this.navPanelNhapDuLieu.Controls.Add(this.label10);
            this.navPanelNhapDuLieu.Controls.Add(this.label08);
            this.navPanelNhapDuLieu.Controls.Add(this.label06);
            this.navPanelNhapDuLieu.Controls.Add(this.label11);
            this.navPanelNhapDuLieu.Controls.Add(this.label09);
            this.navPanelNhapDuLieu.Controls.Add(this.txtHoTenMe);
            this.navPanelNhapDuLieu.Controls.Add(this.label07);
            this.navPanelNhapDuLieu.Controls.Add(this.txtHoTenCha);
            this.navPanelNhapDuLieu.Controls.Add(this.label05);
            this.navPanelNhapDuLieu.Controls.Add(this.txtDiaChi);
            this.navPanelNhapDuLieu.Controls.Add(this.txtTenHocSinh);
            this.navPanelNhapDuLieu.Controls.Add(this.txtGioiTinh);
            this.navPanelNhapDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanelNhapDuLieu.Location = new System.Drawing.Point(1, 25);
            this.navPanelNhapDuLieu.Name = "navPanelNhapDuLieu";
            this.navPanelNhapDuLieu.ParentItem = this.buttonItemNhapDuLieu;
            this.navPanelNhapDuLieu.Size = new System.Drawing.Size(265, 424);
            this.navPanelNhapDuLieu.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navPanelNhapDuLieu.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navPanelNhapDuLieu.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navPanelNhapDuLieu.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPanelNhapDuLieu.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navPanelNhapDuLieu.Style.GradientAngle = 90;
            this.navPanelNhapDuLieu.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 507);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Email:";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Location = new System.Drawing.Point(16, 523);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(196, 20);
            this.txtEmail.TabIndex = 22;
            // 
            // groupPanelGioiTinh
            // 
            this.groupPanelGioiTinh.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelGioiTinh.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelGioiTinh.Controls.Add(this.ckbGTinhNam);
            this.groupPanelGioiTinh.Controls.Add(this.ckbGTinhNu);
            this.groupPanelGioiTinh.Location = new System.Drawing.Point(16, 117);
            this.groupPanelGioiTinh.Name = "groupPanelGioiTinh";
            this.groupPanelGioiTinh.Size = new System.Drawing.Size(196, 24);
            // 
            // 
            // 
            this.groupPanelGioiTinh.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelGioiTinh.Style.BackColorGradientAngle = 90;
            this.groupPanelGioiTinh.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelGioiTinh.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelGioiTinh.Style.BorderBottomWidth = 1;
            this.groupPanelGioiTinh.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelGioiTinh.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelGioiTinh.Style.BorderLeftWidth = 1;
            this.groupPanelGioiTinh.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelGioiTinh.Style.BorderRightWidth = 1;
            this.groupPanelGioiTinh.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelGioiTinh.Style.BorderTopWidth = 1;
            this.groupPanelGioiTinh.Style.CornerDiameter = 4;
            this.groupPanelGioiTinh.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelGioiTinh.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelGioiTinh.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelGioiTinh.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanelGioiTinh.TabIndex = 4;
            // 
            // ckbGTinhNam
            // 
            this.ckbGTinhNam.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.ckbGTinhNam.Location = new System.Drawing.Point(11, 0);
            this.ckbGTinhNam.Name = "ckbGTinhNam";
            this.ckbGTinhNam.Size = new System.Drawing.Size(60, 18);
            this.ckbGTinhNam.TabIndex = 1;
            this.ckbGTinhNam.Text = "Nam";
            // 
            // ckbGTinhNu
            // 
            this.ckbGTinhNu.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.ckbGTinhNu.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ckbGTinhNu.Location = new System.Drawing.Point(81, 0);
            this.ckbGTinhNu.Name = "ckbGTinhNu";
            this.ckbGTinhNu.Size = new System.Drawing.Size(60, 18);
            this.ckbGTinhNu.TabIndex = 2;
            this.ckbGTinhNu.Text = "Nữ";
            // 
            // lblBuffer
            // 
            this.lblBuffer.AutoSize = true;
            this.lblBuffer.Enabled = false;
            this.lblBuffer.Location = new System.Drawing.Point(8, 624);
            this.lblBuffer.Name = "lblBuffer";
            this.lblBuffer.Size = new System.Drawing.Size(0, 13);
            this.lblBuffer.TabIndex = 0;
            // 
            // dtpNgaySinh
            // 
            // 
            // 
            // 
            this.dtpNgaySinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpNgaySinh.ButtonDropDown.Visible = true;
            this.dtpNgaySinh.Location = new System.Drawing.Point(16, 162);
            this.dtpNgaySinh.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtpNgaySinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpNgaySinh.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpNgaySinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpNgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2008, 11, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpNgaySinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpNgaySinh.MonthCalendar.TodayButtonVisible = true;
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(196, 20);
            this.dtpNgaySinh.TabIndex = 5;
            // 
            // btnLuuVaoDS
            // 
            this.btnLuuVaoDS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuVaoDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnLuuVaoDS.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnLuuVaoDS.Location = new System.Drawing.Point(15, 562);
            this.btnLuuVaoDS.Name = "btnLuuVaoDS";
            this.btnLuuVaoDS.Size = new System.Drawing.Size(223, 23);
            this.btnLuuVaoDS.TabIndex = 17;
            this.btnLuuVaoDS.Text = "Lưu vào danh sách";
            this.btnLuuVaoDS.Click += new System.EventHandler(this.btnLuuVaoDS_Click);
            // 
            // btnThemNgheMe
            // 
            this.btnThemNgheMe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemNgheMe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemNgheMe.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNgheMe.Image")));
            this.btnThemNgheMe.Location = new System.Drawing.Point(218, 477);
            this.btnThemNgheMe.Name = "btnThemNgheMe";
            this.btnThemNgheMe.Size = new System.Drawing.Size(20, 20);
            this.btnThemNgheMe.TabIndex = 16;
            this.btnThemNgheMe.Click += new System.EventHandler(this.btnThemNgheMe_Click);
            // 
            // btnThemNgheCha
            // 
            this.btnThemNgheCha.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemNgheCha.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemNgheCha.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNgheCha.Image")));
            this.btnThemNgheCha.Location = new System.Drawing.Point(218, 387);
            this.btnThemNgheCha.Name = "btnThemNgheCha";
            this.btnThemNgheCha.Size = new System.Drawing.Size(20, 20);
            this.btnThemNgheCha.TabIndex = 13;
            this.btnThemNgheCha.Click += new System.EventHandler(this.btnThemNgheCha_Click);
            // 
            // btnThemDanToc
            // 
            this.btnThemDanToc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemDanToc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemDanToc.Image = ((System.Drawing.Image)(resources.GetObject("btnThemDanToc.Image")));
            this.btnThemDanToc.Location = new System.Drawing.Point(218, 252);
            this.btnThemDanToc.Name = "btnThemDanToc";
            this.btnThemDanToc.Size = new System.Drawing.Size(20, 20);
            this.btnThemDanToc.TabIndex = 8;
            this.btnThemDanToc.Click += new System.EventHandler(this.btnThemDanToc_Click);
            // 
            // btnThemTonGiao
            // 
            this.btnThemTonGiao.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemTonGiao.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemTonGiao.Image = ((System.Drawing.Image)(resources.GetObject("btnThemTonGiao.Image")));
            this.btnThemTonGiao.Location = new System.Drawing.Point(218, 297);
            this.btnThemTonGiao.Name = "btnThemTonGiao";
            this.btnThemTonGiao.Size = new System.Drawing.Size(20, 20);
            this.btnThemTonGiao.TabIndex = 10;
            this.btnThemTonGiao.Click += new System.EventHandler(this.btnThemTonGiao_Click);
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Location = new System.Drawing.Point(13, 13);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(68, 13);
            this.label02.TabIndex = 0;
            this.label02.Text = "Mã học sinh:";
            // 
            // label04
            // 
            this.label04.AutoSize = true;
            this.label04.Location = new System.Drawing.Point(13, 102);
            this.label04.Name = "label04";
            this.label04.Size = new System.Drawing.Size(50, 13);
            this.label04.TabIndex = 0;
            this.label04.Text = "Giới tính:";
            // 
            // cmbNgheNghiepMe
            // 
            this.cmbNgheNghiepMe.DisplayMember = "Text";
            this.cmbNgheNghiepMe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNgheNghiepMe.FormattingEnabled = true;
            this.cmbNgheNghiepMe.ItemHeight = 14;
            this.cmbNgheNghiepMe.Location = new System.Drawing.Point(16, 477);
            this.cmbNgheNghiepMe.Name = "cmbNgheNghiepMe";
            this.cmbNgheNghiepMe.Size = new System.Drawing.Size(196, 20);
            this.cmbNgheNghiepMe.TabIndex = 15;
            // 
            // cmbNgheNghiepCha
            // 
            this.cmbNgheNghiepCha.DisplayMember = "Text";
            this.cmbNgheNghiepCha.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNgheNghiepCha.FormattingEnabled = true;
            this.cmbNgheNghiepCha.ItemHeight = 14;
            this.cmbNgheNghiepCha.Location = new System.Drawing.Point(16, 387);
            this.cmbNgheNghiepCha.Name = "cmbNgheNghiepCha";
            this.cmbNgheNghiepCha.Size = new System.Drawing.Size(196, 20);
            this.cmbNgheNghiepCha.TabIndex = 12;
            // 
            // cmbDanToc
            // 
            this.cmbDanToc.DisplayMember = "Text";
            this.cmbDanToc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDanToc.FormattingEnabled = true;
            this.cmbDanToc.ItemHeight = 14;
            this.cmbDanToc.Location = new System.Drawing.Point(16, 252);
            this.cmbDanToc.Name = "cmbDanToc";
            this.cmbDanToc.Size = new System.Drawing.Size(196, 20);
            this.cmbDanToc.TabIndex = 7;
            // 
            // cmbTonGiao
            // 
            this.cmbTonGiao.DisplayMember = "Text";
            this.cmbTonGiao.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTonGiao.FormattingEnabled = true;
            this.cmbTonGiao.ItemHeight = 14;
            this.cmbTonGiao.Location = new System.Drawing.Point(16, 297);
            this.cmbTonGiao.Name = "cmbTonGiao";
            this.cmbTonGiao.Size = new System.Drawing.Size(196, 20);
            this.cmbTonGiao.TabIndex = 9;
            // 
            // label03
            // 
            this.label03.AutoSize = true;
            this.label03.Location = new System.Drawing.Point(13, 57);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(72, 13);
            this.label03.TabIndex = 0;
            this.label03.Text = "Tên học sinh:";
            // 
            // txtMaHocSinh
            // 
            // 
            // 
            // 
            this.txtMaHocSinh.Border.Class = "TextBoxBorder";
            this.txtMaHocSinh.Location = new System.Drawing.Point(16, 30);
            this.txtMaHocSinh.MaxLength = 6;
            this.txtMaHocSinh.Name = "txtMaHocSinh";
            this.txtMaHocSinh.Size = new System.Drawing.Size(196, 20);
            this.txtMaHocSinh.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 462);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Nghề nghiệp mẹ:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nghề nghiệp cha:";
            // 
            // label08
            // 
            this.label08.AutoSize = true;
            this.label08.Location = new System.Drawing.Point(13, 282);
            this.label08.Name = "label08";
            this.label08.Size = new System.Drawing.Size(52, 13);
            this.label08.TabIndex = 0;
            this.label08.Text = "Tôn giáo:";
            // 
            // label06
            // 
            this.label06.AutoSize = true;
            this.label06.Location = new System.Drawing.Point(13, 192);
            this.label06.Name = "label06";
            this.label06.Size = new System.Drawing.Size(43, 13);
            this.label06.TabIndex = 0;
            this.label06.Text = "Địa chỉ:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 417);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Họ tên mẹ:";
            // 
            // label09
            // 
            this.label09.AutoSize = true;
            this.label09.Location = new System.Drawing.Point(13, 327);
            this.label09.Name = "label09";
            this.label09.Size = new System.Drawing.Size(63, 13);
            this.label09.TabIndex = 0;
            this.label09.Text = "Họ tên cha:";
            // 
            // txtHoTenMe
            // 
            // 
            // 
            // 
            this.txtHoTenMe.Border.Class = "TextBoxBorder";
            this.txtHoTenMe.Location = new System.Drawing.Point(16, 432);
            this.txtHoTenMe.MaxLength = 30;
            this.txtHoTenMe.Name = "txtHoTenMe";
            this.txtHoTenMe.Size = new System.Drawing.Size(196, 20);
            this.txtHoTenMe.TabIndex = 14;
            // 
            // label07
            // 
            this.label07.AutoSize = true;
            this.label07.Location = new System.Drawing.Point(13, 237);
            this.label07.Name = "label07";
            this.label07.Size = new System.Drawing.Size(48, 13);
            this.label07.TabIndex = 0;
            this.label07.Text = "Dân tộc:";
            // 
            // txtHoTenCha
            // 
            // 
            // 
            // 
            this.txtHoTenCha.Border.Class = "TextBoxBorder";
            this.txtHoTenCha.Location = new System.Drawing.Point(16, 342);
            this.txtHoTenCha.MaxLength = 30;
            this.txtHoTenCha.Name = "txtHoTenCha";
            this.txtHoTenCha.Size = new System.Drawing.Size(196, 20);
            this.txtHoTenCha.TabIndex = 11;
            // 
            // label05
            // 
            this.label05.AutoSize = true;
            this.label05.Location = new System.Drawing.Point(13, 147);
            this.label05.Name = "label05";
            this.label05.Size = new System.Drawing.Size(57, 13);
            this.label05.TabIndex = 0;
            this.label05.Text = "Ngày sinh:";
            // 
            // txtDiaChi
            // 
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Location = new System.Drawing.Point(16, 207);
            this.txtDiaChi.MaxLength = 50;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(196, 20);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtTenHocSinh
            // 
            // 
            // 
            // 
            this.txtTenHocSinh.Border.Class = "TextBoxBorder";
            this.txtTenHocSinh.Location = new System.Drawing.Point(16, 72);
            this.txtTenHocSinh.MaxLength = 30;
            this.txtTenHocSinh.Name = "txtTenHocSinh";
            this.txtTenHocSinh.Size = new System.Drawing.Size(196, 20);
            this.txtTenHocSinh.TabIndex = 3;
            // 
            // txtGioiTinh
            // 
            // 
            // 
            // 
            this.txtGioiTinh.Border.Class = "TextBoxBorder";
            this.txtGioiTinh.Location = new System.Drawing.Point(68, 30);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.ReadOnly = true;
            this.txtGioiTinh.Size = new System.Drawing.Size(54, 20);
            this.txtGioiTinh.TabIndex = 20;
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
            this.navPanelTimKiem.AutoScroll = true;
            this.navPanelTimKiem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPanelTimKiem.Controls.Add(this.label01);
            this.navPanelTimKiem.Controls.Add(this.chkTimTheoTen);
            this.navPanelTimKiem.Controls.Add(this.chkTimTheoMa);
            this.navPanelTimKiem.Controls.Add(this.btnTimKiem);
            this.navPanelTimKiem.Controls.Add(this.txtTimKiem);
            this.navPanelTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanelTimKiem.Location = new System.Drawing.Point(1, 1);
            this.navPanelTimKiem.Name = "navPanelTimKiem";
            this.navPanelTimKiem.ParentItem = this.buttonItemTimKiem;
            this.navPanelTimKiem.Size = new System.Drawing.Size(265, 448);
            this.navPanelTimKiem.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navPanelTimKiem.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navPanelTimKiem.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navPanelTimKiem.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPanelTimKiem.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navPanelTimKiem.Style.GradientAngle = 90;
            this.navPanelTimKiem.TabIndex = 2;
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Location = new System.Drawing.Point(8, 10);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(121, 13);
            this.label01.TabIndex = 0;
            this.label01.Text = "Nhập thông tin tìm kiếm:";
            // 
            // chkTimTheoTen
            // 
            this.chkTimTheoTen.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkTimTheoTen.Location = new System.Drawing.Point(8, 75);
            this.chkTimTheoTen.Name = "chkTimTheoTen";
            this.chkTimTheoTen.Size = new System.Drawing.Size(163, 23);
            this.chkTimTheoTen.TabIndex = 5;
            this.chkTimTheoTen.Text = "Tìm theo tên học sinh";
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
            this.chkTimTheoMa.Text = "Tìm theo mã học sinh";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnTimKiem.Location = new System.Drawing.Point(11, 105);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(170, 23);
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
            this.txtTimKiem.Size = new System.Drawing.Size(170, 20);
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
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaHocSinh";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã học sinh";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HoTen";
            this.dataGridViewTextBoxColumn2.HeaderText = "Họ và tên";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 30;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // calendarColumn1
            // 
            this.calendarColumn1.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle2.Format = "dd/MM/yyyy";
            this.calendarColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.calendarColumn1.HeaderText = "Ngày sinh";
            this.calendarColumn1.Name = "calendarColumn1";
            this.calendarColumn1.Width = 85;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NoiSinh";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nơi sinh";
            this.dataGridViewTextBoxColumn3.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "HoTenCha";
            this.dataGridViewTextBoxColumn4.HeaderText = "Họ tên cha";
            this.dataGridViewTextBoxColumn4.MaxInputLength = 30;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "HoTenMe";
            this.dataGridViewTextBoxColumn5.HeaderText = "Họ tên mẹ";
            this.dataGridViewTextBoxColumn5.MaxInputLength = 30;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn6.HeaderText = "Email";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // frmHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 536);
            this.ctxMenu.SetContextMenuEx(this, this.btnMenu);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Controls.Add(this.navPaneRight);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHocSinh";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỌC SINH";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHocSinh_Load);
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocSinh)).EndInit();
            this.bindingNavigatorHocSinh.ResumeLayout(false);
            this.bindingNavigatorHocSinh.PerformLayout();
            this.navPaneRight.ResumeLayout(false);
            this.navPanelNhapDuLieu.ResumeLayout(false);
            this.navPanelNhapDuLieu.PerformLayout();
            this.groupPanelGioiTinh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh)).EndInit();
            this.navPanelTimKiem.ResumeLayout(false);
            this.navPanelTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Components
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private DevComponents.DotNetBar.ContextMenuBar ctxMenu;
        private DevComponents.DotNetBar.ButtonItem btnMenu;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private DevComponents.DotNetBar.NavigationPane navPaneRight;
        private DevComponents.DotNetBar.NavigationPanePanel navPanelNhapDuLieu;
        private DevComponents.DotNetBar.ButtonItem buttonItemNhapDuLieu;
        private DevComponents.DotNetBar.NavigationPanePanel navPanelTimKiem;
        private DevComponents.DotNetBar.ButtonItem buttonItemTimKiem;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.DotNetBar.ButtonItem btnRefesh;
        private DevComponents.DotNetBar.ButtonX btnThemNgheCha;
        private DevComponents.DotNetBar.ButtonX btnThemTonGiao;
        private DevComponents.DotNetBar.ButtonX btnThemNgheMe;
        private DevComponents.DotNetBar.ButtonX btnThemDanToc;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvHocSinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaHocSinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenHocSinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkTimTheoTen;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkTimTheoMa;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoTenCha;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNgheNghiepMe;
        private DevComponents.DotNetBar.Controls.TextBoxX txtHoTenMe;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbGTinhNu;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbGTinhNam;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelGioiTinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGioiTinh;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbDanToc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNgheNghiepCha;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbTonGiao;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.Label label06;
        private System.Windows.Forms.Label label05;
        private System.Windows.Forms.Label label03;
        private System.Windows.Forms.Label label04;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label09;
        private System.Windows.Forms.Label label08;
        private System.Windows.Forms.Label label07;
        private System.Windows.Forms.Label lblBuffer;
        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpNgaySinh;
        private System.Windows.Forms.BindingNavigator bindingNavigatorHocSinh;
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
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorExitItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        #endregion
        private DevComponents.DotNetBar.ButtonX btnLuuVaoDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Components.CalendarColumn calendarColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGioiTinh;
        private Components.CalendarColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaDanToc;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaTonGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTenCha;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaNgheCha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTenMe;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaNgheMe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
    }
}