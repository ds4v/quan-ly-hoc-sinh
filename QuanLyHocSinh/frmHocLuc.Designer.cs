namespace QuanLyHocSinh
{
    partial class frmHocLuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.ctxMenu = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.dgvHocLuc = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaHocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenHocLuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemCanTren = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemCanDuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemKhongChe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorHocLuc = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorExitItem = new System.Windows.Forms.ToolStripButton();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocLuc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocLuc)).BeginInit();
            this.bindingNavigatorHocLuc.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.ctxMenu);
            this.groupBoxDanhSach.Controls.Add(this.dgvHocLuc);
            this.groupBoxDanhSach.Controls.Add(this.bindingNavigatorHocLuc);
            this.groupBoxDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDanhSach.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(494, 318);
            this.groupBoxDanhSach.TabIndex = 1;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách học lực";
            // 
            // ctxMenu
            // 
            this.ctxMenu.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.ctxMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenu});
            this.ctxMenu.Location = new System.Drawing.Point(210, 147);
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(75, 25);
            this.ctxMenu.Stretch = true;
            this.ctxMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenu.TabIndex = 5;
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
            this.btnDelete,
            this.btnSave,
            this.btnClose});
            this.btnMenu.Text = "Menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Image = global::QuanLyHocSinh.Properties.Resources.them;
            this.btnAdd.ImagePaddingHorizontal = 8;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::QuanLyHocSinh.Properties.Resources.xoa;
            this.btnDelete.ImagePaddingHorizontal = 8;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btnDelete.Text = "Xóa dòng được chọn";
            this.btnDelete.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::QuanLyHocSinh.Properties.Resources.luu;
            this.btnSave.ImagePaddingHorizontal = 8;
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Text = "Lưu danh sách";
            this.btnSave.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = global::QuanLyHocSinh.Properties.Resources.thoat;
            this.btnClose.ImagePaddingHorizontal = 8;
            this.btnClose.Name = "btnClose";
            this.btnClose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btnClose.Text = "Đóng cửa sổ này";
            this.btnClose.Click += new System.EventHandler(this.bindingNavigatorExitItem_Click);
            // 
            // dgvHocLuc
            // 
            this.dgvHocLuc.AllowUserToAddRows = false;
            this.dgvHocLuc.AllowUserToResizeColumns = false;
            this.dgvHocLuc.AllowUserToResizeRows = false;
            this.dgvHocLuc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvHocLuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHocLuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHocLuc,
            this.colTenHocLuc,
            this.colDiemCanTren,
            this.colDiemCanDuoi,
            this.colDiemKhongChe});
            this.ctxMenu.SetContextMenuEx(this.dgvHocLuc, this.btnMenu);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHocLuc.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHocLuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHocLuc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvHocLuc.Location = new System.Drawing.Point(3, 51);
            this.dgvHocLuc.Name = "dgvHocLuc";
            this.dgvHocLuc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHocLuc.Size = new System.Drawing.Size(488, 264);
            this.dgvHocLuc.TabIndex = 3;
            // 
            // colMaHocLuc
            // 
            this.colMaHocLuc.DataPropertyName = "MaHocLuc";
            this.colMaHocLuc.HeaderText = "Mã học lực";
            this.colMaHocLuc.MaxInputLength = 6;
            this.colMaHocLuc.Name = "colMaHocLuc";
            this.colMaHocLuc.ReadOnly = true;
            this.colMaHocLuc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaHocLuc.Width = 90;
            // 
            // colTenHocLuc
            // 
            this.colTenHocLuc.DataPropertyName = "TenHocLuc";
            this.colTenHocLuc.HeaderText = "Tên học lực";
            this.colTenHocLuc.MaxInputLength = 30;
            this.colTenHocLuc.Name = "colTenHocLuc";
            this.colTenHocLuc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colDiemCanTren
            // 
            this.colDiemCanTren.DataPropertyName = "DiemCanTren";
            this.colDiemCanTren.HeaderText = "Điểm cận trên";
            this.colDiemCanTren.MaxInputLength = 8;
            this.colDiemCanTren.Name = "colDiemCanTren";
            this.colDiemCanTren.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDiemCanTren.Width = 85;
            // 
            // colDiemCanDuoi
            // 
            this.colDiemCanDuoi.DataPropertyName = "DiemCanDuoi";
            this.colDiemCanDuoi.HeaderText = "Điểm cận dưới";
            this.colDiemCanDuoi.MaxInputLength = 8;
            this.colDiemCanDuoi.Name = "colDiemCanDuoi";
            this.colDiemCanDuoi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDiemCanDuoi.Width = 85;
            // 
            // colDiemKhongChe
            // 
            this.colDiemKhongChe.DataPropertyName = "DiemKhongChe";
            this.colDiemKhongChe.HeaderText = "Điểm khống";
            this.colDiemKhongChe.MaxInputLength = 8;
            this.colDiemKhongChe.Name = "colDiemKhongChe";
            this.colDiemKhongChe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDiemKhongChe.Width = 85;
            // 
            // bindingNavigatorHocLuc
            // 
            this.bindingNavigatorHocLuc.AddNewItem = null;
            this.bindingNavigatorHocLuc.AutoSize = false;
            this.bindingNavigatorHocLuc.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorHocLuc.CountItemFormat = "của {0}";
            this.bindingNavigatorHocLuc.DeleteItem = null;
            this.bindingNavigatorHocLuc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorExitItem});
            this.bindingNavigatorHocLuc.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigatorHocLuc.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorHocLuc.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorHocLuc.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorHocLuc.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorHocLuc.Name = "bindingNavigatorHocLuc";
            this.bindingNavigatorHocLuc.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorHocLuc.Size = new System.Drawing.Size(488, 35);
            this.bindingNavigatorHocLuc.TabIndex = 2;
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
            this.bindingNavigatorAddNewItem.Enabled = false;
            this.bindingNavigatorAddNewItem.Image = global::QuanLyHocSinh.Properties.Resources.them;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorAddNewItem.Text = "Thêm";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = global::QuanLyHocSinh.Properties.Resources.xoa;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Image = global::QuanLyHocSinh.Properties.Resources.luu;
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorSaveItem.Text = "Lưu";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorExitItem
            // 
            this.bindingNavigatorExitItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorExitItem.Image = global::QuanLyHocSinh.Properties.Resources.thoat;
            this.bindingNavigatorExitItem.Name = "bindingNavigatorExitItem";
            this.bindingNavigatorExitItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorExitItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorExitItem.Text = "Thoát";
            this.bindingNavigatorExitItem.Click += new System.EventHandler(this.bindingNavigatorExitItem_Click);
            // 
            // frmHocLuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 318);
            this.ctxMenu.SetContextMenuEx(this, this.btnMenu);
            this.Controls.Add(this.groupBoxDanhSach);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHocLuc";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỌC LỰC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHocLuc_Load);
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocLuc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocLuc)).EndInit();
            this.bindingNavigatorHocLuc.ResumeLayout(false);
            this.bindingNavigatorHocLuc.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Components
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvHocLuc;
        private DevComponents.DotNetBar.ContextMenuBar ctxMenu;
        private DevComponents.DotNetBar.ButtonItem btnMenu;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHocLuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHocLuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemCanTren;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemCanDuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemKhongChe;
        private System.Windows.Forms.BindingNavigator bindingNavigatorHocLuc;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorExitItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        #endregion
    }
}