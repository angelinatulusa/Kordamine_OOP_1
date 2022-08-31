//*using Kordamine_OOP_1;
// See https://aka.ms/new-console-template for more information
using Kordamine_OOP_1;

Console.WriteLine("Hello, World!");
/*Koduloom kass = new Koduloom("Murka", "punane", 'E', 5.5, 7, true);
kass.print_Info();
Koduloom kassKloon = new Koduloom(kass);
kassKloon.muuda_Nimi("MurkaKloon");
kassKloon.muuda_Sugu('I');
kassKloon.muuda_Elav(false);
kassKloon.print_Info();*/

/*
Kass kass = new Kass("siiami", "Murka", "punane", Koduloom.sugu.isane, 5.5, 7, true);
kass.print_Info();
Kass kassKloon = new Kass(kass);
kassKloon.muuda_Nimi("MurkaKloon");
kassKloon.muuda_Sugu(Koduloom.sugu.emane);
kassKloon.muuda_Elav(false);
kassKloon.print_Info();*/

Opilane opilane = new Opilane("Emma",Isik.sugu.naine,2007,59,9,"Ehte");
opilane.print_Info();
Console.WriteLine("Tema vanus on - {0}", opilane.arvutaVanus());
//opilane.arvutaVanus();
Opilane opilane2 = new Opilane(opilane);
opilane2.muuda_Sugu(Isik.sugu.mees);
opilane2.muuda_Nimi("Vlad");
opilane2.print_Info();
Console.WriteLine("Tema vanus on - {0}", opilane.arvutaVanus());

Console.WriteLine();

Kutsekooliopilane kutsopilane = new Kutsekooliopilane("Arina", Isik.sugu.naine, 2002, 68,"kook",3);
kutsopilane.print_Info();
Console.WriteLine("Tema vanus on - {0}", kutsopilane.arvutaVanus());

Console.WriteLine();

Tootaja tootaja = new Tootaja("Kirill", Isik.sugu.mees, 1989, 89, "saali töötaja");

