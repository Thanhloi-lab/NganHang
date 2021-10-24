using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang
{
    public partial class UserInfoForm : Form
    {
        private string lastestFirstName = "";
        private string lastestLastName = "";
        private string lastestAddress = "";
        private string lastestGender = "";
        private string lastestPhoneNumber = "";


        public UserInfoForm()
        {
            InitializeComponent();
            cbGender.Items.Add("Nam");
            cbGender.Items.Add("Nữ");

            LoadForm();
        }
        private void LoadForm()
        {
            if (Program.Connect() == 0) return;

            string cmd = "EXEC [dbo].[timNhanVien] '" + Program.userName + "'";

            try
            {
                Program.myReader = Program.ExecSqlDataReader(cmd);
                if (Program.myReader == null) return;
                Program.myReader.Read();

                tbUserId.Text  = Program.myReader.GetString(0);
                tbFirstName.Text = lastestFirstName = Program.myReader.GetString(1);
                tbLastName.Text = lastestLastName = Program.myReader.GetString(2);
                tbAddress.Text = lastestAddress = Program.myReader.GetString(3);
                cbGender.SelectedItem = lastestGender = Program.myReader.GetString(4);
                tbPhoneNumber.Text = lastestPhoneNumber = Program.myReader.GetString(5);
                tbBranch.Text  = Program.myReader.GetString(6);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình tải dữ liệu." + Environment.NewLine+ "" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            DefaultButton();
        }

        private void EnableEdit()
        {
            tbAddress.ReadOnly = tbFirstName.ReadOnly = tbLastName.ReadOnly = tbPhoneNumber.ReadOnly = false;
            cbGender.Enabled = true;

            btnAdd.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
        }

        private void DisableEdit()
        {
            tbAddress.ReadOnly = tbFirstName.ReadOnly = tbLastName.ReadOnly = tbPhoneNumber.ReadOnly = true;
            btnAdd.Enabled = cbGender.Enabled = false;

            btnEdit.Enabled = false;
        }

        private void DefaultButton()
        {
            tbAddress.ReadOnly = tbFirstName.ReadOnly = tbLastName.ReadOnly = tbPhoneNumber.ReadOnly = true;
            btnUndo.Enabled =  cbGender.Enabled = false;

            btnAdd.Enabled = btnEdit.Enabled = btnQuit.Enabled = btnReload.Enabled =  true;
        }

        private int EditInfo()
        {
            if (Program.Connect() == 0) return 0;

            string cmd = String.Format("EXEC [dbo].[suaNhanVien] '{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}', '{6}', {7}",
                tbUserId.Text.Trim(), tbFirstName.Text.Trim(), tbLastName.Text.Trim(), tbAddress.Text.Trim(), cbGender.Text, tbPhoneNumber.Text.Trim(), tbBranch.Text.Trim(), 0);


            try
            {
                return Program.ExecSqlNonQuery(cmd);
                
            }catch(Exception ex)
            {
                return 0;
            }
        }


        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadForm();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EnableEdit();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn thay đổi thông tin cá nhân", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if(EditInfo() == 0)
                {
                    MessageBox.Show("Có lỗi trong quá trình xử lý, vui lòng thử lại sau", "", MessageBoxButtons.OK);
                }
            }
            LoadForm();
            DefaultButton();
            return;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn phục hồi thông tin một bước trước đó?", "", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                string cmd = String.Format("EXEC [dbo].[suaNhanVien] '{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}', '{6}', {7}",
                tbUserId.Text.Trim(), lastestFirstName.Trim(), lastestLastName.Trim(), lastestAddress.Trim(), lastestGender.Trim(), lastestPhoneNumber.Trim(), tbBranch.Text.Trim(), 0);
                try
                {
                    MessageBox.Show("Đã khôi phục thông tin");

                }
                catch (Exception ex)
                {
                   MessageBox.Show("Khôi phục thông tin thất bại." + Environment.NewLine+ "" + ex.Message);
                }
            }
            LoadForm();
        }

        private void btnQuit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}
