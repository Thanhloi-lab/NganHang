using ClosedXML.Excel;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Windows.Forms;

namespace NganHang.Views
{
    public partial class FormTransfer : DevExpress.XtraEditors.XtraForm
    {
        int vitri = 0;
        private bool isChooseSender = false;
        private bool isChooseReceiver = false;
        public FormTransfer()
        {
            InitializeComponent();
        }
        #region Events

        private void ThongTinGDBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.thongTinGDBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dSTransferMoney);

        }

        private void FormTransfer_Load(object sender, EventArgs e)
        {
            dSTransferMoney.EnforceConstraints = false;
            this.thongTinGDTableAdapter.Connection.ConnectionString = Program.connStr;
            this.thongTinGDTableAdapter.Fill(this.dSTransferMoney.ThongTinGD);
            this.thongTinTaiKhoanTableAdapter.Connection.ConnectionString = Program.connStr;
            this.thongTinTaiKhoanTableAdapter.Fill(this.dSTransferMoney.ThongTinTaiKhoan);

            comboBoxBranch.DataSource = Program.dbs_ListFragments;
            comboBoxBranch.DisplayMember = "TENCN";
            comboBoxBranch.ValueMember = "TENSERVER";
            comboBoxBranch.SelectedIndex = Program.mBranch;


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
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = thongTinGDBindingSource.Position;
            panelControlInfo.Enabled = true;
            ThongTinGDGridControl.Enabled = false;
            
            thongTinGDBindingSource.AddNew();
            txtStaffID.Text = Program.userName;

            btnAdd.Enabled = btnDelete.Enabled = btnEdit.Enabled = btnQuit.Enabled = btnSaveToFile.Enabled = btnReload.Enabled = false;
            btnSave.Enabled = true;

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
                this.thongTinGDTableAdapter.Fill(this.dSTransferMoney.ThongTinGD);
                this.thongTinTaiKhoanTableAdapter.Fill(this.dSTransferMoney.ThongTinTaiKhoan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;

            }
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
                    thongTinGDBindingSource.EndEdit();
                    thongTinGDBindingSource.ResetCurrentItem();
                    this.thongTinGDTableAdapter.Connection.ConnectionString = Program.connStr;
                    this.thongTinGDTableAdapter.Fill(this.dSTransferMoney.ThongTinGD);
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

            ThongTinGDGridControl.Enabled = true;
            taiKhoanGridControl.Visible = false;
            taiKhoanGridControl.Enabled = false;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnQuit.Enabled = btnSaveToFile.Enabled = true;
            btnSave.Enabled = false;
            panelControlInfo.Enabled = false;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Không thể xóa giao dịch!");
        }

        private void txtAccountTransfer_Click_1(object sender, EventArgs e)
        {

        }

        private void txtAccountReceive_Click_1(object sender, EventArgs e)
        {

        }

        private void btnRestore_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            thongTinGDBindingSource.CancelEdit();
            if (btnAdd.Enabled == false) thongTinGDBindingSource.Position = vitri;
            ThongTinGDGridControl.Enabled = true;
            panelControlInfo.Enabled = false;
            taiKhoanGridControl.Visible = false;
            taiKhoanGridControl.Enabled = false;
            btnAdd.Enabled = btnEdit.Enabled = btnDelete.Enabled = btnReload.Enabled = btnQuit.Enabled = btnSaveToFile.Enabled = true;
            btnSave.Enabled = false;
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

                        workbook.Worksheets.Add(dt, "Payment");
                        workbook.SaveAs(sfd.FileName);
                    }
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show("Tải xướng thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi trong quá trình tải xuống, vui lòng thử lại sau.");
                }
            }
        }

        private void btnChooseSend_Click(object sender, EventArgs e)
        {
            taiKhoanGridControl.Enabled = true;
            taiKhoanGridControl.Visible = true;
            btnChooseSend.Enabled = btnChooseRec.Enabled = btnOKRec.Enabled = false;
            isChooseSender = true;
            isChooseReceiver = false;
            btnOKSend.Enabled = true;
        }

        private void btnOKSend_Click(object sender, EventArgs e)
        {
            taiKhoanGridControl.Enabled = false;
            taiKhoanGridControl.Visible = false;
            btnChooseRec.Enabled = true;
            btnOKSend.Enabled = false;
            btnChooseSend.Enabled = true;
            isChooseSender = false;
            isChooseReceiver = false;
        }

        private void btnChooseRec_Click(object sender, EventArgs e)
        {
            taiKhoanGridControl.Enabled = true;
            taiKhoanGridControl.Visible = true;
            btnChooseSend.Enabled = btnOKSend.Enabled = false;
            btnChooseRec.Enabled = false;
            isChooseSender = false;
            isChooseReceiver = true;
            btnOKRec.Enabled = true;
        }

        private void btnOKRec_Click(object sender, EventArgs e)
        {
            taiKhoanGridControl.Enabled = false;
            taiKhoanGridControl.Visible = false;
            btnChooseSend.Enabled = true;
            btnOKRec.Enabled = false;
            btnChooseRec.Enabled = true;
            isChooseSender = false;
            isChooseReceiver = false;
        }

        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (isChooseReceiver)
            {
                txtAccountReceive.Text = ((DataRowView)thongTinTaiKhoanBindingSource[thongTinTaiKhoanBindingSource.Position])["SOTK"].ToString();
                lbNameRec.Text = ((DataRowView)thongTinTaiKhoanBindingSource[thongTinTaiKhoanBindingSource.Position])["HOTEN"].ToString().ToUpper();
            }
            else if (isChooseSender)
            {
                txtAccountTransfer.Text = ((DataRowView)thongTinTaiKhoanBindingSource[thongTinTaiKhoanBindingSource.Position])["SOTK"].ToString();
                lbNameSender.Text = ((DataRowView)thongTinTaiKhoanBindingSource[thongTinTaiKhoanBindingSource.Position])["HOTEN"].ToString().ToUpper();
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                txtAccountReceive.Text = ((DataRowView)thongTinGDBindingSource[thongTinGDBindingSource.Position])["SOTK_NHAN"].ToString();
                lbNameRec.Text = ((DataRowView)thongTinGDBindingSource[thongTinGDBindingSource.Position])["HOTEN_NHAN"].ToString();
                txtAccountTransfer.Text = ((DataRowView)thongTinGDBindingSource[thongTinGDBindingSource.Position])["SOTK_CHUYEN"].ToString();
                lbNameSender.Text = ((DataRowView)thongTinGDBindingSource[thongTinGDBindingSource.Position])["HOTEN_CHUYEN"].ToString();
            }
            catch (Exception ex)
            {

            }

        }

        #endregion

        #region Methods

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
    }
}