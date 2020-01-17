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
    public partial class Frm_ModuloOdf : Form
    {
        public Frm_ModuloOdf()
        {
            InitializeComponent();
        }

        private void Frm_ModuloOdf_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'dataSet41.ODA202P'. È possibile spostarla o rimuoverla se necessario.
            this.ODA202PTableAdapter.Fill(this.dataSet41.ODA202P);
            // TODO: questa riga di codice carica i dati nella tabella 'DataSet4.ODA202P'. È possibile spostarla o rimuoverla se necessario.
            this.ODA202PTableAdapter.Fill(this.DataSet4.ODA202P);

            this.reportViewer1.RefreshReport();
        }
    }
}
