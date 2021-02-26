using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_031_Delegate
{

    public delegate void salvataggioEseguitoEventHandler(int id);
    class GestoreSalvataggio
    {
        public event salvataggioEseguitoEventHandler salvataggioEseguito;
        public void SalvaSuFile(int id)
        {
            System.Windows.Forms.MessageBox.Show("Sto eseguendo il salvataggio");
            salvataggioEseguito(id);
        }

    }
}
