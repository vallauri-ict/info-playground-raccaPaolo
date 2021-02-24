
namespace _4_029_IComparer
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
            this.BtnOrdinaCognomeBtnOrdinaCognome = new System.Windows.Forms.Button();
            this.BtnOrdinaNome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOrdinaCognomeBtnOrdinaCognome
            // 
            this.BtnOrdinaCognomeBtnOrdinaCognome.Location = new System.Drawing.Point(13, 13);
            this.BtnOrdinaCognomeBtnOrdinaCognome.Name = "BtnOrdinaCognomeBtnOrdinaCognome";
            this.BtnOrdinaCognomeBtnOrdinaCognome.Size = new System.Drawing.Size(134, 23);
            this.BtnOrdinaCognomeBtnOrdinaCognome.TabIndex = 0;
            this.BtnOrdinaCognomeBtnOrdinaCognome.Text = "Ordina per cognome";
            this.BtnOrdinaCognomeBtnOrdinaCognome.UseVisualStyleBackColor = true;
            this.BtnOrdinaCognomeBtnOrdinaCognome.Click += new System.EventHandler(this.BtnOrdinaCognomeBtnOrdinaCognome_Click);
            // 
            // BtnOrdinaNome
            // 
            this.BtnOrdinaNome.Location = new System.Drawing.Point(12, 42);
            this.BtnOrdinaNome.Name = "BtnOrdinaNome";
            this.BtnOrdinaNome.Size = new System.Drawing.Size(134, 23);
            this.BtnOrdinaNome.TabIndex = 1;
            this.BtnOrdinaNome.Text = "Ordina per nome";
            this.BtnOrdinaNome.UseVisualStyleBackColor = true;
            this.BtnOrdinaNome.Click += new System.EventHandler(this.BtnOrdinaNome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 86);
            this.Controls.Add(this.BtnOrdinaNome);
            this.Controls.Add(this.BtnOrdinaCognomeBtnOrdinaCognome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOrdinaCognomeBtnOrdinaCognome;
        private System.Windows.Forms.Button BtnOrdinaNome;
    }
}

