using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricka_telesa
{
    public class Kruh : ITvar
    {
        public double Radius;
        public const double Pi = Math.PI;

        public void NacteniDatOdUzivatele()
        {
            Console.WriteLine("Napis radius r v mm : ");
            double.TryParse(Console.ReadLine(), out double Radius);

        }

        public double Obsah()
        {
            return Pi * Math.Pow(Radius,2);
        }

        public double Obvod()
        {
            return 2 * Pi * Radius;
        }

        //public void VypisNaKonzoli()
        //{
        //    Console.WriteLine($"Obsah: {Obsah()} mm2");
        //    Console.WriteLine($"Obvod: {Obvod()} mm");
        //}
    }
}
