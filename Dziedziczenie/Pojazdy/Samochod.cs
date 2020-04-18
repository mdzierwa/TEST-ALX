using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Samochody
{
    class Samochod : Pojazd, IPojazd
    {
        public void Uruchom()
        {
            Console.WriteLine("silnik start");
        }

        public void Zatankuj()
        {
            Console.WriteLine("Zalej benzyna/ON/LPG");
        }

        public void Zatrzymaj()
        {
            Console.WriteLine("silnik stop");
        }
    }
}
