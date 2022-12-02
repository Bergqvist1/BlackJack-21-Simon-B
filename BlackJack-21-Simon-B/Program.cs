using System;
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

                        Console.WriteLine("Välkommen till BlackJack, du kommer att få 2 slumpmässiga kort"); 
                        int dittkort1 = slumpkort.Next(1,11); Console.WriteLine("Ditt första kort är"+ " " + dittkort1);
                        int dittkort2 = slumpkort.Next(1, 11); Console.WriteLine("Ditt andra kort är"+ " " + dittkort2);
                        int dinaPoäng = dittkort1 + dittkort2;
                        Console.WriteLine("Dina poäng är"+ " " + dinaPoäng);
                        Console.WriteLine("Vill du dra ett till kort? Svara med j eller n");
                        string svar1 = Console.ReadLine();
                        if(svar1 == "j")
                        {
                            int dittkort3 = slumpkort.Next(1, 11);
                            Console.WriteLine("Ditt tredje kort är" + " " + dittkort3);
                            int dinaPoäng2 = dittkort3 + dinaPoäng;
                            Console.WriteLine("Dina poämng är nu " + " " + dinaPoäng2);
                        }

                        break;
                    
                    
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
