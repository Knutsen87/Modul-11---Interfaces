using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_11___Interfaces
{
    class Auto : IKraftfahrzeug
    {
        public string Hersteller { get; set; }
        public int MaxGeschwindigkeit { get; set; }

        public void Fahren()
        {
            Console.WriteLine("Das Auto fährt.");
        }
        public void Bremsen()
        {
            Console.WriteLine("Das Auto bremst.");
        }
    }
}
