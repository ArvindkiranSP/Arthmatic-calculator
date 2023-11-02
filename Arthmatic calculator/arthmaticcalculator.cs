using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthmatic_calculator
{
    internal class arthmaticcalculator
    {
        public int GetResult(int x, int y, string operaters) 
        { 
            var result = 0;
            switch (operaters) 
            {
                case "+":
                    {
                        result = x + y;
                       return result;
                    }
                    case "-":
                    {
                        result = x - y;
                        return result;
                    }
                    case "*":
                    {
                        result = x * y;
                        return result;
                    }
                    case "/":
                    
                    {
                        result = x / y;
                        return result;
                    }
                default:
                    {
                        return  0;
                    }

            }
        }
    }
}
