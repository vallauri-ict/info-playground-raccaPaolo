
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_032_Delegate
{
    public delegate void OverMaxEventHandler(object sender, OverMaxEventArgs e);
    class Counter
    {
        public event OverMaxEventHandler OverMax;
        private int maxVal;
        public int cont = 0;
        public Counter(int n)
        {
            if (n>10)
            {
                throw new Exception("Il valore massimo è 10");
            }
            else
            {
                maxVal = n;
            }
        }
        public void Increment()
        {
            cont++;
            if (cont>=maxVal)
            {
                OverMaxEventArgs e = new OverMaxEventArgs(cont);
                OnOverMax(this, e);
            }
        }

        private void OnOverMax(object sender, OverMaxEventArgs e)
        {
            if (OverMax !=null)//se punta una funzione, è stato gestito da qualcuno al di fuori della classe
            {
                OverMax(sender, e);
            }
        }
    }
}
