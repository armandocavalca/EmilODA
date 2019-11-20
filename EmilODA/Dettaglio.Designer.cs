namespace EmilODA
{
    partial class Dettaglio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGV_dettaglio = new System.Windows.Forms.DataGridView();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.Lbl_Data = new System.Windows.Forms.Label();
            this.Lbl_Fornitore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DTPRichiesta = new System.Windows.Forms.DateTimePicker();
            this.CMB_Articolo = new System.Windows.Forms.ComboBox();
            this.txt_qta = new System.Windows.Forms.TextBox();
            this.Btn_inserisci = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtQtaEvasione = new System.Windows.Forms.TextBox();
            this.CMB_tipoEvasione = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_riga = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_dettaglio)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_dettaglio
            // 
            this.DGV_dettaglio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGV_dettaglio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_dettaglio.Location = new System.Drawing.Point(8, 88);
            this.DGV_dettaglio.Name = "DGV_dettaglio";
            this.DGV_dettaglio.RowHeadersWidth = 51;
            this.DGV_dettaglio.RowTemplate.Height = 24;
            this.DGV_dettaglio.Size = new System.Drawing.Size(865, 452);
            this.DGV_dettaglio.TabIndex = 0;
            this.DGV_dettaglio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_dettaglio_CellClick);
            // 
            // Btn_exit
            // 
            this.Btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_exit.Location = new System.Drawing.Point(741, 766);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(127, 45);
            this.Btn_exit.TabIndex = 3;
            this.Btn_exit.Text = "Uscita";
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.Location = new System.Drawing.Point(139, 18);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(46, 17);
            this.lbl_numero.TabIndex = 4;
            this.lbl_numero.Text = "label1";
            // 
            // Lbl_Data
            // 
            this.Lbl_Data.AutoSize = true;
            this.Lbl_Data.Location = new System.Drawing.Point(299, 18);
            this.Lbl_Data.Name = "Lbl_Data";
            this.Lbl_Data.Size = new System.Drawing.Size(46, 17);
            this.Lbl_Data.TabIndex = 5;
            this.Lbl_Data.Text = "label1";
            // 
            // Lbl_Fornitore
            // 
            this.Lbl_Fornitore.AutoSize = true;
            this.Lbl_Fornitore.Location = new System.Drawing.Point(139, 52);
            this.Lbl_Fornitore.Name = "Lbl_Fornitore";
            this.Lbl_Fornitore.Size = new System.Drawing.Size(46, 17);
            this.Lbl_Fornitore.TabIndex = 6;
            this.Lbl_Fornitore.Text = "label1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data Richiesta Consegna";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 611);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codice Articolo";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 642);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantità Ordine";
            // 
            // DTPRichiesta
            // 
            this.DTPRichiesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DTPRichiesta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPRichiesta.Location = new System.Drawing.Point(210, 573);
            this.DTPRichiesta.Name = "DTPRichiesta";
            this.DTPRichiesta.Size = new System.Drawing.Size(123, 22);
            this.DTPRichiesta.TabIndex = 10;
            // 
            // CMB_Articolo
            // 
            this.CMB_Articolo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CMB_Articolo.FormattingEnabled = true;
            this.CMB_Articolo.Location = new System.Drawing.Point(210, 604);
            this.CMB_Articolo.Name = "CMB_Articolo";
            this.CMB_Articolo.Size = new System.Drawing.Size(362, 24);
            this.CMB_Articolo.TabIndex = 11;
            // 
            // txt_qta
            // 
            this.txt_qta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_qta.Location = new System.Drawing.Point(210, 637);
            this.txt_qta.Name = "txt_qta";
            this.txt_qta.Size = new System.Drawing.Size(362, 22);
            this.txt_qta.TabIndex = 12;
            // 
            // Btn_inserisci
            // 
            this.Btn_inserisci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Btn_inserisci.Location = new System.Drawing.Point(23, 766);
            this.Btn_inserisci.Name = "Btn_inserisci";
            this.Btn_inserisci.Size = new System.Drawing.Size(127, 45);
            this.Btn_inserisci.TabIndex = 13;
            this.Btn_inserisci.Text = "Inserisci";
            this.Btn_inserisci.UseVisualStyleBackColor = true;
            this.Btn_inserisci.Click += new System.EventHandler(this.Btn_inserisci_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 682);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quantità Evasione";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 716);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Tipo Evasione";
            // 
            // TxtQtaEvasione
            // 
            this.TxtQtaEvasione.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtQtaEvasione.Location = new System.Drawing.Point(210, 677);
            this.TxtQtaEvasione.Name = "TxtQtaEvasione";
            this.TxtQtaEvasione.Size = new System.Drawing.Size(362, 22);
            this.TxtQtaEvasione.TabIndex = 16;
            // 
            // CMB_tipoEvasione
            // 
            this.CMB_tipoEvasione.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CMB_tipoEvasione.FormattingEnabled = true;
            this.CMB_tipoEvasione.Location = new System.Drawing.Point(210, 709);
            this.CMB_tipoEvasione.Name = "CMB_tipoEvasione";
            this.CMB_tipoEvasione.Size = new System.Drawing.Size(362, 24);
            this.CMB_tipoEvasione.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Ordine Numero:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Del:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Fornitore:";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 578);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Progressivo";
            // 
            // txt_riga
            // 
            this.txt_riga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_riga.Location = new System.Drawing.Point(452, 576);
            this.txt_riga.Name = "txt_riga";
            this.txt_riga.Size = new System.Drawing.Size(120, 22);
            this.txt_riga.TabIndex = 22;
            // 
            // Dettaglio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 823);
            this.Controls.Add(this.txt_riga);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CMB_tipoEvasione);
            this.Controls.Add(this.TxtQtaEvasione);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Btn_inserisci);
            this.Controls.Add(this.txt_qta);
            this.Controls.Add(this.CMB_Articolo);
            this.Controls.Add(this.DTPRichiesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_Fornitore);
            this.Controls.Add(this.Lbl_Data);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.DGV_dettaglio);
            this.Name = "Dettaglio";
            this.Text = "Dettaglio";
            this.Load += new System.EventHandler(this.Dettaglio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_dettaglio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_dettaglio;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Label Lbl_Data;
        private System.Windows.Forms.Label Lbl_Fornitore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DTPRichiesta;
        private System.Windows.Forms.ComboBox CMB_Articolo;
        private System.Windows.Forms.TextBox txt_qta;
        private System.Windows.Forms.Button Btn_inserisci;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtQtaEvasione;
        private System.Windows.Forms.ComboBox CMB_tipoEvasione;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_riga;
    }
}