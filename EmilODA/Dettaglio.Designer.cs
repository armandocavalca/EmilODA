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
            this.DGV_dettaglio.Size = new System.Drawing.Size(865, 410);
            this.DGV_dettaglio.TabIndex = 0;
            // 
            // Btn_exit
            // 
            this.Btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_exit.Location = new System.Drawing.Point(741, 533);
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
            // Dettaglio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 590);
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
    }
}