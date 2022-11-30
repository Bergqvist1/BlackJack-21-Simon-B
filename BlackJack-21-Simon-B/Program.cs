using System;
namespace Blackjack_21
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Random slumpkort = new Random();

            Console.WriteLine("Välkommen till blackjack kingen");
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1: Spela Blackjack/21");
            Console.WriteLine("2: Senaste vinnaren");
            Console.WriteLine("3: Regler");
            Console.WriteLine("4: Avsluta programmet");

            int menyVal = int.Parse(Console.ReadLine());
            

            while(menyVal != 4)
            {


                switch(menyVal)
                {
                    case 1:  
                        Console.WriteLine("Välkommen till Blackjack, du kommer nu att få 2 start kort. Det kommer datorn också att få");
                        int dittkort1 = slumpkort.Next(11);
                        int dittkort2 = slumpkort.Next(11);
                        int dinaPoäng = dittkort1 + dittkort2;
                        Console.WriteLine("Dina poäng är:" + dinaPoäng);
                        break;


                    case 2:

                        break;

                    case 3:

                        break;

                    case 4:
                        break;
                }

            }





        }
    }
}
