using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;

namespace EmilODA
{
    public partial class Dettaglio : Form
    {
        static string _n;
        static string _f;
        static string _do;
        static string _dc;
        static string _cf;
        static string _r;

        public Dettaglio(string fornitore, string dataordine, string numeroordine, string datarichiesta, string CodFor)
        {
            InitializeComponent();
            lbl_numero.Text = numeroordine;
            Lbl_Fornitore.Text = fornitore;
            Lbl_Data.Text = dataordine;
            _n = numeroordine;
            _f = fornitore;
            _do = dataordine;
            _dc = datarichiesta;
            _cf = CodFor;
        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Ricarica()
        {
            iDB2Connection DBCONN = new iDB2Connection(Program.myConnString);

            DBCONN.Open();

            iDB2Command myCommand = new iDB2Command();

            myCommand.Connection = DBCONN;

            myCommand.CommandText = "SELECT o.cart,a.ardsar,o.qord,o.qric, o.qsta, " +
                "concat(concat(substring(o.dric, 7, 2), '/') , " +
                "concat(concat(substring(o.dric, 5, 2) , '/') , " +
                "substring(o.dric, 1, 4))), prog" +
                 " FROM $EMIEDATI.oda200f o " +
                " left join $EMIEDATI.art00f a " +
                " on o.cart = a.ararti  " +
                " where o.qsta <> 'X' " +
                " and o.nord = " + lbl_numero.Text;

            iDB2DataReader myReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(myReader);

            DGV_dettaglio.DataSource = dt;
            DGV_dettaglio.Columns[0].HeaderText = "Codice";
            DGV_dettaglio.Columns[1].HeaderText = "Descrizione";
            DGV_dettaglio.Columns[2].HeaderText = "Q.tà Ordine";
            DGV_dettaglio.Columns[3].HeaderText = "Q.tà Ricevuta";
            DGV_dettaglio.Columns[4].HeaderText = "Stato";
            DGV_dettaglio.Columns[5].HeaderText = "Data Richiesta";
            DGV_dettaglio.Columns[6].HeaderText = "Numero Riga";
            for (int i = 0; i < DGV_dettaglio.Columns.Count; i++)
                DGV_dettaglio.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


        }

        private void Dettaglio_Load(object sender, EventArgs e)
        {
            Ricarica();
            impostaarticolo();

            Stato _stato= new Stato();
            if (Program._Stato == _stato.Inserisci)
            {
                DTPRichiesta.Value = Convert.ToDateTime( _dc);
                Btn_inserisci.Text = "Inserisci";
            }
            if(Program._Stato==_stato.Modifica)
            {
                StatoModifica();
            }
        }
        void StatoModifica()
        {
            Btn_inserisci.Text = "Modifica";
            Btn_inserisci.Enabled = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            DTPRichiesta.Visible = false;
            CMB_Articolo.Visible = false;
            txt_qta.Visible = false;
        }
        void impostaarticolo()
        {
            Caricamento carica = new Caricamento();
            carica.Show();
            Application.DoEvents();
            iDB2Connection DBCONN = new iDB2Connection(Program.myConnString);

            DBCONN.Open();

            iDB2Command myCommand = new iDB2Command();

            myCommand.Connection = DBCONN;

            myCommand.CommandText = "SELECT ararti, ardsar" +
                " FROM $emiedati.art00f a " +
                " order by ardsar";

            iDB2DataReader myReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(myReader);

            CMB_Articolo.DataSource = dt;
            CMB_Articolo.DisplayMember = "ardsar";
            CMB_Articolo.ValueMember = "ararti";
            carica.Close();
            DBCONN.Close();
        }

        private void Btn_inserisci_Click(object sender, EventArgs e)
        {
            Stato _stato = new Stato();
            if (Program._Stato==_stato.Inserisci)
            {
                iDB2Connection DBCONN = new iDB2Connection(Program.myConnString);

                DBCONN.Open();

                iDB2Command myCommand = new iDB2Command();

                myCommand.Connection = DBCONN;

                myCommand.CommandText = "insert into " +
                    " $emiedati.oda200f " +
                    " (NORD,PROG,DORD,DTIP,CFOR,DRIC,CART,QORD,QRIC,QSTA) " +
                    " values(" +
                    _n + ","+
                    (PrimoNumeroLibero()+1)  + "," +
                    Convert.ToDateTime( _do).ToString("yyyyMMdd") + "," +
                    "'F','" +
                    _cf + "'," +
                    DTPRichiesta.Value.ToString("yyyyMMdd") + ",'" +
                    CMB_Articolo.SelectedValue + "'," +
                    Convert.ToDecimal(txt_qta.Text) + "," +
                    0 + ",'" +
                    _stato.Inserisci + "'" +
                    ") ";

                try
                {
                    myCommand.ExecuteNonQuery();
                }
                catch(Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                DBCONN.Close();

                Ricarica();
            }
            if(Program._Stato==_stato.Modifica)
            {
                iDB2Connection DBCONN = new iDB2Connection(Program.myConnString);

                DBCONN.Open();

                iDB2Command myCommand = new iDB2Command();

                myCommand.Connection = DBCONN;

                myCommand.CommandText = "update " +
                    " $emiedati.oda200f " +
                    " set  " +
                    " cart = '" + CMB_Articolo.SelectedValue + "',"+
                    " qord = " + Convert.ToDecimal(txt_qta.Text) + "," +
                    " dric = " + DTPRichiesta.Value.ToString("yyyyMMdd") +
                    " where nord = " + _n +
                    " and prog = "+ _r ;

                try
                {
                    myCommand.ExecuteNonQuery();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    return;
                }

                DBCONN.Close();

                Ricarica();


                Btn_inserisci.Enabled = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                DTPRichiesta.Visible = false;
                CMB_Articolo.Visible = false;
                txt_qta.Visible = false;
            }
        }
        private int PrimoNumeroLibero()
        {
            iDB2Connection DBCONN = new iDB2Connection(Program.myConnString);

            DBCONN.Open();

            iDB2Command myCommand = new iDB2Command();

            myCommand.Connection = DBCONN;

            myCommand.CommandText = "SELECT max(o.prog) " +
                " FROM $EMIEDATI.oda200f o " +
                " where NORD = " + _n;

            iDB2DataReader myReader = myCommand.ExecuteReader();

            if (myReader.HasRows)
                while (myReader.Read())
                    try
                    { return myReader.GetInt32(0); }
                    catch
                    { return 0; }
            else
                return 0;
            DBCONN.Close();
            return 0;

        }

        private void DGV_dettaglio_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGV_dettaglio.SelectedRows.Count == 0)
                return;
            Btn_inserisci.Enabled = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            DTPRichiesta.Visible = true;
            CMB_Articolo.Visible = true;
            txt_qta.Visible = true;
            var _riga = DGV_dettaglio.SelectedRows[0].Index;
            DTPRichiesta.Value = Convert.ToDateTime (DGV_dettaglio[5, _riga].Value);
            CMB_Articolo.Text = DGV_dettaglio[1, _riga].Value.ToString();
            txt_qta.Text = DGV_dettaglio[2, _riga].Value.ToString();
            _r = DGV_dettaglio[6, _riga].Value.ToString();
        }
    }

        
}
