using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(args[0]);
            foreach (var line in lines)
            {
                if (line.Length == 0)
                {
                    continue;
                }
                int sum = 0;
                foreach (var digit in line)
                {
                    int number = (int)(Char.GetNumericValue(digit));
                    sum += number;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
