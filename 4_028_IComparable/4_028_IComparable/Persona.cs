using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_028_IComparable
{
    class Persona : IComparable
    {
        string nome;
        string cognome;
        string citta;

        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
        public string Citta { get => citta; set => citta = value; }

        public Persona(string nome, string cognome, string citta)
        {
            Nome = nome;
            Cognome = cognome;
            Citta = citta;
        }

        public int CompareTo(object obj)
        {
            if (obj==null)
            {
                return 1;
            }
            Persona p = (Persona)obj;
            return String.Compare(Cognome, p.Cognome, true);
        }
        public override string ToString()
        {
            return $"{Cognome} {Nome} {Citta}";
        }
    }
}
