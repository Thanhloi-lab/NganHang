
namespace NganHang.Views
{
    partial class FormListCustomer
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
            this.panelControl1.Controls.Add(this.comboBoxBranch);
            this.panelControl1.Controls.Add(this.labelBranchTop);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(872, 240);
            this.panelControl1.TabIndex = 3;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(156, 118);
            this.btnPreview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(81, 45);
            this.btnPreview.TabIndex = 15;
            this.btnPreview.Text = "PREVIEW";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // comboBoxBranch
            // 
            this.comboBoxBranch.Location = new System.Drawing.Point(156, 38);
            this.comboBoxBranch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxBranch.Name = "comboBoxBranch";
            this.comboBoxBranch.Size = new System.Drawing.Size(172, 21);
            this.comboBoxBranch.TabIndex = 3;
            this.comboBoxBranch.SelectedIndexChanged += new System.EventHandler(this.comboBoxBranch_SelectedIndexChanged);
            // 
            // labelBranchTop
            // 
            this.labelBranchTop.AutoSize = true;
            this.labelBranchTop.Location = new System.Drawing.Point(86, 40);
            this.labelBranchTop.Name = "labelBranchTop";
            this.labelBranchTop.Size = new System.Drawing.Size(60, 13);
            this.labelBranchTop.TabIndex = 2;
            this.labelBranchTop.Text = "Chi Nhánh:";
            // 
            // cbChoose
            // 
            this.cbChoose.AutoSize = true;
            this.cbChoose.Location = new System.Drawing.Point(156, 78);
            this.cbChoose.Name = "cbChoose";
            this.cbChoose.Size = new System.Drawing.Size(114, 17);
            this.cbChoose.TabIndex = 17;
            this.cbChoose.Text = "Toàn bộ chi nhánh";
            this.cbChoose.UseVisualStyleBackColor = true;
            this.cbChoose.CheckedChanged += new System.EventHandler(this.cbChoose_CheckedChanged);
            // 
            // FormListCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 464);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormListCustomer";
            this.Text = "FormListCustomer";
            this.Load += new System.EventHandler(this.FormListCustomer_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.ComboBox comboBoxBranch;
        private System.Windows.Forms.Label labelBranchTop;
        private System.Windows.Forms.CheckBox cbChoose;
    }
}