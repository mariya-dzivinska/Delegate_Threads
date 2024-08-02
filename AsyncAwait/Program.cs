namespace AsyncAwait
{
    using System.Diagnostics;
    using System.Runtime.InteropServices.JavaScript;
    using System.Threading;
    using Stopwatch = System.Diagnostics.Stopwatch;

    internal class Program
    {
        static readonly object lockObject = new object();

        static async Task Main(string[] args)
        {

            var a = new MonitorSample();

            string i = "one";

            var t1 = new Thread(() =>
            {
                lock (lockObject)
                {
                    Add(i);
                    while(true){}
                }
            });

            var t2 = new Thread(() =>
            {
                lock (lockObject)
                {
                    i = "name";
                    Add(i);
                }
            });

            t1.Start();
            //Thread.Sleep(1000);
            t2.Start();

            void Add(string i)
            {
                if (i == "one")
                {
                    Thread.Sleep(100);
                    Console.WriteLine("t1: i> 0, i = " + i);
                    i = "two";

                    Console.WriteLine("t1: , i = " + i);
                }
                else
                {
                    Console.WriteLine("t2: i<= 0, i = " + i);
                }
            }

            Console.ReadLine();



            var helper = new BreakfastHelper();

            Stopwatch s = Stopwatch.StartNew();

            helper.PoorCoffee();
            helper.HeatPan();
            helper.MakeToast();

            s.Stop();

            Console.WriteLine("time1: "+ s.ElapsedMilliseconds);


            //async await
            s.Restart();

            await helper.PoorCoffee1();

            Console.WriteLine("1: ");
            Console.WriteLine("2: " );
            Console.WriteLine("3: ");

            await helper.HeatPan1();
            await helper.MakeToast1();

            s.Stop();
            Console.WriteLine("time2: " + s.ElapsedMilliseconds);


            s.Restart();

            //parallel

            var task0 = Task.Factory.StartNew(async () =>
            {
                Console.WriteLine("Poor coffee: " + Thread.CurrentThread.ManagedThreadId);
                await Task.Delay(500);
            });

            var task1 = Task.Factory.StartNew(async () =>
            {
                Console.WriteLine("Heat pan: " + Thread.CurrentThread.ManagedThreadId);
                await Task.Delay(1000);
            });

            var task2 = Task.Factory.StartNew(async () =>
            {
                Console.WriteLine("Make toast: " + Thread.CurrentThread.ManagedThreadId);
                await Task.Delay(500);
            });

            await task1;
            await task2;
            await task0;


            s.Stop();
            Console.WriteLine("time3 parallel: " + s.ElapsedMilliseconds);
            var list = new List<Task>();
            list.Add(task1);
            list.Add(task2);
            list.Add(task0);

            await Task.WhenAll(list);

            Console.ReadLine();
        }
    }
}
