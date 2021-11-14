
namespace NganHang.Views
{
    partial class FormListAccount
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnPreview = new System.Windows.Forms.Button();
            this.datePickerTo = new System.Windows.Forms.DateTimePicker();
            this.datePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBranch = new System.Windows.Forms.ComboBox();
            this.labelBranchTop = new System.Windows.Forms.Label();
            this.cbChoose = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cbChoose);
            this.panelControl1.Controls.Add(this.btnPreview);
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
            this.panelControl1.Size = new System.Drawing.Size(949, 149);
            this.panelControl1.TabIndex = 2;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(634, 61);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(81, 45);
            this.btnPreview.TabIndex = 15;
            this.btnPreview.Text = "PREVIEW";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // datePickerTo
            // 
            this.datePickerTo.Location = new System.Drawing.Point(403, 84);
            this.datePickerTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePickerTo.Name = "datePickerTo";
            this.datePickerTo.Size = new System.Drawing.Size(180, 21);
            this.datePickerTo.TabIndex = 11;
            this.datePickerTo.Value = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            // 
            // datePickerFrom
            // 
            this.datePickerFrom.Location = new System.Drawing.Point(118, 85);
            this.datePickerFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datePickerFrom.Name = "datePickerFrom";
            this.datePickerFrom.Size = new System.Drawing.Size(181, 21);
            this.datePickerFrom.TabIndex = 10;
            this.datePickerFrom.Value = new System.DateTime(2021, 11, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Đến Ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Từ Ngày:";
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.Location = new System.Drawing.Point(118, 31);
            this.comboBoxBranch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(181, 21);
            this.comboBoxBranch.TabIndex = 3;
            this.comboBoxBranch.SelectedIndexChanged += new System.EventHandler(this.comboBoxBranch_SelectedIndexChanged);
            // 
            // labelBranchTop
            // 
            this.labelBranchTop.AutoSize = true;
            this.labelBranchTop.Location = new System.Drawing.Point(48, 33);
            this.labelBranchTop.Name = "labelBranchTop";
            this.labelBranchTop.Size = new System.Drawing.Size(60, 13);
            this.labelBranchTop.TabIndex = 2;
            this.labelBranchTop.Text = "Chi Nhánh:";
            // 
            // cbChoose
            // 
            this.cbChoose.AutoSize = true;
            this.cbChoose.Location = new System.Drawing.Point(403, 33);
            this.cbChoose.Name = "cbChoose";
            this.cbChoose.Size = new System.Drawing.Size(114, 17);
            this.cbChoose.TabIndex = 16;
            this.cbChoose.Text = "Toàn bộ chi nhánh";
            this.cbChoose.UseVisualStyleBackColor = true;
            this.cbChoose.CheckedChanged += new System.EventHandler(this.cbChoose_CheckedChanged);
            // 
            // FormListAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 495);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormListAccount";
            this.Text = "FormListAccount";
            this.Load += new System.EventHandler(this.FormListAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.DateTimePicker datePickerTo;
        private System.Windows.Forms.DateTimePicker datePickerFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.Label labelBranchTop;
        private System.Windows.Forms.CheckBox cbChoose;
    }
}