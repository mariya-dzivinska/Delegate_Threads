using System.Diagnostics;
using System.Runtime.InteropServices.JavaScript;
using Stopwatch = System.Diagnostics.Stopwatch;

namespace AsyncAwait
{
    internal class Program
    {
        static readonly object lockObject = new object();


        static async Task Main(string[] args)
        {
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

          

            s.Stop();
            Console.WriteLine("time3 parallel: " + s.ElapsedMilliseconds);
            var list = new List<Task>();
            list.Add(task1);
            list.Add(task2);
            list.Add(task0);

            await Task.WhenAll(list);
            //Task.WaitAll(list, CancellationToken.None);

            Console.ReadLine();
        }
    }
}
