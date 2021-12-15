using ClosedXML.Excel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using NganHang.UndoRedo;
using NganHang.Validation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace NganHang
{
    public partial class StaffForm : Form
    {
        private static string branchId = "";
        private int position = 0;
        private bool firstLoad = false;
        private bool isSwitchBranch = false;
        private bool isAdding = false;
        private bool isEditing = false;

        private Stack<UndoRedoControl> stackUndo;
        private Stack<UndoRedoControl> stackRedo;
        public static SqlConnection conn_Publisher = new SqlConnection();
        public static BindingSource staff_Dbs_ListFragments = new BindingSource();

        #region Events
        public StaffForm()
        {
            stackUndo = new Stack<UndoRedoControl>();
            stackRedo = new Stack<UndoRedoControl>();
            InitializeComponent();
            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = true;
            gcStaff.Enabled = true;
            pcStaff.Enabled = false;

            cbGender.Items.Add("Nam");
            cbGender.Items.Add("Nữ");

            cmbBranch.DataSource = Program.dbs_ListFragments;
            cmbBranch.DisplayMember = "TENCN";
            cmbBranch.ValueMember = "TENSERVER";
            cmbBranch.SelectedIndex = Program.mBranch;

            GetListFragments("SELECT * FROM [dbo].[V_DS_PHANMANH]");
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNhanVien.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            LoadData();
            //Phan quyen
            Reload();
            firstLoad = true;
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsNhanVien.Position;
            bdsNhanVien.AddNew();
            ClearStack();
            EnableAdd();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsNhanVien.Position;
            ClearStack();
            EnableEdit();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OptionDelete();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if(!MyRegex.ValidateSurname(tbFirstName.Text))
            {
                tbFirstName.Focus();
                return;
            }

            if (!MyRegex.ValidateName(tbLastName.Text))
            {
                tbLastName.Focus();
                return;
            }

            if (!MyRegex.ValidatePhoneNumber(tbPhoneNumber.Text))
            {
                tbPhoneNumber.Focus();
                return;
            }
            if (!MyRegex.ValidateAddress(tbAddress.Text))
            {
                tbAddress.Focus();
                return;
            }

            if (!MyRegex.ValidateCMND(cMNDTextEdit.Text))
            {
                cMNDTextEdit.Focus();
                return;
            }

            if (isSwitchBranch)
            {
                if (SwitchStaffBranch())
                {
                    MessageBox.Show("Chuyển thành công.");
                    isSwitchBranch = false;
                    isAdding = false;
                    isEditing = false;
                    LoadData();
                    ClearStack();
                }
                else
                    return;
            }
            else
            {
                if (isEditing)
                {
                    if (EditStaff())
                    {
                        this.nhanVienTableAdapter.Connection.ConnectionString = Program.connStr;
                        this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                        isEditing = false;
                        bdsNhanVien.Position = position;
                        ClearStack();
                    }
                    else
                    {
                        return;
                    }
                }
                else if (isAdding)
                {
                    if (AddStaff())
                    {
                        bdsNhanVien.EndEdit();
                        isAdding = false;
                        FormReload();
                        bdsNhanVien.Position = bdsNhanVien.Count - 1;
                        return;
                    }
                    else
                    {
                        return;
                    }
                }
            }

            Reload();
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
                        DataTable dt = GetDataTable(gvStaff);

                        workbook.Worksheets.Add(dt, "Staff");
                        workbook.SaveAs(sfd.FileName);
                    }
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Tải xướng thành công.");
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
            if(isAdding || isEditing || isSwitchBranch)
            {
                if(MessageBox.Show("Bạn có muỗn thoát khỏi trang này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ClearStack();
                    Reload();
                }
            }
            else
                if (MessageBox.Show("Bạn có muỗn thoát khỏi trang này?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ClearStack();
                    QuitForm();
                }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn tải lại trang?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                FormReload();
            }
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == true)
            {
                ClearStack();
                GetBranchId();
                LoadData();
            }
        }

        private void tbFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.InitUndoRedoForTextBox(sender, ref stackUndo, btnUndo);
        }

        private void tbLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.InitUndoRedoForTextBox(sender, ref stackUndo, btnUndo);
        }

        private void tbAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.InitUndoRedoForTextBox(sender, ref stackUndo, btnUndo);
        }

        private void tbPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextEdit te = sender as TextEdit;
            UndoRedoControl ur = new UndoRedoControl(te.Name, te.Text);
            stackUndo.Push(ur);
        }

        private void cMNDTextEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextEdit te = sender as TextEdit;
            UndoRedoControl ur = new UndoRedoControl(te.Name, te.Text);
            stackUndo.Push(ur);
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (isAdding || isEditing)
            //{
                //System.Windows.Forms.ComboBox cb = sender as System.Windows.Forms.ComboBox;
                //int index = 0;
                //if (cb.SelectedIndex == 0)
                //{

                //}
                //UndoRedoControl ur = new UndoRedoControl(cb.Name, index);
                //stackUndo.Push(ur);
                //if (stackUndo.Count > 0)
                //{
                //    btnUndo.Enabled = true;
                //}
            //}
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có muốn hủy thao tác lại trang?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                bdsNhanVien.CancelEdit();
                if (btnAdd.Enabled == false)
                {
                    bdsNhanVien.Position = position;
                }
                gcStaff.Enabled = true;
                pcStaff.Enabled = false;
                btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = true;
                btnSave.Enabled = btnRestore.Enabled = false;

                Reload();
                ClearStack();
            }    
            
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.UndoRedo(ref stackUndo, ref stackRedo, pcStaff, false);
            Program.SetEnableBtnEndoRedo(ref stackUndo, ref stackRedo, btnUndo, btnRedo);
        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.UndoRedo(ref stackRedo, ref stackUndo, pcStaff, false);
            Program.SetEnableBtnEndoRedo(ref stackUndo, ref stackRedo, btnUndo, btnRedo);
        }

        private void cbxIsActive_MouseClick(object sender, MouseEventArgs e)
        {
            Program.InitUndoRedoForCheckBox(sender, ref stackUndo, btnUndo);
        }

        private void btnSwitchBranch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (tbUserId.Text.Trim().Equals(Program.userName))
            {
                MessageBox.Show("Bạn không thể chuyển chi nhánh của chính bản thân.");
                return;
            }
            EnableSwitchBranch();
        }

        #endregion

        #region Methods

        private void LoadData()
        {
            Cursor.Current = Cursors.WaitCursor;
            DS.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'dS.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connStr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

            // TODO: This line of code loads data into the 'DS.GD_CHUYENTIEN' table. You can move, or remove it, as needed.
            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connStr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);

            // TODO: This line of code loads data into the 'DS.GD_GOIRUT' table. You can move, or remove it, as needed.
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connStr;
            this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);

            try
            {
                branchId = ((DataRowView)bdsNhanVien[0])["MACN"].ToString();
            }
            catch (Exception ex)
            {
                GetBranchId();
            }
            Cursor.Current = Cursors.Default;
            stackUndo.Clear();
        }

        private void FormForRoleChiNhanh()
        {
            pnBranch.Visible = false;

            btnSaveToFile.Enabled = btnSwitchBranch.Enabled = btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnRestore.Enabled = true;
            btnRestore.Enabled= btnSave.Enabled = cmbBranch.Enabled = false;
        }

        private void FormForRoleNganHang()
        {
            pnBranch.Visible = false;
            btnSaveToFile.Enabled = btnSwitchBranch.Enabled = btnSave.Enabled = btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnRestore.Enabled = false;
            cmbBranch.Enabled = true;
            btnRestore.Enabled = btnSave.Enabled =false;
        }

        private void EnableAdd()
        {
            GetNewestUserId();
            GetBranchId();
            pnInfo.Enabled = true;
            gcStaff.Enabled = false;
            pcStaff.Enabled = true;
            tbFirstName.Focus();
            isAdding = true;
            

            btnSwitchBranch.Enabled = btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = btnRestore.Enabled = true;
            gcStaff.Enabled = false;
            
        }

        private void GetBranchId()
        {
            Program.serverName = cmbBranch.SelectedValue.ToString().Trim();

            string cmdGetBranchId = "select *from LayMaChiNhanh";

            if( Program.currentServerName == Program.serverName)
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


            //cbBranchId.Text = Program.myReader.GetString(0).Trim();
            branchId = Program.myReader.GetString(0).Trim();
        }

        private void GetNewestUserId()
        {
            Program.serverName = cmbBranch.SelectedValue.ToString().Trim();

            string cmd = "EXEC [dbo].[TaoMaNhanVien]"; /*'" + tbBranchId.Text.Trim() + "'";*/

            if (Program.Connect() == 0)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý.");
                return;
            }

            Program.myReader = Program.ExecSqlDataReader(cmd);
            Program.myReader.Read();

            tbUserId.Text = Program.myReader.GetString(0).Trim();
            if (Convert.IsDBNull(Program.userName))
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý.");
                return;
            }
        }

        private void EnableEdit()
        {
            pcStaff.Enabled = true;
            gcStaff.Enabled = false;
            //cbBranchId.Text = branchId;
            pnInfo.Enabled = true;
            isEditing = true;
            tbFirstName.Focus();

            btnSwitchBranch.Enabled = tbAddress.ReadOnly = tbFirstName.ReadOnly = tbLastName.ReadOnly = false;
            cbGender.Enabled = true;

            btnAdd.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = btnRestore.Enabled = true;
        }

        private void EnableSwitchBranch()
        {
            pcStaff.Enabled = pnBranch.Visible = true;
            cbBranchId.Text = cmbBranch.Text;
            cbBranchId.Focus();

            btnSwitchBranch.Enabled =  cbGender.Enabled =  btnAdd.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = btnRestore.Enabled = isSwitchBranch = true;
            pnInfo.Enabled = false;
        }

        private void OptionDelete()
        {
            if(Program.userName.Trim() == tbUserId.Text.Trim())
            {
                MessageBox.Show("Bạn không thể xóa chính bản thân", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsGuiRut.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Nhân viên đã từng thực hiện giao dịch gửi rút." + Environment.NewLine+ "Bạn có chắc muốn xóa nhân viên này?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    InActiveUser();
                }
                return;
            }
            else if (bdsChuyenTien.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Nhân viên đã từng thực hiện giao dịch chuyển tiền." + Environment.NewLine+ "Bạn có chắc muốn xóa nhân viên này?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    InActiveUser();
                }
                return;
            }

            DialogResult result = MessageBox.Show("Thực hiện xóa sẽ xóa tài khoản liên kết với nhân viên này." + Environment.NewLine+ "Bạn có chắc muốn xóa nhân viên này?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                
                DeleteUser();
            }
            return;
        }

        private bool InActiveUser()
        {
            Program.serverName = cmbBranch.SelectedValue.ToString().Trim();
            if(tbUserId.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần khóa", "", MessageBoxButtons.OK);
                return false;
            }
            string cmd = "exec dbo.KhoaNhanVien '" + tbUserId.Text.Trim() + "";

            if (Program.Connect() == 0)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý.");
                return false;
            }

            try
            {
                if(Program.ExecSqlNonQuery(cmd)==999)
                    return true;
            }catch(Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình khóa." + Environment.NewLine+ "" + ex.Message, "", MessageBoxButtons.OK);
                return false;
            }
            return false;
        }

        private void Reload()
        {
            gcStaff.Enabled = true;
            pcStaff.Enabled = false;
            isSwitchBranch = false;
            if (Program.mGroup == "NGANHANG")
            {
                FormForRoleNganHang();
            }

            else
            {
                FormForRoleChiNhanh();
            }
        }

        private void DeleteUser()
        {
            string userId = "";
            position = bdsNhanVien.Position;
            try
            {
                userId = ((DataRowView)bdsNhanVien[position])["MANV"].ToString();
                if (DeleteLogin(userId))
                {
                    bdsNhanVien.RemoveCurrent();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connStr;
                    this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                    if (position > 0)
                        bdsNhanVien.Position = position - 1;
                    else
                        bdsNhanVien.Position = 0;
                    ClearStack();
                    MessageBox.Show("Xóa nhân viên thành công.");
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình thực hiện, vui lòng thử lại sau.");
                }

                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện, vui lòng thử lại sau." + Environment.NewLine+ "" + ex.Message, "", MessageBoxButtons.OK);
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                bdsNhanVien.Position = bdsNhanVien.Find("MANV", userId);
            }


        }

        private bool DeleteLogin(string MANV)
        {
            if (MANV == "" || MANV == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa", "", MessageBoxButtons.OK);
                return false;
            }
            string cmdDeleteLogin = String.Format("exec dbo.xoaLogin '{0}'", tbUserId.Text.Trim());
            if (Program.Connect() == 0)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý.");
                return false;
            }
            try
            {
                int result = Program.ExecSqlNonQuery(cmdDeleteLogin);
                if (result == Program.excuteSuccess || result == Program.loginNotExist)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình chuyển, vui lòng thử lại sau." + Environment.NewLine + "" + ex.Message, "", MessageBoxButtons.OK);
                return false;
            }
            return false ;
        }

        private void QuitForm()
        {
            ClearStack();
            this.Close();
        }

        private void ClearStack()
        {
            stackUndo.Clear();
            stackRedo.Clear();
            btnUndo.Enabled = false;
            btnRedo.Enabled = false;
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

        private bool SwitchStaffBranch()
        {
            if (tbUserId.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần chuyển", "", MessageBoxButtons.OK);
                return false;
            }
            Program.serverName = cbBranchId.SelectedValue.ToString().Trim();
            string cmdRemote = String.Format("exec dbo.ChuyenNhanVien '{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}', '{6}'",
                tbUserId.Text.Trim(),
                tbFirstName.Text.Trim(),
                tbLastName.Text.Trim(),
                tbAddress.Text.Trim(),
                cbGender.Text.Trim(),
                tbPhoneNumber.Text.Trim(),
                cMNDTextEdit.Text.Trim());

            if (Program.currentServerName == Program.serverName)
            {
                MessageBox.Show("Không có sự thay đổi nào.");
                return false;
            }

            if (Program.Connect() == 0)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý.");
                return false;
            }

            try
            {
                if (Program.ExecSqlNonQuery(cmdRemote) == Program.excuteSuccess)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình chuyển, vui lòng thử lại sau." + Environment.NewLine + "" + ex.Message, "", MessageBoxButtons.OK);
                return false;
            }

            return false;
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

            staff_Dbs_ListFragments.DataSource = dt;
            cbBranchId.DataSource = staff_Dbs_ListFragments;
            cbBranchId.DisplayMember = "TENCN";
            cbBranchId.ValueMember = "TENSERVER";
            cbBranchId.SelectedIndex = Program.mBranch;

            //dgvNhanVien.DataSource = Program.dbs_ListFragments;
        }
        
        private bool EditStaff()
        {
            string cmdEdit = String.Format("exec dbo.suaNhanVien '{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}', '{6}'",
                tbUserId.Text.Trim(),
                tbFirstName.Text.Trim(),
                tbLastName.Text.Trim(),
                tbAddress.Text.Trim(),
                cbGender.Text.Trim(),
                tbPhoneNumber.Text.Trim(),
                cMNDTextEdit.Text.Trim());

            if (Program.Connect() == 0)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý.");
                return false;
            }

            try
            {
                if (Program.ExecSqlNonQuery(cmdEdit) == Program.excuteSuccess)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện, vui lòng thử lại sau." + Environment.NewLine + "" + ex.Message, "", MessageBoxButtons.OK);
                return false;
            }

            return false;
        }

        private bool AddStaff()
        {
            
            string cmdAdd= String.Format("exec dbo.taoNhanVien '{0}', N'{1}', N'{2}', N'{3}', N'{4}', '{5}', '{6}'",
                tbFirstName.Text.Trim(),
                tbLastName.Text.Trim(),
                tbAddress.Text.Trim(),
                cbGender.Text.Trim(),
                tbPhoneNumber.Text.Trim(),
                branchId.Trim(),
                cMNDTextEdit.Text.Trim());

            if (Program.Connect() == 0)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý.");
                return false;
            }

            try
            {
                if (Program.ExecSqlNonQuery(cmdAdd) == Program.excuteSuccess)
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện, vui lòng thử lại sau." + Environment.NewLine + "" + ex.Message, "", MessageBoxButtons.OK);
                return false;
            }

            return false;
        }

        private void FormReload()
        {
            cmbBranch.DataSource = Program.dbs_ListFragments;
            cmbBranch.DisplayMember = "TENCN";
            cmbBranch.ValueMember = "TENSERVER";

            bdsNhanVien.CancelEdit();
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại trang " + ex.Message + "." + Environment.NewLine + "Vui lòng thử lại sau", "", MessageBoxButtons.OK);
            }

            Reload();
            ClearStack();
        }

        #endregion


    }
}
