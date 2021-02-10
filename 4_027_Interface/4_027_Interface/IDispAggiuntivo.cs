using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_027_Interface
{
    interface IDispAggiuntivo
    {
        int id { get; set; }
        bool status { get; }
        void Connetti(string s);
        void Disconnetti(string s);
    }
}
