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
    public partial class Inserisci : Form
    {
        public Inserisci()
        {
            InitializeComponent();
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_inserisci_Click(object sender, EventArgs e)
        {
            Dettaglio fdet = new Dettaglio();
            fdet.ShowDialog();
        }

        private void Inserisci_Load(object sender, EventArgs e)
        {
            Lbl_number.Text = Convert.ToString( PrimoNumeroLibero() + 1) ;
        }
        private int PrimoNumeroLibero()
        {
            iDB2Connection DBCONN = new iDB2Connection(Program.myConnString);

            DBCONN.Open();

            iDB2Command myCommand = new iDB2Command();

            myCommand.Connection = DBCONN;

            myCommand.CommandText = "SELECT max(o.nord)" +
                " FROM $EMIEDATI.oda200f o " ;

            iDB2DataReader myReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();

            if (myReader.HasRows)
                return myReader.GetInt32(0);
            else
                return 0;

        }
        private void CaricaFornitore()
        {
            iDB2Connection DBCONN = new iDB2Connection(Program.myConnString);

            DBCONN.Open();

            iDB2Command myCommand = new iDB2Command();

            myCommand.Connection = DBCONN;

            myCommand.CommandText = "SELECT o.qsta,o.Nord," +
                "concat(concat(substring(o.dord, 7, 2), '/') , " +
                "concat(concat(substring(o.dord, 5, 2) , '/') , " +
                "substring(o.dord, 1, 4)))," +
                " a.acrag1   " +
                " FROM $EMIEDATI.oda200f o " +
                " left join $d_emil.acf00f a " +
                " on o.dtip = a.actpcd and o.cfor = a.acscon " +
                " where o.qsta <> 'X'" +
                " group by o.qsta,o.Nord,o.dord, a.acrag1";

            iDB2DataReader myReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(myReader);

            //dataGridView1.DataSource = dt;
            //dataGridView1.Columns[0].HeaderText = "Stato";
            //dataGridView1.Columns[1].HeaderText = "Numero Ordine";
            //dataGridView1.Columns[2].HeaderText = "Data Ordine";
            //dataGridView1.Columns[3].HeaderText = "Fornitore";
            //for (int i = 0; i < dataGridView1.Columns.Count; i++)
            //    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


        }
    }
}
