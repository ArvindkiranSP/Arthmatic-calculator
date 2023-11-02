using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthmatic_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = int.Parse(Console.ReadLine());
            var operater= Convert.ToString(Console.ReadLine());
            var input1= int.Parse(Console.ReadLine());

            arthmaticcalculator arthm = new arthmaticcalculator();
            var result = arthm.GetResult(input, input1, operater);

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
