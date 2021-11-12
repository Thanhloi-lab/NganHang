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
    public partial class FormSendCashout : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        private bool isAdding = false;
        private const string MA_LOAIGD = "MA_LOAIGD";
        private const string LOAIGD = "LOAIGD";
        private const string SEND_ID = "GT";
        //private const int SEND_ORDER_NUM = "GT";
        private const string SEND = "Gửi tiền";
        private const string CASH_OUT_ID = "RT";
        private const string CASH_OUT = "Rút tiền";
        //private const string CASH_OUT_ORDER_NUM = "RT";

        public FormSendCashout()
        {
            InitializeComponent();
            InitCbTransactionName();
        }

        private void gD_GOIRUTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.gD_GOIRUTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSSendCashout);

        }

        private void FormSendCashOut_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSSendCashout.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.dSSendCashout.NhanVien);

            dSSendCashout.EnforceConstraints = false;
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connStr;
            this.gD_GOIRUTTableAdapter.Fill(this.dSSendCashout.GD_GOIRUT);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connStr;
            this.taiKhoanTableAdapter.Fill(this.dSSendCashout.TaiKhoan);

            comboBoxBranch.DataSource = Program.dbs_ListFragments;
            comboBoxBranch.DisplayMember = "TENCN";
            comboBoxBranch.ValueMember = "TENSERVER";
            comboBoxBranch.SelectedIndex = Program.mBranch;

            try
            {
                string selection = ((DataRowView)gD_GOIRUTBindingSource[gD_GOIRUTBindingSource.Position])["LOAIGD"].ToString();
                if (selection.Equals(SEND_ID))
                    cbTransactionName.SelectedIndex = 0;
                else if (selection.Equals(CASH_OUT_ID))
                    cbTransactionName.SelectedIndex = 1;
            }
            catch (Exception ex)
            {

            }

            if (Program.mGroup == "NGANHANG")
            {
                btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnSave.Enabled =  false;
                comboBoxBranch.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnSave.Enabled =  true;
                comboBoxBranch.Enabled = false;
            }

        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = gD_GOIRUTBindingSource.Position;
            panelControlInfo.Enabled = true;
            gD_GOIRUTGridControl.Enabled = false;
            taiKhoanGridControl.Enabled = true;
            taiKhoanGridControl.Visible = true;
            isAdding = true;

            gD_GOIRUTBindingSource.AddNew();
            txtStaffID.Text = Program.userName;

            txtAccountNumber.Text = ((DataRowView)taiKhoanBindingSource[0])["SOTK"].ToString();
            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled =  btnSaveToFile.Enabled = btnReload.Enabled = false;
            btnSave.Enabled =  true;
            nGAYGDDateTimePicker.Value = DateTime.Now;
            cbTransactionName.SelectedIndex = 0;
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Không thể sửa thông tin giao dịch!");
        }

        private void btnQuit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (isAdding)
            {
                if (MessageBox.Show("Thoát khỏi thêm giao dịch.", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    LoadDefaultForm();
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn thoát khỏi trang này", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    this.Close();
            }

            
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Reload();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (txtAccountNumber.Text.Trim() == "")
            {
                MessageBox.Show("Số tài khoản không được thiếu!", "", MessageBoxButtons.OK);
                txtAccountNumber.Focus();
                return;
            }
            if (txtMoney.Value < 100000)
            {
                MessageBox.Show("Số tiền giao dịch phải lớn hơn 100000!", "", MessageBoxButtons.OK);
                txtMoney.Focus();
                return;
            }
            if (CheckAccountNumber() == false)
            {
                MessageBox.Show("Không tồn tại số tài khoản!", "", MessageBoxButtons.OK);
                txtAccountNumber.Focus();
                return;
            }

            if (cbTransactionName.SelectedValue.ToString().Trim().Equals(SEND_ID))
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn tạo giao dịch gởi tiền này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        SendMoney();
                        gD_GOIRUTBindingSource.EndEdit();
                        gD_GOIRUTBindingSource.ResetCurrentItem();
                        this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connStr;
                        this.gD_GOIRUTTableAdapter.Fill(this.dSSendCashout.GD_GOIRUT);
                        cbTransactionName.SelectedIndex = 0;
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
            }
            else if(cbTransactionName.SelectedValue.ToString().Trim().Equals(CASH_OUT_ID))
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn tạo giao dịch rút tiền này?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    try
                    {
                        CashOutMoney();
                        gD_GOIRUTBindingSource.EndEdit();
                        gD_GOIRUTBindingSource.ResetCurrentItem();
                        this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connStr;
                        this.gD_GOIRUTTableAdapter.Fill(this.dSSendCashout.GD_GOIRUT);
                        cbTransactionName.SelectedIndex = 0;
                        
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
            }
            Reload();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Không thể xóa giao dịch!");
        }

        private void taiKhoanGridControl_Click(object sender, EventArgs e)
        {
            txtAccountNumber.Text = ((DataRowView)taiKhoanBindingSource[taiKhoanBindingSource.Position])["SOTK"].ToString();
        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gD_GOIRUTBindingSource.CancelEdit();
            if (btnAdd.Enabled == false) gD_GOIRUTBindingSource.Position = vitri;
            gD_GOIRUTGridControl.Enabled = true;
            panelControlInfo.Enabled = false;
            taiKhoanGridControl.Visible = false;
            taiKhoanGridControl.Enabled = false;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnQuit.Enabled = btnSaveToFile.Enabled = true;
            btnSave.Enabled =  false;
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
                        DataTable dt = GetDataTable(gridView1);

                        workbook.Worksheets.Add(dt, "CashOut");
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

        private void InitCbTransactionName()
        {
            DataTable dt = new DataTable();

            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "LOAIGD";
            column.ReadOnly = true;
            column.Unique = true;
            dt.Columns.Add(column);

            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "MA_LOAIGD";
            column.AutoIncrement = false;
            column.Caption = "MA_LOAIGD";
            column.ReadOnly = true;
            column.Unique = true;
            dt.Columns.Add(column);

            row = dt.NewRow();
            row[MA_LOAIGD] = "GT";
            row[LOAIGD] = SEND;
            dt.Rows.Add(row);

            row = dt.NewRow();
            row[MA_LOAIGD] = "RT";
            row[LOAIGD] = CASH_OUT;
            dt.Rows.Add(row);

            cbTransactionName.DataSource = dt;
            cbTransactionName.DisplayMember = "LOAIGD";
            cbTransactionName.ValueMember = "MA_LOAIGD";
            cbTransactionName.SelectedIndex = 0;

        }

        private void SendMoney()
        {
            if (Program.Connect() == 0)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý.");
                return;
            }
            string cmd = "exec GuiTien @soTaiKhoan='" + txtAccountNumber.Text.Trim() + "',@soTien='" + txtMoney.Text + "',@maNhanVien='" + Program.userName + "'";
            try
            {
                Program.ExecSqlDataReader(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực hiện giao dịch gởi tiền. \n" + ex);
            }

        }

        private void CashOutMoney()
        {
            if (Program.Connect() == 0)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý.");
                return;
            }
            string cmd = "exec RutTien @soTaiKhoan='" + txtAccountNumber.Text.Trim() + "',@soTien='" + txtMoney.Text + "',@maNhanVien='" + Program.userName + "'";
            try
            {
                Program.ExecSqlDataReader(cmd);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thực hiện giao dịch rút tiền. \n" + ex);
            }

        }

        private Boolean CheckAccountNumber()
        {
            if (Program.Connect() == 0)
            {
                MessageBox.Show("Có lỗi trong quá trình xử lý.");
                return false;
            }
            string cmd = "exec KiemTraSoTaiKhoan @Sotk='" + txtAccountNumber.Text.Trim() + "'";
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

        private void Reload()
        {
            try
            {
                this.gD_GOIRUTTableAdapter.Fill(this.dSSendCashout.GD_GOIRUT);
                this.taiKhoanTableAdapter.Fill(this.dSSendCashout.TaiKhoan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;

            }
            
        }

        private void LoadDefaultForm()
        {
            gD_GOIRUTGridControl.Enabled = true;
            taiKhoanGridControl.Visible = false;
            taiKhoanGridControl.Enabled = false;
            isAdding = false;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnQuit.Enabled = btnSaveToFile.Enabled = true;
            btnSave.Enabled = false;
            panelControlInfo.Enabled = false;
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

        private void gD_GOIRUTGridControl_Click(object sender, EventArgs e)
        {
            try
            {
                string selection = ((DataRowView)gD_GOIRUTBindingSource[gD_GOIRUTBindingSource.Position])["LOAIGD"].ToString();
                if (selection.Equals(SEND_ID))
                    cbTransactionName.SelectedIndex = 0;
                else if (selection.Equals(CASH_OUT_ID))
                    cbTransactionName.SelectedIndex = 1;
            }
            catch (Exception ex)
            {

            }

        }
    }
}