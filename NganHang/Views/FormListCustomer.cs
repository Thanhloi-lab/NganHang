using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace NganHang.Views
{
    public partial class FormListCustomer : XtraForm
    {
        private bool isAll = false;

        public FormListCustomer()
        {
            InitializeComponent();
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

        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ReportCustomer report = new ReportCustomer(isAll);
            report.txtBranch.Text = comboBoxBranch.Text;
            report.txtDate.Text = DateTime.Now.ToString();
            report.txtStaff.Text = Program.userName;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
            Cursor.Current = Cursors.Default;
        }

        private void FormListCustomer_Load_1(object sender, EventArgs e)
        {
            comboBoxBranch.DataSource = Program.dbs_ListFragments;
            comboBoxBranch.DisplayMember = "TENCN";
            comboBoxBranch.ValueMember = "TENSERVER";
            comboBoxBranch.SelectedIndex = Program.mBranch;
            if (Program.mGroup == "NGANHANG")
            {
                comboBoxBranch.Enabled = true;
                cbChoose.Visible = true;
            }
            else
            {
                cbChoose.Visible = false;
                comboBoxBranch.Enabled = false;
            }
        }

        private void cbChoose_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
                isAll = true;
            else
                isAll = false;
        }
    }
}