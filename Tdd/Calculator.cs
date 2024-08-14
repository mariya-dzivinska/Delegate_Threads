using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tdd
{
    public class Calculator
    {
        private readonly ValueManager manager;

        public Calculator(ValueManager _manager)
        {
            manager = _manager;
        }


        public int Sum(int a, int b)
        {
            return a + b;
        }

        public int SumWithOneValue(int a)
        {
            if (a == 0)
            {
                throw new FileNotFoundException();
            }

            var b = manager.GetValue(a);
            return a + b;
        }

        public int Substract(int a, int b)
        {
            return a - b;
        }
    }
}
