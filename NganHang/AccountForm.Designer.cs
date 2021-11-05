
namespace NganHang
{
    partial class AccountForm
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
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label9;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barMenu = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveToFile = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnRedo = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.pnControlBranch = new DevExpress.XtraEditors.PanelControl();
            this.cmbBranch = new System.Windows.Forms.ComboBox();
            this.lbChiNhanh = new System.Windows.Forms.Label();
            this.gcAccount = new DevExpress.XtraGrid.GridControl();
            this.gvAccount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.columnMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnLoginName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnFullname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.columnGroup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbUserId = new System.Windows.Forms.TextBox();
            this.tbLoginName = new System.Windows.Forms.TextBox();
            this.tbFullname = new System.Windows.Forms.TextBox();
            this.tbGroup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnAccount = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.gcStaff = new DevExpress.XtraGrid.GridControl();
            this.gvStaff = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pncStaff = new DevExpress.XtraEditors.PanelControl();
            this.tbStaffBranch = new System.Windows.Forms.TextBox();
            this.tbStaffPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbStaffGender = new System.Windows.Forms.TextBox();
            this.tbStaffId = new System.Windows.Forms.TextBox();
            this.tbStaffAddress = new System.Windows.Forms.TextBox();
            this.tbRegisterPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRegisterLogin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbStaffLastName = new System.Windows.Forms.TextBox();
            this.tbStaffFirstName = new System.Windows.Forms.TextBox();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControlBranch)).BeginInit();
            this.pnControlBranch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAccount)).BeginInit();
            this.pnAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncStaff)).BeginInit();
            this.pncStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(33, 99);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 2;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(29, 159);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(30, 13);
            tENLabel.TabIndex = 4;
            tENLabel.Text = "TEN:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(357, 40);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(50, 13);
            mACNLabel.TabIndex = 28;
            mACNLabel.Text = "DIA CHI:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(20, 38);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(39, 13);
            mANVLabel.TabIndex = 29;
            mANVLabel.Text = "MANV:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(372, 101);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(35, 13);
            label5.TabIndex = 31;
            label5.Text = "PHAI:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(377, 161);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(30, 13);
            label6.TabIndex = 33;
            label6.Text = "SDT:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new System.Drawing.Point(767, 161);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(40, 13);
            label9.TabIndex = 35;
            label9.Text = "MACN:";
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMenu,
            this.bar3});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControl1);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnAdd,
            this.btnDelete,
            this.btnSave,
            this.btnRestore,
            this.btnSaveToFile,
            this.btnQuit,
            this.btnReload,
            this.btnEdit,
            this.btnUndo,
            this.btnRedo});
            this.barManager.MainMenu = this.barMenu;
            this.barManager.MaxItemId = 10;
            this.barManager.StatusBar = this.bar3;
            // 
            // barMenu
            // 
            this.barMenu.BarName = "Main menu";
            this.barMenu.DockCol = 0;
            this.barMenu.DockRow = 0;
            this.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRestore),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveToFile),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnRedo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnQuit)});
            this.barMenu.OptionsBar.MultiLine = true;
            this.barMenu.OptionsBar.UseWholeRow = true;
            this.barMenu.Text = "Main menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Id = 0;
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.LargeImage")));
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAdd_ItemClick);
            // 
            // btnEdit
            // 
            this.btnEdit.Caption = "Sửa";
            this.btnEdit.Hint = "F2";
            this.btnEdit.Id = 7;
            this.btnEdit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.Image")));
            this.btnEdit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnEdit.ImageOptions.LargeImage")));
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEdit_ItemClick);
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Ghi";
            this.btnSave.Hint = "Crtl + S";
            this.btnSave.Id = 2;
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.LargeImage")));
            this.btnSave.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S));
            this.btnSave.Name = "btnSave";
            this.btnSave.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSave_ItemClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa";
            this.btnDelete.Hint = "Delete";
            this.btnDelete.Id = 1;
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.Delete);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDelete_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Tải lại";
            this.btnReload.Hint = "F5";
            this.btnReload.Id = 6;
            this.btnReload.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.Image")));
            this.btnReload.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnReload.ImageOptions.LargeImage")));
            this.btnReload.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.btnReload.Name = "btnReload";
            this.btnReload.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnRestore
            // 
            this.btnRestore.Caption = "Phục Hồi";
            this.btnRestore.Id = 3;
            this.btnRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.Image")));
            this.btnRestore.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRestore.ImageOptions.LargeImage")));
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRestore_ItemClick);
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Caption = "Xuất File";
            this.btnSaveToFile.Id = 4;
            this.btnSaveToFile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveToFile.ImageOptions.Image")));
            this.btnSaveToFile.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSaveToFile.ImageOptions.LargeImage")));
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnSaveToFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveToFile_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Undo";
            this.btnUndo.Enabled = false;
            this.btnUndo.Hint = "Ctrl + Z";
            this.btnUndo.Id = 8;
            this.btnUndo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.Image")));
            this.btnUndo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUndo.ImageOptions.LargeImage")));
            this.btnUndo.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnRedo
            // 
            this.btnRedo.Caption = "Redo";
            this.btnRedo.Enabled = false;
            this.btnRedo.Hint = "Ctrl + Y";
            this.btnRedo.Id = 9;
            this.btnRedo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRedo.ImageOptions.Image")));
            this.btnRedo.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnRedo.ImageOptions.LargeImage")));
            this.btnRedo.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y));
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnRedo_ItemClick);
            // 
            // btnQuit
            // 
            this.btnQuit.Caption = "Thoát";
            this.btnQuit.Hint = "Ctrl + W";
            this.btnQuit.Id = 5;
            this.btnQuit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.ImageOptions.Image")));
            this.btnQuit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnQuit.ImageOptions.LargeImage")));
            this.btnQuit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W));
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnQuit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuit_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1041, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 944);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1041, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 920);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1041, 24);
            this.barDockControl1.Manager = this.barManager;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(0, 920);
            // 
            // pnControlBranch
            // 
            this.pnControlBranch.Controls.Add(this.cmbBranch);
            this.pnControlBranch.Controls.Add(this.lbChiNhanh);
            this.pnControlBranch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnControlBranch.Location = new System.Drawing.Point(0, 24);
            this.pnControlBranch.Name = "pnControlBranch";
            this.pnControlBranch.Size = new System.Drawing.Size(1041, 63);
            this.pnControlBranch.TabIndex = 5;
            // 
            // cmbBranch
            // 
            this.cmbBranch.FormattingEnabled = true;
            this.cmbBranch.Location = new System.Drawing.Point(100, 23);
            this.cmbBranch.Name = "cmbBranch";
            this.cmbBranch.Size = new System.Drawing.Size(253, 21);
            this.cmbBranch.TabIndex = 1;
            this.cmbBranch.SelectedIndexChanged += new System.EventHandler(this.cmbBranch_SelectedIndexChanged);
            // 
            // lbChiNhanh
            // 
            this.lbChiNhanh.AutoSize = true;
            this.lbChiNhanh.Location = new System.Drawing.Point(39, 26);
            this.lbChiNhanh.Name = "lbChiNhanh";
            this.lbChiNhanh.Size = new System.Drawing.Size(55, 13);
            this.lbChiNhanh.TabIndex = 0;
            this.lbChiNhanh.Text = "Chi nhánh";
            // 
            // gcAccount
            // 
            this.gcAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcAccount.Location = new System.Drawing.Point(0, 87);
            this.gcAccount.MainView = this.gvAccount;
            this.gcAccount.MenuManager = this.barManager;
            this.gcAccount.Name = "gcAccount";
            this.gcAccount.Size = new System.Drawing.Size(1041, 200);
            this.gcAccount.TabIndex = 10;
            this.gcAccount.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAccount});
            this.gcAccount.DataSourceChanged += new System.EventHandler(this.gcAccount_DataSourceChanged);
            // 
            // gvAccount
            // 
            this.gvAccount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.columnMANV,
            this.columnLoginName,
            this.columnFullname,
            this.columnGroup});
            this.gvAccount.GridControl = this.gcAccount;
            this.gvAccount.Name = "gvAccount";
            this.gvAccount.OptionsBehavior.Editable = false;
            this.gvAccount.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvAccount_FocusedRowChanged_1);
            // 
            // columnMANV
            // 
            this.columnMANV.FieldName = "MANV";
            this.columnMANV.Name = "columnMANV";
            this.columnMANV.Visible = true;
            this.columnMANV.VisibleIndex = 0;
            // 
            // columnLoginName
            // 
            this.columnLoginName.FieldName = "LOGIN";
            this.columnLoginName.Name = "columnLoginName";
            this.columnLoginName.Visible = true;
            this.columnLoginName.VisibleIndex = 1;
            // 
            // columnFullname
            // 
            this.columnFullname.FieldName = "HOTEN";
            this.columnFullname.Name = "columnFullname";
            this.columnFullname.Visible = true;
            this.columnFullname.VisibleIndex = 2;
            // 
            // columnGroup
            // 
            this.columnGroup.FieldName = "TENNHOM";
            this.columnGroup.Name = "columnGroup";
            this.columnGroup.Visible = true;
            this.columnGroup.VisibleIndex = 3;
            // 
            // tbUserId
            // 
            this.tbUserId.Location = new System.Drawing.Point(86, 36);
            this.tbUserId.Name = "tbUserId";
            this.tbUserId.ReadOnly = true;
            this.tbUserId.Size = new System.Drawing.Size(216, 20);
            this.tbUserId.TabIndex = 15;
            // 
            // tbLoginName
            // 
            this.tbLoginName.Location = new System.Drawing.Point(424, 36);
            this.tbLoginName.Name = "tbLoginName";
            this.tbLoginName.ReadOnly = true;
            this.tbLoginName.Size = new System.Drawing.Size(216, 20);
            this.tbLoginName.TabIndex = 16;
            this.tbLoginName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbLoginName_KeyPress);
            // 
            // tbFullname
            // 
            this.tbFullname.Location = new System.Drawing.Point(765, 35);
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.ReadOnly = true;
            this.tbFullname.Size = new System.Drawing.Size(224, 20);
            this.tbFullname.TabIndex = 17;
            // 
            // tbGroup
            // 
            this.tbGroup.Location = new System.Drawing.Point(86, 93);
            this.tbGroup.Name = "tbGroup";
            this.tbGroup.ReadOnly = true;
            this.tbGroup.Size = new System.Drawing.Size(216, 20);
            this.tbGroup.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "MANV:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(711, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "HOTEN:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "TEN NHOM:";
            // 
            // pnAccount
            // 
            this.pnAccount.Controls.Add(this.tbPassword);
            this.pnAccount.Controls.Add(this.lbPassword);
            this.pnAccount.Controls.Add(this.tbUserId);
            this.pnAccount.Controls.Add(this.label4);
            this.pnAccount.Controls.Add(this.tbLoginName);
            this.pnAccount.Controls.Add(this.label3);
            this.pnAccount.Controls.Add(this.tbFullname);
            this.pnAccount.Controls.Add(this.label2);
            this.pnAccount.Controls.Add(this.tbGroup);
            this.pnAccount.Controls.Add(this.label1);
            this.pnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAccount.Enabled = false;
            this.pnAccount.Location = new System.Drawing.Point(0, 287);
            this.pnAccount.Name = "pnAccount";
            this.pnAccount.Size = new System.Drawing.Size(1041, 154);
            this.pnAccount.TabIndex = 23;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(424, 94);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(216, 20);
            this.tbPassword.TabIndex = 29;
            this.tbPassword.Visible = false;
            this.tbPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPassword_KeyPress);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(360, 97);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(55, 13);
            this.lbPassword.TabIndex = 30;
            this.lbPassword.Text = "Mật khẩu:";
            this.lbPassword.Visible = false;
            // 
            // gcStaff
            // 
            this.gcStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcStaff.Location = new System.Drawing.Point(0, 441);
            this.gcStaff.MainView = this.gvStaff;
            this.gcStaff.MenuManager = this.barManager;
            this.gcStaff.Name = "gcStaff";
            this.gcStaff.Size = new System.Drawing.Size(1041, 220);
            this.gcStaff.TabIndex = 29;
            this.gcStaff.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvStaff});
            this.gcStaff.Visible = false;
            this.gcStaff.DataSourceChanged += new System.EventHandler(this.gcStaff_DataSourceChanged);
            // 
            // gvStaff
            // 
            this.gvStaff.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colSODT,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gvStaff.GridControl = this.gcStaff;
            this.gvStaff.Name = "gvStaff";
            this.gvStaff.OptionsBehavior.Editable = false;
            this.gvStaff.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvStaff_FocusedRowChanged_1);
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 5;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            // 
            // pncStaff
            // 
            this.pncStaff.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pncStaff.Controls.Add(label9);
            this.pncStaff.Controls.Add(this.tbStaffBranch);
            this.pncStaff.Controls.Add(label6);
            this.pncStaff.Controls.Add(this.tbStaffPhoneNumber);
            this.pncStaff.Controls.Add(label5);
            this.pncStaff.Controls.Add(this.tbStaffGender);
            this.pncStaff.Controls.Add(mANVLabel);
            this.pncStaff.Controls.Add(this.tbStaffId);
            this.pncStaff.Controls.Add(mACNLabel);
            this.pncStaff.Controls.Add(this.tbStaffAddress);
            this.pncStaff.Controls.Add(this.tbRegisterPassword);
            this.pncStaff.Controls.Add(this.label7);
            this.pncStaff.Controls.Add(this.tbRegisterLogin);
            this.pncStaff.Controls.Add(this.label8);
            this.pncStaff.Controls.Add(tENLabel);
            this.pncStaff.Controls.Add(this.tbStaffLastName);
            this.pncStaff.Controls.Add(hOLabel);
            this.pncStaff.Controls.Add(this.tbStaffFirstName);
            this.pncStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.pncStaff.Location = new System.Drawing.Point(0, 661);
            this.pncStaff.Name = "pncStaff";
            this.pncStaff.Size = new System.Drawing.Size(1041, 193);
            this.pncStaff.TabIndex = 34;
            this.pncStaff.Visible = false;
            // 
            // tbStaffBranch
            // 
            this.tbStaffBranch.Location = new System.Drawing.Point(813, 156);
            this.tbStaffBranch.Name = "tbStaffBranch";
            this.tbStaffBranch.ReadOnly = true;
            this.tbStaffBranch.Size = new System.Drawing.Size(216, 21);
            this.tbStaffBranch.TabIndex = 36;
            // 
            // tbStaffPhoneNumber
            // 
            this.tbStaffPhoneNumber.Location = new System.Drawing.Point(413, 158);
            this.tbStaffPhoneNumber.Name = "tbStaffPhoneNumber";
            this.tbStaffPhoneNumber.ReadOnly = true;
            this.tbStaffPhoneNumber.Size = new System.Drawing.Size(216, 21);
            this.tbStaffPhoneNumber.TabIndex = 34;
            // 
            // tbStaffGender
            // 
            this.tbStaffGender.Location = new System.Drawing.Point(413, 96);
            this.tbStaffGender.Name = "tbStaffGender";
            this.tbStaffGender.ReadOnly = true;
            this.tbStaffGender.Size = new System.Drawing.Size(216, 21);
            this.tbStaffGender.TabIndex = 32;
            // 
            // tbStaffId
            // 
            this.tbStaffId.Location = new System.Drawing.Point(67, 37);
            this.tbStaffId.Name = "tbStaffId";
            this.tbStaffId.ReadOnly = true;
            this.tbStaffId.Size = new System.Drawing.Size(160, 21);
            this.tbStaffId.TabIndex = 30;
            // 
            // tbStaffAddress
            // 
            this.tbStaffAddress.Location = new System.Drawing.Point(413, 37);
            this.tbStaffAddress.Name = "tbStaffAddress";
            this.tbStaffAddress.ReadOnly = true;
            this.tbStaffAddress.Size = new System.Drawing.Size(216, 21);
            this.tbStaffAddress.TabIndex = 29;
            // 
            // tbRegisterPassword
            // 
            this.tbRegisterPassword.Location = new System.Drawing.Point(813, 96);
            this.tbRegisterPassword.Name = "tbRegisterPassword";
            this.tbRegisterPassword.Size = new System.Drawing.Size(216, 21);
            this.tbRegisterPassword.TabIndex = 27;
            this.tbRegisterPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRegisterPassword_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(752, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Mật khẩu:";
            // 
            // tbRegisterLogin
            // 
            this.tbRegisterLogin.Location = new System.Drawing.Point(813, 35);
            this.tbRegisterLogin.Name = "tbRegisterLogin";
            this.tbRegisterLogin.Size = new System.Drawing.Size(216, 21);
            this.tbRegisterLogin.TabIndex = 25;
            this.tbRegisterLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRegisterLogin_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(750, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Tài khoản:";
            // 
            // tbStaffLastName
            // 
            this.tbStaffLastName.Location = new System.Drawing.Point(67, 158);
            this.tbStaffLastName.Name = "tbStaffLastName";
            this.tbStaffLastName.ReadOnly = true;
            this.tbStaffLastName.Size = new System.Drawing.Size(160, 21);
            this.tbStaffLastName.TabIndex = 5;
            // 
            // tbStaffFirstName
            // 
            this.tbStaffFirstName.Location = new System.Drawing.Point(67, 98);
            this.tbStaffFirstName.Name = "tbStaffFirstName";
            this.tbStaffFirstName.ReadOnly = true;
            this.tbStaffFirstName.Size = new System.Drawing.Size(160, 21);
            this.tbStaffFirstName.TabIndex = 3;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 964);
            this.Controls.Add(this.pncStaff);
            this.Controls.Add(this.gcStaff);
            this.Controls.Add(this.pnAccount);
            this.Controls.Add(this.gcAccount);
            this.Controls.Add(this.pnControlBranch);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnControlBranch)).EndInit();
            this.pnControlBranch.ResumeLayout(false);
            this.pnControlBranch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAccount)).EndInit();
            this.pnAccount.ResumeLayout(false);
            this.pnAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pncStaff)).EndInit();
            this.pncStaff.ResumeLayout(false);
            this.pncStaff.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar barMenu;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnEdit;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnRestore;
        private DevExpress.XtraBars.BarButtonItem btnSaveToFile;
        private DevExpress.XtraBars.BarButtonItem btnQuit;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraEditors.PanelControl pnControlBranch;
        private System.Windows.Forms.ComboBox cmbBranch;
        private System.Windows.Forms.Label lbChiNhanh;
        private DevExpress.XtraGrid.GridControl gcAccount;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAccount;
        private DevExpress.XtraGrid.Columns.GridColumn columnMANV;
        private DevExpress.XtraGrid.Columns.GridColumn columnLoginName;
        private DevExpress.XtraGrid.Columns.GridColumn columnFullname;
        private DevExpress.XtraGrid.Columns.GridColumn columnGroup;
        private System.Windows.Forms.TextBox tbUserId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbGroup;
        private System.Windows.Forms.TextBox tbFullname;
        private System.Windows.Forms.TextBox tbLoginName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnAccount;
        private DevExpress.XtraGrid.GridControl gcStaff;
        private DevExpress.XtraGrid.Views.Grid.GridView gvStaff;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraEditors.PanelControl pncStaff;
        private System.Windows.Forms.TextBox tbStaffId;
        private System.Windows.Forms.TextBox tbStaffAddress;
        private System.Windows.Forms.TextBox tbRegisterPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRegisterLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbStaffLastName;
        private System.Windows.Forms.TextBox tbStaffFirstName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbStaffPhoneNumber;
        private System.Windows.Forms.TextBox tbStaffGender;
        private System.Windows.Forms.TextBox tbStaffBranch;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
    }
}