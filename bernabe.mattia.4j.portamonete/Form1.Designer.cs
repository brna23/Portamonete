namespace bernabe.mattia._4j.portamonete
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_inserisci = new System.Windows.Forms.Button();
            this.text_value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.num_value = new System.Windows.Forms.TextBox();
            this.money_value = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.money_type = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_inserisci
            // 
            this.btn_inserisci.Location = new System.Drawing.Point(83, 116);
            this.btn_inserisci.Name = "btn_inserisci";
            this.btn_inserisci.Size = new System.Drawing.Size(121, 42);
            this.btn_inserisci.TabIndex = 0;
            this.btn_inserisci.Text = "Inserisci";
            this.btn_inserisci.UseVisualStyleBackColor = true;
            this.btn_inserisci.Click += new System.EventHandler(this.btn_inserisci_Click);
            // 
            // text_value
            // 
            this.text_value.Location = new System.Drawing.Point(83, 51);
            this.text_value.Name = "text_value";
            this.text_value.Size = new System.Drawing.Size(121, 20);
            this.text_value.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valore della moneta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quantità di monete";
            // 
            // num_value
            // 
            this.num_value.Location = new System.Drawing.Point(84, 90);
            this.num_value.Name = "num_value";
            this.num_value.Size = new System.Drawing.Size(120, 20);
            this.num_value.TabIndex = 5;
            // 
            // money_value
            // 
            this.money_value.Location = new System.Drawing.Point(411, 51);
            this.money_value.Name = "money_value";
            this.money_value.Size = new System.Drawing.Size(177, 20);
            this.money_value.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(408, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Soldi totali ";
            // 
            // money_type
            // 
            this.money_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.money_type.Location = new System.Drawing.Point(308, 116);
            this.money_type.Name = "money_type";
            this.money_type.Size = new System.Drawing.Size(470, 23);
            this.money_type.TabIndex = 8;
            this.money_type.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.money_type);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.money_value);
            this.Controls.Add(this.num_value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_value);
            this.Controls.Add(this.btn_inserisci);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inserisci;
        private System.Windows.Forms.TextBox text_value;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num_value;
        private System.Windows.Forms.TextBox money_value;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label money_type;
    }
}

