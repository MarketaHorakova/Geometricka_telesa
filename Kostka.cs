using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricka_telesa
{
    public class Kostka : Teleso
    {
        public double Strana;

        public override void NacteniOdUzivatele()
        {
            Console.WriteLine("Zadejte delku strany v mm: "); 
            double.TryParse(Console.ReadLine(), out Strana);
        }

        public override double Objem()
        {
            return Strana*Strana*Strana;
        }

        public override double VypocitejPovrch()
        {
            return 6*Strana*Strana;
        }
    }
}
