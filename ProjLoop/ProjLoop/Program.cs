using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine("Polska");

            foreach (char ch in "Polska")
                Console.WriteLine(ch);

            Random r = new Random();
            bool isWork = true;
            while (isWork)
            {
                int number = r.Next(1, 10);
                Console.WriteLine(number);
                if (number == 5)
                    break;
            }

            Console.ReadKey();
        }
    }
}
