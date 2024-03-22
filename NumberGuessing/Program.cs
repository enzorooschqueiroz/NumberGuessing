using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();

            int winNum = r.Next(0, 100);
            int attempts = 0;

            bool win = false;

            do
            {

                Console.Write("Guess a number between 0 and 100 : ");
                string s = Console.ReadLine();

                int i = int.Parse(s); 

                if (i > winNum)
                {
                    Console.WriteLine("To high... guess lower");
                    attempts++;
                }
                else if (i < winNum)
                {
                    Console.WriteLine("To low... guess higher");
                    attempts++;
                }
                else
                {
                    attempts++;
                    Console.WriteLine("\nYOU GOT IT!!!");
                    Console.WriteLine("It took you only: " + attempts + " attempts" );
                    win = true; 
                }

            } while (win == false); 
        }
    }
}
