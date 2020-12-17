using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_020_PersoneStudenti
{
    class Studente : Persona
    {
        List<int> voti = new List<int>();
        
        public double Media()
        {
            int somma=0;
            foreach (var item in voti)
            {
                somma += item;
            }
            return (double)(somma / voti.Count());
        }
    }
}
