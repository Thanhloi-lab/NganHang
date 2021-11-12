using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace NganHang.Views
{
    public partial class ReportBankStatement : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportBankStatement()
        {
            InitializeComponent();
        }
        public ReportBankStatement(String sotk, DateTime sDate, DateTime eDate)
        {
            InitializeComponent();
            this.sqlDataSource3.Connection.ConnectionString = Program.connStr;
            this.sqlDataSource3.Queries[0].Parameters[0].Value = sotk;
            this.sqlDataSource3.Queries[0].Parameters[1].Value = sDate;
            this.sqlDataSource3.Queries[0].Parameters[2].Value = eDate;
            this.sqlDataSource3.Fill();

        }
    }
}
