
namespace NganHang.Views
{
    partial class FormTransfer
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
            System.Windows.Forms.Label labelStaffID;
            System.Windows.Forms.Label labelMoney;
            System.Windows.Forms.Label labelAccountReceive;
            System.Windows.Forms.Label labelAccountTransfer;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransfer));
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
            this.panelControlTop = new DevExpress.XtraEditors.PanelControl();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.labelBranch = new System.Windows.Forms.Label();
            this.panelControlInfo = new DevExpress.XtraEditors.PanelControl();
            this.lbNameRec = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNameSender = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOKRec = new System.Windows.Forms.Button();
            this.btnChooseRec = new System.Windows.Forms.Button();
            this.btnOKSend = new System.Windows.Forms.Button();
            this.btnChooseSend = new System.Windows.Forms.Button();
            this.txtMoney = new DevExpress.XtraEditors.SpinEdit();
            this.txtAccountReceive = new DevExpress.XtraEditors.TextEdit();
            this.txtAccountTransfer = new DevExpress.XtraEditors.TextEdit();
            this.taiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSTransferMoney = new NganHang.DSTransferMoney();
            this.ThongTinGDGridControl = new DevExpress.XtraGrid.GridControl();
            this.thongTinTaiKhoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK_CHUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN_CHUYEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK_NHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN_NHAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableAdapterManager = new NganHang.DSTransferMoneyTableAdapters.TableAdapterManager();
            this.taiKhoanTableAdapter = new NganHang.DSTransferMoneyTableAdapters.TaiKhoanTableAdapter();
            this.taiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.thongTinTaiKhoanTableAdapter = new NganHang.DSTransferMoneyTableAdapters.ThongTinTaiKhoanTableAdapter();
            this.thongTinGDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thongTinGDTableAdapter = new NganHang.DSTransferMoneyTableAdapters.ThongTinGDTableAdapter();
            this.gD_CHUYENTIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD_CHUYENTIENTableAdapter = new NganHang.DSTransferMoneyTableAdapters.GD_CHUYENTIENTableAdapter();
            this.txtStaffID = new DevExpress.XtraEditors.TextEdit();
            labelStaffID = new System.Windows.Forms.Label();
            labelMoney = new System.Windows.Forms.Label();
            labelAccountReceive = new System.Windows.Forms.Label();
            labelAccountTransfer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).BeginInit();
            this.panelControlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlInfo)).BeginInit();
            this.panelControlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoney.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountReceive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountTransfer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTransferMoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinGDGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinTaiKhoanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinGDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelStaffID
            // 
            labelStaffID.AutoSize = true;
            labelStaffID.Location = new System.Drawing.Point(598, 97);
            labelStaffID.Name = "labelStaffID";
            labelStaffID.Size = new System.Drawing.Size(76, 13);
            labelStaffID.TabIndex = 6;
            labelStaffID.Text = "Mã Nhân Viên:";
            // 
            // labelMoney
            // 
            labelMoney.AutoSize = true;
            labelMoney.Location = new System.Drawing.Point(91, 98);
            labelMoney.Name = "labelMoney";
            labelMoney.Size = new System.Drawing.Size(46, 13);
            labelMoney.TabIndex = 4;
            labelMoney.Text = "Số Tiền:";
            // 
            // labelAccountReceive
            // 
            labelAccountReceive.AutoSize = true;
            labelAccountReceive.Location = new System.Drawing.Point(573, 20);
            labelAccountReceive.Name = "labelAccountReceive";
            labelAccountReceive.Size = new System.Drawing.Size(101, 13);
            labelAccountReceive.TabIndex = 2;
            labelAccountReceive.Text = "Số Tài Khoản Nhận:";
            // 
            // labelAccountTransfer
            // 
            labelAccountTransfer.AutoSize = true;
            labelAccountTransfer.Location = new System.Drawing.Point(27, 20);
            labelAccountTransfer.Name = "labelAccountTransfer";
            labelAccountTransfer.Size = new System.Drawing.Size(113, 13);
            labelAccountTransfer.TabIndex = 0;
            labelAccountTransfer.Text = "Số Tài Khoản Chuyển:";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1296, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 751);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlBottom.Size = new System.Drawing.Size(1296, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 727);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1296, 24);
            this.barDockControl1.Manager = this.barManager;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.barDockControl1.Size = new System.Drawing.Size(0, 727);
            // 
            // panelControlTop
            // 
            this.panelControlTop.Controls.Add(this.comboBoxBranch);
            this.panelControlTop.Controls.Add(this.labelBranch);
            this.panelControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlTop.Location = new System.Drawing.Point(0, 24);
            this.panelControlTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControlTop.Name = "panelControlTop";
            this.panelControlTop.Size = new System.Drawing.Size(1296, 38);
            this.panelControlTop.TabIndex = 5;
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.FormattingEnabled = true;
            this.comboBoxBranch.Location = new System.Drawing.Point(147, 9);
            this.comboBoxBranch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(133, 21);
            this.comboBoxBranch.TabIndex = 1;
            // 
            // labelBranch
            // 
            this.labelBranch.AutoSize = true;
            this.labelBranch.Location = new System.Drawing.Point(77, 11);
            this.labelBranch.Name = "labelBranch";
            this.labelBranch.Size = new System.Drawing.Size(60, 13);
            this.labelBranch.TabIndex = 0;
            this.labelBranch.Text = "Chi Nhánh:";
            // 
            // panelControlInfo
            // 
            this.panelControlInfo.Controls.Add(this.txtStaffID);
            this.panelControlInfo.Controls.Add(this.lbNameRec);
            this.panelControlInfo.Controls.Add(this.label3);
            this.panelControlInfo.Controls.Add(this.lbNameSender);
            this.panelControlInfo.Controls.Add(this.label1);
            this.panelControlInfo.Controls.Add(this.btnOKRec);
            this.panelControlInfo.Controls.Add(this.btnChooseRec);
            this.panelControlInfo.Controls.Add(this.btnOKSend);
            this.panelControlInfo.Controls.Add(this.btnChooseSend);
            this.panelControlInfo.Controls.Add(labelStaffID);
            this.panelControlInfo.Controls.Add(labelMoney);
            this.panelControlInfo.Controls.Add(this.txtMoney);
            this.panelControlInfo.Controls.Add(labelAccountReceive);
            this.panelControlInfo.Controls.Add(this.txtAccountReceive);
            this.panelControlInfo.Controls.Add(labelAccountTransfer);
            this.panelControlInfo.Controls.Add(this.txtAccountTransfer);
            this.panelControlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlInfo.Enabled = false;
            this.panelControlInfo.Location = new System.Drawing.Point(0, 286);
            this.panelControlInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControlInfo.Name = "panelControlInfo";
            this.panelControlInfo.Size = new System.Drawing.Size(1296, 139);
            this.panelControlInfo.TabIndex = 11;
            // 
            // lbNameRec
            // 
            this.lbNameRec.AutoSize = true;
            this.lbNameRec.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameRec.Location = new System.Drawing.Point(681, 60);
            this.lbNameRec.Name = "lbNameRec";
            this.lbNameRec.Size = new System.Drawing.Size(20, 16);
            this.lbNameRec.TabIndex = 15;
            this.lbNameRec.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(588, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tên người nhận:";
            // 
            // lbNameSender
            // 
            this.lbNameSender.AutoSize = true;
            this.lbNameSender.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameSender.Location = new System.Drawing.Point(154, 60);
            this.lbNameSender.Name = "lbNameSender";
            this.lbNameSender.Size = new System.Drawing.Size(20, 16);
            this.lbNameSender.TabIndex = 13;
            this.lbNameSender.Text = "...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên người gửi:";
            // 
            // btnOKRec
            // 
            this.btnOKRec.Enabled = false;
            this.btnOKRec.Location = new System.Drawing.Point(984, 15);
            this.btnOKRec.Name = "btnOKRec";
            this.btnOKRec.Size = new System.Drawing.Size(85, 23);
            this.btnOKRec.TabIndex = 11;
            this.btnOKRec.Text = "Xác nhận";
            this.btnOKRec.UseVisualStyleBackColor = true;
            this.btnOKRec.Click += new System.EventHandler(this.btnOKRec_Click);
            // 
            // btnChooseRec
            // 
            this.btnChooseRec.Location = new System.Drawing.Point(903, 15);
            this.btnChooseRec.Name = "btnChooseRec";
            this.btnChooseRec.Size = new System.Drawing.Size(75, 23);
            this.btnChooseRec.TabIndex = 10;
            this.btnChooseRec.Text = "Chọn";
            this.btnChooseRec.UseVisualStyleBackColor = true;
            this.btnChooseRec.Click += new System.EventHandler(this.btnChooseRec_Click);
            // 
            // btnOKSend
            // 
            this.btnOKSend.Enabled = false;
            this.btnOKSend.Location = new System.Drawing.Point(440, 14);
            this.btnOKSend.Name = "btnOKSend";
            this.btnOKSend.Size = new System.Drawing.Size(87, 23);
            this.btnOKSend.TabIndex = 9;
            this.btnOKSend.Text = "Xác nhận";
            this.btnOKSend.UseVisualStyleBackColor = true;
            this.btnOKSend.Click += new System.EventHandler(this.btnOKSend_Click);
            // 
            // btnChooseSend
            // 
            this.btnChooseSend.Location = new System.Drawing.Point(359, 14);
            this.btnChooseSend.Name = "btnChooseSend";
            this.btnChooseSend.Size = new System.Drawing.Size(75, 23);
            this.btnChooseSend.TabIndex = 8;
            this.btnChooseSend.Text = "Chọn";
            this.btnChooseSend.UseVisualStyleBackColor = true;
            this.btnChooseSend.Click += new System.EventHandler(this.btnChooseSend_Click);
            // 
            // txtMoney
            // 
            this.txtMoney.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMoney.Location = new System.Drawing.Point(157, 95);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMoney.MenuManager = this.barManager;
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMoney.Properties.DisplayFormat.FormatString = "{0:#,##0}";
            this.txtMoney.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMoney.Properties.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtMoney.Size = new System.Drawing.Size(196, 20);
            this.txtMoney.TabIndex = 5;
            // 
            // txtAccountReceive
            // 
            this.txtAccountReceive.Location = new System.Drawing.Point(684, 17);
            this.txtAccountReceive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccountReceive.MenuManager = this.barManager;
            this.txtAccountReceive.Name = "txtAccountReceive";
            this.txtAccountReceive.Properties.ReadOnly = true;
            this.txtAccountReceive.Size = new System.Drawing.Size(213, 20);
            this.txtAccountReceive.TabIndex = 3;
            this.txtAccountReceive.Click += new System.EventHandler(this.txtAccountReceive_Click_1);
            // 
            // txtAccountTransfer
            // 
            this.txtAccountTransfer.Location = new System.Drawing.Point(157, 17);
            this.txtAccountTransfer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccountTransfer.MenuManager = this.barManager;
            this.txtAccountTransfer.Name = "txtAccountTransfer";
            this.txtAccountTransfer.Properties.ReadOnly = true;
            this.txtAccountTransfer.Size = new System.Drawing.Size(196, 20);
            this.txtAccountTransfer.TabIndex = 1;
            this.txtAccountTransfer.Click += new System.EventHandler(this.txtAccountTransfer_Click_1);
            // 
            // taiKhoanBindingSource
            // 
            this.taiKhoanBindingSource.DataMember = "TaiKhoan";
            this.taiKhoanBindingSource.DataSource = this.dSTransferMoney;
            // 
            // dSTransferMoney
            // 
            this.dSTransferMoney.DataSetName = "DSTransferMoney";
            this.dSTransferMoney.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ThongTinGDGridControl
            // 
            this.ThongTinGDGridControl.DataSource = this.thongTinGDBindingSource;
            this.ThongTinGDGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ThongTinGDGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThongTinGDGridControl.Location = new System.Drawing.Point(0, 62);
            this.ThongTinGDGridControl.MainView = this.gridView1;
            this.ThongTinGDGridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThongTinGDGridControl.MenuManager = this.barManager;
            this.ThongTinGDGridControl.Name = "ThongTinGDGridControl";
            this.ThongTinGDGridControl.Size = new System.Drawing.Size(1296, 224);
            this.ThongTinGDGridControl.TabIndex = 9;
            this.ThongTinGDGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // thongTinTaiKhoanBindingSource
            // 
            this.thongTinTaiKhoanBindingSource.DataMember = "ThongTinTaiKhoan";
            this.thongTinTaiKhoanBindingSource.DataSource = this.dSTransferMoney;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGD,
            this.colSOTK_CHUYEN,
            this.HOTEN_CHUYEN,
            this.colSOTK_NHAN,
            this.HOTEN_NHAN,
            this.colSOTIEN,
            this.colNGAYGD,
            this.colMANV});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.ThongTinGDGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colMAGD
            // 
            this.colMAGD.FieldName = "MAGD";
            this.colMAGD.MinWidth = 21;
            this.colMAGD.Name = "colMAGD";
            this.colMAGD.Visible = true;
            this.colMAGD.VisibleIndex = 0;
            this.colMAGD.Width = 81;
            // 
            // colSOTK_CHUYEN
            // 
            this.colSOTK_CHUYEN.FieldName = "SOTK_CHUYEN";
            this.colSOTK_CHUYEN.MinWidth = 21;
            this.colSOTK_CHUYEN.Name = "colSOTK_CHUYEN";
            this.colSOTK_CHUYEN.Visible = true;
            this.colSOTK_CHUYEN.VisibleIndex = 1;
            this.colSOTK_CHUYEN.Width = 81;
            // 
            // HOTEN_CHUYEN
            // 
            this.HOTEN_CHUYEN.FieldName = "HOTEN_CHUYEN";
            this.HOTEN_CHUYEN.Name = "HOTEN_CHUYEN";
            this.HOTEN_CHUYEN.Visible = true;
            this.HOTEN_CHUYEN.VisibleIndex = 2;
            // 
            // colSOTK_NHAN
            // 
            this.colSOTK_NHAN.FieldName = "SOTK_NHAN";
            this.colSOTK_NHAN.MinWidth = 21;
            this.colSOTK_NHAN.Name = "colSOTK_NHAN";
            this.colSOTK_NHAN.Visible = true;
            this.colSOTK_NHAN.VisibleIndex = 3;
            this.colSOTK_NHAN.Width = 81;
            // 
            // HOTEN_NHAN
            // 
            this.HOTEN_NHAN.FieldName = "HOTEN_NHAN";
            this.HOTEN_NHAN.Name = "HOTEN_NHAN";
            this.HOTEN_NHAN.Visible = true;
            this.HOTEN_NHAN.VisibleIndex = 4;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.DisplayFormat.FormatString = "{0:#,##0}";
            this.colSOTIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.MinWidth = 21;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 5;
            this.colSOTIEN.Width = 81;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.MinWidth = 21;
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 6;
            this.colNGAYGD.Width = 81;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.MinWidth = 21;
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 7;
            this.colMANV.Width = 81;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NganHang.DSTransferMoneyTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // taiKhoanGridControl
            // 
            this.taiKhoanGridControl.DataSource = this.thongTinTaiKhoanBindingSource;
            this.taiKhoanGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.taiKhoanGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taiKhoanGridControl.Enabled = false;
            this.taiKhoanGridControl.Location = new System.Drawing.Point(0, 425);
            this.taiKhoanGridControl.MainView = this.gridView2;
            this.taiKhoanGridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.taiKhoanGridControl.MenuManager = this.barManager;
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(1296, 326);
            this.taiKhoanGridControl.TabIndex = 16;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.taiKhoanGridControl.Visible = false;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND,
            this.HOTEN,
            this.colSODU,
            this.colMACN,
            this.colNGAYMOTK});
            this.gridView2.DetailHeight = 284;
            this.gridView2.GridControl = this.taiKhoanGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView2.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView2_FocusedRowChanged);
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
            // thongTinGDBindingSource
            // 
            this.thongTinGDBindingSource.DataMember = "ThongTinGD";
            this.thongTinGDBindingSource.DataSource = this.dSTransferMoney;
            // 
            // thongTinGDTableAdapter
            // 
            this.thongTinGDTableAdapter.ClearBeforeFill = true;
            // 
            // gD_CHUYENTIENBindingSource
            // 
            this.gD_CHUYENTIENBindingSource.DataMember = "GD_CHUYENTIEN";
            this.gD_CHUYENTIENBindingSource.DataSource = this.dSTransferMoney;
            // 
            // gD_CHUYENTIENTableAdapter
            // 
            this.gD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // txtStaffID
            // 
            this.txtStaffID.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongTinGDBindingSource, "MANV", true));
            this.txtStaffID.Location = new System.Drawing.Point(684, 95);
            this.txtStaffID.MenuManager = this.barManager;
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Properties.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(213, 20);
            this.txtStaffID.TabIndex = 16;
            // 
            // FormTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 771);
            this.Controls.Add(this.taiKhoanGridControl);
            this.Controls.Add(this.panelControlInfo);
            this.Controls.Add(this.ThongTinGDGridControl);
            this.Controls.Add(this.panelControlTop);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "FormTransfer";
            this.Text = "FormTransfer";
            this.Load += new System.EventHandler(this.FormTransfer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlTop)).EndInit();
            this.panelControlTop.ResumeLayout(false);
            this.panelControlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlInfo)).EndInit();
            this.panelControlInfo.ResumeLayout(false);
            this.panelControlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMoney.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountReceive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountTransfer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTransferMoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongTinGDGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinTaiKhoanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinGDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_CHUYENTIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStaffID.Properties)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnRedo;
        private DevExpress.XtraBars.BarButtonItem btnQuit;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DSTransferMoney dSTransferMoney;
        private DevExpress.XtraEditors.PanelControl panelControlInfo;
        private DevExpress.XtraEditors.SpinEdit txtMoney;
        private DevExpress.XtraEditors.TextEdit txtAccountReceive;
        private DevExpress.XtraEditors.TextEdit txtAccountTransfer;
        private DevExpress.XtraGrid.GridControl ThongTinGDGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_CHUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK_NHAN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraEditors.PanelControl panelControlTop;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.Label labelBranch;
        private DSTransferMoneyTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTransferMoneyTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.BindingSource taiKhoanBindingSource;
        private DevExpress.XtraGrid.GridControl taiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private System.Windows.Forms.Button btnOKRec;
        private System.Windows.Forms.Button btnChooseRec;
        private System.Windows.Forms.Button btnOKSend;
        private System.Windows.Forms.Button btnChooseSend;
        private System.Windows.Forms.BindingSource thongTinTaiKhoanBindingSource;
        private DSTransferMoneyTableAdapters.ThongTinTaiKhoanTableAdapter thongTinTaiKhoanTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN;
        private System.Windows.Forms.Label lbNameRec;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNameSender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource thongTinGDBindingSource;
        private DSTransferMoneyTableAdapters.ThongTinGDTableAdapter thongTinGDTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN_CHUYEN;
        private DevExpress.XtraGrid.Columns.GridColumn HOTEN_NHAN;
        private System.Windows.Forms.BindingSource gD_CHUYENTIENBindingSource;
        private DSTransferMoneyTableAdapters.GD_CHUYENTIENTableAdapter gD_CHUYENTIENTableAdapter;
        private DevExpress.XtraEditors.TextEdit txtStaffID;
    }
}