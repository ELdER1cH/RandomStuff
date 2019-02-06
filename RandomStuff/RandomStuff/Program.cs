using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace RandomStuff
{
    class Program
    {
        static int loadingtime = 3;
        static void Main(string[] args)
        {


            Start();
        }
        static void Textwiederholung()
        {


            string wiederholung = "y";
            Random FarbWahl = new Random();
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            int Farblauf = 1;

            //----------------------------------------------------------------------------------------------------------
            while (wiederholung == "y")
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Sie haben die Textwiederholung gewählt");
                    Console.WriteLine("--------------------------------------");
                    Console.Write("Welchen Text: ");
                    string text = Console.ReadLine();
                    Console.Write("Wie oft möchten sie den Text wiederholen: ");
                    int repeat = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Farboptionen: ");
                    Console.WriteLine("--------------");
                    Console.WriteLine("Einfarbig");
                    Console.WriteLine("Random");
                    Console.WriteLine("Hell");
                    Console.WriteLine("Dunkel");
                    Console.WriteLine("Farblauf");
                    string Farboptionen = Console.ReadLine();
                    ConsoleColor currentcolor = Console.ForegroundColor;
                    Loading(loadingtime);
                    while (repeat > 0)
                    {
                        //----------------------------------------------------------------------------------------------------------
                        switch (Farboptionen)
                        {
                            case ("Einfarbig"):
                                break;
                            case ("Random"):
                                Console.ForegroundColor = colors[FarbWahl.Next(1, 16)];
                                break;
                            case ("Hell"):
                                Console.ForegroundColor = colors[FarbWahl.Next(8, 16)];
                                break;
                            case ("Dunkel"):
                                Console.ForegroundColor = colors[FarbWahl.Next(1, 7)];
                                break;
                            case ("Farblauf"):
                                Console.ForegroundColor = colors[Farblauf];
                                Farblauf++;
                                if (Farblauf >= 16)
                                {
                                    Farblauf = 1;
                                }
                                break;
                        }
                        //----------------------------------------------------------------------------------------------------------
                        repeat--;
                        Console.WriteLine(text);
                        Thread.Sleep(20);
                    }
                    Console.ForegroundColor = currentcolor;
                }
                //----------------------------------------------------------------------------------------------------------
                catch (Exception e)
                {
                    ConsoleColor currentcolor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fehler :" + e.Message);
                    Console.ForegroundColor = currentcolor;
                }
                //----------------------------------------------------------------------------------------------------------
                Console.WriteLine("Möchten sie das Programm wiederholen (y/n)");
                wiederholung = Console.ReadLine();
                Console.Clear();
                Start();

            }
        }
        static void RandomZahlen()
        {
            int AnzahlZahlen;
            int MinimaleZahl;
            int MaximaleZahl;
            int Verzögerung;
            int Farblauf = 1;
            string repeat = "y";
            Random Zufall = new Random();
            Random FarbWahl = new Random();
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

            //----------------------------------------------------------------------------------------
            Console.Clear();
            while (repeat == "y")
            {
                try
                {
                    Console.WriteLine("Sie haben RandomZahlen gewählt");
                    Console.WriteLine("--------------------------------------");
                    Console.Write("Wie viele Zahlen wollen sie generieren: ");
                    AnzahlZahlen = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Was soll die kleinstmögliche Zahl sein: ");
                    MinimaleZahl = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Was soll die größtmögliche Zahl sein: ");
                    MaximaleZahl = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Wie groß soll die Verzögerung sein: ");
                    Verzögerung = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Farboptionen: ");
                    Console.WriteLine("--------------");
                    Console.WriteLine("Einfarbig");
                    Console.WriteLine("Random");
                    Console.WriteLine("Hell");
                    Console.WriteLine("Dunkel");
                    Console.WriteLine("Farblauf");
                    string Farboptionen = Console.ReadLine();
                    ConsoleColor currentcolor = Console.ForegroundColor;
                    //----------------------------------------------------------------------------------------
                    Loading(loadingtime);
                    while (AnzahlZahlen > 0)
                    {
                        AnzahlZahlen--;
                        switch (Farboptionen)
                        {
                            case ("Einfarbig"):
                                break;
                            case ("Random"):
                                Console.ForegroundColor = colors[FarbWahl.Next(1, 16)];
                                break;
                            case ("Hell"):
                                Console.ForegroundColor = colors[FarbWahl.Next(8, 16)];
                                break;
                            case ("Dunkel"):
                                Console.ForegroundColor = colors[FarbWahl.Next(1, 7)];
                                break;
                            case ("Farblauf"):
                                Console.ForegroundColor = colors[Farblauf];
                                Farblauf++;
                                if (Farblauf >= 16)
                                {
                                    Farblauf = 1;
                                }
                                break;
                        }

                        Console.Write(Zufall.Next(MinimaleZahl, MaximaleZahl));
                        Thread.Sleep(Verzögerung);
                    }
                    //----------------------------------------------------------------------------------------
                    Console.ForegroundColor = currentcolor;
                    Console.WriteLine();
                    Console.WriteLine("Möchten sie das Programm wiederholen");
                    repeat = Console.ReadLine();
                }
                catch (Exception e)
                {
                    ConsoleColor currentcolor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fehler :" + e.Message);
                    Console.ForegroundColor = currentcolor;
                }

            }
            //----------------------------------------------------------------------------------------
            Console.Clear();
            Start();

        }
        static void RandomBuchstaben()
        {
            int AnzahlBuchstaben;
            Random Buchstabe = new Random();
            char[] Buchstaben = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            string repeat = "y";
            Random FarbWahl = new Random();
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            int Farblauf = 1;

            //----------------------------------------------------------------------------------------
            Console.Clear();
            Loading(loadingtime);
            while (repeat == "y")
            {
                try
                {
                    Console.WriteLine("Sie haben Random Buchstaben gewählt");
                    Console.WriteLine("--------------------------------------");
                    Console.Write("Wie viele Buchstaben möchtest du schreiben: ");
                    AnzahlBuchstaben = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Mit was für einer Verzögerung:");
                    int Verzögerung = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Farboptionen: ");
                    Console.WriteLine("--------------");
                    Console.WriteLine("Einfarbig");
                    Console.WriteLine("Random");
                    Console.WriteLine("Hell");
                    Console.WriteLine("Dunkel");
                    Console.WriteLine("Farblauf");
                    string Farboptionen = Console.ReadLine();
                    ConsoleColor currentcolor = Console.ForegroundColor;
                    while (AnzahlBuchstaben > 0)
                    {
                        AnzahlBuchstaben--;
                        switch (Farboptionen)
                        {
                            case ("Einfarbig"):
                                break;
                            case ("Random"):
                                Console.ForegroundColor = colors[FarbWahl.Next(1, 16)];
                                break;
                            case ("Hell"):
                                Console.ForegroundColor = colors[FarbWahl.Next(8, 16)];
                                break;
                            case ("Dunkel"):
                                Console.ForegroundColor = colors[FarbWahl.Next(1, 7)];
                                break;
                            case ("Farblauf"):
                                Console.ForegroundColor = colors[Farblauf];
                                Farblauf++;
                                if (Farblauf >= 16)
                                {
                                    Farblauf = 1;
                                }
                                break;
                        }
                        Console.Write(Buchstaben[Buchstabe.Next(0, 23)]);
                        Thread.Sleep(Verzögerung);

                    }
                    //----------------------------------------------------------------------------------------
                    Console.ForegroundColor = currentcolor;
                    Console.WriteLine();
                    Console.WriteLine("Möchten sie das Programm wiederholen (y/n)");
                    repeat = Console.ReadLine();
                }
                catch (Exception e)
                {
                    ConsoleColor currentcolor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fehler :" + e.Message);
                    Console.ForegroundColor = currentcolor;
                }
            }
            //----------------------------------------------------------------------------------------
            Console.Clear();


        }
        static void Start()
        {

            string Programm;
            //----------------------------------------------------------------------------------------
            Program e = new Program();
            Console.WriteLine("Welches Programm möchten sie ausführen?");
            Console.WriteLine("Es sind folgende Programme möglch:");
            Console.WriteLine("- Textwiederholung");
            Console.WriteLine("- RandomZahlen");
            Console.WriteLine("- RandomBuchstaben");
            Console.WriteLine("- Einstellungen");
            Console.WriteLine("- Programm beenden");
            Programm = Console.ReadLine();
            //----------------------------------------------------------------------------------------
            switch (Programm)
            {
                case ("Textwiederholung"):
                    Loading(loadingtime);
                    Textwiederholung();
                    break;

                case ("RandomZahlen"):
                    Loading(loadingtime);
                    RandomZahlen();
                    break;

                case ("RandomBuchstaben"):
                    Loading(loadingtime);
                    RandomBuchstaben();
                    break;

                case ("Einstellungen"):
                    Loading(loadingtime);
                    Einstellungen();
                    break;
                case ("Programm beenden"):
                    Environment.Exit(0);
                    break;
                //----------------------------------------------------------------------------------------
                default:
                    ConsoleColor currentcolor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Falsche Eingabe");
                    Console.ForegroundColor = currentcolor;
                    Thread.Sleep(2000);
                    Console.Clear();
                    Start();
                    break;
            }

            Console.ReadLine();
        }
        static void Einstellungen()

        {

            string einstellung;
            string schriftFarbe;
            int counter = 0;
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            //----------------------------------------------------------------------------------------
            Console.Clear();
            Console.WriteLine("Sie befinden sich in den Einstellungen");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Was möchten sie ändern?");
            Console.WriteLine("- Schriftfarbe");
            Console.WriteLine("- Ladezeit");
            Console.WriteLine("- Hauptmenu");

            einstellung = Console.ReadLine();
            //----------------------------------------------------------------------------------------
            switch (einstellung)
            {
                //----------------------------------------------------------------------------------------
                case ("Schriftfarbe"):
                    Console.Clear();
                    Console.WriteLine("Was für eine Schriftfarbe möchten sie haben?");
                    Console.WriteLine("--------------------------------------------");
                    foreach (var color in colors)
                    {
                        Console.WriteLine("- " + colors[counter]);
                        counter++;
                    }
                    Console.WriteLine("Einstellungen");
                    schriftFarbe = Console.ReadLine();
                    switch (schriftFarbe)
                    {
                        case ("Green"):
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Clear();
                            break;

                        case ("Black"):
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Clear();
                            break;
                        case ("Blue"):
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Clear();
                            break;
                        case ("Cyan"):
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Clear();
                            break;
                        case ("DarkBlue"):
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.Clear();
                            break;
                        case ("DarkCyan"):
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Clear();
                            break;
                        case ("DarkGray"):
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.Clear();
                            break;
                        case ("DarkGreen"):
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Clear();
                            break;
                        case ("DarkMagenta"):
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Clear();
                            break;
                        case ("DarkRed"):
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.Clear();
                            break;
                        case ("DarkYellow"):
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.Clear();
                            break;
                        case ("Gray"):
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Clear();
                            break;
                        case ("Magenta"):
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Clear();
                            break;
                        case ("Red"):
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Clear();
                            break;
                        case ("White"):
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Clear();
                            break;
                        case ("Yellow"):
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Clear();
                            break;
                        case ("Einstellungen"):
                            Console.Clear();
                            Einstellungen();
                            break;
                        default:
                            ConsoleColor currentcolor1 = Console.ForegroundColor;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Unbekannte Farbe");
                            Console.ForegroundColor = currentcolor1;
                            break;
                    }
                    break;
                //----------------------------------------------------------------------------------------
                case ("Ladezeit"):
                    Console.WriteLine("Wie lange soll die Ladezeit sein?");
                    Console.WriteLine("---------------------------------");
                    try
                    {
                        loadingtime = Convert.ToInt32(Console.ReadLine());

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Fehler: " + e.Message);
                    }
                    break;
                //----------------------------------------------------------------------------------------
                case ("Hauptmenu"):
                    Console.Clear();
                    Start();
                    break;
                //----------------------------------------------------------------------------------------
                default:
                    ConsoleColor currentcolor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Falsche einagbe");
                    Console.ForegroundColor = currentcolor;
                    break;

            }
            //----------------------------------------------------------------------------------------
            Console.WriteLine("Möchten sie in das Hauptmenü zurück?(y/n)");
            string Hauptmenüabfrage = Console.ReadLine();
            if (Hauptmenüabfrage == "y")
            {
                Console.Clear();
                Start();
            }
            else
            {
                Console.WriteLine("Möchten sie zu den Einstellungen wechseln?");
                string Einstellungsentscheidung = Console.ReadLine();
                if (Einstellungsentscheidung == "y")
                {
                    Console.Clear();
                    Einstellungen();
                }
                else;
            }

        }
        static void Loading(int Länge)
        {
            Console.Clear();
            for (int i = 0; i < Länge; i++)
            {
                Console.WriteLine("Loading");
                for (int a = 0; a < 3; a++)
                {
                    Console.CursorVisible = false;
                    Console.Write(".");
                    Thread.Sleep(200);
                }
                Console.Clear();
            }
            Console.CursorVisible = true;

        }
    }
}
    