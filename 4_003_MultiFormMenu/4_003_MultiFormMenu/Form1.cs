using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_003_MultiFormMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //dato che tutte le txt sono readonly, le imposto tutte in readonly
            foreach (var txt in this.Controls.OfType<TextBox>())
            {
                txt.ReadOnly = true;
            }

        }

        private void passaTxtAFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2p = new Form2(txtInvia);//new istanza l'oggetto
            f2p.Text = "Form con TextBox";
            f2p.Show();
        }

        private void apriForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //form senza parametro
            Form2 f2 = new Form2();
            f2.Text = "Form senza parametro";
            f2.Show();

            //form con parametro
            Form2 f2p = new Form2(10);
            f2p.Text = "Form con parametro";
            f2p.Show();

            toolStripLbl.Text = "Apertura Form2";
        }

        private void apriForm2BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f2b = new Form();
            f2b.Text = "Form dinamica aperta";
            f2b.Show();
            toolStripLbl.Text = "Apertura Form Dinamica";
        }


        private void passaTxtAForm2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2p = new Form2(txtInvia);
            f2p.Text = "Form con parametro";
            f2p.Show();
            toolStripLbl.Text = "Apertura Form con Textbox";
        }


        private void apriFormModaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModale fm = new FormModale();
            if (fm.ShowDialog() == DialogResult.OK)
            {
                txtNome.Text = fm.nome;
                txtEta.Text = fm.eta;
                MessageBox.Show("Premuto OK");
            }
            else
            {
                txtNome.Text = "";
                txtEta.Text = "";
                MessageBox.Show("Premuto Annulla");
            }
            toolStripLbl.Text = "Apertura Form modale";
        }

        public void esciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModalEsci f = new FormModalEsci();
            f.Text = "Uscire";
            if (f.ShowDialog() == DialogResult.Yes)
            {
                Close();
            }
            toolStripLbl.Text = "Uscita";
        }
    }
}
