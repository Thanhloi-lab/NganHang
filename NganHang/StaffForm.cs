﻿using DevExpress.XtraEditors;
using NganHang.UndoRedo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace NganHang
{
    public partial class StaffForm : Form
    {
        private static string branchId = "";
        private int position = 0;
        private bool firstLoad = false;
        private Stack<UndoRedoControl> stackUndo;
        private Stack<UndoRedoControl> stackRedo;

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
            EnableAdd();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsNhanVien.Position;
            EnableEdit();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OptionDelete();
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(tbFirstName.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống họ.");
                tbFirstName.Focus();
                return;
            }

            if (tbLastName.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống tên.");
                tbLastName.Focus();
                return;
            }

            if (tbPhoneNumber.Text.Trim() == "")
            {
                MessageBox.Show("Không được để trống SĐT.");
                tbPhoneNumber.Focus();
                return;
            }

            try
            {
                bdsNhanVien.EndEdit();
                bdsNhanVien.ResetCurrentItem();
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connStr;
                this.nhanVienTableAdapter.Update(this.DS.NhanVien);
            }catch(Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý." + Environment.NewLine+ "" + ex.Message);
                return;
            }

            Reload();
        }

        private void btnSaveToFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnQuit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            QuitForm();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            cmbBranch.DataSource = Program.dbs_ListFragments;
            cmbBranch.DisplayMember = "TENCN";
            cmbBranch.ValueMember = "TENSERVER";
            

            bdsNhanVien.CancelEdit();
            try
            {
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connStr;
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải lại trang " + ex.Message + "." + Environment.NewLine+ "Vui lòng thử lại sau", "", MessageBoxButtons.OK);
            }

            Reload();
        }

        private void cmbBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (firstLoad == true)
            {
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

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            Program.InitUndoRedoCombobox(sender, ref stackUndo, btnUndo);
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.UndoRedo(ref stackUndo, ref stackRedo, pcStaff);
            Program.SetEnableBtnEndoRedo(ref stackUndo, ref stackRedo, btnUndo, btnRedo);
        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.UndoRedo(ref stackRedo, ref stackUndo, pcStaff);
            Program.SetEnableBtnEndoRedo(ref stackUndo, ref stackRedo, btnUndo, btnRedo);
        }

        private void cbxIsActive_MouseClick(object sender, MouseEventArgs e)
        {
            Program.InitUndoRedoForCheckBox(sender, ref stackUndo, btnUndo);
        }

        #endregion

        #region Methods

        private void LoadData()
        {
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

            stackUndo.Clear();
        }

        private void FormForRoleChiNhanh()
        {

            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnRestore.Enabled = true;
            cmbBranch.Enabled = false;
        }

        private void FormForRoleNganHang()
        {
            btnSave.Enabled = btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnRestore.Enabled = false;
            cmbBranch.Enabled = true;
        }

        private void EnableAdd()
        {
            GetNewestUserId();
            GetBranchId();

            pcStaff.Enabled = true;
            tbBranchId.Text = branchId;
            tbFirstName.Focus();

            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = btnRestore.Enabled = true;
            gcStaff.Enabled = false;
            
        }

        private void GetBranchId()
        {
            Program.serverName = cmbBranch.SelectedValue.ToString().Trim();

            string cmdGetBranchId = "select *from LayMaChiNhanh";

            if(Program.mGroup == "CHINHANH")
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
            string id = Program.myReader.GetString(0);

            tbBranchId.Text = Program.myReader.GetString(0).Trim();
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
            tbBranchId.Text = branchId;
            tbFirstName.Focus();

            tbAddress.ReadOnly = tbFirstName.ReadOnly = tbLastName.ReadOnly = false;
            cbGender.Enabled = true;

            btnAdd.Enabled = btnEdit.Enabled = false;
            btnSave.Enabled = btnRestore.Enabled = true;
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
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa", "", MessageBoxButtons.OK);
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
                if(Program.ExecSqlNonQuery(cmd)==1)
                    return true;
            }catch(Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình xóa." + Environment.NewLine+ "" + ex.Message, "", MessageBoxButtons.OK);
                return false;
            }
            return false;
        }

        private void Reload()
        {
            gcStaff.Enabled = true;
            pcStaff.Enabled = false;

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
            try
            {
                userId = ((DataRowView)bdsNhanVien[bdsNhanVien.Position])["MANV"].ToString();   
                bdsNhanVien.RemoveCurrent();
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connStr;
                this.nhanVienTableAdapter.Update(this.DS.NhanVien);


            }catch(Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình thực hiện, vui lòng thử lại sau." + Environment.NewLine+ "" + ex.Message, "", MessageBoxButtons.OK);
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                bdsNhanVien.Position = bdsNhanVien.Find("MANV", userId);
            }


        }

        private void QuitForm()
        {
            this.Close();
        }


        #endregion
    }
}