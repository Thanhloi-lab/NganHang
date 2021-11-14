using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace NganHang.Views
{
    public partial class ReportCustomer : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportCustomer(bool isChecked)
        {
            InitializeComponent();
            this.sqlDataSource2.Connection.ConnectionString = Program.connStr;
            this.sqlDataSource2.Queries[0].Parameters[0].Value = isChecked;
            this.sqlDataSource2.Fill();
        }

    }
}
