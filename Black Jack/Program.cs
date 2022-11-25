using System;

namespace ____
{
    class Program
    {
        static void Main(string[] args)
        {
            // avancerad WIP
            int ess = 11;
            int kung = 10;
            int drotning = 10;
            int Kneckt = 10;    

            int[] value = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            string[] suits = { "Spader", "Hjärter", "Klöver", "Ruter" };

            Random rnd = new Random();

            bool sant =true;

            int playervalue = 0;
            int playerstart = 0;
            int pcstart = 0;    

            while (sant)
            {
                int value2 = value[rnd.Next(0, 11)]; 
                string suit2 = suits[rnd.Next(0, 4)];

                int value3 = value[rnd.Next(0, 11)];
                string suit3 = suits[rnd.Next(0, 4)];

                int value4 = value[rnd.Next(0, 11)];
                int value5 = value[rnd.Next(0, 11)]; 

                //Steg 1 
                Console.WriteLine("Välkommen till Black Jack");
                Console.WriteLine($"Dina startkort kommer att vara {suit2} {value2} och {suit3} {value3}");
                Console.WriteLine($"Du kommer att starta med {value2 + value3} poäng");
                Console.WriteLine("Vill du dra ett nytt kort (y/n)");
                string val1 = Console.ReadLine();
                val1.ToLower();

                if (val1 == "n")
                {
                    sant = false;
                }

                if (playerstart > 21)
                {
                    Console.WriteLine("Du förlorade");
                    break;
                }
                if(pcstart > 21)
                {
                    Console.WriteLine("Datorn förlorade");
                    break;
                }    

                 playerstart = value2 + value3;  
                 pcstart = value4 + value5;

                while (sant)
                {
                    //Steg 2 (spelaren tur)
                    int value6 = value[rnd.Next(0, 11)];
                    string suit4 = suits[rnd.Next(0, 4)];
                    playervalue = value6 + playerstart;
                    Console.WriteLine("Du har nu fått ett nytt kort");
                    Console.WriteLine($"Ditt nya kort kommer att vara {suit4} {value6}");
                    Console.WriteLine($"Du kommer nu ha {playervalue} poäng");
                    Console.WriteLine("Vill du dra ett nytt kort (y/n)");
                    string val2 = Console.ReadLine();
                    val2.ToLower();
                    playerstart = playervalue;
                    
                    if (val2 == "y")
                    {
                        sant = true;
                    }
                    if(val2 == "n")
                    {
                        sant=false;
                    }

                    if(playervalue> 21)
                    {
                        Console.WriteLine("Datron vann");
                        break;
                    }

                }

                while (true)
                {
                    //Steg 2 (Datorn tur)
                    int value7 = value[rnd.Next(0, 11)];
                    string suit5 = suits[rnd.Next(0, 4)];

                    Console.WriteLine($"Datron drog ett {suit5} {value7}");
                    Console.WriteLine($"Datorn slutade på {value7 + pcstart} poäng");
                    Console.WriteLine($"Du slutade med {playervalue} poäng");

                    int PCend = value7 + pcstart;
                    if (PCend > 15) break;
                }
            }
        }
    }
}



