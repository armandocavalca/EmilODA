using IBM.Data.DB2.iSeries;
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
    public partial class SceltaFornitore : Form
    {
        public SceltaFornitore()
        {
            InitializeComponent();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SceltaFornitore_Load(object sender, EventArgs e)
        {
            Caricamento carica = new Caricamento();
            carica.Show();
            Application.DoEvents();
            iDB2Connection DBCONN = new iDB2Connection(Program.myConnString);

            DBCONN.Open();

            iDB2Command myCommand = new iDB2Command();

            myCommand.Connection = DBCONN;

            myCommand.CommandText = "SELECT acscon, acrag1" +
                " FROM $d_emil.acf00f a " +
                " where actpcd <> 'F'" +
                " order by acrag1";

            iDB2DataReader myReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(myReader);

            Cmb_Fornitore.DataSource = dt;
            Cmb_Fornitore.DisplayMember = "acrag1";
            Cmb_Fornitore.ValueMember = "acscon";
            carica.Close();

        }

        private void Cmb_Fornitore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Fornitore.SelectedIndex > 0)
                lbl_Codice.Text = Cmb_Fornitore.SelectedValue.ToString();
            else
                lbl_Codice.Text = "";
        }
    }
}
