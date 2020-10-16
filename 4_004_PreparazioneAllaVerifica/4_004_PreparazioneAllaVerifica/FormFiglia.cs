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

        public FormFiglia()
        {
            InitializeComponent();

        }

        private void btnInviaStringa_Click(object sender, EventArgs e)
        {
            formMain.txtPassata.Text = txtStringaFiglia.Text;
        }

        private void FormFiglia_Load(object sender, EventArgs e)
        {
            txt1= txtStringaFiglia;
        }


        //public void cambiaTesto()
        //{
        //    formMain.txtPassata = txt1;
        //}
    }
}
