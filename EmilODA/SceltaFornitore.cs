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
                " where actpcd = 'F'" +
                " order by acrag1";

            iDB2DataReader myReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(myReader);

            Cmb_Fornitore.DataSource = dt;
            Cmb_Fornitore.DisplayMember = "acrag1";
            Cmb_Fornitore.ValueMember = "acscon";
            carica.Close();
            DBCONN.Close();

            //primo numero libero
            lbl_ordine.Text = Convert.ToString(PrimoNumeroLibero() + 1);
        }

        private void Cmb_Fornitore_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cmb_Fornitore.SelectedIndex > 0)
                lbl_Codice.Text = Cmb_Fornitore.SelectedValue.ToString();
            else
                lbl_Codice.Text = "";
        }

        private int PrimoNumeroLibero()
        {
            iDB2Connection DBCONN = new iDB2Connection(Program.myConnString);

            DBCONN.Open();

            iDB2Command myCommand = new iDB2Command();

            myCommand.Connection = DBCONN;

            myCommand.CommandText = "SELECT max(o.nord) " +
                " FROM $EMIEDATI.oda200f o ";

            iDB2DataReader myReader = myCommand.ExecuteReader();

            //DataTable dt = new DataTable();
            //dt.Load(myReader);
            if (myReader.HasRows)
                while(myReader.Read())
                return myReader.GetInt32(0);
            else
                return 0;
            DBCONN.Close();
            return 0;

        }

        private void Btn_Avanti_Click(object sender, EventArgs e)
        {
            if (Cmb_Fornitore.Text != "")
            {
                Program._Stato = "I";
                Dettaglio frmdt =
                   new Dettaglio(Cmb_Fornitore.Text,
                   DTP_Ordine.Value.ToString("dd/MM/yyyy"),
                   lbl_ordine.Text,
                   DTP_Consegna.Value.ToString());
                frmdt.ShowDialog();
            }
        }
    }
}
