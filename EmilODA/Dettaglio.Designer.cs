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
            this.DGV_dettaglio.Size = new System.Drawing.Size(865, 372);
            this.DGV_dettaglio.TabIndex = 0;
            this.DGV_dettaglio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_dettaglio_CellClick);
            // 
            // Btn_exit
            // 
            this.Btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_exit.Location = new System.Drawing.Point(741, 573);
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
            this.lbl_numero.Location = new System.Drawing.Point(17, 13);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(46, 17);
            this.lbl_numero.TabIndex = 4;
            this.lbl_numero.Text = "label1";
            // 
            // Lbl_Data
            // 
            this.Lbl_Data.AutoSize = true;
            this.Lbl_Data.Location = new System.Drawing.Point(108, 13);
            this.Lbl_Data.Name = "Lbl_Data";
            this.Lbl_Data.Size = new System.Drawing.Size(46, 17);
            this.Lbl_Data.TabIndex = 5;
            this.Lbl_Data.Text = "label1";
            // 
            // Lbl_Fornitore
            // 
            this.Lbl_Fornitore.AutoSize = true;
            this.Lbl_Fornitore.Location = new System.Drawing.Point(17, 47);
            this.Lbl_Fornitore.Name = "Lbl_Fornitore";
            this.Lbl_Fornitore.Size = new System.Drawing.Size(46, 17);
            this.Lbl_Fornitore.TabIndex = 6;
            this.Lbl_Fornitore.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Data Richiesta Consegna";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codice Articolo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 545);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Quantità";
            // 
            // DTPRichiesta
            // 
            this.DTPRichiesta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPRichiesta.Location = new System.Drawing.Point(210, 476);
            this.DTPRichiesta.Name = "DTPRichiesta";
            this.DTPRichiesta.Size = new System.Drawing.Size(123, 22);
            this.DTPRichiesta.TabIndex = 10;
            // 
            // CMB_Articolo
            // 
            this.CMB_Articolo.FormattingEnabled = true;
            this.CMB_Articolo.Location = new System.Drawing.Point(210, 507);
            this.CMB_Articolo.Name = "CMB_Articolo";
            this.CMB_Articolo.Size = new System.Drawing.Size(365, 24);
            this.CMB_Articolo.TabIndex = 11;
            // 
            // txt_qta
            // 
            this.txt_qta.Location = new System.Drawing.Point(210, 540);
            this.txt_qta.Name = "txt_qta";
            this.txt_qta.Size = new System.Drawing.Size(362, 22);
            this.txt_qta.TabIndex = 12;
            // 
            // Btn_inserisci
            // 
            this.Btn_inserisci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_inserisci.Location = new System.Drawing.Point(23, 573);
            this.Btn_inserisci.Name = "Btn_inserisci";
            this.Btn_inserisci.Size = new System.Drawing.Size(127, 45);
            this.Btn_inserisci.TabIndex = 13;
            this.Btn_inserisci.Text = "Inserisci";
            this.Btn_inserisci.UseVisualStyleBackColor = true;
            this.Btn_inserisci.Click += new System.EventHandler(this.Btn_inserisci_Click);
            // 
            // Dettaglio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 630);
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
    }
}