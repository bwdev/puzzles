using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplesofThreeAndFive
{
  class Program
  {
    static void Main(string[] args)
    {
      //Create a place to stash each multiple
      List<int> multiples = new List<int>();

      for (int i = 0; i < 1000; i++)
      {
        if ((i % 3 == 0) || (i % 5 == 0))
        {
          multiples.Add(i); //add the multiple to the list
        }
      }

      //print out the sum
      Console.WriteLine(multiples.Sum().ToString());
      Console.Read();
    }
  }
}
