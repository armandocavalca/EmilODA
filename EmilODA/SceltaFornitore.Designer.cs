namespace EmilODA
{
    partial class SceltaFornitore
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Cmb_Fornitore = new System.Windows.Forms.ComboBox();
            this.lbl_Codice = new System.Windows.Forms.Label();
            this.DTP_Ordine = new System.Windows.Forms.DateTimePicker();
            this.DTP_Consegna = new System.Windows.Forms.DateTimePicker();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.Btn_Avanti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fornitore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Immissione";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Richiesta Consegna";
            // 
            // Cmb_Fornitore
            // 
            this.Cmb_Fornitore.FormattingEnabled = true;
            this.Cmb_Fornitore.Location = new System.Drawing.Point(260, 9);
            this.Cmb_Fornitore.Name = "Cmb_Fornitore";
            this.Cmb_Fornitore.Size = new System.Drawing.Size(348, 24);
            this.Cmb_Fornitore.TabIndex = 3;
            this.Cmb_Fornitore.SelectedIndexChanged += new System.EventHandler(this.Cmb_Fornitore_SelectedIndexChanged);
            // 
            // lbl_Codice
            // 
            this.lbl_Codice.AutoSize = true;
            this.lbl_Codice.Location = new System.Drawing.Point(657, 12);
            this.lbl_Codice.Name = "lbl_Codice";
            this.lbl_Codice.Size = new System.Drawing.Size(46, 17);
            this.lbl_Codice.TabIndex = 4;
            this.lbl_Codice.Text = "label4";
            // 
            // DTP_Ordine
            // 
            this.DTP_Ordine.Location = new System.Drawing.Point(260, 40);
            this.DTP_Ordine.Name = "DTP_Ordine";
            this.DTP_Ordine.Size = new System.Drawing.Size(348, 22);
            this.DTP_Ordine.TabIndex = 5;
            // 
            // DTP_Consegna
            // 
            this.DTP_Consegna.Location = new System.Drawing.Point(260, 68);
            this.DTP_Consegna.Name = "DTP_Consegna";
            this.DTP_Consegna.Size = new System.Drawing.Size(348, 22);
            this.DTP_Consegna.TabIndex = 6;
            // 
            // Btn_exit
            // 
            this.Btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_exit.Location = new System.Drawing.Point(660, 129);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(127, 45);
            this.Btn_exit.TabIndex = 7;
            this.Btn_exit.Text = "Annulla";
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Btn_Avanti
            // 
            this.Btn_Avanti.Location = new System.Drawing.Point(17, 129);
            this.Btn_Avanti.Name = "Btn_Avanti";
            this.Btn_Avanti.Size = new System.Drawing.Size(172, 45);
            this.Btn_Avanti.TabIndex = 8;
            this.Btn_Avanti.Text = "Procedi";
            this.Btn_Avanti.UseVisualStyleBackColor = true;
            // 
            // SceltaFornitore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 186);
            this.Controls.Add(this.Btn_Avanti);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.DTP_Consegna);
            this.Controls.Add(this.DTP_Ordine);
            this.Controls.Add(this.lbl_Codice);
            this.Controls.Add(this.Cmb_Fornitore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SceltaFornitore";
            this.Text = "SceltaFornitore";
            this.Load += new System.EventHandler(this.SceltaFornitore_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cmb_Fornitore;
        private System.Windows.Forms.Label lbl_Codice;
        private System.Windows.Forms.DateTimePicker DTP_Ordine;
        private System.Windows.Forms.DateTimePicker DTP_Consegna;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Button Btn_Avanti;
    }
}