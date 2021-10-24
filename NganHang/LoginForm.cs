using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NganHang
{
    public partial class LoginForm : Form
    {
        public static SqlConnection conn_Publisher = new SqlConnection();
        public LoginForm()
        {
            InitializeComponent();
            GetListFragments("SELECT * FROM [dbo].[V_DS_PHANMANH]");
            
        }


        private void GetListFragments(String cmd)
        {
            DataTable dt = new DataTable();
            if (conn_Publisher.State != ConnectionState.Closed)
            {
                conn_Publisher.Close();
            }
            else
            {
                try
                {
                    conn_Publisher.ConnectionString = Program.connStr_Publisher;
                    conn_Publisher.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể kết nối với cơ sở dữ liệu");
                    return;
                }
            }
            

            SqlDataAdapter da = new SqlDataAdapter(cmd, conn_Publisher);
            da.Fill(dt);
            conn_Publisher.Close();

            Program.dbs_ListFragments.DataSource = dt;
            cmbBranch.DataSource = Program.dbs_ListFragments;
            cmbBranch.DisplayMember = "TENCN";
            cmbBranch.ValueMember = "TENSERVER";

            //dgvNhanVien.DataSource = Program.dbs_ListFragments;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbUsername.Text.Trim()=="" || tbPassword.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng không bỏ trống tài khoản, mật khẩu");
                return;
            }

            Program.mLogin = tbUsername.Text;
            Program.password = tbPassword.Text;

            Program.mBranch = cmbBranch.SelectedIndex;
            Program.mLoginDN = Program.mLogin;
            Program.passwordDN = Program.password;
            Program.currentServerName = Program.serverName = cmbBranch.SelectedValue.ToString();

            if (Program.Connect() == 0) return;

            string cmd = "EXEC [dbo].[SP_DANGNHAP] '" + Program.mLogin + "'";

            Program.myReader = Program.ExecSqlDataReader(cmd);
            if (Program.myReader == null) return;
            Program.myReader.Read();

            Program.userName = Program.myReader.GetString(0); //lay user name

            if(Convert.IsDBNull(Program.userName))
            {
                MessageBox.Show("Tài khoản của bạn không có quyền truy cập dữ liệu." + Environment.NewLine+ " Vui lòng xem lại username và password", "", MessageBoxButtons.OK);
                return;
            }

            try
            {
                Program.mFullname = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
            }
            catch(Exception ex)
            {
                Program.mFullname = "Null";
                Program.mGroup = "Null";
            }
            
            
            Program.myReader.Close();

            MessageBox.Show("Đăng nhập thành công", "", MessageBoxButtons.OK);

            Program.mainForm.lbUserId.Caption =  Program.userName;
            Program.mainForm.lbName.Caption = Program.mFullname;
            Program.mainForm.lbGroup.Caption = Program.mGroup;
            Program.mainForm.ShowMenu();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {

        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
