using ClosedXML.Excel;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using NganHang.UndoRedo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace NganHang
{
    public partial class AccountForm : Form
    {
        private bool isAdding = false;
        private bool isEditing = false;
        private bool firstLoad = false;
        private DataRowView drvCache;


        private Stack<UndoRedoControl> stackUndo;
        private Stack<UndoRedoControl> stackRedo;

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
            stackUndo = new Stack<UndoRedoControl>();
            stackRedo = new Stack<UndoRedoControl>();

            firstLoad = true;

        }

        #region Events

        private void gvAccount_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gv = sender as GridView;
            DataRowView drv = drvCache = gv.GetRow(e.FocusedRowHandle) as DataRowView;
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
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn tạo mới login?.", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AddLogin();
                    StaffLoad();
                    return;
                }
            }
            else if (isEditing)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn chỉnh sửa login?.", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    EditLogin();
                    return;
                }
                LoadDefaultForm();
            }
            
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Program.userName.Trim() == tbUserId.Text.Trim())
            {
                MessageBox.Show("Bạn không thể xóa chính bản thân", "", MessageBoxButtons.OK);
                return;
            }
            else
            {

                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa người dùng " + tbFullname.Text + "?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    DeleteUser();
                }
               
            }
            
            return;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            if (isAdding)
            {
                dialogResult = MessageBox.Show("Bạn có muốn hủy bỏ tạo mới?.", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    StaffLoad();
                    drvCache = null; 
                }
                return;
            }
            else if(isEditing)
            {
                dialogResult = MessageBox.Show("Bạn có muốn hủy bỏ chỉnh sửa.", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    isEditing = false;
                    LoadDefaultForm();
                    drvCache = null;
                }
                return;
            }

            LoadDefaultForm();
            drvCache = null;
            return;
        }

        private void btnSaveToFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        DataTable dt = GetDataTable(gvAccount);

                        workbook.Worksheets.Add(dt, "Account");
                        workbook.SaveAs(sfd.FileName);
                    }
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Tải xuống thành công.");
                    ClearStack();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi trong quá trình tải xuống, vui lòng thử lại sau.");
                }
            }
        }

        private void btnQuit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdding)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn hủy bỏ tạo mới?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    isAdding = false;
                    LoadDefaultForm();
                    drvCache = null;
                }
                return;
            }
            else if (isEditing)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn hủy bỏ chỉnh sửa?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    isEditing = false;
                    LoadDefaultForm();
                    drvCache = null;
                }
                return;
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn thoát khỏi trang này?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Close();
                }
            }

        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad)
            {
                Program.serverName = cmbBranch.SelectedValue.ToString().Trim();
                LoadDefaultForm();
                drvCache = null;
            }
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdding)
            {
                if (drvCache != null)
                {
                    tbRegisterLogin.Text = "";
                    tbRegisterPassword.Text = "";
                }
            }
            else if (isEditing)
            {
                if (drvCache != null)
                {
                    tbLoginName.Text = drvCache[0].ToString();
                    tbPassword.Text = "";
                }
            }
            ClearStack();
        }

        private void gvStaff_FocusedRowChanged_1(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            GridView gv = sender as GridView;
            DataRowView drv =  gv.GetRow(e.FocusedRowHandle) as DataRowView;
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

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isEditing)
            {
                Program.UndoRedo(ref stackUndo, ref stackRedo, pnAccount, false);
                Program.SetEnableBtnEndoRedo(ref stackUndo, ref stackRedo, btnUndo, btnRedo);
            }
            else if (isAdding)
            {
                Program.UndoRedo(ref stackUndo, ref stackRedo, pncStaff, false);
                Program.SetEnableBtnEndoRedo(ref stackUndo, ref stackRedo, btnUndo, btnRedo);
            }
        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isEditing)
            {
                Program.UndoRedo(ref stackRedo, ref stackUndo, pnAccount, false);
                Program.SetEnableBtnEndoRedo(ref stackUndo, ref stackRedo, btnUndo, btnRedo);
            }
            else if (isAdding)
            {
                Program.UndoRedo(ref stackRedo, ref stackUndo, pncStaff, false);
                Program.SetEnableBtnEndoRedo(ref stackUndo, ref stackRedo, btnUndo, btnRedo);
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.InitUndoRedoForTextBox(sender, ref stackUndo, btnUndo);
        }

        private void tbLoginName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.InitUndoRedoForTextBox(sender, ref stackUndo, btnUndo);
        }

        private void tbRegisterLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.InitUndoRedoForTextBox(sender, ref stackUndo, btnUndo);
        }

        private void tbRegisterPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.InitUndoRedoForTextBox(sender, ref stackUndo, btnUndo);
        }

        #endregion

        #region Methods

        private void EnableAdd()
        {
            StaffLoad();
            tbLoginName.Focus();

            btnSaveToFile.Enabled = btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = btnRestore.Enabled = true;

            isAdding = true;
            ClearStack();
        }

        private void EnableEdit()
        {
            lbPassword.Visible = tbPassword.Visible = true;
            gcAccount.Enabled = false;
            tbLoginName.Enabled = true;

             btnAdd.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = btnRestore.Enabled = true;

            isEditing = true;
            pnAccount.Enabled = true;
            
            ClearStack();
        }

        private void StaffLoad()
        {
            Cursor.Current = Cursors.WaitCursor;
            btnEdit.Enabled = false;
            gcAccount.Visible = false;
            pnAccount.Visible = false;

            gcStaff.Size = gcAccount.Size;
            gcStaff.Visible = true;

            pncStaff.Visible = true;

            foreach (Control item in pncStaff.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }

            }

            BindingDataForStaff();
            Cursor.Current = Cursors.Default;
        }

        private void DefaultButton()
        {
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = true;
            btnSave.Enabled = btnRestore.Enabled = false;
        }

        private void LoadDefaultForm()
        {
            Cursor.Current = Cursors.WaitCursor;
            gcStaff.Visible = pncStaff.Visible = false;
            tbLoginName.Enabled = lbPassword.Visible = tbPassword.Visible = false;

            gcAccount.Visible = true;
            pnAccount.Visible = true;
            gcAccount.Enabled = true;

            foreach(Control item in pnAccount.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                
            }
            BindingDataForAccount();

            DefaultButton();

            isAdding = isEditing = false;
            Cursor.Current = Cursors.Default;
        }

        private void AddLogin()
        {
            if (Program.Connect() == 0)
            {
                MessageBox.Show("Lỗi kết nối", "", MessageBoxButtons.OK);
                return ;
            }
            if (tbRegisterLogin.Text.Trim() == "")
            {
                MessageBox.Show("Không thể để trống tài khoản", "", MessageBoxButtons.OK);
                return ;
            }
            if (tbRegisterPassword.Text.Trim() == "")
            {
                MessageBox.Show("Không thể để trống mật khẩu", "", MessageBoxButtons.OK);
                return ;
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

            if (Program.Connect() == 0)
            {
                MessageBox.Show("Lỗi kết nối", "", MessageBoxButtons.OK);
                return;
            }
            if (tbLoginName.Text.Trim() == "")
            {
                MessageBox.Show("Không thể để trống tài khoản", "", MessageBoxButtons.OK);
                return;
            }
            if (tbPassword.Text.Trim() == "")
            {
                MessageBox.Show("Không thể để trống mật khẩu", "", MessageBoxButtons.OK);
                return;
            }

            string cmd = String.Format("exec [dbo].[doiMatKhauTaiKhoanDangNhap] '{0}', '{1}'",
                tbLoginName.Text.Trim(),
                tbPassword.Text.Trim());

            if (Program.ExecSqlNonQuery(cmd) == 1)
            {
                MessageBox.Show("Đổi mật khẩu thành công, vui lòng đăng nhập lại.", "", MessageBoxButtons.OK);
                Program.SetDefautValue();
                Program.mainForm.HideMenu();
                Program.mainForm.ShowLoginForm();
                Program.mainForm.ButtonBeforeLogin();
                return;
            }
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
            gvAccount.FocusedRowHandle = 0;

            Cursor.Current = Cursors.Default;
        }

        private void BindingDataForStaff()
        {
            Cursor.Current = Cursors.WaitCursor;
            if (Program.Connect() == 0) return;

            string cmd = "select * from NhanVienChuaCoLogin";

            DataTable dt = Program.ExecSqlDataTable(cmd);
            if (dt == null) return;

            gcStaff.DataSource = dt;
            gvStaff.FocusedRowHandle = 0;

            Cursor.Current = Cursors.Default;
        }

        private void ClearStack()
        {
            stackUndo.Clear();
            stackRedo.Clear();
            btnUndo.Enabled = false;
            btnRedo.Enabled = false;
        }

        private void DeleteUser()
        {

            if (Program.Connect() == 0)
            {
                MessageBox.Show("Lỗi kết nối", "", MessageBoxButtons.OK);
                return;
            }
            if (tbLoginName.Text.Trim() == "")
            {
                MessageBox.Show("Không thể để trống tài khoản", "", MessageBoxButtons.OK);
                return;
            }
            if (tbUserId.Text.Trim() == "")
            {
                MessageBox.Show("Không thể để trống mã nhân viên", "", MessageBoxButtons.OK);
                return;
            }
            if (!tbGroup.Text.Trim().Equals(Program.mGroup.Trim()))
            {
                MessageBox.Show("Bạn không thể xóa tài khoản thuộc nhóm quyền khác.", "", MessageBoxButtons.OK);
                return;
            }

            string cmd = String.Format("exec [dbo].[XOALOGIN] '{0}', '{1}'",
                tbUserId.Text.Trim(),
                tbLoginName.Text.Trim());

            if (Program.ExecSqlNonQuery(cmd) == 1)
            {
                MessageBox.Show("Xóa thành công", "", MessageBoxButtons.OK);
                LoadDefaultForm();
                return;
            }

        }

        private DataTable GetDataTable(GridView view)
        {
            DataTable dt = new DataTable();
            foreach (GridColumn c in view.Columns)
                dt.Columns.Add(c.FieldName, c.ColumnType);
            for (int r = 0; r < view.RowCount; r++)
            {
                object[] rowValues = new object[dt.Columns.Count];
                for (int c = 0; c < dt.Columns.Count; c++)
                    rowValues[c] = view.GetRowCellValue(r, dt.Columns[c].ColumnName);
                dt.Rows.Add(rowValues);
            }
            return dt;
        }

        #endregion

        private void gcAccount_DataSourceChanged(object sender, EventArgs e)
        {
            this.ActiveControl = this.gcAccount;
            this.gvAccount.FocusedRowHandle = 0;

            if (gcAccount.DataSource != null)
            {
                try
                {
                    DataRowView drv = drvCache = gvAccount.GetRow(0) as DataRowView;
                    if (drv != null)
                    {
                        tbUserId.Text = drv[1].ToString();
                        tbLoginName.Text = drv[0].ToString();
                        tbFullname.Text = drv[2].ToString();
                        tbGroup.Text = drv[3].ToString();
                    }
                }catch(Exception ex)
                {

                }
                
            }
        }

        private void gcStaff_DataSourceChanged(object sender, EventArgs e)
        {
            this.ActiveControl = this.gcStaff;
            this.gvStaff.FocusedRowHandle = 0;

            if (gcStaff.DataSource != null)
            {
                try{
                    DataRowView drv = gvStaff.GetRow(0) as DataRowView;
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
                }catch(Exception ex)
                {

                }
                
            }
        }
    }
}
