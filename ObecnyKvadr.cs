using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Geometricka_telesa
{
    public class ObecnyKvadr : Teleso
    {
        public double StranaA;
        public double StranaB;
        public double VyskaV;

        public override void NacteniOdUzivatele()
        {
            Console.WriteLine("Zadejte delku strany A v mm: ");
            double.TryParse(Console.ReadLine(), out StranaA);
            Console.WriteLine("Zadejte delku strany B v mm: ");
            double.TryParse(Console.ReadLine(), out StranaB);
            Console.WriteLine("Zadejte delku vysky V v mm: ");
            double.TryParse(Console.ReadLine(), out VyskaV);
        }
        public override double Objem()
        {
            return StranaA * StranaB * VyskaV;
        }

        public override double VypocitejPovrch()
        {
            return (2*StranaA * StranaB) + (2 * StranaA * VyskaV) + (2 * StranaB * VyskaV) ;
        }
    }
}
