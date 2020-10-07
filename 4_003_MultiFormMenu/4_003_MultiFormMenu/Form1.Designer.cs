namespace _4_003_MultiFormMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menùToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriForm2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriForm2BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passaTxtAFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.apriFormModaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menùToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menùToolStripMenuItem
            // 
            this.menùToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apriForm2ToolStripMenuItem,
            this.apriForm2BToolStripMenuItem,
            this.passaTxtAFormToolStripMenuItem,
            this.apriFormModaleToolStripMenuItem});
            this.menùToolStripMenuItem.Name = "menùToolStripMenuItem";
            this.menùToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menùToolStripMenuItem.Text = "&Menù";
            // 
            // apriForm2ToolStripMenuItem
            // 
            this.apriForm2ToolStripMenuItem.Name = "apriForm2ToolStripMenuItem";
            this.apriForm2ToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.apriForm2ToolStripMenuItem.Text = "Apri Form &2";
            this.apriForm2ToolStripMenuItem.Click += new System.EventHandler(this.apriForm2ToolStripMenuItem_Click);
            // 
            // apriForm2BToolStripMenuItem
            // 
            this.apriForm2BToolStripMenuItem.Name = "apriForm2BToolStripMenuItem";
            this.apriForm2BToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.apriForm2BToolStripMenuItem.Text = "Apri Form 2&B";
            this.apriForm2BToolStripMenuItem.Click += new System.EventHandler(this.apriForm2BToolStripMenuItem_Click);
            // 
            // passaTxtAFormToolStripMenuItem
            // 
            this.passaTxtAFormToolStripMenuItem.Name = "passaTxtAFormToolStripMenuItem";
            this.passaTxtAFormToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.passaTxtAFormToolStripMenuItem.Text = "Passa &Txt a Form2";
            this.passaTxtAFormToolStripMenuItem.Click += new System.EventHandler(this.passaTxtAFormToolStripMenuItem_Click);
            // 
            // apriFormModaleToolStripMenuItem
            // 
            this.apriFormModaleToolStripMenuItem.Name = "apriFormModaleToolStripMenuItem";
            this.apriFormModaleToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.apriFormModaleToolStripMenuItem.Text = "Apri Form &Modale";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripLbl
            // 
            this.toolStripLbl.Name = "toolStripLbl";
            this.toolStripLbl.Size = new System.Drawing.Size(43, 17);
            this.toolStripLbl.Text = "Pronto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "TextBox1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menùToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriForm2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem apriForm2BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passaTxtAFormToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem apriFormModaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

