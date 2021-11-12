
using DevExpress.XtraReports.UI;
using System;
using System.Data;
using System.Windows.Forms;

namespace NganHang.Views
{
    public partial class FormBankStatement : DevExpress.XtraEditors.XtraForm
    {
        public FormBankStatement()
        {
            InitializeComponent();
        }

        private void FormBankStatement_Load(object sender, EventArgs e)
        {

            this.saoKeTableAdapter.Connection.ConnectionString = Program.connStr;
            this.saoKeTableAdapter.Fill(this.dSBankStatement.SaoKe);

            comboBoxBranch.DataSource = Program.dbs_ListFragments;
            comboBoxBranch.DisplayMember = "TENCN";
            comboBoxBranch.ValueMember = "TENSERVER";
            comboBoxBranch.SelectedIndex = Program.mBranch;
            if (Program.mGroup == "NGANHANG")
            {

                comboBoxBranch.Enabled = true;
            }
            else
            {

                comboBoxBranch.Enabled = false;
            }


        }

        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBranch.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.serverName = comboBoxBranch.SelectedValue.ToString();
            if (comboBoxBranch.SelectedIndex != Program.mBranch)
            {
                Program.mLogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            else
            {
                Program.mLogin = Program.mLoginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.Connect() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);

            }
            else
            {
                this.saoKeTableAdapter.Connection.ConnectionString = Program.connStr;
                this.saoKeTableAdapter.Fill(this.dSBankStatement.SaoKe);
            }
        }


        private void saoKeGridControl_Click_1(object sender, EventArgs e)
        {
            txtName.Text = ((DataRowView)saoKeBindingSource[saoKeBindingSource.Position])["HOTEN"].ToString();
            txtAccountNumber.Text = ((DataRowView)saoKeBindingSource[saoKeBindingSource.Position])["SOTK"].ToString();
            saoKeGridControl.Visible = false;
        }


        private void txtName_MouseEnter(object sender, EventArgs e)
        {
            saoKeGridControl.Visible = true;
        }

        private void txtAccountNumber_MouseEnter_1(object sender, EventArgs e)
        {
            saoKeGridControl.Visible = true;
        }

        private void btnChosse_Click_1(object sender, EventArgs e)
        {
            saoKeGridControl.Visible = true;
        }

        private void btnPreview_Click_1(object sender, EventArgs e)
        {
            DateTime temps = datePickerFrom.Value;
            DateTime tempe = datePickerTo.Value;
            ReportBankStatement report = new ReportBankStatement(txtAccountNumber.Text, temps, tempe);
            report.txtAccount.Text = txtAccountNumber.Text;
            report.txtBranch.Text = comboBoxBranch.Text;
            report.txtCustomer.Text = txtName.Text;
            report.txtFrom.Text = datePickerFrom.Text.ToString();
            report.txtTo.Text = datePickerTo.Value.ToString();
            report.txtDate.Text = DateTime.Now.ToString();
            report.txtStaff.Text = Program.userName;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

    }
}