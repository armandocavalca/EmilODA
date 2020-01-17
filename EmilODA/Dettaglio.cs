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
                " and o.nord = " + lbl_numero.Text +
                " order by prog";

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

            // carica combo tipo evasione
            //CMB_tipoEvasione.Items.Insert(0,"Inserito");
            //CMB_tipoEvasione.Items.Insert(1, "Evaso Parzialmente");
            //CMB_tipoEvasione.Items.Insert(2, "Evaso Totalmente");
            
            DataTable workTable = new DataTable("Evasione");

            DataColumn workCol = workTable.Columns.Add("Codice", typeof(String));
            workTable.Columns.Add("Descrizione", typeof(String));
            DataRow workRow = workTable.NewRow();
            workRow[0] = "I";
            workRow[1] = "Inserito (I)";
            workTable.Rows.Add(workRow);
            workRow = workTable.NewRow();
            workRow[0] = "P";
            workRow[1] = "Evaso Parzialmente (P)";
            workTable.Rows.Add(workRow);
            workRow = workTable.NewRow();
            workRow[0] = "S";
            workRow[1] = "Evaso Totalmente (S)";
            workTable.Rows.Add(workRow);

            CMB_tipoEvasione.DataSource = workTable;
            CMB_tipoEvasione.ValueMember = "Codice";
            CMB_tipoEvasione.DisplayMember = "Descrizione";


            Stato _stato = new Stato();
            if (Program._Stato == _stato.Inserisci)
            {
                DTPRichiesta.Value = Convert.ToDateTime( _dc);
                Btn_inserisci.Text = "Inserisci";
                chkDel.Visible = false;
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
            label4.Visible = false;
            label5.Visible = false;
            label9.Visible = false;
            DTPRichiesta.Visible = false;
            CMB_Articolo.Visible = false;
            txt_qta.Visible = false;
            TxtQtaEvasione.Visible = false;
            CMB_tipoEvasione.Visible = false;
            txt_riga.Visible = false;
            chkDel.Visible = false;
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
                    (PrimoNumeroLibero()+10)  + "," +
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
                if(txt_riga.Text!=_r)
                if(ControllaDoppi())
                {
                    MessageBox.Show("Progressivo esiste già modificare progressivo");
                    return;
                }

                iDB2Connection DBCONN = new iDB2Connection(Program.myConnString);

                DBCONN.Open();

                iDB2Command myCommand = new iDB2Command();

                myCommand.Connection = DBCONN;

                if(chkDel.Checked)
                {
                    if(MessageBox.Show("Confermi la cancellazione della riga?","Cancella Riga",MessageBoxButtons.YesNo)==DialogResult.No)
                        return;
                    else
                    {
                        myCommand.CommandText = "delete from " +
                            " $emiedati.oda200f " +
                            " where nord = " + _n +
                            " and prog = " + _r;
                    }

                }
                else
                myCommand.CommandText = "update " +
                    " $emiedati.oda200f " +
                    " set  " +
                    " cart = '" + CMB_Articolo.SelectedValue + "',"+
                    " qord = " + txt_qta.Text.Replace(",",".") + "," +
                    " dric = " + DTPRichiesta.Value.ToString("yyyyMMdd") + ","+
                    " qric = " + TxtQtaEvasione.Text.Replace(",", ".") + "," +
                    " qsta = '" + CMB_tipoEvasione.SelectedValue + "'," +
                    " prog = " + Convert.ToDecimal(txt_riga.Text) + 
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

                StatoModifica();

                //Btn_inserisci.Enabled = false;
                //label1.Visible = false;
                //label2.Visible = false;
                //label3.Visible = false;
                //DTPRichiesta.Visible = false;
                //CMB_Articolo.Visible = false;
                //txt_qta.Visible = false;
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
            label4.Visible = true;
            label5.Visible = true;
            label9.Visible = true;
            DTPRichiesta.Visible = true;
            CMB_Articolo.Visible = true;
            txt_qta.Visible = true;
            TxtQtaEvasione.Visible = true;
            CMB_tipoEvasione.Visible = true;
            txt_riga.Visible = true;
            chkDel.Visible = true;
            chkDel.Checked = false;
            var _riga = DGV_dettaglio.SelectedRows[0].Index;
            DTPRichiesta.Value = Convert.ToDateTime (DGV_dettaglio[5, _riga].Value);
            CMB_Articolo.Text = DGV_dettaglio[1, _riga].Value.ToString();
            txt_qta.Text = DGV_dettaglio[2, _riga].Value.ToString();
            _r = DGV_dettaglio[6, _riga].Value.ToString();
            TxtQtaEvasione.Text= DGV_dettaglio[3    , _riga].Value.ToString();
            CMB_tipoEvasione.SelectedValue= DGV_dettaglio[4, _riga].Value.ToString();
            txt_riga.Text = DGV_dettaglio[6, _riga].Value.ToString();
        }
        private bool ControllaDoppi()
        {

            iDB2Connection DBCONN = new iDB2Connection(Program.myConnString);

            DBCONN.Open();

            iDB2Command myCommand = new iDB2Command();

            myCommand.Connection = DBCONN;

            myCommand.CommandText = "SELECT *" +
                " FROM $emiedati.oda200f a " +
                " where NORD = " + _n +
                " and prog = " + txt_riga.Text;

            iDB2DataReader myReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();
            dt.Load(myReader);

            bool _conta = true;
            if (dt.Rows.Count > 0)
                _conta = true;
            else
                _conta = false;

            DBCONN.Close();

            return _conta;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // svuota file di passaggio
            iDB2Connection DBCONN = new iDB2Connection(Program.myConnString);

            DBCONN.Open();

            iDB2Command myCommand = new iDB2Command();

            myCommand.Connection = DBCONN;

            myCommand.CommandText = "delete from ODA202P ";
            myCommand.ExecuteNonQuery();

            myCommand.CommandText = "SELECT ACRAG1, ACRAG2, ACVIA, ACCAP, ACCITT, ACPROV " + 
                "FROM $d_emil.acf00f " +
                " WHERE ACTPCD = 'F' and ACSCON = '" + _cf + "'";
            iDB2DataReader myReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(myReader);

            string _rg1="";
            string _rg2 = "";
            string _via = "";
            string _cap = "";
            string _cit = "";
            string _prov = "";
            foreach (DataRow r in dt.Rows)
            {
               _rg1= r[0].ToString().Replace("'","''");
                _rg2 = r[1].ToString().Replace("'","''");
                _via = r[2].ToString().Replace("'", "''");
                _cap = r[3].ToString().Substring(0,5).Replace("'", "''");
                _cit = r[4].ToString().Replace("'", "''");
                _prov = r[5].ToString().Substring(0,2).Replace("'", "''");
            }

            for (int i = 0; i <  DGV_dettaglio.Rows.Count; i++)
            {
                if (DGV_dettaglio.Rows[i].Cells[3].Value != null)
                {
                    myCommand.CommandText = "insert into ODA202P " +
                        "(NORD,PROG, DORD, DTIP, CFOR, ACRAG1," +
                        "ACRAG2, ACVIA, ACCAP, ACCIT, ACPROV, DRIC,CART," +
                        "ARDSAR, ARUNMI, QORD)  " +
                        " values('" + _n +"','" +
                        DGV_dettaglio.Rows[i].Cells[6].Value.ToString() + "','" +
                        _do.Replace("/","") + "','F'," +"'"+ _cf+"','" + _f + 
                        "','" + _rg2 +"','" + _via +"','" + _cap +"','" + _cit + "','" + _prov +"','" + 
                        DGV_dettaglio.Rows[i].Cells[5].Value.ToString().Replace("/","") + "'," +
                        "'" + DGV_dettaglio.Rows[i].Cells[0].Value.ToString() + "'," +
                        "'" + DGV_dettaglio.Rows[i].Cells[1].Value.ToString() + "'," +
                        "'Nr','" +
                        DGV_dettaglio.Rows[i].Cells[2].Value.ToString().Replace(",",".") + "')";
                    myCommand.ExecuteNonQuery();
                    //MessageBox.Show(dataGridView1.Rows[i].Cells[3].Value.ToString());
                }
            }

            Frm_ModuloOdf Podf = new Frm_ModuloOdf();
            Podf.WindowState = FormWindowState.Maximized;
            Podf.ShowDialog();
        }
    }

        
}
