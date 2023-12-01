//Použijte abstraktní třídy pro geometrická tělesa. Mějme abstraktní třídu Těleso s metodami VypočítejObjem, VypočítejPovrch. Každé těleso logicky tyto metody implementuje jinak.
//Může k tomu potřebovat i jiné vlastnosti.

using Geometricka_telesa;

bool isOver = false;

while (!isOver) 
{
    Console.WriteLine("Vyber si geometrické těleso:\n0 - Konec\n1 - Krychle\n2 - Kvadr\n3 - Koule\n4 - Valec");
    int.TryParse(Console.ReadLine(), out int inputNumberChoice);

    switch (inputNumberChoice)
    {
        case 0:
            isOver = true;
            break;
        case 1:
            Kostka krychle = new Kostka();

            krychle.NacteniOdUzivatele();
            Console.WriteLine($"Povrch krychle: {krychle.VypocitejPovrch()} mm2");
            Console.WriteLine($"Objem krychle: {krychle.Objem()} mm3");
            break;
        case 2:
            ObecnyKvadr kvadr = new ObecnyKvadr();
            kvadr.NacteniOdUzivatele();
            Console.WriteLine($"Povrch kvadru: {kvadr.VypocitejPovrch()} mm2");
            Console.WriteLine($"Objem kvadru: {kvadr.Objem()} mm3");
            break;
        case 3:
            Koule koule = new Koule();
            koule.NacteniOdUzivatele();
            Console.WriteLine($"Povrch koule: {koule.VypocitejPovrch()} mm2");
            Console.WriteLine($"Objem koule: {koule.Objem()} mm3");
            break;
        case 4:
            Valec valec = new Valec();
            valec.NacteniOdUzivatele();
            Console.WriteLine($"Povrch valce: {valec.VypocitejPovrch()} mm2");
            Console.WriteLine($"Objem valce: {valec.Objem()} mm3");
            break;
    }

}
        
