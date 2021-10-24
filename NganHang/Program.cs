using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using NganHang.UndoRedo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace NganHang
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        public static SqlConnection conn = new SqlConnection();
       
        public static String connStr;
        public static String connStr_Publisher = "Data Source=DESKTOP-SBOS10S;Initial Catalog=NGANHANG;Integrated Security=True";

        public static SqlDataReader myReader;
        public static String serverName = "";
        public static String currentServerName = "";
        public static String userName = "";
        public static String mLogin = "";
        public static String password = "";

        public static String database = "NGANHANG";
        public static String remoteLogin = "htkn";
        public static String remotePassword = "123";
        public static String mLoginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mFullname = "";
        public static int mBranch = 0;

        public static BindingSource dbs_ListFragments = new BindingSource();
        public static MainForm mainForm;

        public static int Connect()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connStr = "Data Source=" + Program.serverName + ";Initial Catalog=" +
                    Program.database + ";User ID=" +
                    Program.mLogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connStr;
                Program.conn.Open();
                return 1;
            }
            catch(Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu." + Environment.NewLine+ "Bạn vui lòng xem lại username và pasword." + Environment.NewLine+ "" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static int RemoteConnect()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connStr = "Data Source=" + Program.serverName + ";Initial Catalog=" +
                    Program.database + ";User ID=" +
                    Program.remoteLogin + ";password=" + Program.remotePassword;
                Program.conn.ConnectionString = Program.connStr;
                Program.conn.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu." + Environment.NewLine+ "Bạn vui lòng xem lại username và pasword." + Environment.NewLine+ "" + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String cmd)
        {
            SqlDataReader reader;
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();

            try
            {
                reader = sqlcmd.ExecuteReader();
                //Program.conn.Close();
                return reader;
            }catch(SqlException e)
            {
                Program.conn.Close();
                MessageBox.Show(e.Message);
                return null;
            }
        }

        public static DataTable ExecSqlDataTable(String cmd)
        {
            DataTable dt = new DataTable();

            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;

        }

        public static void AuthorizeCombobox(System.Windows.Forms.ComboBox cmb)
        {
            if (mGroup == "CHINHANH")
            {
                cmb.Enabled = false;
                return;
            }
            else
            {
                cmb.Enabled = true;
                return;
            }
        }

        public static void AuthorizeConnect()
        {
            if (mGroup == "CHINHANH")
            {
                if (Connect() == 0)
                {
                    MessageBox.Show("Có lỗi trong quá trình xử lý.");
                    return;
                }
            }
            else
            {
                if (RemoteConnect() == 0)
                {
                    MessageBox.Show("Có lỗi trong quá trình xử lý.");
                    return;
                }
            }
        }

        public static int ExecSqlNonQuery(String cmd)
        {
            SqlCommand sqlcmd = new SqlCommand(cmd, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                sqlcmd.ExecuteNonQuery();
                conn.Close();
                return 1;
            }
            catch (SqlException e)
            {
                if (e.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show("Bạn format cell lại cột\"Ngày\" qua kiểu number hoặc mở file Exel.");
                else MessageBox.Show(e.Message);
                Program.conn.Close();
                MessageBox.Show(e.Message);
                //state la error gui ve tu sql server
                return e.State;
            }
        }

        public static void SetDefautValue()
        {
            mLogin = "";
            password = "";

            mBranch = 0;
            mLoginDN = "";
            passwordDN = "";
            serverName = "";
            userName = "";
            mGroup = "";
        }

        public static void UndoRedo(ref Stack<UndoRedoControl> stackPop, ref Stack<UndoRedoControl> stackPush, Control container)
        {
            if (stackPop.Count < 1)
                return;

            UndoRedoControl ur = stackPop.Pop();
            stackPush.Push(ur);
            foreach (Control item in container.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tb = (TextBox)item;

                    if (tb.Name.Equals(ur.Name))
                    {
                        tb.Text = ur.Text;
                        tb.Focus();
                        tb.Select(tb.Text.Length, 0);
                    }
                }
                else if (item is TextEdit)
                {
                    TextEdit te = (TextEdit)item;

                    if (te.Name.Equals(ur.Name))
                    {
                        te.Text = ur.Text;
                        te.Focus();
                        te.Select(te.Text.Length, 0);
                    }
                }
                else if (item is System.Windows.Forms.ComboBox)
                {
                    System.Windows.Forms.ComboBox cb = (System.Windows.Forms.ComboBox)item;

                    if (cb.Name.Equals(ur.Name))
                    {
                        cb.SelectedIndex = ur.Index;
                        cb.Focus();
                    }
                }
                else if (item is CheckBox)
                {
                    CheckBox cb = (CheckBox)item;

                    if (cb.Name.Equals(ur.Name))
                    {
                        cb.Checked = ur.Check;
                        cb.Focus();
                    }
                }
            }
        }

        public static void SetEnableBtnEndoRedo(ref Stack<UndoRedoControl> stackUndo, ref Stack<UndoRedoControl> stackRedo, BarButtonItem btnUndo, BarButtonItem btnRedo)
        {
            if (stackRedo.Count > 0)
            {
                btnRedo.Enabled = true;
            }
            else if (stackRedo.Count < 1)
            {
                btnRedo.Enabled = false;
            }

            if (stackUndo.Count > 0)
            {
                btnUndo.Enabled = true;
            }
            else if (stackUndo.Count < 1)
            {
                btnUndo.Enabled = false;
            }
        }

        public static void InitUndoRedoCombobox(object sender, ref Stack<UndoRedoControl> stackUndo, BarButtonItem btnUndo)
        {
            System.Windows.Forms.ComboBox cb = sender as System.Windows.Forms.ComboBox;
            UndoRedoControl ur = new UndoRedoControl(cb.Name, cb.SelectedIndex);
            stackUndo.Push(ur);
            if (stackUndo.Count > 0)
            {
                btnUndo.Enabled = true;
            }
        }

        public static void InitUndoRedoForTextBox(object sender, ref Stack<UndoRedoControl> stackUndo, BarButtonItem btnUndo)
        {
            TextBox tb = sender as TextBox;
            UndoRedoControl ur = new UndoRedoControl(tb.Name, tb.Text);
            stackUndo.Push(ur);
            if (stackUndo.Count > 0)
            {
                btnUndo.Enabled = true;
            }
        }

        public static void InitUndoRedoForCheckBox(object sender, ref Stack<UndoRedoControl> stackUndo, BarButtonItem btnUndo)
        {
            CheckBox cb = sender as CheckBox;

            UndoRedoControl ur = new UndoRedoControl(cb.Name, !cb.Checked);
            stackUndo.Push(ur);
            if (stackUndo.Count > 0)
            {
                btnUndo.Enabled = true;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainForm = new MainForm();
            
            
            Application.Run(mainForm);
        }
    }
}
