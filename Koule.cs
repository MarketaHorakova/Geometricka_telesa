using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//  V = 4 / 3 π r³ S=4πr2

namespace Geometricka_telesa
{    
    public class Koule : Teleso
    {
        public double Radius;
        public const double PiNumber = Math.PI;

        public override void NacteniOdUzivatele()
        {
            Console.WriteLine("Zadej radius koule");
            double.TryParse(Console.ReadLine(), out Radius);
        }

        public override double Objem()
        {
            return 4/3 * PiNumber * Math.Pow(Radius,3);
        }

        public override double VypocitejPovrch()
        {
            return 4*PiNumber * Math.Pow(Radius,2);
        }
    }
}
