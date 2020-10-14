using System;
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
        public TextBox txt1;
        public string value;

        public FormFiglia(TextBox txtStringa)
        {
            InitializeComponent();
            txt1 = txtStringa;
        }

        private void btnInviaStringa_Click(object sender, EventArgs e)
        {
            txt1.Text = txtStringaFiglia.Text;
        }


        //public void cambiaTesto(string testo)
        //{
        //    txtStringaFiglia.Text = ;
        //}
    }
}
