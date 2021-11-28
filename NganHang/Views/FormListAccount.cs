using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace NganHang.Views
{
    public partial class FormListAccount : DevExpress.XtraEditors.XtraForm
    {
        private string MACN = "";
        public FormListAccount()
        {
            InitializeComponent();
        }



        private void FormListAccount_Load(object sender, EventArgs e)
        {
            comboBoxBranch.DataSource = Program.dbs_ListFragments;
            comboBoxBranch.DisplayMember = "TENCN";
            comboBoxBranch.ValueMember = "TENSERVER";
            comboBoxBranch.SelectedIndex = Program.mBranch;
            if (Program.mGroup == "NGANHANG")
            {
                cbChoose.Visible = true;
                comboBoxBranch.Enabled = true;
            }
            else
            {
                cbChoose.Visible = false;
                comboBoxBranch.Enabled = false;
            }
            GetBranchId();
        }

        private void comboBoxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxBranch.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.serverName = comboBoxBranch.SelectedValue.ToString();
            if (Program.currentServerName != Program.serverName)
            {
                if (Program.RemoteConnect() == 0)
                {
                    MessageBox.Show("Lỗi kết nối về chi nhánh", "", MessageBoxButtons.OK);
                }
            }
            else
            {
                if (Program.Connect() == 0)
                {
                    MessageBox.Show("Lỗi kết nối về chi nhánh", "", MessageBoxButtons.OK);
                }
            }
            
            GetBranchId();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            
            DateTime temps = datePickerFrom.Value;
            DateTime tempe = datePickerTo.Value;
            ReportBankAccount report = new ReportBankAccount(temps, tempe, MACN);
            report.txtBranch.Text = comboBoxBranch.Text;
            report.txtFrom.Text = datePickerFrom.Value.ToString();
            report.txtTo.Text = datePickerTo.Value.ToString();
            report.txtDate.Text = DateTime.Now.ToString();
            report.txtStaff.Text = Program.userName;
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
            Cursor.Current = Cursors.Default;
        }

        private void GetBranchId()
        {
            Program.serverName = comboBoxBranch.SelectedValue.ToString().Trim();

            string cmdGetBranchId = "select *from LayMaChiNhanh";

            if (Program.mGroup == "CHINHANH")
            {
                if (Program.Connect() == 0)
                {
                    MessageBox.Show("Có lỗi trong quá trình xử lý.");
                    return;
                }
            }
            else
            {
                if (Program.RemoteConnect() == 0)
                {
                    MessageBox.Show("Có lỗi trong quá trình xử lý.");
                    return;
                }

            }

            Program.myReader = Program.ExecSqlDataReader(cmdGetBranchId);

            if (Program.myReader == null)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý.");
                return;
            }
            Program.myReader.Read();

            MACN = Program.myReader.GetString(0).Trim();
        }

        private void cbChoose_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.Checked)
            {
                MACN = "All";
            }
            else
                GetBranchId();
        }
    }
}