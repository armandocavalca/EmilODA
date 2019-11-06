﻿using System;
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
        public Dettaglio(string fornitore, string dataordine, string numeroordine, string datarichiesta)
        {
            InitializeComponent();
            lbl_numero.Text = numeroordine;
            Lbl_Fornitore.Text = fornitore;
            Lbl_Data.Text = dataordine;
            _n = numeroordine;
            _f = fornitore;
            _do = dataordine;
            _dc = datarichiesta;
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
                "substring(o.dric, 1, 4)))" +
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
            for (int i = 0; i < DGV_dettaglio.Columns.Count; i++)
                DGV_dettaglio.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


        }

        private void Dettaglio_Load(object sender, EventArgs e)
        {
            Ricarica();
            Stato _stato= new Stato();
            if (Program._Stato == _stato.Inserisci)
            {
                impostaarticolo();
                //MessageBox.Show(_dc);
                DTPRichiesta.Value = Convert.ToDateTime( _dc);
            }
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
    }

        
}
