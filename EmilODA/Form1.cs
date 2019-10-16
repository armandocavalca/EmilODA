﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;


namespace EmilODA
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ricarica();
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

            myCommand.CommandText = "SELECT o.qsta,o.Nord," + 
                "concat(concat(substring(o.dord, 7, 2), '/') , " +
                "concat(concat(substring(o.dord, 5, 2) , '/') , " +
                "substring(o.dord, 1, 4)))," +
                " a.acrag1   " + 
                " FROM $EMIEDATI.oda200f o " + 
                " left join $d_emil.acf00f a " +
                " on o.dtip = a.actpcd and o.cfor = a.acscon " +
                " where o.qsta <> 'X'"+
                " group by o.qsta,o.Nord,o.dord, a.acrag1"; 

            iDB2DataReader myReader = myCommand.ExecuteReader();

            DataTable dt = new DataTable();

            dt.Load(myReader);

            dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "Stato";
            dataGridView1.Columns[1].HeaderText = "Numero Ordine";
            dataGridView1.Columns[2].HeaderText = "Data Ordine";
            dataGridView1.Columns[3].HeaderText = "Fornitore";
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ricarica();
        }

        private void Btn_inserisci_Click(object sender, EventArgs e)
        {
            Form Ffornitore = new SceltaFornitore();
            Ffornitore.ShowDialog();
        }
    }
}