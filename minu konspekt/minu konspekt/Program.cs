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
            if (kasutajavanus > 0 && kasutajavanus < 18)
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
            if (pikkus < 1.00d)
            {
                Console.WriteLine("oled juntsu");
            }
            else if (pikkus < 1.25d && pikkus > 1.00d)
            {
                Console.WriteLine("oled peaaegu allamateetrimes");
            }
            else if (pikkus < 1.50d && pikkus > 1.25d)
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


            //4 parool, if ja string amdmetüüp
            Console.WriteLine("programmi edasiseks tööks sisesta:");
            string password = Console.ReadLine();

            if (password == "simsalabim")
            {
                Console.WriteLine("parool on õige, aarete laegas avend");
            }
            else if (password == "saatana" || password == "1234")
            {
                Console.WriteLine("parool on sobomatu, pakun ningi muu");
            }
            else
            {
                Console.WriteLine("parool on vale, proovi uuesti");
            }

            //5 värvivastus
            Console.WriteLine("milline värv sulle kõige rohkem meeldib?");
            string favoriteColour = Console.ReadLine();
            if (favoriteColour == "punane") ;
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            if (favoriteColour == "oranz") ;
            {
                Console.WriteLine("kahjuks oranzi ei ole");
            }
            if (favoriteColour == "kollane") ;
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            if (favoriteColour == "roheline") ;
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else
            {

            }
            // 
            // ISESEISEV TÖÖ
            Console.WriteLine("kas sa tahab ära mõõta pappkasti või õlitünni?");
            string valik = Console.ReadLine();

            if (valik == "õlitünni")
            {
                Console.WriteLine("kas sa teab põhja raadiust (r)või põhja läbimõõtu (d)?");
                string rvõid = Console.ReadLine();
                Console.WriteLine("mis on selle radius/läbimõõt? meetrites");
                double kasutajamõõt = double.Parse(Console.ReadLine());
                //kõrgust
                Console.WriteLine("kui kõrge on su yünni kaas? meetrites");
                double kõrgus = double.Parse(Console.ReadLine();
                //kanne pakkus
                Console.WriteLine("kui paks on su yünni kaas? meetrites");
                double kannepaksust = double.Parse(Console.ReadLine();
                // arvutab tünni.....


                double Sp = 0;
                if (rvõid == "R")
                {
                    Sp = Math.PI * (kasutajamõõt * kasutajamõõt);
                }
                else if (rvõid == "D")
                {
                    kasutajamõõt = kasutajamõõt / 2;
                    Sp = Math.PI * (kasutajamõõt * kasutajamõõt);
                }
                double V = 0;
                kõrgus = kõrgus - kannepaksust;
                V = Sp * kõrgus;
                // tunni ruumala on olemas ...
                kõrgus += kannepaksust;
            double Sk = 2 * Math.PI * kasutajamõõt * kõrgus;
                // tünni küljepindala....
                double S = Sp + Sk;
                Console.WriteLine($"sini tünn mahutab {V}\nTünni küljepindala on {Sk}\nTünni kogupindala on {S}");
                //{
                //# Kolija kalkulaator - Kirjuta programm mis:
                //#    - Küsib kasutajalt kas ta tahab ära mõõta pappkasti või õlitünni.
                //#    - olenevalt kasutaja sisestusest küsib ta:
                //#    - - tünni jaoks:
                //#    - - - kas kasutaja teab põhja raadiust (r) või põhja läbimõõtu (d):
                //#    - - - tünni kõrgust
                //#    - - - kaane paksust (kaane paksus võtab tünni kõrgusest maha, kuna kaan võtab tünni sisust natuke ruumi)
                //#    - - - Arvutab tünni ruumala mahu, tünni küljepindala, tünni kogupindala
                //#    - - kasti jaoks:
                //#    - - - Kas kast on kuubiku kujuline või risttahuka kujuline
                //#    - - - - kui on kuubik, siis küsib kasutajalt ainult küljepikkust
                //#    - - - - kui on risttahukas siis küsib kasutajalt:
                //#    - - - - - pikima külje pikkust, 
                //#    - - - - - lühima külje pikkust ja
                //#    - - - - - kasti kõrgust
                //#    - - arvutab vastavalt kasti kogupindala, mahu, ja pikima läbiva joone (d)
                //}

                Console.WriteLine("hapukapsas");
                // Console -> on modul C# mida me adresserime, Console aitab teha tegevusi käsureal
                //         -> näitab, et meil on vaja adresserida mingisugust funktsiooni  või meetodid
                //           mooduli "console" seest
                // "Writeline" -> funktioon mida me parasjagu kasutame
                //()           -> sulapaar mis omab funktsiooni tööks vajaliku infot
                //[]           ->tähistab masive
                //{}           ->koodoplook, tavaliselt kas pärast (if, else if) tingimust,
                //nemeskapei või funktsiooni kireldus
                // "hapukapsas"  -> paraameter mis antakse funktsioonileWriteLine töötlemiseks kaasa
                // Taane aitab areadajad aru saada; kuskohas millise koodiplooki sees kood
                //asub, see on vajalik ka kompilaatorile samal eesmärgil
                // ;            -> kõik koodilaused lõppevad komakoloogia, mis tähtistavad lause lõppu
                // //           -> tähistab komentari
                // /**/         -> tähistab mitmerealist komentaari võikom.reioni

                int muutuja = 3;
                // int          -> on mutuja nime ees olev andmetüübi kirjeldus mis näitab ära, millist
                // tüüpi andmed selle muutuja sees on
                // "mutuja"    -> on nimetus, ehk mutuja mis hoiab endas mingeid andmed, inimeloetava
                //sõnaga ja mille abil saab neid adreseerida koodi sees
                // =            -> üksik võrdusmärk omistab muutuja sisse vastava väärtuse mis asub teisepoolvõrdusmärgki
                //3             -> mutujale omistatav väärtlus

                /* võimalikud andmetüübid mida vaja võib minna */
                int a = 1; //int on täisarv
                decimal b = 2.1M; // decimal on kümnesüsteemis komakohaga arv
                float c = 3.9f; // float on 32_bitene komakohaga arv
                double d = 5.6; // double on 64_bitine kmakohaga arv
                char c1 = "a"; // üksainus täht või tähtemark mis tähtitatakse ülakomaga  ""
                string s = "tekst"; // tähtede koosne sõna või tekst 2komaga
                var x = "abc" // var on ebamäärese  andmetüübiga kohalik muutuja
                var y = 123; // ta võib omada endas teisi andmetüüpe
                const int z = 9;  // konstant tüüpi mutujaid ei saa muuta, nende sisu on read only


                //põhilised matematilised tehted
                int liitmine = 1 + 1; // liitmine; kaks arvu liidetakse kokku
                int lahutamune = 1 - 1; // lahutamine, kus esimesest srvust lahutatakse maha teine
                double korutamine = 1 * 2; // korrutamine kus teine arv korrutatakse esimene kordi
                double jagamine = 1 / 2; //jagamine esimene srv jagatakse mteise arvuga
                double astendamine = Math.Pow(2, 2); // astendamine esimene arv astendatakse teisega
                double juurimine = Math.Sqrt(2); // ruutjuur

                // muutuja nimed
                int arv = 0;
                string sõne = "abc";
                //string= abc; // kaitstud sõna kasutada ei saa

                // muutuja nimeks ei sobi järvenevad sõnad:
                //abstract, as. base, bool, break, byte, case,
                // catch, char, cheked, class, count, continue, decimal,
                //explicit, exetern, false, finally, fixed,float, for
                //foreach, goto, if, implicit, in, int, interface, internal,
                // is, lock, long,namespase, new, null, objwkt, operator,
                //out, override, params, private, projekted, public, readonly,
                //ref, return, sbyte, sealed, short, sizeof, stackalloc,
                //static, unlong,uncheked, unface,unshort,usinf, virtual,
                //string, struck, switch, this, throw, try, typeof,
                //void, volatile, while, 



                Console.WriteLine("tere, sisesta esimene liidetav arv");
                //adreseerimine moodulit "Console", punkti abil ütleme et kasutame funktsiooni Writeline
                //selle jaoks et öelda kasutajale sõnum mis asub funktsiooni nime järvel sulgude vahel
                // ümberisteuna jihmärkidega. kautajale esistav sõnum en tere sisesta oma esimenne arv
                int arv1 = int.Parse(Console.ReadLine());
                //instanrsieesine muutuja nime "arvi" ning selle ette anneme andmetüübiks int see
                //ülteb ära, et siin muutujas on täisarvatu sees. omistame mutujale võrdlusmärgi abil
                //väärtuse mille saame kasutejalt selle jaoks adreseerimine uuesti " console" moodulit
                //aga seekord on funktsiooni nimi "raedline. selleks et kä'surealpeas tulev arv programile
                ///tekstina ei näe välja küsime int moofduli sseest omakorda funktsiooni 2parse2 ning paneme
                /////readline funktsiooni Parse() sulgude vahele
                Console.WriteLine("tere, sisesta teine liidetav arv");
                //adreseerimine moodulit "Console", punkti abil ütleme et kasutame funktsiooni Writeline
                //selle jaoks et öelda kasutajale sõnum mis asub funktsiooni nime järvel sulgude vahel
                // ümberisteuna jihmärkidega. kautajale esistav sõnum en tere sisesta oma esimenne arv
                int arv2 = int.Parse(Console.ReadLine());
                //instanrsieesine muutuja nime "arvi" ning selle ette anneme andmetüübiks int see
                //ülteb ära, et siin muutujas on täisarvatu sees. omistame mutujale võrdlusmärgi abil
                //väärtuse mille saame kasutejalt selle jaoks adreseerimine uuesti " console" moodulit
                //aga seekord on funktsiooni nimi "raedline. selleks et kä'surealpeas tulev arv programile
                ///tekstina ei näe välja küsime int moofduli sseest omakorda funktsiooni 2parse2 ning paneme
                /////readline funktsiooni Parse() sulgude vahele
                Console.WriteLine("sisesta tehemärk: / * + -");
                //adreseerimine moodulit "Console" kooss " writeline2 funktsioonida et esitssda kasutajale
                //küsimuse "sisesta oma tehtemark. punktil abil saame moodulist Console, funktsiooni
                //WriteLine ning sulgude vahel ongi kasutajale esistav tekst, tekst ise on ka ümbeitsetud
                //jutusmärkidega lause lõpeb lauselõppemärgida
                string tehtetyyp = Console.ReadLine();
                //instantsieerimine muutuja nimega 2tehtetyyp", mille ette kirjutame andmetüübiks string
                //omistame võrdusmärgi abil sellese mutujasse kadutajalt sisendi mille saame kasutade
                //"Console" moodulis oleva ReadLine() funktsiooni abil, lause lõpeb

                int tulemus = 0;
                //instansieerime muutuja nimega tulemus, andmetüübiga int, omistame talle algse
                //väärtuse võrdusmärgi abil, milleks on 0. lause lõpeb.
                if (tehtetyyp == "+")
                //teeme tingimislause if, ning selle tingimuse määrame ära sudega mille vahel on
                // võrdsuskontroll. kontrollime kas muutuja tähtetüüp omad andmeid samal kujul
                // nagu võrdusmärkides teisel poolt olev tekst "+". siin lause ei lõõpe, kuna tegu ei
                // ole koodiga mis midagi kindlalt veel ära teeb
                {
                    tulemus = arv1 + arv2;
                }
                //peale tingimust on koodiplokk {} sulgude vahel, mis sisaldab endas ühte koodirida
                //selles lauses omistame muutujale "tulemus" võrdusmärgi abil liitmistehte tulemuse.
                //kus liidame kokku muutujad arv1 ja arv2 sisu. lause lõppeb.

                int tulemus = arv1 + arv2;

                Console.WriteLine(tulemus);

                else if (tehtetyyp == "-")
                //teeme sekundaarse tingimuslause else if ning määrame tema tingimuse ära sulgedega
                //sulgude vahel on vkontroll. kontrollime kas muutuja tehtetyyp omab andmeid
                //samal kujul nagu vm teisel pool olev tekst - kui eelnev tingimus ei
                //täitnud lause siin ei lõppe vaid tingimusele mjärgneb kodiplokk
                {
                    tulemus = arv1 - arv2;
                }
                //peale tingimust on koodiplokk {} loogiliste sulge vahel, mis sisaldab endas ühte
                //koodiriida selles lauses omistame muutujale "tulemus" vm abil lahutustrhte
                //tulemuse kus lahutume muutuja arv sees olevst värtusest maha arv2 muutujas
                //oleva värtuse lause lõpp


                else if (tehtetyyp == "*")
                //teeme sekundaarse tingimus lause else if ning märassme tema tingimuse ära sulgudega
                //sulgude vahel on vkontroll. kontrollime kas muutuja tehtetyyp omab andmeid
                //samal kujul nagu vm teisel pool olev tekst * kui eelnev tingimus ei
                //täitnud lause siin ei lõppe vaid tingimusele mjärgneb kodiplokk
                {
                    tulemus = arv1 * arv2;
                }
                //peale tingimust on koodiplokk {} loogiliste sulge vahel, mis sisaldab endas ühte
                //koodiriida selles lauses omistame muutujale "tulemus" vm abil korrutustehte
                //tulemuse kus lahutume muutuja arv1 sees olevst värtusest üks kordi
                //lause lõpp
                else if (tehtetyyp == "/")
                //teeme sekundaarse tingimus lause else if ning märassme tema tingimuse ära sulgudega
                //sulgude vahel on vkontroll. kontrollime kas muutuja tehtetyyp omab andmeid
                //samal kujul nagu vm teisel pool olev tekst / kui eelnev tingimus ei
                //täitnud lause siin ei lõppe vaid tingimusele mjärgneb kodiplokk
                {
                    tulemus = arv1 / arv2;
                }
                //peale tingimust on koodiplokk {} loogiliste sulge vahel, mis sisaldab endas ühte
                //koodiriida selles lauses omistame muutujale "tulemus" vm abil jagamistehte
                //tulemuse kus lahutume muutuja arv1 sees olevst värtusest muutuja arv2 jagajaga
                //lause lõpp

                else if (tehtetyyp == "^")
                //teeme sekundaarse tingimus lause else if ning märassme tema tingimuse ära sulgudega
                //sulgude vahel on vkontroll. kontrollime kas muutuja tehtetyyp omab andmeid
                //samal kujul nagu vm teisel pool olev tekst ^ kui eelnev tingimus ei
                //täitnud lause siin ei lõppe vaid tingimusele mjärgneb kodiplokk
                {
                    tulemus = (int)Math.Pow(arv1, arv2);
                }
                //peale tingimust on koodiplokk {} loogiliste sulge vahel, mis sisaldab endas ühte
                //koodiriida selles lauses omistatakse vm "tulemus" vm abil mille saame
                //Math moodulist pärineva funktsiooni pow() abil. math.pow() võid parameetrina
                //sisse astendaja. funktsiooni math.pow() väljund teistendatakse nii täisvarvus8
                //lause lõpp
                else
                //peale kõiki järetingimusi osaelse mida täidakse kõikide
                //muude tingimuslause osade mittetäitumisel. siin eraldi tingimust välja ei kirjutada
                //ning sellest tulenevalt ei ole ka sulge, järgeneb ainult koodipookk
                {
                    Console.WriteLine("Palun sisestada tehe, mida kalkulaator tuvastada oskab");
                }
                //peale else on koodiplokk {} loogiliste sulge vahel, mis sisaldab endas ühte
                //koodiriida selles koodides kasutame moodulist "console" punkti  abil 
                //"writeline" et öelda kasutajale "palun sisesta.." selle  jaoks on WriteLine funktsioonis parameetrina pundud muutuja
                //tulemus ilma tekstis teisendamata
                //lause lõpp
                //if (tulemus != 0)
                //{
                //    Console.WriteLine(tulemus);
                //}
                //else
                //{
                //    Console.writeline("tulemus on 0, või üritasid teha mida kalkulaator ei tunne")

                //}
                //string kasutajanimi = "";
                //do
                //{
                //    Console.WriteLine("palun sisesta oma kasutajanimi:");
                //    kasutajanimi = Console.ReadLine();
                //} while (kasutajanimi != "user1");
                //if (kasutajanimi == "user1")
                //{
                //    int ruuduSuurus = 0;

                //    do
                //    {
                //        Console.WriteLine("kui suurt ruutu saada tahad?");
                //        ruuduSuurus = int.Parse(Console.ReadLine());
                //    } while (ruuduSuurus < 0 || ruuduSuurus > 20);

                //    char reaKujund = '▓';
                //    string üksRida = "";
                //    int tsüklimuutuja = ruuduSuurus;

                //    do
                //    {
                //        üksRida = üksRida + "_" + reaKujund;
                //        tsüklimuutuja = tsüklimuutuja - 1;
                //    } while (tsüklimuutuja != 0);

                //    tsüklimuutuja = ruuduSuurus;

                //    do
                //    {
                //        Console.WriteLine(üksRida);
                //        tsüklimuutuja -= 1;
                //    } while (tsüklimuutuja != 0);

                //    Console.WriteLine($"palun siin on sinu ruut, suurusega {ruuduSuurus}x{ruuduSuurus}");
                //}
                Console.WriteLine("sisesta ostusumma");
                double ostusumma = double.Parse(Console.ReadLine());
                if (ostusumma> 100)
                {
                    Console.WriteLine("Sa saad 20% alahindlust!!!!!!!!!!!!")
                }
                else if(ostusumma < 101 && ostusumma > 50)
                {
                    Console.WriteLine("saad 10% allahindlust c:yay");
                }
                else if (ostusumma < 51 && ostusumma > 20)
                {
                    Console.WriteLine("allahindlust 5%");
                }
                else if (ostusumma < 21 && ostusumma > 0)
                {
                    Console.WriteLine("allahindlust ei saa");
                }
                else
                {
                    Console.WriteLine("sisestanud on viigane arv");
                }
                //tingimuslause osad
                if (true) { } //kaitsud sõna if kutsub eesle tingimuslause mille tingimus on sulgude vahel, ning järgneb
                              //koodiplokk tingimuse teostava koodiga
                else if (true) { } //kaitstud sõnad else ja if kutsavad eide tingimasule mille tingimus
                                   // on samamoodi sulgude vahel, ning millele pepad eelma alt kas if või else if  tingimuse täitumisel
                                   //ja eelneva mitteäitumisel, teotakse koodiploki sees olev kood.
                else { }// kaitstud sõna else kutsub else kutsub esile järgtingimusi millele peab eelmena kas if / else if , ning mille koodiplokki   sisu
                        //täidetakse kõikidele teiste if ja else if tingimuse läbikukkumisel.

                int option = 3; // ---------
                switch (option) //switch on kaitstud sõna allternatiivse tingimus kontrolli jaoks mida saab else-if asemel kasutada.
                                //sulgude vahele käib muutuja nimi , mille põhjal tingimuslik ümberliitus  toimub, siinu vahel
                                // ei ole tingimus ise ,vaid kõigest kontrollitav muutuja või omakorda sulgude vahel muu tingimus
                                // pärast lülitusvakult tileb koodoplokk
                {
                    case 1:  //koodiplokk sees on erinevad juhtmid süsestakse kaitstud sõna  case abil  antud  juhil kontrollitakse .
                             // kas muutuja option on väärtus 1; millele järgneb koloon . väljandades tingimuse täitmusel tehtava
                             //kooditegevuse algust
                        break;  // kui tegevus  on tehtud siis see on kõik
                    case 2:
                        break;
                    default: // default juhtmid täidetakse siis kui ülejäänud juhtmis ei kirjelda muutujas option olevat seisu
                        break; //ka lõppeb
                }


                /* sõne tööristad ja muud trkstiga seotud */
                string alfa = "a\nb";  // tekkitab ühe sõne sisse kus on sees üks \n omad kahte riida
                string beta = $"a{alfa}b"; //$ lubab kasutada muutujad loogiliste sulddega otse teksti sees on variant
                                            // formateeritud stringis

                /*loogilised tehted*/


                // && -> and loogiline  thehe mida kasutatatkse tingimusete kirjaldamisel , mning mis annab positiuvse vastuse (true  ) juhil  kui
                //mõelmaal pool && olevad tingimused on täited kui üks neist ei ole siis annab negatiiv vastuse (false)
                // || -> or loogiline tege mida kasutattakse tingimuste lirjeldamisel ning mis annab (true) siis kui
                // vähemat üks tingimus on täidetud negatiivne (false) tagatakse siis kui kõik tingimusel on täitama 
                // !-> not" loog´iline trhr mida kasutatakse tingimuse tulemuse inverteemiseks tulemus mis midu tagataks (true)
                //hüümargi abil tagastab (false ) ja vastupildi tulemus mis midu tagataks  true

                /*võrdlusoperaatorid*/

                // == -> on võrdne võrdusmärkidde ühel objekt peab vastama täpselt oma olemust teise pool oleva objektina ei ole sana nagu üks võrdusmärk omustab kaks võrdleb
                // != ei ole võrdne ühe pool objekt ei tohi  olla samal nagu võrdusmärgi teisel pool olev objekt
                // ta võib olla  ükskõik  mis muul kujul aga mitte võrdne objektiga samal kujul operatoor teeb kaks funktsiooni yah/ei
                // > -> on suure kui märgist vasakul pol olev objekt  peaks olema suurem kui paremal pool olev objekt
                // < -> on väiksem kui märgist vasakul pol olev objekt  peaks olema vähem kui paremal pool olev objekt
                //>= suuremvõrdne märgist vasaskul pol märgist olev objekt  peaks olema võrdne või suurem kui paremal pool olev objekt
                //>= vähemvõrdne märgist vasakul pol olev objekt  peaks olema vähemalt võrdne kui paremal pool olev objekt


                /*omistus operaaoriid*/
                int thing = 1; // üksik võrdusmärk muutuja väärtuse mida saab kasutada läbi muutuja nime 
                thing += 1; // üksik võrdusmärk omistab sisse väärtusse mida saab kasutada läbi muutujannime  osta võrdusmärgi teisel pool oleva arvu
                // asendab tehet thing +1 on kobinatsioon  matemaatilised tehtesed + ja omistamises -

                thing -= 1; // võrdusmärgi mille ees on miinus automaatselt lahutab muutujast maha võrdusmärgi trisel pool oleva arvu
                //asendab tehet thing 0 thinh -1  on kombin. - ja omistanutest =
                thing *= 2;// võrdusmärk mille ees on korrutusmärk * automaatselt korutab muutuja sissu võrdusmärgi teisel pool 
                // oleva arvu kordi aseendab teht thng = thing * 2 on kopmbinaatsioon matem. teh. * ja om. =
                thing /= 2; // võrdusmärk mille ees on jagamismärk * automaatselt jagab muutuja sissu võrdusmärgi teisel pool 
                // oleva arvu kordi aseendab teht thng = thing / 2 on kopmbinaatsioon matem. teh. / ja om. =
                thing++;//++ spetsifilised liitmiseks kiirtehte
                thing++; //++ spetsifilised lahutemiseks kiirtehte

                /*tsüüklid*/
                //do-while
                int dew = 0;
                do //do on kaitstud sõna mis alustab do while ts, pärast seda on koodiplokk {} ning ütleb see et tee seda koodi
                {
                    dew++
                } while (dew != 5); // niikaua kuni järel olevate sulgude vahel tingimus ei täitu, käivitatakse eelnev kood uuesti.


                //2, while
                int = i = 1; // tsüükli muutujamis aitab järge pidada while tsüükli  toimisel
                while (i < 5) // while on kaitstud sõna mis alustad while tsüükli  ariant ilma  do ning vajab alati välist
                    //tsüüklimuutujat antul jubul on selleks i, tsükli tingimus mis peale while sõna on asub sulgude vahel,
                    //siin kontroll tsüükli tood, läbi kindla tingimuse kasutades tsüüklimuutujas
                    // antud juhul  tsüükeltöötab niikaua kuni i ln väiksem kui 5 kui i saana suurus  nagu 5, siis tsüükel
                    //katkeb.



                        //koodiplokk kus midagi tehakse
                        i++;   //nini selejärel muudetakse tsmuutuja i olekut antud juhul liidetakse 1 juurde kiirtrhrga ++
            }


        }
    }
}