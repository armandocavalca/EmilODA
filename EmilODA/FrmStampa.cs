using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmilODA
{
    public partial class FrmStampa : Form
    {
        public FrmStampa()
        {
            InitializeComponent();
        }

        private void FrmStampa_Load(object sender, EventArgs e)
        {
            ReportViewer rv = new ReportViewer();
            rv.LocalReport.ReportPath = Application.ExecutablePath + "RPT_oda.rdl";
            
            rv.LocalReport.Refresh();
        }
    }
}
