using NganHang.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NganHang
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        #region Methods

        public void ShowMenu()
        {
            HideMenu();
            ButtonAfterLogin();
            ShowAllBarButton();
        }

        public void HideMenu()
        {
            foreach (Form f in this.MdiChildren)
            {
                f.Close();
            }
        }

        public void ButtonAfterLogin()
        {
            btnLogin.Enabled = false;
            btnLogout.Enabled = true;
            btnUserInfo.Enabled = true;
        }

        public void ShowLoginForm()
        {
            Cursor.Current = Cursors.WaitCursor;
            Form frm = this.CheckExists(typeof(LoginForm));
            if (frm != null) frm.Activate();
            else
            {
                LoginForm f = new LoginForm();
                f.MdiParent = this;
                f.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        public void ShowUserInfoForm()
        {
            Cursor.Current = Cursors.WaitCursor;
            Form frm = this.CheckExists(typeof(UserInfoForm));
            if (frm != null) frm.Activate();
            else
            {
                UserInfoForm f = new UserInfoForm();
                f.MdiParent = this;
                f.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        public void ShowAllBarButton()
        {
            barBtnDisplay.Visible = barBtnManage.Visible = barBtnStatistic.Visible = barBtnSystem.Visible = true;
        }

        public void ShowStaffList()
        {
            Cursor.Current = Cursors.WaitCursor;
            Form frm = this.CheckExists(typeof(StaffForm));
            if (frm != null) frm.Activate();
            else
            {
                StaffForm f = new StaffForm();
                f.MdiParent = this;
                f.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        public void ShowAccountList()
        {
            Cursor.Current = Cursors.WaitCursor;
            Form frm = this.CheckExists(typeof(AccountForm));
            if (frm != null) frm.Activate();
            else
            {
                AccountForm f = new AccountForm();
                f.MdiParent = this;
                f.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        public void ButtonBeforeLogin()
        {
            btnLogin.Enabled = true;
            btnLogout.Enabled = false;
            btnUserInfo.Enabled = false;
        }

        public void Logout()
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn đăng xuất khỏi hệ thống?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Program.SetDefautValue();
                HideMenu();
                ShowLoginForm();
                ButtonBeforeLogin();
            }
            return;
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        public void ShowBankAccountForm()
        {
            Cursor.Current = Cursors.WaitCursor;
            Form frm = this.CheckExists(typeof(FormBankAccount));
            if (frm != null) frm.Activate();
            else
            {
                FormBankAccount f = new FormBankAccount();
                f.MdiParent = this;
                f.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        public void ShowCustomerForm()
        {
            Cursor.Current = Cursors.WaitCursor;
            Form frm = this.CheckExists(typeof(FormCustomer));
            if (frm != null) frm.Activate();
            else
            {
                FormCustomer f = new FormCustomer();
                f.MdiParent = this;
                f.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        public void ShowReportForm()
        {
            Cursor.Current = Cursors.WaitCursor;
            Form frm = this.CheckExists(typeof(FormBankStatement));
            if (frm != null) frm.Activate();
            else
            {
                FormBankStatement f = new FormBankStatement();
                f.MdiParent = this;
                f.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        public void ShowTransferMoneyForm()
        {
            Cursor.Current = Cursors.WaitCursor;
            Form frm = this.CheckExists(typeof(FormTransfer));
            if (frm != null) frm.Activate();
            else
            {
                FormTransfer f = new FormTransfer();
                f.MdiParent = this;
                f.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        public void ShowFormSendCashout()
        {
            Cursor.Current = Cursors.WaitCursor;
            Form frm = this.CheckExists(typeof(FormSendCashout));
            if (frm != null) frm.Activate();
            else
            {
                FormSendCashout f = new FormSendCashout();
                f.MdiParent = this;
                f.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        public void ShowFormListAccount()
        {
            Cursor.Current = Cursors.WaitCursor;
            Form frm = this.CheckExists(typeof(FormListAccount));
            if (frm != null) frm.Activate();
            else
            {
                FormListAccount f = new FormListAccount();
                f.MdiParent = this;
                f.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        public void ShowFormListCustomer()
        {
            Cursor.Current = Cursors.WaitCursor;
            Form frm = this.CheckExists(typeof(FormListCustomer));
            if (frm != null) frm.Activate();
            else
            {
                FormListCustomer f = new FormListCustomer();
                f.MdiParent = this;
                f.Show();
            }
            Cursor.Current = Cursors.Default;
        }

        #endregion


        #region Events

        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Logout();
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowLoginForm();
        }

        private void btnUserInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowUserInfoForm();
        }

        private void btnChuyenNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnThongTinNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowStaffList();
        }

        private void btnThongTinTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowAccountList();
        }

        private void btnThongTinKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowCustomerForm();
        }

        private void btnMoTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowBankAccountForm();
        }

        #endregion

        private void btnSaoKe_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowReportForm();
        }

        private void btnGoiTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowFormSendCashout();
        }

        private void btnChuyenTien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowTransferMoneyForm();
        }

        private void btnLietKeTaiKhoan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowFormListAccount();
        }

        private void btnLietKeKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowFormListCustomer();
        }
    }
}
