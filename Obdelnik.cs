using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricka_telesa
{
    public class Obdelnik :ITvar
    {
        public double StranaA;
        public double StranaB;

        public void NacteniDatOdUzivatele ()
        {
            Console.WriteLine("Napis delku strany A v mm : ");
            double.TryParse(Console.ReadLine(), out double StranaA);
            Console.WriteLine("Napis delku strany B v mm : ");
            double.TryParse(Console.ReadLine(), out double StranaB);
        }

        public double Obsah()
        {
            return StranaA*StranaB;
        }

        public double Obvod()
        {
            return 2*(StranaA + StranaB);
        }

    }
}
