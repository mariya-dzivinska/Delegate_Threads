using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class InputManager
    {
        public string PrintMultiplyValue(int value1, int value2)
        {
            var result = value1 * value2;
            Console.WriteLine($"Multiply : {result}");
            return result.ToString();
        }
    }
}
