using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = 0;
            int iterator = 0;
            int tester;

            while (answer == 0)
            {
                tester = 20;
                while (iterator % tester == 0)
                {
                    tester -= 1;
                    if (tester == 1)
                    {
                        answer = iterator;
                        break;
                    }
                }
                iterator++;
            }

            Console.WriteLine(answer);
            Console.Read();
        }
    }
}
