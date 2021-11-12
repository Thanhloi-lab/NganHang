
namespace NganHang.Views
{
    partial class FormBankStatement
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
            this.sOTKLabel = new System.Windows.Forms.Label();
            this.hOTENLabel = new System.Windows.Forms.Label();
            this.dSBankStatement = new NganHang.DSBankStatement();
            this.saoKeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.saoKeTableAdapter = new NganHang.DSBankStatementTableAdapters.SaoKeTableAdapter();
            this.tableAdapterManager = new NganHang.DSBankStatementTableAdapters.TableAdapterManager();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnChosse = new System.Windows.Forms.Button();
            this.txtAccountNumber = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.btnPreview = new System.Windows.Forms.Button();
            this.datePickerTo = new System.Windows.Forms.DateTimePicker();
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.labelBranchTop = new System.Windows.Forms.Label();
            this.saoKeGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dSBankStatement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saoKeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saoKeGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            this.sOTKLabel.AutoSize = true;
            this.sOTKLabel.Location = new System.Drawing.Point(304, 63);
            this.sOTKLabel.Name = "sOTKLabel";
            this.sOTKLabel.Size = new System.Drawing.Size(73, 13);
            this.sOTKLabel.TabIndex = 12;
            this.sOTKLabel.Text = "Số Tài Khoản:";
            // 
            // hOTENLabel
            // 
            this.hOTENLabel.AutoSize = true;
            this.hOTENLabel.Location = new System.Drawing.Point(56, 63);
            this.hOTENLabel.Name = "hOTENLabel";
            this.hOTENLabel.Size = new System.Drawing.Size(45, 13);
            this.hOTENLabel.TabIndex = 11;
            this.hOTENLabel.Text = "Họ Tên:";
            // 
            // dSBankStatement
            // 
            this.dSBankStatement.DataSetName = "DSBankStatement";
            this.dSBankStatement.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saoKeBindingSource
            // 
            this.saoKeBindingSource.DataMember = "SaoKe";
            this.saoKeBindingSource.DataSource = this.dSBankStatement;
            // 
            // saoKeTableAdapter
            // 
            this.saoKeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NganHang.DSBankStatementTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnChosse);
            this.panelControl1.Controls.Add(this.txtAccountNumber);
            this.panelControl1.Controls.Add(this.txtName);
            this.panelControl1.Controls.Add(this.btnPreview);
            this.panelControl1.Controls.Add(this.sOTKLabel);
            this.panelControl1.Controls.Add(this.hOTENLabel);
            this.panelControl1.Controls.Add(this.datePickerTo);
            this.panelControl1.Controls.Add(this.datePickerFrom);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.comboBoxBranch);
            this.panelControl1.Controls.Add(this.labelBranchTop);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(717, 149);
            this.panelControl1.TabIndex = 1;
            // 
            // btnChosse
            // 
            this.btnChosse.Location = new System.Drawing.Point(566, 58);
            this.btnChosse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChosse.Name = "btnChosse";
            this.btnChosse.Size = new System.Drawing.Size(66, 20);
            this.btnChosse.TabIndex = 18;
            this.btnChosse.Text = "Chọn";
            this.btnChosse.UseVisualStyleBackColor = true;
            this.btnChosse.Click += new System.EventHandler(this.btnChosse_Click_1);
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Enabled = false;
            this.txtAccountNumber.Location = new System.Drawing.Point(389, 61);
            this.txtAccountNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(159, 20);
            this.txtAccountNumber.TabIndex = 17;
            this.txtAccountNumber.MouseEnter += new System.EventHandler(this.txtAccountNumber_MouseEnter_1);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(110, 61);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 20);
            this.txtName.TabIndex = 16;
            this.txtName.MouseEnter += new System.EventHandler(this.txtName_MouseEnter);
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(566, 94);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(81, 45);
            this.btnPreview.TabIndex = 15;
            this.btnPreview.Text = "PREVIEW";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click_1);
            // 
            // datePickerTo
            // 
            this.datePickerTo.Location = new System.Drawing.Point(377, 104);
            this.datePickerTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePickerTo.Name = "datePickerTo";
            this.datePickerTo.Size = new System.Drawing.Size(172, 21);
            this.datePickerTo.TabIndex = 11;
            this.datePickerTo.Value = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            // 
            // datePickerFrom
            // 
            this.datePickerFrom.Location = new System.Drawing.Point(110, 104);
            this.datePickerFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePickerFrom.Name = "datePickerFrom";
            this.datePickerFrom.Size = new System.Drawing.Size(172, 21);
            this.datePickerFrom.TabIndex = 10;
            this.datePickerFrom.Value = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đến Ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Từ Ngày:";
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.Location = new System.Drawing.Point(110, 17);
            this.comboBoxBranch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(144, 21);
            this.comboBoxBranch.TabIndex = 3;
            this.comboBoxBranch.SelectedIndexChanged += new System.EventHandler(this.comboBoxBranch_SelectedIndexChanged);
            // 
            // labelBranchTop
            // 
            this.labelBranchTop.AutoSize = true;
            this.labelBranchTop.Location = new System.Drawing.Point(39, 20);
            this.labelBranchTop.Name = "labelBranchTop";
            this.labelBranchTop.Size = new System.Drawing.Size(60, 13);
            this.labelBranchTop.TabIndex = 2;
            this.labelBranchTop.Text = "Chi Nhánh:";
            // 
            // saoKeGridControl
            // 
            this.saoKeGridControl.DataSource = this.saoKeBindingSource;
            this.saoKeGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saoKeGridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saoKeGridControl.Location = new System.Drawing.Point(0, 149);
            this.saoKeGridControl.MainView = this.gridView1;
            this.saoKeGridControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saoKeGridControl.Name = "saoKeGridControl";
            this.saoKeGridControl.Size = new System.Drawing.Size(717, 439);
            this.saoKeGridControl.TabIndex = 2;
            this.saoKeGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.saoKeGridControl.Visible = false;
            this.saoKeGridControl.Click += new System.EventHandler(this.saoKeGridControl_Click_1);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHOTEN,
            this.colSOTK});
            this.gridView1.DetailHeight = 284;
            this.gridView1.GridControl = this.saoKeGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsSelection.EnableAppearanceHideSelection = false;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 21;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            this.colCMND.Width = 81;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.MinWidth = 21;
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            this.colHOTEN.Width = 81;
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 21;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 2;
            this.colSOTK.Width = 81;
            // 
            // FormBankStatement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 588);
            this.Controls.Add(this.saoKeGridControl);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormBankStatement";
            this.Text = "FormBankStatement";
            this.Load += new System.EventHandler(this.FormBankStatement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSBankStatement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saoKeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saoKeGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DSBankStatement dSBankStatement;
        private System.Windows.Forms.BindingSource saoKeBindingSource;
        private DSBankStatementTableAdapters.SaoKeTableAdapter saoKeTableAdapter;
        private DSBankStatementTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnChosse;
        private DevExpress.XtraEditors.TextEdit txtAccountNumber;
        private DevExpress.XtraEditors.TextEdit txtName;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.DateTimePicker datePickerTo;
        private System.Windows.Forms.DateTimePicker datePickerFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.Label labelBranchTop;
        private DevExpress.XtraGrid.GridControl saoKeGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private System.Windows.Forms.Label sOTKLabel;
        private System.Windows.Forms.Label hOTENLabel;
    }
}