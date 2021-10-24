using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace NganHang
{
    public partial class AccountForm : Form
    {
        private bool isAdding = false;
        private bool isEditing = false;
        private bool firstLoad = false;
        
        public AccountForm()
        {
            InitializeComponent();
            LoadDefaultForm();

            cmbBranch.DataSource = Program.dbs_ListFragments;
            cmbBranch.DisplayMember = "TENCN";
            cmbBranch.ValueMember = "TENSERVER";
            cmbBranch.SelectedIndex = Program.mBranch;

            cmbBranch.Enabled = false;

            Program.AuthorizeCombobox(cmbBranch);
            firstLoad = true;
        }

        #region Events

        private void gvAccount_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gv = sender as GridView;
            DataRowView drv = gv.GetRow(e.FocusedRowHandle) as DataRowView;
            if (drv != null)
            {
                tbUserId.Text = drv[1].ToString();
                tbLoginName.Text = drv[0].ToString();
                tbFullname.Text = drv[2].ToString();
                tbGroup.Text = drv[3].ToString();
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EnableAdd();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(tbUserId.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản muốn chỉnh sửa", "", MessageBoxButtons.OK);
                return;
            }

            if(tbUserId.Text.Trim() != Program.userName)
            {
                MessageBox.Show("Không thể chỉnh sửa tài khoản của người khác", "", MessageBoxButtons.OK);
                return;
            }
            EnableEdit();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(isAdding)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có thật sự muốn tạo mới login?.", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AddLogin();
                }
            }
            else if (isEditing)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có thật sự muốn chỉnh sửa login?.", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    EditLogin();
                }
            }
            LoadDefaultForm();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSaveToFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnQuit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdding)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn hủy bỏ tạo mới?.", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    isAdding = false;
                    LoadDefaultForm();
                }
                return;
            }


            if (isEditing)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn hủy bỏ chỉnh sửa.", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    isEditing = false;
                    LoadDefaultForm();
                }
                return;
            }

            this.Close();
        }

        private void gvStaff_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gv = sender as GridView;
            DataRowView drv = gv.GetRow(e.FocusedRowHandle) as DataRowView;
            if (drv != null)
            {
                tbStaffId.Text = drv[0].ToString();
                tbStaffFirstName.Text = drv[1].ToString();
                tbStaffLastName.Text = drv[2].ToString();
                tbStaffAddress.Text = drv[3].ToString();
                tbStaffGender.Text = drv[4].ToString();
                tbStaffPhoneNumber.Text = drv[5].ToString();
                tbStaffBranch.Text = drv[6].ToString();
            }
        }

        #endregion

        #region Methods

        private void EnableAdd()
        {
            StaffLoad();
            tbLoginName.Focus();

            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;

            isAdding = true;
        }

        private void EnableEdit()
        {
            lbPassword.Visible = tbPassword.Visible = true;
            gcAccount.Enabled = false;

            btnAdd.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;

            isEditing = true;
            pnAccount.Enabled = true;
        }

        private void StaffLoad()
        {
            btnEdit.Enabled = false;
            gcAccount.Visible = false;
            pnAccount.Visible = false;

            gcStaff.Size = gcAccount.Size;
            gcStaff.Visible = true;

            pncStaff.Visible = true;

            BindingDataForStaff();
        }

        private void DefaultButton()
        {
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
        }

        private void LoadDefaultForm()
        {
            gcStaff.Visible = pncStaff.Visible = false;
            lbPassword.Visible = tbPassword.Visible = false;

            gcAccount.Visible = true;
            pnAccount.Visible = true;
            gcAccount.Enabled = true;
            BindingDataForAccount();

            DefaultButton();

            isAdding = isEditing = false;
        }

        private void AddLogin()
        {
            if (Program.Connect() == 0)
            {
                MessageBox.Show("Lỗi kết nối", "", MessageBoxButtons.OK);
                return;
            }
            if (tbRegisterLogin.Text.Trim() == "")
            {
                MessageBox.Show("Không thể để trống tài khoản", "", MessageBoxButtons.OK);
                return;
            }
            if (tbRegisterPassword.Text.Trim() == "")
            {
                MessageBox.Show("Không thể để trống mật khẩu", "", MessageBoxButtons.OK);
                return;
            }

            string cmd = String.Format("exec [dbo].[SP_TAOLOGIN] '{0}', '{1}', '{2}', '{3}'",
                tbRegisterLogin.Text.Trim(),
                tbRegisterPassword.Text.Trim(),
                tbStaffId.Text.Trim(),
                Program.mGroup.Trim());

            if (Program.ExecSqlNonQuery(cmd) !=1) return;
        }

        private void EditLogin()
        {

        }

        private void BindingDataForAccount()
        {
            Cursor.Current = Cursors.WaitCursor;

            if (Program.mGroup == "NGANHANG" && Program.serverName != Program.currentServerName)
            {
                if (Program.RemoteConnect() == 0 )
                {
                    MessageBox.Show("Có lỗi trong quá trình xử lý.");
                    return;
                }
            }
            else
            {
                if (Program.Connect() == 0)
                {
                    MessageBox.Show("Có lỗi trong quá trình xử lý.");
                    return;
                }

            }
            string cmd = "EXEC LietKeTaiKhoan";

            DataTable dt = Program.ExecSqlDataTable(cmd);
            if (dt == null) return;

            gcAccount.DataSource = dt;

            Cursor.Current = Cursors.Default;

            gvAccount.FocusedRowChanged += gvAccount_FocusedRowChanged;
        }

        private void BindingDataForStaff()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (Program.Connect() == 0) return;

            string cmd = "select * from NhanVienChuaCoLogin";

            DataTable dt = Program.ExecSqlDataTable(cmd);
            if (dt == null) return;

            gcStaff.DataSource = dt;

            Cursor.Current = Cursors.Default;
        }

        #endregion

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(firstLoad)
            {
                Program.serverName = cmbBranch.SelectedValue.ToString().Trim();
                LoadDefaultForm();
            }
        }


    }
}
