using Kordamine_OOP_1;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Koduloom kass = new Koduloom("Murka", "punane", 'E', 5.5, 7, true);
kass.print_Info();
Koduloom kassKloon = new Koduloom(kass);
kassKloon.muuda_Nimi("MurkaKloon");
kassKloon.muuda_Sugu('I');
kassKloon.muuda_Elav(false);
kassKloon.print_Info();*/
Kass kass = new Kass("siiami", "Murka", "punane", 'E', 5.5, 7, true);
kass.print_Info();
Kass kassKloon = new Kass(kass);
kassKloon.muuda_Nimi("MurkaKloon");
kassKloon.muuda_Sugu('I');
kassKloon.muuda_Elav(false);
kassKloon.print_Info();