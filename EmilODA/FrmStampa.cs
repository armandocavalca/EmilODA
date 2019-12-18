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
            // TODO: questa riga di codice carica i dati nella tabella 'DataSet3.ODA201P'. È possibile spostarla o rimuoverla se necessario.
            this.ODA201PTableAdapter.Fill(this.DataSet3.ODA201P);
            // TODO: questa riga di codice carica i dati nella tabella 'dataSet2.ODA201L'. È possibile spostarla o rimuoverla se necessario.
            this.ODA201LTableAdapter.Fill(this.dataSet2.ODA201L);

            this.reportViewer1.RefreshReport();
        }
    }
}
