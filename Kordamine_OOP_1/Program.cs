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

/*Opilane Emma = new Opilane("Emma",Isik.sugu.naine,2007,59,9,"Ehte","head");
//Emma.print_Info();
//Console.WriteLine("Tema vanus on - {0}", Emma.arvutaVanus());

Opilane Vlad = new Opilane(Emma);
Vlad.muuda_Sugu(Isik.sugu.mees);
Vlad.muuda_Nimi("Vlad");
//Vlad.print_Info();
//Console.WriteLine("Tema vanus on - {0}", Emma.arvutaVanus());

Console.WriteLine();

Kutsekooliopilane Arina = new Kutsekooliopilane("Arina", Isik.sugu.naine, 2002, 68,"kooki",3, 60,1,2);
//Arina.print_Info2();
//Console.WriteLine("Tema vanus on - {0}", Arina.arvutaVanus());

Kutsekooliopilane Arina2 = new Kutsekooliopilane(Arina);
Arina2.muuda_eriala("tarkvaraarendaja");
Arina2.muuda_toetusi(2);
Arina2.muuda_pere(3);
Arina2.print_Info2();

Console.WriteLine();*/

Tootaja Kirill = new Tootaja("Kirill", Isik.sugu.mees, 1989, 89, "saali töötaja",2000,300,25,"Kristiine keskus");
Tootaja Dima = new Tootaja("Dima", Isik.sugu.mees, 1989, 89, "admin", 2000, 300, 25, "Kristiine keskus");
//Kirill.print_Info();
//Console.WriteLine("Tema vanus on - {0}", Kirill.arvutaVanus());

List<Tootaja> inimesed = new List<Tootaja>();
inimesed.Add(Dima);
inimesed.Add(Kirill);
StreamWriter to_file = new StreamWriter(@"..\..\..\Inimesed.txt", false);
foreach (Tootaja p in inimesed)
{
    p.print_Info();

    to_file.WriteLine(p.nimi + ", " + p.inimSugu +", " + p.synniAasta + ", " + p.kaal + ", " + p.amet + ", " + p.palk + ", " + p.maksuvaba + ", " + p.tulumaks + ", " + p.asutus + ", " + ";");
}
to_file.Close();
StreamReader from_file = new StreamReader(@"..\..\..\Inimesed.txt");
/*string text = from_file.ReadToEnd();
Console.WriteLine(text);
from_file.Close();*/
List<string> lines = new List<string>();
int n = from_file.ReadToEnd().Split(new char[] { '\n'}).Length;
Console.WriteLine("========== " + n + " ==========");
List<Tootaja> tootajad = new List<Tootaja>();
StreamReader sr = new StreamReader(@"..\..\..\Inimesed.txt");
string text;

while ((text = sr.ReadLine()) != null)
{
    string[] rida = text.Split(',');
    tootajad.Add(new Tootaja(rida[0], TextFailistEnumSugu(rida[1]), Converter(rida[2]), Converter(rida[3]), rida[4], Converter(rida[5]), Converter(rida[6]), Converter(rida[7]), rida[8]));
}
sr.Close();

foreach (var tootaja in tootajad)
{
    Console.WriteLine(tootaja.nimi + " " + tootaja.inimSugu + " " + tootaja.synniAasta + " " + tootaja.kaal + " " + tootaja.amet + " " + tootaja.palk + " " + tootaja.maksuvaba + " " + tootaja.tulumaks + " " + tootaja.asutus);
}
Console.ReadLine();
//kui klassis kasutame enam klassi andmete kirjeldamiseks
Isik.sugu TextFailistEnumSugu(string andmed)
{
    switch (andmed)
    {
        case "naine":
            return Isik.sugu.naine;
        default:
            return Isik.sugu.mees;
    }
}

int Converter(string variable)
{
    string num = variable;
    int Num = Int32.Parse(variable);
    return Num;
}


