using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace NganHang.Views
{
    public partial class ReportBankAccount : XtraReport
    {
        public ReportBankAccount(DateTime sDate, DateTime eDate, String maChiNhanh)
        {
            InitializeComponent();
            this.sqlDataSource2.Connection.ConnectionString = Program.connStr;
            this.sqlDataSource2.Queries[0].Parameters[0].Value = sDate;
            this.sqlDataSource2.Queries[0].Parameters[1].Value = eDate;
            this.sqlDataSource2.Queries[0].Parameters[2].Value = maChiNhanh;
            this.sqlDataSource2.Fill();

        }

    }
}
