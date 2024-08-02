namespace AsyncAwait
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    public class MonitorSample
    {
        public void Sample()
        {
            var t1 = new System.Threading.Thread(x =>
            {
                Add(1);
            });

            var t2 = new System.Threading.Thread(x =>
            {
                Add(-1);
            });


            t1.Start();
            t2.Start();

            void Add(int i)
            {
                if (i > 0)
                {
                    Console.WriteLine("t1:" + i);
                    Thread.Sleep(100);
                    i--;

                    Console.WriteLine("t1: " + i);
                }
                else
                {
                    Console.WriteLine("t2: i< 0, i = " + i);
                }
            }
        }
    }
}
