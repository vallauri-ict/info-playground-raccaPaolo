using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_MultiForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnForm2_Click(object sender, EventArgs e)
        {
            //apertura form senza parametro
            Form2 f2 = new Form2();//new istanza l'oggetto
            f2.Text = "Form senza parametro";
            f2.Show();

            //apertura form con parametro
            Form2 f2p = new Form2(10);//new istanza l'oggetto
            f2p.Text = "Form con parametro";
            f2p.Show();
        }

        private void btnForm2B_Click(object sender, EventArgs e)
        {
            Form f2b = new Form();//creo dinamicamente, senza aggiungere prima classe con classe di default di C#
            f2b.Text = "Form dinamica aperta";
            f2b.Show();
        }

        private void btnPassaTxt_Click(object sender, EventArgs e)
        {
            Form2 f2p = new Form2(txtPassata);//new istanza l'oggetto
            f2p.Text = "Form con parametro";
            f2p.Show();
        }
    }
}
