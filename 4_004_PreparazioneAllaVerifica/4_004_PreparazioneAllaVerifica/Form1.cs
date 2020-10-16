﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_004_PreparazioneAllaVerifica
{
    public partial class formMain : Form
    {
        public FormFiglia ff;

        public formMain()
        {
            InitializeComponent();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "File/Load";
            loadBar();

        }

        private void loadBar()
        {
            if (toolStripProgressBar1.Value == 100)
            {
                toolStripProgressBar1.Value = 0;

            }
            toolStripProgressBar1.Value = 100;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "File/Save";
            loadBar();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormExit fe = new FormExit();
            if (fe.ShowDialog()==DialogResult.OK)
            {
                Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "File/UscitaAnnullata";
            }
        }

        private void form2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(txtNome,txtEta);
            if (f2.ShowDialog() == DialogResult.OK)//showDialog aspetta finisca f2
            {
                MessageBox.Show("Nome:" + f2.nome + "\nEtà:" + f2.eta);
                txtEta.Text = f2.eta;
                txtNome.Text = f2.nome;
            }
            else
            {
                MessageBox.Show("Operazione annullata");
            }
            toolStripStatusLabel1.Text = "File/ApriForm2";
        }

        private void formDinamicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fd = new Form();
            fd.Show();
            fd.Text = "Form dinamica";
            toolStripStatusLabel1.Text = "File/ApriFormDinamica";
        }

        private void formFigliaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //passo la txt alla form figlia
            ff= new FormFiglia(txtStringa);
            ff.Show();
        }

        private void formMDIToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void btnInviaStringa_Click(object sender, EventArgs e)
        {
            ff.TxtValue = txtStringa.Text;//richiama il set di TxtValue
        }

    }
}
