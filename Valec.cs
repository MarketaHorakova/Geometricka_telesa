using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 2 π r v + 2 π r²
namespace Geometricka_telesa
{
    public class Valec : Teleso
    {
        public double Radius;
        public double Heigh;
        public const double Pi = Math.PI;

        public override void NacteniOdUzivatele()
        {
            Console.WriteLine("Zadej radius valce");
            double.TryParse(Console.ReadLine(), out Radius);
            Console.WriteLine("Zadej vysku valce");
            double.TryParse(Console.ReadLine(), out Heigh);
        }

        public override double Objem()
        {
            return Pi * Math.Pow(Radius, 2) * Heigh;
        }

        public override double VypocitejPovrch()
        {
            return (2 * Pi * Math.Pow(Radius, 2)) + (Heigh * Pi * Radius * 2);
        }
    }
}
