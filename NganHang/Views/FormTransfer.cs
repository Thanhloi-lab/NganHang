using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang.Views
{
    public partial class FormTransfer : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        int doi;
        String manv = "";
        public FormTransfer()
        {
            InitializeComponent();
        }

        private void gD_CHUYENTIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gD_CHUYENTIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSTransferMoney);

        }

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            dSTransferMoney.EnforceConstraints = false;
            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connStr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.dSTransferMoney.GD_CHUYENTIEN);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connStr;
            this.taiKhoanTableAdapter.Fill(this.dSTransferMoney.TaiKhoan);
            comboBoxBranch.DataSource = Program.dbs_ListFragments;
            comboBoxBranch.DisplayMember = "TENCN";
            comboBoxBranch.ValueMember = "TENSERVER";
            comboBoxBranch.SelectedIndex = Program.mBranch;


            if (Program.mGroup == "NGANHANG")
            {
                btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnSave.Enabled = btnUndo.Enabled = false;
                comboBoxBranch.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnSave.Enabled = btnUndo.Enabled = true;
                comboBoxBranch.Enabled = false;
            }
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = gD_CHUYENTIENBindingSource.Position;
            panelControlInfo.Enabled = true;
            gD_CHUYENTIENGridControl.Enabled = false;
            taiKhoanGridControl.Enabled = true;
            taiKhoanGridControl.Visible = true;

            gD_CHUYENTIENBindingSource.AddNew();
            txtStaffID.Text = Program.userName;

            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnQuit.Enabled = btnSaveToFile.Enabled = btnReload.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;

        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Không thể sửa thông tin giao dịch!");
        }

        private void btnQuit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.gD_CHUYENTIENTableAdapter.Fill(this.dSTransferMoney.GD_CHUYENTIEN);
                this.taiKhoanTableAdapter.Fill(this.dSTransferMoney.TaiKhoan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;

            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gD_CHUYENTIENBindingSource.CancelEdit();
            if (btnAdd.Enabled == false) gD_CHUYENTIENBindingSource.Position = vitri;
            gD_CHUYENTIENGridControl.Enabled = true;
            panelControlInfo.Enabled = false;
            taiKhoanGridControl.Visible = false;
            taiKhoanGridControl.Enabled = false;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnQuit.Enabled = btnSaveToFile.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtAccountReceive.Text.Trim() == "")
            {
                MessageBox.Show("Số tài khoản không được thiếu!!!", "", MessageBoxButtons.OK);
                txtAccountReceive.Focus();
                return;
            }
            if (txtAccountTransfer.Text.Trim() == "")
            {
                MessageBox.Show("Số tài khoản không được thiếu!!!", "", MessageBoxButtons.OK);
                txtAccountTransfer.Focus();
                return;
            }
            if (txtMoney.Value <= 0)
            {
                MessageBox.Show("Số tiền giao dịch phải lớn hơn 0!!!", "", MessageBoxButtons.OK);
                txtMoney.Focus();
                return;
            }
            if (CheckAccountTransfer() == false)
            {
                MessageBox.Show("Không tồn tại số tài khoản chuyển!!!", "", MessageBoxButtons.OK);
                txtAccountTransfer.Focus();
                return;
            }
            if (CheckAccountReceive() == false)
            {
                MessageBox.Show("Không tồn tại số tài khoản nhận!!!", "", MessageBoxButtons.OK);
                txtAccountReceive.Focus();
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn tạo giao dịch chuyển tiền này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    TransferMoney();
                    gD_CHUYENTIENBindingSource.EndEdit();
                    gD_CHUYENTIENBindingSource.ResetCurrentItem();
                    this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connStr;
                    this.gD_CHUYENTIENTableAdapter.Fill(this.dSTransferMoney.GD_CHUYENTIEN);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi ghi tạo giao dịch. \n" + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                return;
            }

            gD_CHUYENTIENGridControl.Enabled = true;
            taiKhoanGridControl.Visible = false;
            taiKhoanGridControl.Enabled = false;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnQuit.Enabled = btnSaveToFile.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            panelControlInfo.Enabled = false;
        }

        private void TransferMoney()
        {
            if (Program.Connect() == 0)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý.");
                return;
            }
            string cmd = "exec ChuyenTien @soTaikhoanGui='" + txtAccountTransfer.Text.Trim() + "',@soTaikhoanNhan='" + txtAccountReceive.Text.Trim() + "',@soTien='" + txtMoney.Text + "',@maNhanVien='" + Program.userName + "'";
            try
            {
                Program.ExecSqlDataReader(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực hiện giao dịch chuyển tiền. \n" + ex);
            }

        }

        private Boolean CheckAccountTransfer()
        {
            if (Program.Connect() == 0)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý.");
                return false;
            }
            string cmd = "exec KiemTraSoTaiKhoan @Sotk='" + txtAccountTransfer.Text.Trim() + "'";
            try
            {
                Program.ExecSqlDataReader(cmd);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        private Boolean CheckAccountReceive()
        {
            if (Program.Connect() == 0)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý.");
                return false;
            }
            string cmd = "exec KiemTraSoTaiKhoan @Sotk='" + txtAccountReceive.Text.Trim() + "'";
            try
            {
                Program.ExecSqlDataReader(cmd);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            MessageBox.Show("Không thể xóa giao dịch!");
        }

        private void taiKhoanGridControl_Click(object sender, EventArgs e)
        {

        }

        private void txtAccountTransfer_Click_1(object sender, EventArgs e)
        {
            doi = 1;
        }

        private void txtAccountReceive_Click_1(object sender, EventArgs e)
        {
            doi = 2;
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSaveToFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

    }
}