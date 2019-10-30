namespace EmilODA
{
    partial class Inserisci
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
            this.Btn_inserisci = new System.Windows.Forms.Button();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.Lbl_number = new System.Windows.Forms.Label();
            this.DTP_DataOrdine = new System.Windows.Forms.DateTimePicker();
            this.CMB_Fornitore = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Btn_inserisci
            // 
            this.Btn_inserisci.Location = new System.Drawing.Point(12, 86);
            this.Btn_inserisci.Name = "Btn_inserisci";
            this.Btn_inserisci.Size = new System.Drawing.Size(172, 45);
            this.Btn_inserisci.TabIndex = 4;
            this.Btn_inserisci.Text = "Inserisci";
            this.Btn_inserisci.UseVisualStyleBackColor = true;
            this.Btn_inserisci.Click += new System.EventHandler(this.Btn_inserisci_Click);
            // 
            // Btn_exit
            // 
            this.Btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_exit.Location = new System.Drawing.Point(602, 86);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(127, 45);
            this.Btn_exit.TabIndex = 5;
            this.Btn_exit.Text = "Uscita";
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Lbl_number
            // 
            this.Lbl_number.AutoSize = true;
            this.Lbl_number.Location = new System.Drawing.Point(17, 21);
            this.Lbl_number.Name = "Lbl_number";
            this.Lbl_number.Size = new System.Drawing.Size(56, 17);
            this.Lbl_number.TabIndex = 6;
            this.Lbl_number.Text = "nnnnnn";
            // 
            // DTP_DataOrdine
            // 
            this.DTP_DataOrdine.Location = new System.Drawing.Point(113, 16);
            this.DTP_DataOrdine.Name = "DTP_DataOrdine";
            this.DTP_DataOrdine.Size = new System.Drawing.Size(167, 22);
            this.DTP_DataOrdine.TabIndex = 7;
            // 
            // CMB_Fornitore
            // 
            this.CMB_Fornitore.FormattingEnabled = true;
            this.CMB_Fornitore.Location = new System.Drawing.Point(320, 17);
            this.CMB_Fornitore.Name = "CMB_Fornitore";
            this.CMB_Fornitore.Size = new System.Drawing.Size(409, 24);
            this.CMB_Fornitore.TabIndex = 8;
            // 
            // Inserisci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 143);
            this.Controls.Add(this.CMB_Fornitore);
            this.Controls.Add(this.DTP_DataOrdine);
            this.Controls.Add(this.Lbl_number);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.Btn_inserisci);
            this.Name = "Inserisci";
            this.Text = "Inserisci";
            this.Load += new System.EventHandler(this.Inserisci_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_inserisci;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Label Lbl_number;
        private System.Windows.Forms.DateTimePicker DTP_DataOrdine;
        private System.Windows.Forms.ComboBox CMB_Fornitore;
    }
}