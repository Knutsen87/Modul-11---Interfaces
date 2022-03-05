using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_11___Interfaces
{
    class E_Auto : IKraftfahrzeug
    {
        public string Hersteller { get; set; }
        public int MaxGeschwindigkeit { get; set ; }

        public void Bremsen()
        {
            Console.WriteLine("Das Elektro-Auto bremst.");
        }

        public void Fahren()
        {
            Console.WriteLine("Das Elektro-Auto fährt.");
        }
    }
}
