using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> palindromes = new List<int>();
            for (int x = 100; x < 1000; x++)
            {
                for (int y = 100; y < 1000; y++)
                {
                    int i = x * y;
                    string str = i.ToString();
                    if (str.Length % 2 == 0)
                    {
                        char[] chars = str.ToCharArray();
                        Array.Reverse(chars);
                        string strTest = new String(chars);
                        if (str == strTest)
                        {
                            palindromes.Add(i);
                        }
                    }
                }
            }

            Console.WriteLine(palindromes.OrderBy(o => o).Last());
            Console.Read();
        }
    }
}
