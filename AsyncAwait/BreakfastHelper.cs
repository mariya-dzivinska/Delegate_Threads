using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public class BreakfastHelper
    {
        public void PoorCoffee()
        {
            Console.WriteLine("Poor coffee: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(500);
        }

        public void HeatPan()
        {
            Console.WriteLine("Heat pan: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
        }

        public void MakeToast()
        {
            Console.WriteLine("Make toast: " + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(1000);
        }

        public async Task PoorCoffee1()
        {
            Console.WriteLine("Poor coffee: " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(500);
        }

        public async Task HeatPan1()
        {
            Console.WriteLine("Heat pan: " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(1000);
        }

        public async Task MakeToast1()
        {
            Console.WriteLine("Make toast: " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(500);
        }

        public async Task<string> HeatPan2()
        {
            Console.WriteLine("Heat pan: " + Thread.CurrentThread.ManagedThreadId);
            await Task.Delay(1000);
            return "pan has been heated";
        }
    }
}
