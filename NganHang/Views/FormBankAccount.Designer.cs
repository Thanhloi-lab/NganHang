
namespace NganHang.Views
{
    partial class FormBankAccount
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
            System.Windows.Forms.Label labelAccountOpenDate;
            System.Windows.Forms.Label labelBranch;
            System.Windows.Forms.Label labelAccountBalance;
            System.Windows.Forms.Label labelCMND;
            System.Windows.Forms.Label labelAccountNumber;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBankAccount));
            this.barMenu = new DevExpress.XtraBars.Bar();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnEdit = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnRestore = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveToFile = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuit = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.panelControlTop = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.labelBranchTop = new System.Windows.Forms.Label();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.panelControlInfo = new DevExpress.XtraEditors.PanelControl();
            this.pnCus = new DevExpress.XtraEditors.PanelControl();
            this.pnFullnameAcc = new System.Windows.Forms.Panel();
            this.tbFullname = new DevExpress.XtraEditors.TextEdit();
            this.thongTinTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSBankAccount = new NganHang.DSBankAccount();
            this.dateEditAccountOpenDate = new DevExpress.XtraEditors.DateEdit();
            this.pnFullnameCus = new System.Windows.Forms.Panel();
            this.tbLastName = new DevExpress.XtraEditors.TextEdit();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbFirstName = new DevExpress.XtraEditors.TextEdit();
            this.txtBranch = new DevExpress.XtraEditors.TextEdit();
            this.spinEditAccountBalance = new DevExpress.XtraEditors.SpinEdit();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtAccountNumber = new DevExpress.XtraEditors.TextEdit();
            this.khachHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gvAccount = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thongTinTaiKhoanTableAdapter = new NganHang.DSBankAccountTableAdapters.ThongTinTaiKhoanTableAdapter();
            this.tableAdapterManager = new NganHang.DSBankAccountTableAdapters.TableAdapterManager();
            this.khachHangTableAdapter = new NganHang.DSBankAccountTableAdapters.KhachHangTableAdapter();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanTableAdapter = new NganHang.DSBankAccountTableAdapters.TaiKhoanTableAdapter();
            labelAccountOpenDate = new System.Windows.Forms.Label();
            labelBranch = new System.Windows.Forms.Label();
            labelAccountBalance = new System.Windows.Forms.Label();
            labelCMND = new System.Windows.Forms.Label();
            labelAccountNumber = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).BeginInit();
            this.panelControlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlInfo)).BeginInit();
            this.panelControlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnCus)).BeginInit();
            this.pnCus.SuspendLayout();
            this.pnFullnameAcc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFullname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinTaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBankAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAccountOpenDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAccountOpenDate.Properties)).BeginInit();
            this.pnFullnameCus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAccountBalance.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAccountOpenDate
            // 
            labelAccountOpenDate.AutoSize = true;
            labelAccountOpenDate.Location = new System.Drawing.Point(6, 8);
            labelAccountOpenDate.Name = "labelAccountOpenDate";
            labelAccountOpenDate.Size = new System.Drawing.Size(53, 13);
            labelAccountOpenDate.TabIndex = 8;
            labelAccountOpenDate.Text = "Ngày Mở:";
            // 
            // labelBranch
            // 
            labelBranch.AutoSize = true;
            labelBranch.Location = new System.Drawing.Point(275, 53);
            labelBranch.Name = "labelBranch";
            labelBranch.Size = new System.Drawing.Size(40, 13);
            labelBranch.TabIndex = 6;
            labelBranch.Text = "MACN:";
            // 
            // labelAccountBalance
            // 
            labelAccountBalance.AutoSize = true;
            labelAccountBalance.Location = new System.Drawing.Point(274, 14);
            labelAccountBalance.Name = "labelAccountBalance";
            labelAccountBalance.Size = new System.Drawing.Size(40, 13);
            labelAccountBalance.TabIndex = 4;
            labelAccountBalance.Text = "Số Dư:";
            // 
            // labelCMND
            // 
            labelCMND.AutoSize = true;
            labelCMND.Location = new System.Drawing.Point(63, 53);
            labelCMND.Name = "labelCMND";
            labelCMND.Size = new System.Drawing.Size(40, 13);
            labelCMND.TabIndex = 2;
            labelCMND.Text = "CMND:";
            // 
            // labelAccountNumber
            // 
            labelAccountNumber.AutoSize = true;
            labelAccountNumber.Location = new System.Drawing.Point(27, 14);
            labelAccountNumber.Name = "labelAccountNumber";
            labelAccountNumber.Size = new System.Drawing.Size(73, 13);
            labelAccountNumber.TabIndex = 0;
            labelAccountNumber.Text = "Số Tài Khoản:";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Location = new System.Drawing.Point(12, 44);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(45, 13);
            hOTENLabel.TabIndex = 19;
            hOTENLabel.Text = "HOTEN:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(12, 6);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(26, 13);
            hOLabel.TabIndex = 23;
            hOLabel.Text = "HO:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(218, 6);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(30, 13);
            tENLabel.TabIndex = 24;
            tENLabel.Text = "TEN:";
            // 
            // barMenu
            // 
            this.barMenu.BarName = "Main menu";
            this.barMenu.DockCol = 0;
            this.barMenu.DockRow = 0;
            this.barMenu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMenu.OptionsBar.MultiLine = true;
            this.barMenu.OptionsBar.UseWholeRow = true;
            this.barMenu.Text = "Main menu";
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
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
            this.btnEdit});
            this.barManager.MainMenu = this.bar1;
            this.barManager.MaxItemId = 11;
            // 
            // bar1
            // 
            this.bar1.BarName = "Main menu";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnAdd),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnRestore),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSaveToFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnQuit)});
            this.bar1.OptionsBar.MultiLine = true;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Main menu";
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
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlTop.Size = new System.Drawing.Size(1067, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 937);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1067, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 913);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1067, 24);
            this.barDockControl1.Manager = this.barManager;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(0, 913);
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
            // panelControlTop
            // 
            this.panelControlTop.Controls.Add(this.comboBoxBranch);
            this.panelControlTop.Controls.Add(this.labelBranchTop);
            this.panelControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlTop.Location = new System.Drawing.Point(0, 24);
            this.panelControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControlTop.Name = "panelControlTop";
            this.panelControlTop.Size = new System.Drawing.Size(1067, 38);
            this.panelControlTop.TabIndex = 22;
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.Location = new System.Drawing.Point(112, 10);
            this.comboBoxBranch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(393, 21);
            this.comboBoxBranch.TabIndex = 1;
            this.comboBoxBranch.SelectedIndexChanged += new System.EventHandler(this.comboBoxBranch_SelectedIndexChanged_1);
            // 
            // labelBranchTop
            // 
            this.labelBranchTop.AutoSize = true;
            this.labelBranchTop.Location = new System.Drawing.Point(42, 12);
            this.labelBranchTop.Name = "labelBranchTop";
            this.labelBranchTop.Size = new System.Drawing.Size(60, 13);
            this.labelBranchTop.TabIndex = 0;
            this.labelBranchTop.Text = "Chi Nhánh:";
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl2.Location = new System.Drawing.Point(0, 24);
            this.barDockControl2.Manager = this.barManager;
            this.barDockControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl2.Size = new System.Drawing.Size(0, 913);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1067, 24);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 913);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl3.Location = new System.Drawing.Point(0, 937);
            this.barDockControl3.Manager = this.barManager;
            this.barDockControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl3.Size = new System.Drawing.Size(1067, 0);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl4.Location = new System.Drawing.Point(0, 24);
            this.barDockControl4.Manager = this.barManager;
            this.barDockControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl4.Size = new System.Drawing.Size(1067, 0);
            // 
            // bar2
            // 
            this.bar2.BarName = "Custom 4";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 1;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Text = "Custom 4";
            // 
            // panelControlInfo
            // 
            this.panelControlInfo.Controls.Add(this.pnCus);
            this.panelControlInfo.Controls.Add(this.khachHangGridControl);
            this.panelControlInfo.Controls.Add(this.taiKhoanGridControl);
            this.panelControlInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControlInfo.Location = new System.Drawing.Point(0, 62);
            this.panelControlInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControlInfo.Name = "panelControlInfo";
            this.panelControlInfo.Size = new System.Drawing.Size(1067, 875);
            this.panelControlInfo.TabIndex = 43;
            // 
            // pnCus
            // 
            this.pnCus.Controls.Add(this.pnFullnameAcc);
            this.pnCus.Controls.Add(this.pnFullnameCus);
            this.pnCus.Controls.Add(this.txtBranch);
            this.pnCus.Controls.Add(this.spinEditAccountBalance);
            this.pnCus.Controls.Add(this.txtCMND);
            this.pnCus.Controls.Add(this.txtAccountNumber);
            this.pnCus.Controls.Add(labelBranch);
            this.pnCus.Controls.Add(labelAccountBalance);
            this.pnCus.Controls.Add(labelCMND);
            this.pnCus.Controls.Add(labelAccountNumber);
            this.pnCus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCus.Location = new System.Drawing.Point(2, 451);
            this.pnCus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnCus.Name = "pnCus";
            this.pnCus.Size = new System.Drawing.Size(1063, 422);
            this.pnCus.TabIndex = 19;
            // 
            // pnFullnameAcc
            // 
            this.pnFullnameAcc.Controls.Add(this.tbFullname);
            this.pnFullnameAcc.Controls.Add(hOTENLabel);
            this.pnFullnameAcc.Controls.Add(this.dateEditAccountOpenDate);
            this.pnFullnameAcc.Controls.Add(labelAccountOpenDate);
            this.pnFullnameAcc.Location = new System.Drawing.Point(563, 9);
            this.pnFullnameAcc.Name = "pnFullnameAcc";
            this.pnFullnameAcc.Size = new System.Drawing.Size(284, 73);
            this.pnFullnameAcc.TabIndex = 27;
            // 
            // tbFullname
            // 
            this.tbFullname.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongTinTaiKhoanBindingSource, "HOTEN", true));
            this.tbFullname.Location = new System.Drawing.Point(65, 41);
            this.tbFullname.MenuManager = this.barManager;
            this.tbFullname.Name = "tbFullname";
            this.tbFullname.Properties.ReadOnly = true;
            this.tbFullname.Size = new System.Drawing.Size(189, 20);
            this.tbFullname.TabIndex = 20;
            // 
            // thongTinTaiKhoanBindingSource
            // 
            this.thongTinTaiKhoanBindingSource.DataMember = "ThongTinTaiKhoan";
            this.thongTinTaiKhoanBindingSource.DataSource = this.dSBankAccount;
            // 
            // dSBankAccount
            // 
            this.dSBankAccount.DataSetName = "DSBankAccount";
            this.dSBankAccount.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateEditAccountOpenDate
            // 
            this.dateEditAccountOpenDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongTinTaiKhoanBindingSource, "NGAYMOTK", true));
            this.dateEditAccountOpenDate.EditValue = null;
            this.dateEditAccountOpenDate.Enabled = false;
            this.dateEditAccountOpenDate.Location = new System.Drawing.Point(65, 5);
            this.dateEditAccountOpenDate.MenuManager = this.barManager;
            this.dateEditAccountOpenDate.Name = "dateEditAccountOpenDate";
            this.dateEditAccountOpenDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditAccountOpenDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEditAccountOpenDate.Size = new System.Drawing.Size(189, 20);
            this.dateEditAccountOpenDate.TabIndex = 23;
            // 
            // pnFullnameCus
            // 
            this.pnFullnameCus.Controls.Add(this.tbLastName);
            this.pnFullnameCus.Controls.Add(tENLabel);
            this.pnFullnameCus.Controls.Add(this.tbFirstName);
            this.pnFullnameCus.Controls.Add(hOLabel);
            this.pnFullnameCus.Location = new System.Drawing.Point(66, 82);
            this.pnFullnameCus.Name = "pnFullnameCus";
            this.pnFullnameCus.Size = new System.Drawing.Size(481, 38);
            this.pnFullnameCus.TabIndex = 26;
            this.pnFullnameCus.Visible = false;
            // 
            // tbLastName
            // 
            this.tbLastName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "TEN", true));
            this.tbLastName.Location = new System.Drawing.Point(254, 3);
            this.tbLastName.MenuManager = this.barManager;
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Properties.ReadOnly = true;
            this.tbLastName.Size = new System.Drawing.Size(212, 20);
            this.tbLastName.TabIndex = 25;
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.dSBankAccount;
            // 
            // tbFirstName
            // 
            this.tbFirstName.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.khachHangBindingSource, "HO", true));
            this.tbFirstName.Location = new System.Drawing.Point(44, 3);
            this.tbFirstName.MenuManager = this.barManager;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Properties.ReadOnly = true;
            this.tbFirstName.Size = new System.Drawing.Size(139, 20);
            this.tbFirstName.TabIndex = 24;
            // 
            // txtBranch
            // 
            this.txtBranch.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongTinTaiKhoanBindingSource, "MACN", true));
            this.txtBranch.Location = new System.Drawing.Point(320, 50);
            this.txtBranch.MenuManager = this.barManager;
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Properties.ReadOnly = true;
            this.txtBranch.Size = new System.Drawing.Size(212, 20);
            this.txtBranch.TabIndex = 22;
            // 
            // spinEditAccountBalance
            // 
            this.spinEditAccountBalance.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongTinTaiKhoanBindingSource, "SODU", true));
            this.spinEditAccountBalance.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditAccountBalance.Enabled = false;
            this.spinEditAccountBalance.Location = new System.Drawing.Point(320, 11);
            this.spinEditAccountBalance.MenuManager = this.barManager;
            this.spinEditAccountBalance.Name = "spinEditAccountBalance";
            this.spinEditAccountBalance.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditAccountBalance.Properties.DisplayFormat.FormatString = "{0:#,##0}";
            this.spinEditAccountBalance.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.spinEditAccountBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.spinEditAccountBalance.Size = new System.Drawing.Size(212, 20);
            this.spinEditAccountBalance.TabIndex = 21;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongTinTaiKhoanBindingSource, "CMND", true));
            this.txtCMND.Location = new System.Drawing.Point(110, 50);
            this.txtCMND.MenuManager = this.barManager;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Properties.ReadOnly = true;
            this.txtCMND.Size = new System.Drawing.Size(139, 20);
            this.txtCMND.TabIndex = 19;
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongTinTaiKhoanBindingSource, "SOTK", true));
            this.txtAccountNumber.Location = new System.Drawing.Point(110, 11);
            this.txtAccountNumber.MenuManager = this.barManager;
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Properties.ReadOnly = true;
            this.txtAccountNumber.Size = new System.Drawing.Size(139, 20);
            this.txtAccountNumber.TabIndex = 18;
            // 
            // khachHangGridControl
            // 
            this.khachHangGridControl.DataSource = this.khachHangBindingSource;
            this.khachHangGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.khachHangGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.khachHangGridControl.Location = new System.Drawing.Point(2, 221);
            this.khachHangGridControl.MainView = this.gridView2;
            this.khachHangGridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.khachHangGridControl.MenuManager = this.barManager;
            this.khachHangGridControl.Name = "khachHangGridControl";
            this.khachHangGridControl.Size = new System.Drawing.Size(1063, 230);
            this.khachHangGridControl.TabIndex = 17;
            this.khachHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.khachHangGridControl.Visible = false;
            this.khachHangGridControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.khachHangGridControl_MouseClick);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND1,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colSODT,
            this.colMACN1});
            this.gridView2.DetailHeight = 284;
            this.gridView2.GridControl = this.khachHangGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsSelection.EnableAppearanceHideSelection = false;
            // 
            // colCMND1
            // 
            this.colCMND1.FieldName = "CMND";
            this.colCMND1.MinWidth = 21;
            this.colCMND1.Name = "colCMND1";
            this.colCMND1.Visible = true;
            this.colCMND1.VisibleIndex = 0;
            this.colCMND1.Width = 81;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 21;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            this.colHO.Width = 81;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 21;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            this.colTEN.Width = 81;
            // 
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 21;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            this.colDIACHI.Width = 81;
            // 
            // colPHAI
            // 
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 21;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            this.colPHAI.Width = 81;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.MinWidth = 21;
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            this.colNGAYCAP.Width = 81;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 21;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            this.colSODT.Width = 81;
            // 
            // colMACN1
            // 
            this.colMACN1.FieldName = "MACN";
            this.colMACN1.MinWidth = 21;
            this.colMACN1.Name = "colMACN1";
            this.colMACN1.Visible = true;
            this.colMACN1.VisibleIndex = 7;
            this.colMACN1.Width = 81;
            // 
            // taiKhoanGridControl
            // 
            this.taiKhoanGridControl.DataSource = this.thongTinTaiKhoanBindingSource;
            this.taiKhoanGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.taiKhoanGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taiKhoanGridControl.Location = new System.Drawing.Point(2, 2);
            this.taiKhoanGridControl.MainView = this.gvAccount;
            this.taiKhoanGridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taiKhoanGridControl.MenuManager = this.barManager;
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(1063, 219);
            this.taiKhoanGridControl.TabIndex = 18;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvAccount});
            // 
            // gvAccount
            // 
            this.gvAccount.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.HOTEN,
            this.colSODU,
            this.colMACN,
            this.colNGAYMOTK});
            this.gvAccount.DetailHeight = 284;
            this.gvAccount.GridControl = this.taiKhoanGridControl;
            this.gvAccount.Name = "gvAccount";
            this.gvAccount.OptionsBehavior.Editable = false;
            this.gvAccount.OptionsFind.AlwaysVisible = true;
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 21;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 81;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 21;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 2;
            this.colCMND.Width = 81;
            // 
            // HOTEN
            // 
            this.HOTEN.FieldName = "HOTEN";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Visible = true;
            this.HOTEN.VisibleIndex = 1;
            // 
            // colSODU
            // 
            this.colSODU.DisplayFormat.FormatString = "{0:#,##0}";
            this.colSODU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 21;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 3;
            this.colSODU.Width = 81;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.MinWidth = 21;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 4;
            this.colMACN.Width = 81;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 21;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 5;
            this.colNGAYMOTK.Width = 81;
            // 
            // thongTinTaiKhoanTableAdapter
            // 
            this.thongTinTaiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NganHang.DSBankAccountTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.dSBankAccount;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // FormBankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 937);
            this.Controls.Add(this.panelControlInfo);
            this.Controls.Add(this.panelControlTop);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormBankAccount";
            this.Text = "FormBankAccount";
            this.Load += new System.EventHandler(this.FormBankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).EndInit();
            this.panelControlTop.ResumeLayout(false);
            this.panelControlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlInfo)).EndInit();
            this.panelControlInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnCus)).EndInit();
            this.pnCus.ResumeLayout(false);
            this.pnCus.PerformLayout();
            this.pnFullnameAcc.ResumeLayout(false);
            this.pnFullnameAcc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbFullname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinTaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSBankAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAccountOpenDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditAccountOpenDate.Properties)).EndInit();
            this.pnFullnameCus.ResumeLayout(false);
            this.pnFullnameCus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAccountBalance.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar barMenu;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
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
        private DevExpress.XtraEditors.PanelControl panelControlTop;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.Label labelBranchTop;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraEditors.PanelControl panelControlInfo;
        private DSBankAccount dSBankAccount;
        private DSBankAccountTableAdapters.ThongTinTaiKhoanTableAdapter thongTinTaiKhoanTableAdapter;
        private DSBankAccountTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl khachHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND1;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN1;
        private DevExpress.XtraGrid.GridControl taiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gvAccount;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private DSBankAccountTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private DevExpress.XtraEditors.PanelControl pnCus;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private DSBankAccountTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.BindingSource thongTinTaiKhoanBindingSource;
        private System.Windows.Forms.Panel pnFullnameAcc;
        private DevExpress.XtraEditors.TextEdit tbFullname;
        private System.Windows.Forms.Panel pnFullnameCus;
        private DevExpress.XtraEditors.TextEdit tbLastName;
        private DevExpress.XtraEditors.TextEdit tbFirstName;
        private DevExpress.XtraEditors.DateEdit dateEditAccountOpenDate;
        private DevExpress.XtraEditors.TextEdit txtBranch;
        private DevExpress.XtraEditors.SpinEdit spinEditAccountBalance;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraEditors.TextEdit txtAccountNumber;
    }
}