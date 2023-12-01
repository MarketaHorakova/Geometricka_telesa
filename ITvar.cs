using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometricka_telesa
{
    public interface ITvar
    {
        void NacteniDatOdUzivatele();

        double Obsah();

        double Obvod();

        void VypisNaKonzoli();
    }
}
