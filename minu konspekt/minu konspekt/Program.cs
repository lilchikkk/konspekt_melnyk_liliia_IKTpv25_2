using System.Runtime.InteropServices;

namespace minu_konspekt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");


            //muutujad matemaatilised tehted, IF, ELSE IF ja ELSE:

            //1. tuvasta sinu võrdluses null´ga
            Console.WriteLine("tere kasutaja, mis on sinu nimii");
            string nimi = Console.ReadLine();

            if (nimi == "")
            {
                Console.WriteLine("kasutaja  ei sisestanud oma nime");
            }
            else if (nimi != "")
            {
                Console.WriteLine("tere " + nimi + "!"); ;
            }
            else
            {
                Console.WriteLine("kasutaja  ei sisestanud oma nime");
            }

            //2. tuvasta arvuvahemik, võrsluses piirväärtustega, int/double/float andmetüüp
            Console.WriteLine(nimi + " , mis on sinu vanus?:");
            int kasutajavanus = int.Parse(Console.ReadLine());
            //if (kasutajavanus > 0)
            //{
            //    if (kasutajavanus < 18)
            //    {
            //        Console.WriteLine("kahjuks energjajooki sulle ei müüda, oled Monsterist ilma 🤣");
            //    }
            //    else
            //    {
            //        Console.WriteLine("saad osta Monsterit, YIPPIE");
            //    }
            //}
            //2.2 mitu tingimust ühe ifi sees kasutades 
            if(kasutajavanus > 0 && kasutajavanus < 18)
            {
                Console.WriteLine("kahjuks energjajooki sulle ei müüda, oled Monsterist ilma 🤣");
            }
            else
            {
                Console.WriteLine("saad osta Monsterit, YIPPIE");
            }
            //2.3 mitu vahemikku, if-elsif abil, double/float
            Console.WriteLine("sisesta oma pikkus ka, palun, " + nimi + ":");
            double pikkus = double.Parse(Console.ReadLine());
            if(pikkus < 1.00d)
            {
                Console.WriteLine("oled juntsu");
            }
            else if (pikkus <1.25d && pikkus > 1.00d)
            {
                Console.WriteLine("oled peaaegu allamateetrimes");
            }
            else if (pikkus < 1.50d && pikkus >1.25d)
            {
                Console.WriteLine("oioi, päkapikk enam ei oleg " + nimi + " !");
            }
            else if (pikkus < 1.75d && pikkus > 1.5d)
            {
                Console.WriteLine("oled enamasti standardpikkuses kui mitte just natuke lühike");
            }
            else if (pikkus < 2.00d && pikkus > 1.75d)
            {
                Console.WriteLine("pikk kolge, vaata et sa pead vastu uksepiita ära ei löö.");
            }
            else if (pikkus < 2.00d)
            {
                Console.WriteLine("täielik tulnukas, kuidas pilved välja näevad?");
            }
            else
            {
                Console.WriteLine("pikkust ei tunta");
            }

            /*
int arv1 = 100; //siin on arv 100
float arv2 = 25.5f;
int arv3 = 50;
int tulemus = arv1 + arv3; //siin on tehe
Console.WriteLine("tulemus: "+tulemus);
Console.WriteLine(" https://meet.google.com/xjy-drff-qbf"); //kuuvane
string tekst1 = "kakoy to t5ekst";
string tekst2 = "vtoroy tekst";
Console.WriteLine( tekst1 + tekst2); //esistav tekst
bool thisthing = false;
Console.WriteLine(thisthing);
string yourname = Console.ReadLine();
Console.WriteLine("Tere hommikust, öpilane: " + yourname);
*/
            Console.WriteLine("tere, sisesta esimene liidetav arv");
            int arv1 = int.Parse(Console.ReadLine());
            Console.WriteLine("tere, sisesta teine liidetav arv");
            int arv2 = int.Parse(Console.ReadLine());
            Console.WriteLine("sisesta tehemärk: / * + -");
            string tehtetyyp = Console.ReadLine();

            int tulemus = 0;
            if (tehtetyyp == "+")
            {
                tulemus = arv1 + arv2;
            }

            int tulemus = arv1 + arv2;
            Console.WriteLine(tulemus);

            if (tehtetyyp == "-")
            {
                tulemus = arv1 - arv2;
            }

            if (tehtetyyp == "*")
            {
                tulemus = arv1 * arv2;
            }
            else if (tehtetyyp == "/")
            {
                tulemus = arv1 / arv2;
            }

            else if (tehtetyyp == "^")
            {
                tulemus = (int)Math.Pow(arv1, arv2);
            }
            else
            {
                Console.WriteLine("Palun sisestada tehe, mida kalkulaator tuvastada oskab");
            }
            if (tulemus != 0)
            {
                Console.WriteLine(tulemus);
            }
            else
            {
                Console.WriteLine("Tulemus on 0, või üritasid teha tehet, mida kalkulaator ei tunne");
            }
            Console.WriteLine("Kas sa tahad õuna või banaani?");
            string vastus = Console.ReadLine();

            if (vastus == "õuna") ;
            {
                Console.WriteLine("🍎🍎🍎");
            }




        }
    }
}
