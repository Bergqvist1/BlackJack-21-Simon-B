using System;
using System.Globalization;

namespace Blackjack_21
{
    class Program
    {
        static void Main(string[] args)
        {

            Random slumpkort = new Random();

            Console.WriteLine("Välkommen till blackajack");

            string menyVal = "0";
            while(menyVal != "4")
            {
                Console.WriteLine("Välj ett alternativ");
                Console.WriteLine("1: Spela Blackjack");
                Console.WriteLine("2: Visa senaste vinnaren");
                Console.WriteLine("3: Visa spelets regler");
                Console.WriteLine("4: Avsluta programmet");

                menyVal = Console.ReadLine();

                switch(menyVal)
                {
                    case "1":
                        
                        
                        int datornsPoäng = 0;
                        int spelarensPoäng = 0;
                        string spelareVal = "";
                        Console.WriteLine("Välkommen till BlackJack, du och datorn kommer att få 2 slumpmässiga kort.");
                        datornsPoäng += slumpkort.Next(1, 11);
                        datornsPoäng += slumpkort.Next(1, 11);
                        spelarensPoäng += slumpkort.Next(1, 11);
                        spelarensPoäng += slumpkort.Next(1, 11);

                        while (spelareVal != "n" && spelarensPoäng <= 21)
                        {

                            Console.WriteLine("Datorns poäng är:"+ " " + datornsPoäng);
                            Console.WriteLine("Dina poäng är:"+ " " + spelarensPoäng);
                            Console.WriteLine("Vill du dra ett till kort? svara med j eller n");
                            spelareVal = Console.ReadLine();

                            switch(spelareVal)
                            {



                                case "j":
                                    int extrakort = slumpkort.Next(1,11);
                                    spelarensPoäng += extrakort;
                                    Console.WriteLine("Du drog en:" + " " + extrakort + "a");
                                    Console.WriteLine("Ditt nya totala poäng är:" + spelarensPoäng);
                                    break;


                                case "n":
                                    break;

                                default:
                                    Console.WriteLine("Välj ett av alternativen");
                                    break;
                            }


                        }
                        break;
                       if(spelarensPoäng > 21)
                       {

                            Console.WriteLine("Du har tyvärr förlorat");
                            break;
                       }

                       while(datornsPoäng < spelarensPoäng && datornsPoäng <= 21) 
                       {

                            int datorextrakort = slumpkort.Next(1, 11);
                            datornsPoäng += datorextrakort;
                            Console.WriteLine("Datorn drog en"+ " " + datorextrakort + "n");
                       }

                        Console.WriteLine("Dina poäng är:"+ " " + spelarensPoäng);
                        Console.WriteLine("Datorns poäng är:" + " " + datornsPoäng);

                        if (datornsPoäng > 21)
                        {
                            Console.WriteLine("Grattis du har vunnit över datorn ");
                            Console.WriteLine("Skriv ditt namn så vi man kan se vem senaste vinnaren är");
                            string senastekungen = Console.ReadLine();
                        }

                        else
                        {
                            Console.WriteLine("Tyvärr kingen datorn vann över dig");
                        }
                    
                    case "2":
                        Console.WriteLine("Jag vann din n00b");
                        break;

                    case "3":
                        Console.WriteLine("Spelets regler är:");
                        break;

                    case "4":
                        Console.WriteLine("Hejdå :)");
                        break;

                    default:
                        Console.WriteLine("Du valde inte ett av alternativen");
                        break;
                }
            }
            



        }
    }
}
