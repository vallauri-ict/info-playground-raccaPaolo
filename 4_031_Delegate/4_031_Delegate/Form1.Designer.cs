﻿
namespace _4_031_Delegate
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
            this.BtnSalva = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSalva
            // 
            this.BtnSalva.Location = new System.Drawing.Point(13, 13);
            this.BtnSalva.Name = "BtnSalva";
            this.BtnSalva.Size = new System.Drawing.Size(75, 23);
            this.BtnSalva.TabIndex = 0;
            this.BtnSalva.Text = "Salva";
            this.BtnSalva.UseVisualStyleBackColor = true;
            this.BtnSalva.Click += new System.EventHandler(this.BtnSalva_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSalva);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSalva;
    }
}

