using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 5;

            while (counter > 0)
            {
                Console.WriteLine("Counter = {0}", counter);
                counter = counter-1;
            }

            counter = 100;

            do
            {


                Console.WriteLine("Counter = {0}", counter);
                counter++;

            } while (counter < 0);

            Console.Read();
        }
    }
}
