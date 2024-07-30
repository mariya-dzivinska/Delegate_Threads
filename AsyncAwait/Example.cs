using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class Example
    {
        private object lockObject = new object();

        public void Get()
        {
            Stopwatch s = new Stopwatch();

            int i = 0;

            s.Start();

            Parallel.For(1, 20, x =>
            {
                if (i > 10)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(0);
                    i = i + 10;
                }
            });

            Console.ReadLine();
        }
    }
}
