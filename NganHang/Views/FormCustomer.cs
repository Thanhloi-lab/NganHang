
using NganHang.UndoRedo;
using NganHang.Validation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace NganHang.Views
{
    public partial class FormCustomer : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        String macn = "";
        string CMND = "";
        private bool isAdding = false;
        private bool isEditing = false;
        private string cacheCMND = "";
        private string cacheFirstName = "";
        private string cacheLastName = "";
        private string cacheAddress = "";
        private string cacheGender = "";
        private string cachePhonenumber = "";

        private Stack<UndoRedoControl> stackUndo;
        private Stack<UndoRedoControl> stackRedo;

        public FormCustomer()
        {
            InitializeComponent();

            cbGender.Items.Add("Nam");
            cbGender.Items.Add("Nữ");

            stackUndo = new Stack<UndoRedoControl>();
            stackRedo = new Stack<UndoRedoControl>();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.khachHangBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSCustomer);

        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSCustomer.TaiKhoan' table. You can move, or remove it, as needed.
            dSCustomer.EnforceConstraints = false;
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connStr;
            this.khachHangTableAdapter.Fill(this.dSCustomer.KhachHang);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connStr;
            this.taiKhoanTableAdapter.Fill(this.dSCustomer.TaiKhoan);

            comboBoxBranch.DataSource = Program.dbs_ListFragments;
            comboBoxBranch.DisplayMember = "TENCN";
            comboBoxBranch.ValueMember = "TENSERVER";
            comboBoxBranch.SelectedIndex = Program.mBranch;
            try
            {
                macn = ((DataRowView)khachHangBindingSource[0])["MACN"].ToString();
            }
            catch (Exception ex)
            {
                GetBranchId();
            }

            if (Program.mGroup == "NGANHANG")
            {
                btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnSave.Enabled = false;
                comboBoxBranch.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnSave.Enabled = true;
                comboBoxBranch.Enabled = false;
            }
            btnUndo.Enabled = btnRedo.Enabled = false;
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đổi CMND khách hàng này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                txtCMND.Enabled = true;
                buttonUpdate.Visible = true;
                CMND = txtCMND.Text;
            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string regexCMND = "^(?:[0-9]{10})";
            string newCMND = "";
            if (!Regex.IsMatch(txtCMND.Text.Trim(), regexCMND))
            {
                MessageBox.Show("CMND phải có 10 số", "", MessageBoxButtons.OK);
                txtCMND.Text = CMND;
                return;
            }
            if (checkCMND() == false)
            {
                MessageBox.Show("Trùng CMND!", "", MessageBoxButtons.OK);
                txtCMND.Text = CMND;
                return;
            }
            if (Program.Connect() == 0)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý.");
                return;
            }
            newCMND = ((DataRowView)khachHangBindingSource[khachHangBindingSource.Position])["CMND"].ToString().Trim();
            //string cmd = "exec doiCMND @oldCMND='" + newCMND +"', @newCMND='" + txtCMND.Text + "'";
            //try
            //{
            //    Program.ExecSqlDataReader(cmd);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Lỗi đổi CMND. \n" + ex);
            //}
            //this.khachHangTableAdapter.Fill(this.dSCustomer.KhachHang);
            buttonUpdate.Visible = false;
            txtCMND.Enabled = false;
            txtCMND.Text = newCMND;
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


            this.khachHangTableAdapter.Connection.ConnectionString = Program.connStr;
            this.khachHangTableAdapter.Fill(this.dSCustomer.KhachHang);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connStr;
            this.taiKhoanTableAdapter.Fill(this.dSCustomer.TaiKhoan);
            ClearStack();
            try
            {
                macn = ((DataRowView)khachHangBindingSource[0])["MACN"].ToString();
            }
            catch (Exception ex)
            {
                GetBranchId();
            }


        }

        private void btnAdd_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearStack();
            vitri = khachHangBindingSource.Position;
            InitCache(gridView1.GetRow(vitri) as DataRowView);
            panelControlInfo.Enabled = isAdding = true;
            khachHangBindingSource.AddNew();
            txtBranch.Text = macn;
            cbGender.SelectedValue = "Nam";

            dateEditDateCreate.DateTime = DateTime.Now;
            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnSaveToFile.Enabled = btnReload.Enabled = false;
            btnSave.Enabled = btnRestore.Enabled = true;
            khachHangGridControl.Enabled = false;
        }

        private void btnEdit_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearStack();
            vitri = khachHangBindingSource.Position;
            InitCache(gridView1.GetRow(vitri) as DataRowView);
            panelControlInfo.Enabled = true;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnSaveToFile.Enabled = false;
            btnSave.Enabled = btnRestore.Enabled = true;
            khachHangGridControl.Enabled = false;
            txtCMND.Enabled = false;
            buttonEdit.Visible = isEditing = true;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (!MyRegex.ValidateCMND(txtCMND.Text))
            {
                txtCMND.Focus();
                return;
            }
            if (!MyRegex.ValidateSurname(txtSurname.Text))
            {
                txtSurname.Focus();
                return;
            }
            if (!MyRegex.ValidateName(txtName.Text))
            {
                txtName.Focus();
                return;
            }
            if (!MyRegex.ValidateAddress(txtAddress.Text))
            {
                txtAddress.Focus();
                return;
            }
            if (!MyRegex.ValidatePhoneNumber(txtPhoneNumber.Text))
            {
                txtPhoneNumber.Focus();
                return;
            }
            //if (!Regex.Match(txtSurname.Text.Trim(), MyRegex.RegexSurname).Success)
            //{
            //    MessageBox.Show("Họ phải từ 1->50 kí tự không bao gồm số và kí tự đặt biệt.", "", MessageBoxButtons.OK);
            //    txtSurname.Focus();
            //    return;
            //}
            //if (!Regex.Match(txtName.Text.Trim(), MyRegex.RegexName).Success)
            //{
            //    MessageBox.Show("Tên phải từ 1->10 kí tự không bao gồm số và kí tự đặt biệt.", "", MessageBoxButtons.OK);
            //    txtName.Focus();
            //    return;
            //}
            ////if (!Regex.Match(txtAddress.Text, regexAddress).Success)
            //if(txtAddress.Text.Trim().Length==0 || txtAddress.Text.Trim().Length>100)
            //{
            //    MessageBox.Show("Địa chỉ phải từ 1->100 kí tự.", "", MessageBoxButtons.OK);
            //    txtAddress.Focus();
            //    return;
            //}
            //if (!Regex.Match(txtPhoneNumber.Text.Trim(), MyRegex.RegexSDT).Success)
            //{
            //    MessageBox.Show("Số điện thoại phải có 10 số.", "", MessageBoxButtons.OK);
            //    txtPhoneNumber.Focus();
            //    return;
            //}
            if (txtCMND.Enabled == true)
            {
                if (checkCMND() == false)
                {
                    MessageBox.Show("Trùng CMND!!!", "", MessageBoxButtons.OK);
                    txtCMND.Focus();
                    return;
                }
            }

            //ktra Phai
            //Kiemtra rang buoc
            //MANV ko duoc trung tren cac phan manh

            try
            {
                khachHangBindingSource.EndEdit();
                khachHangBindingSource.ResetCurrentItem();
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connStr;
                this.khachHangTableAdapter.Update(this.dSCustomer.KhachHang);
                MessageBox.Show("Thao tác thành công", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên. \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            LoadDefault();
            buttonEdit.Visible = false;
            txtCMND.Enabled = true;
        }

        private void btnDelete_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String CMND = "";
            if (taiKhoanBindingSource.Count > 0)
            {
                MessageBox.Show("Không thể xóa khách hàng này vì đã tạo tài khoản!", "", MessageBoxButtons.OK);
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    CMND = ((DataRowView)khachHangBindingSource[khachHangBindingSource.Position])["CMND"].ToString();
                    khachHangBindingSource.RemoveCurrent();
                    this.khachHangTableAdapter.Connection.ConnectionString = Program.connStr;
                    this.khachHangTableAdapter.Update(this.dSCustomer.KhachHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại!! \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.khachHangTableAdapter.Fill(this.dSCustomer.KhachHang);
                    khachHangBindingSource.Position = khachHangBindingSource.Find("CMND", CMND);
                    return;
                }
            }
            if (khachHangBindingSource.Count == 0) btnDelete.Enabled = false;
        }

        private void btnReload_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connStr;
                this.khachHangTableAdapter.Fill(this.dSCustomer.KhachHang);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;

            }
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RestoreByCache();
        }

        private void btnSaveToFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnUndo_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.UndoRedo(ref stackUndo, ref stackRedo, panelControlInfo, false);
            Program.SetEnableBtnEndoRedo(ref stackUndo, ref stackRedo, btnUndo, btnRedo);
        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Program.UndoRedo(ref stackRedo, ref stackUndo, panelControlInfo, false);
            Program.SetEnableBtnEndoRedo(ref stackUndo, ref stackRedo, btnUndo, btnRedo);
        }

        private void btnQuit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdding)
            {
                if (MessageBox.Show("Thoát khỏi thêm mới?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    LoadDefault();
                }
            }
            if (isEditing)
            {
                if (MessageBox.Show("Thoát khỏi sửa?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    LoadDefault();

                }
                txtCMND.Enabled = true;
                buttonEdit.Visible = false;
            }
            else
            {
                if (MessageBox.Show("Thoát khỏi trang?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Close();
                }
            }

        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.InitUndoRedoForTextEdit(sender, ref stackUndo, btnUndo);
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {

            Program.InitUndoRedoForTextEdit(sender, ref stackUndo, btnUndo);
        }

        private void cbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (isAdding || isEditing)
            //{
            //    System.Windows.Forms.ComboBox cb = sender as System.Windows.Forms.ComboBox;
            //    int index = 0;
            //    if (cb.SelectedIndex == 0)
            //    {
            //        index = 1;
            //    }
            //    UndoRedoControl ur = new UndoRedoControl(cb.Name, index);
            //    stackUndo.Push(ur);
            //    if (stackUndo.Count > 0)
            //    {
            //        btnUndo.Enabled = true;
            //    }
            //}
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.InitUndoRedoForTextEdit(sender, ref stackUndo, btnUndo);
        }

        private void txtSurname_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.InitUndoRedoForTextEdit(sender, ref stackUndo, btnUndo);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.InitUndoRedoForTextEdit(sender, ref stackUndo, btnUndo);
        }

        #region methods

        private void ClearStack()
        {
            stackUndo.Clear();
            stackRedo.Clear();
            btnUndo.Enabled = false;
            btnRedo.Enabled = false;
        }

        private void LoadDefault()
        {
            ClearStack();
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connStr;
            this.khachHangTableAdapter.Fill(this.dSCustomer.KhachHang);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connStr;
            this.taiKhoanTableAdapter.Fill(this.dSCustomer.TaiKhoan);

            if (btnAdd.Enabled == false) khachHangBindingSource.Position = vitri;
            khachHangGridControl.Enabled = true;
            panelControlInfo.Enabled = false;

            if (Program.mGroup == "NGANHANG")
            {
                btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnSave.Enabled = false;
                comboBoxBranch.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnSave.Enabled = true;
                comboBoxBranch.Enabled = false;
            }

            isAdding = isEditing =  btnUndo.Enabled = btnRedo.Enabled = false;
            btnReload.Enabled = true;
        }

        private void InitCache(DataRowView data)
        {
            if (data != null)
            {
                cacheCMND = data[0].ToString();
                cacheFirstName = data[1].ToString();
                cacheLastName = data[2].ToString();
                cacheAddress = data[3].ToString();
                cacheGender = data[4].ToString();
                cachePhonenumber = data[6].ToString();
            }
        }

        private void RestoreByCache()
        {
            txtCMND.Text = cacheCMND;
            txtSurname.Text = cacheFirstName;
            txtName.Text = cacheLastName;
            txtAddress.Text = cacheAddress;
            cbGender.Text = cacheGender;
            txtPhoneNumber.Text = cachePhonenumber;
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
            string id = Program.myReader.GetString(0);

            txtBranch.Text = Program.myReader.GetString(0).Trim();
            macn = txtBranch.Text;
        }

        private Boolean checkCMND()
        {
            string cmd = "exec trungCMND @CMND='" + txtCMND.Text.Trim() + "'";
            try
            {
                Program.Connect();
                Program.ExecSqlDataReader(cmd);
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        #endregion
    }
}