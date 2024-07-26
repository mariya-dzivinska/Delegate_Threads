using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Theard2
{
    internal class Program
    {
        static  void Main(string[] args)
        {
            //Task.Run(() =>
            //{
            //    Console.WriteLine("100");
            //});



            //var task = new Task(() =>
            //{
            //    Console.WriteLine("start");
            //    //throw new NullReferenceException();
            //});

            //task.ContinueWith(t =>
            //    {
            //        Console.WriteLine("end");
            //    }
            //);



            ////Task.Factory.StartNew(() =>
            ////{
            ////    Console.WriteLine("300");
            ////});


            //task.Start();
            //task.Wait();



            //Thread t = new Thread(() =>
            //{
            //    Console.WriteLine("Thread ");
            //});

            //Thread backGround = new Thread(() =>
            //{
            //    Console.WriteLine("Background  start");
            //    Thread.Sleep(7000);
            //    Console.WriteLine("Background end");
            //});

            //backGround.IsBackground = true;
           


            //ThreadPool.QueueUserWorkItem(t =>
            //Console.WriteLine("ThreadPool task"));

            //t.Start();
            //backGround.Start();
            //backGround.Join();


            Stopwatch s = new Stopwatch();
            s.Start();

            for (int j = 0; j < 30; j++)
            {
                Console.WriteLine(j);
            }
            s.Stop();
            Console.WriteLine("not parallel:" + s.ElapsedMilliseconds);


            int i = 0;

            s.Start();

            Parallel.For(1, 30, x => { Console.WriteLine(i++); });

            s.Stop();
            Console.WriteLine("parallel:" + s.ElapsedMilliseconds);

            //Thread.Sleep(10000);
            Console.ReadLine();
        }
    }
}
