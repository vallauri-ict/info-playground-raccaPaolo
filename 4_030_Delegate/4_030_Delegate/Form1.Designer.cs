
namespace _4_030_Delegate
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
            this.BtnSomma = new System.Windows.Forms.Button();
            this.BtnProdotto = new System.Windows.Forms.Button();
            this.BtnSottrazione = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSomma
            // 
            this.BtnSomma.Location = new System.Drawing.Point(13, 13);
            this.BtnSomma.Name = "BtnSomma";
            this.BtnSomma.Size = new System.Drawing.Size(75, 23);
            this.BtnSomma.TabIndex = 0;
            this.BtnSomma.Text = "+";
            this.BtnSomma.UseVisualStyleBackColor = true;
            this.BtnSomma.Click += new System.EventHandler(this.BtnSomma_Click);
            // 
            // BtnProdotto
            // 
            this.BtnProdotto.Location = new System.Drawing.Point(94, 13);
            this.BtnProdotto.Name = "BtnProdotto";
            this.BtnProdotto.Size = new System.Drawing.Size(75, 23);
            this.BtnProdotto.TabIndex = 1;
            this.BtnProdotto.Text = "*";
            this.BtnProdotto.UseVisualStyleBackColor = true;
            this.BtnProdotto.Click += new System.EventHandler(this.BtnProdotto_Click);
            // 
            // BtnSottrazione
            // 
            this.BtnSottrazione.Location = new System.Drawing.Point(175, 13);
            this.BtnSottrazione.Name = "BtnSottrazione";
            this.BtnSottrazione.Size = new System.Drawing.Size(75, 23);
            this.BtnSottrazione.TabIndex = 2;
            this.BtnSottrazione.Text = "-";
            this.BtnSottrazione.UseVisualStyleBackColor = true;
            this.BtnSottrazione.Click += new System.EventHandler(this.BtnSottrazione_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSottrazione);
            this.Controls.Add(this.BtnProdotto);
            this.Controls.Add(this.BtnSomma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSomma;
        private System.Windows.Forms.Button BtnProdotto;
        private System.Windows.Forms.Button BtnSottrazione;
    }
}

