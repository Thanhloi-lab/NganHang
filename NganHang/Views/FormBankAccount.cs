using ClosedXML.Excel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
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
    public partial class FormBankAccount : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        String macn = "";
        bool isAdding = false;
        public FormBankAccount()
        {
            InitializeComponent();
        }

        private void taiKhoanBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.thongTinTaiKhoanBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSBankAccount);

        }

        private void LoadData()
        {
            dSBankAccount.EnforceConstraints = false;
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connStr;
            this.gD_GOIRUTTableAdapter.Fill(this.dSBankAccount.GD_GOIRUT);
            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connStr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.dSBankAccount.GD_CHUYENTIEN);

            this.khachHangTableAdapter.Connection.ConnectionString = Program.connStr;
            this.khachHangTableAdapter.Fill(this.dSBankAccount.KhachHang);
            this.thongTinTaiKhoanTableAdapter.Connection.ConnectionString = Program.connStr;
            this.thongTinTaiKhoanTableAdapter.Fill(this.dSBankAccount.ThongTinTaiKhoan);
        }

        private void FormBankAccount_Load(object sender, EventArgs e)
        {
            LoadData();

            comboBoxBranch.DataSource = Program.dbs_ListFragments;
            comboBoxBranch.DisplayMember = "TENCN";
            comboBoxBranch.ValueMember = "TENSERVER";
            comboBoxBranch.SelectedIndex = Program.mBranch;
            try
            {
                macn = ((DataRowView)thongTinTaiKhoanBindingSource[0])["MACN"].ToString();
            }
            catch (Exception ex)
            {
                GetBranchId();
            }
            LoadAccountPanel();
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

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                txtCMND.Text = ((DataRowView)khachHangBindingSource[0])["CMND"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiện không có khách hàng nào.");
                return;
            }
            vitri = thongTinTaiKhoanBindingSource.Position;

            LoadCustomerPanel();
            GetNewesAccountId();
            
            btnSave.Enabled = true;
        }

        private void GetNewesAccountId()
        {
            Program.serverName = comboBoxBranch.SelectedValue.ToString().Trim();

            string cmd = "EXEC [dbo].[taoTaiKhoanNganHang] @MaChiNhanh='" + macn + "' "; /*'" + tbBranchId.Text.Trim() + "'";*/

            if (Program.Connect() == 0)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý.");
                return;
            }

            Program.myReader = Program.ExecSqlDataReader(cmd);
            Program.myReader.Read();

            txtAccountNumber.Text = Program.myReader.GetString(0).Trim();
            if (Convert.IsDBNull(Program.userName))
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý.");
                return;
            }
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Không thể sửa thông tin tài khoán!");
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;

            }
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String Sotk = "";

            if (!CheckIsTransaction())
                return;

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    Sotk = ((DataRowView)thongTinTaiKhoanBindingSource[thongTinTaiKhoanBindingSource.Position])["SOTK"].ToString();
                    thongTinTaiKhoanBindingSource.RemoveCurrent();

                    if (Program.Connect() == 0)
                    {
                        MessageBox.Show("Lỗi kết nối", "", MessageBoxButtons.OK);
                        return;
                    }
                    if (txtAccountNumber.Text.Trim() == "")
                    {
                        MessageBox.Show("Không thể để trống số tài khoản.", "", MessageBoxButtons.OK);
                        thongTinTaiKhoanBindingSource.Position = thongTinTaiKhoanBindingSource.Find("SOTK", Sotk);
                        return;
                    }

                    string cmd = String.Format("exec [dbo].[XoaTaiKhoanTinDung] '{0}'", Sotk);

                    if (Program.ExecSqlNonQuery(cmd) != 1)
                    {
                        MessageBox.Show("Lỗi xóa tài khoản, thử lại sau.", "", MessageBoxButtons.OK);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa nhân viên. Bạn hãy xóa lại!! \n" + ex.Message, "", MessageBoxButtons.OK);
                    this.thongTinTaiKhoanTableAdapter.Fill(this.dSBankAccount.ThongTinTaiKhoan);
                    thongTinTaiKhoanBindingSource.Position = thongTinTaiKhoanBindingSource.Find("SOTK", Sotk);
                    return;
                }
            }
            if (thongTinTaiKhoanBindingSource.Count == 0) btnDelete.Enabled = false;
        }

        private void comboBoxBranch_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBoxBranch.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.serverName = comboBoxBranch.SelectedValue.ToString();
            if (comboBoxBranch.SelectedIndex != Program.mBranch)
            {
                Program.mLogin = Program.remoteLogin;
                Program.password = Program.remotePassword;
            }
            else
            {
                Program.mLogin = Program.mLoginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.Connect() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);

            }
            else
            {
                LoadData();

                try
                {
                    macn = ((DataRowView)thongTinTaiKhoanBindingSource[0])["MACN"].ToString();
                }
                catch (Exception ex)
                {
                    GetBranchId();

                }

            }
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Tạo tài khoản cho anh(chị) " + tbFirstName.Text + " " + tbLastName.Text, "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Save();
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi tạo mới? ", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                LoadAccountPanel();
                thongTinTaiKhoanBindingSource.Position = vitri;
            }
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

                        workbook.Worksheets.Add(dt, "Tài khoản");
                        workbook.SaveAs(sfd.FileName);
                    }
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Tải xuống thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi trong quá trình tải xuống, vui lòng thử lại sau.");
                }
            }
        }

        private void btnQuit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result;
            if (isAdding)
            {
                result = MessageBox.Show("Bạn có muốn thoát khỏi tạo mới? ", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    LoadAccountPanel();
                }
            }    
            else
            {
                result = MessageBox.Show("Bạn có muốn thoát khỏi trang này? ", "", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                    this.Close();
            }    
        }

        private void Save()
        {
            //Kiemtra rang buoc
            //MANV ko duoc trung tren cac phan manh
            dateEditAccountOpenDate.EditValue = DateTime.Now;
            try
            {

                if (Program.Connect() == 0)
                {
                    MessageBox.Show("Lỗi kết nối", "", MessageBoxButtons.OK);
                    return;
                }
                if (txtCMND.Text.Trim() == "")
                {
                    MessageBox.Show("Không thể để trống CMND", "", MessageBoxButtons.OK);
                    return;
                }

                string cmd = String.Format("exec [dbo].[SP_TaoTaiKhoan] '{0}', '{1}', '{2}'",
                    txtAccountNumber.Text.Trim(),
                    txtCMND.Text.Trim(),
                    txtBranch.Text.Trim());

                if (Program.ExecSqlNonQuery(cmd) != 1)
                {
                    MessageBox.Show("Lỗi ghi tài khoản, vui lòng thử lại sau.", "", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi tài khoản ngân hàng. \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            LoadAccountPanel();
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

        private void khachHangGridControl_MouseClick(object sender, MouseEventArgs e)
        {
            txtCMND.Text = ((DataRowView)khachHangBindingSource[khachHangBindingSource.Position])["CMND"].ToString();
        }

        private void LoadAccountPanel()
        {
            pnFullnameAcc.Visible = true;
            pnFullnameCus.Visible = false;
            taiKhoanGridControl.Enabled = true;
            khachHangGridControl.Visible = false;
            isAdding = false;

            if (Program.mGroup == "NGANHANG")
            {
                btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnSave.Enabled = false;
                comboBoxBranch.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = true;
                comboBoxBranch.Enabled = btnSave.Enabled = btnRestore.Enabled = false;
            }

            LoadData();
        }

        private void LoadCustomerPanel()
        {
            pnFullnameAcc.Visible = false;
            pnFullnameCus.Visible = true;
            taiKhoanGridControl.Enabled = false;
            khachHangGridControl.Visible = true;
            isAdding = true;

            txtBranch.Text = macn;
            spinEditAccountBalance.EditValue = 0;
            dateEditAccountOpenDate.EditValue = DateTime.Now;

            if (Program.mGroup == "NGANHANG")
            {
                btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnSave.Enabled = false;
                comboBoxBranch.Enabled = true;
            }
            else
            {
                comboBoxBranch.Enabled= btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnSaveToFile.Enabled = false;
                btnSave.Enabled = true;
                btnRestore.Enabled = true;
            }

            LoadData();
        }

        private Boolean CheckIsTransaction()
        {
            string cmd = "exec DaThucHienGiaoDich @Sotk='" + ((DataRowView)thongTinTaiKhoanBindingSource[thongTinTaiKhoanBindingSource.Position])["SOTK"].ToString() + "'";
            try
            {
                if (Program.Connect() == 0)
                {
                    MessageBox.Show("Lỗi kết nối", "", MessageBoxButtons.OK);
                    return false;
                }
                if (Program.ExecSqlNonQuery(cmd) != 1)
                {
                    MessageBox.Show("Không thể xóa tài khoản đã từng thực hiện giao dịch.", "", MessageBoxButtons.OK);
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình xóa, vui lòng thử lại sau.", "", MessageBoxButtons.OK);
                return false;
            }
        }
    }
}