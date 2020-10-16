﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_004_PreparazioneAllaVerifica
{
    public partial class FormFiglia : Form
    {
        private TextBox txtPadre;
        private string txtValue;

        public FormFiglia(TextBox txtPadre)
        {
            InitializeComponent();//da aggiungere sempre quando creo costruttore
            this.txtPadre = txtPadre;
        }

        public string TxtValue
        {
            get => txtValue;
            set {
                txtValue = value;
                txtStringaFiglia.Text = txtValue;
            }
        }

        public FormFiglia()
        {
            InitializeComponent();

        }

        private void btnInviaStringa_Click(object sender, EventArgs e)
        {
            txtPadre.Text = txtStringaFiglia.Text;
        }
    }
}
