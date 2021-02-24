using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_030_Delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Dichiarazione del delegate che, nel nostro caso, accetta 2 parametri interi e returna un valore intero

        public delegate int Operazione(int op1, int op2);
        public int Somma (int x, int y)
        {
            return x + y;
        }
        public int Sottrazione(int x, int y)
        {
            return x - y;
        }
        public int Prodotto(int x, int y)
        {
            return x * y;
        }

        private void BtnSomma_Click(object sender, EventArgs e)
        {
            //metodo 1 per delegate
            //istazione delegate e passo nome della funzione come parametro
            Operazione op = new Operazione(Somma);//Somma è funzione puntata da delegate

            //richiamo delegate che eseguirà la funzione somma
            MessageBox.Show("Somma: " + op(10,15).ToString());
        }

        private void BtnProdotto_Click(object sender, EventArgs e)
        {
            //Metodo 2: istanzio il delegato
            Operazione op = Prodotto;
            MessageBox.Show("Prodotto: " + op(10, 15).ToString());
        }

        private void BtnSottrazione_Click(object sender, EventArgs e)
        {

        }
    }
}
