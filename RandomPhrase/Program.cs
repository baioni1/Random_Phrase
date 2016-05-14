using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomPhrase
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] responses = { "Ah Ha!", "Sirahn ++ !", "Not So Good!" };
            int max = responses.Length;
            string answer;
            Random random = new Random();
            do
            {
                int selectedNumber = random.Next(max);
                Console.WriteLine(responses[selectedNumber]);
                Console.WriteLine("Would you like to play again? Yes or No?");
                answer = (Console.ReadLine());

            }

            while (answer == "yes" );
            Console.WriteLine("Your Loss!");
        }
    }
}
