using System;

namespace _99Bottles
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Greeting();
            bottlesGame();
        }
        public static string CountBottles(int bottles)
        {
            
            bottles--;
            if (bottles >= 2)
            {
                string a = "Pass it around!\n";
                string b = bottles + " Bottle of Beer on the wall!\n"
                    + bottles + " Bottle of Beer on the wall!\n";
                string c = bottles + " Bottles of Beer!";
                return a + b + c;
            }
            else if (bottles == 1)
            {
                string a = "Pass it around!\n";                
                string b = bottles + " Bottle of Beer on the wall!\n"
                    + bottles + " Bottle of Beer on the wall!\n";
                string c = bottles + " Bottle of Beer!";
                return a + b + c;
            }
            else
                return "No more Beer!";
            
         }
        public static void Greeting()
        {
         
            Console.WriteLine("To sing the Beer song enter how many bottles you have.");
            Console.WriteLine("When you want to take one down type \"take one down.\"\n");
            Console.WriteLine("To start how many bottles? ");

        }

        public static void bottlesGame()
        {
            int bottles = Convert.ToInt32(Console.ReadLine());

            while (bottles > 0)
            {
            Console.WriteLine("Take one down?");
            string takeBottle = Console.ReadLine();

            
                if (takeBottle == "take one down")
                {
                    Console.WriteLine(CountBottles(bottles));
                    bottles--;
                }
                else { Console.WriteLine("Incorrect input"); }

            }
        }
    }
        
}
