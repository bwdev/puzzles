using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciNumbers
{
  class Program
  {
    static void Main(string[] args)
    {
      int result = 0;
      int cap = 4000000; //the given max

      int x = 0;
      int y = 1;
      int z = x + y;

      while (z < cap)
      {
        // x + y = z
        x = y; //replace value with y
        y = z; //replace value with the sum of x + y
        z = x + y;

        //check for even number
        if (y % 2 == 0)
        {
          result += y;
        }
      }

      Console.WriteLine(result);
      Console.Read();
    }
  }
}
