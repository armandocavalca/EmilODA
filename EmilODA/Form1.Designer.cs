namespace EmilODA
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_ricarica = new System.Windows.Forms.Button();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.Btn_inserisci = new System.Windows.Forms.Button();
            this.btn_modifica = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(776, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // Btn_ricarica
            // 
            this.Btn_ricarica.Location = new System.Drawing.Point(12, 463);
            this.Btn_ricarica.Name = "Btn_ricarica";
            this.Btn_ricarica.Size = new System.Drawing.Size(172, 45);
            this.Btn_ricarica.TabIndex = 1;
            this.Btn_ricarica.Text = "Ricarica";
            this.Btn_ricarica.UseVisualStyleBackColor = true;
            this.Btn_ricarica.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_exit
            // 
            this.Btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_exit.Location = new System.Drawing.Point(661, 463);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(127, 45);
            this.Btn_exit.TabIndex = 2;
            this.Btn_exit.Text = "Uscita";
            this.Btn_exit.UseVisualStyleBackColor = true;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Btn_inserisci
            // 
            this.Btn_inserisci.Location = new System.Drawing.Point(190, 463);
            this.Btn_inserisci.Name = "Btn_inserisci";
            this.Btn_inserisci.Size = new System.Drawing.Size(172, 45);
            this.Btn_inserisci.TabIndex = 3;
            this.Btn_inserisci.Text = "Inserisci";
            this.Btn_inserisci.UseVisualStyleBackColor = true;
            this.Btn_inserisci.Click += new System.EventHandler(this.Btn_inserisci_Click);
            // 
            // btn_modifica
            // 
            this.btn_modifica.Location = new System.Drawing.Point(368, 463);
            this.btn_modifica.Name = "btn_modifica";
            this.btn_modifica.Size = new System.Drawing.Size(172, 45);
            this.btn_modifica.TabIndex = 4;
            this.btn_modifica.Text = "Modifica/Evadi";
            this.btn_modifica.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.btn_modifica);
            this.Controls.Add(this.Btn_inserisci);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.Btn_ricarica);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_ricarica;
        private System.Windows.Forms.Button Btn_exit;
        private System.Windows.Forms.Button Btn_inserisci;
        private System.Windows.Forms.Button btn_modifica;
    }
}