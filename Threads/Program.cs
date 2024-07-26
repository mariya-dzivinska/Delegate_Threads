using System.Runtime.CompilerServices;

namespace Threads
{
    internal class Program
    {
        public delegate string AlarmDelegete(DateTime date);

        public static AlarmDelegete OnNotificationRaise;

        static void Main(string[] args)
        {
            OnNotificationRaise += GetDate;

            var temp = Console.ReadLine();

            if (temp == "1")
            {
                OnNotificationRaise.Invoke(DateTime.Now);
            }
            else
            {
                Console.WriteLine("Event is not raised.");
            }

        }

        public static string GetDate(DateTime date)
        {
            var notification = $"It's time to wake up : {date}";
            Console.WriteLine(notification);
            return notification;
        }





        private static void Process()
        {
            Thread.Sleep(1000);
            var i = 1;
            Console.WriteLine(i++);
            Thread.Sleep(1000);
            Console.WriteLine(i++);
        }


        //Task
        /*
         
         Console.WriteLine("Start");
            var current = Thread.CurrentThread;

            ThreadPool.QueueUserWorkItem(x =>
            {
                Console.WriteLine("Pool");
                Thread.Sleep(1000);
                Console.WriteLine("Pool");
            });

            Thread t = new Thread(Process);
            Thread t2 = new Thread(x => 
            {
                Console.WriteLine("T2");
            });

            var task = new Task(x =>
            {
                Console.WriteLine("tAsk");
            },null);
            task.Start();

            t2.Start();

            //t.IsBackground = true;
            t.Start();
            Console.WriteLine("End");
         */
         

        /*
         * public static event EventHandler<EventArgs> Processing;

        public delegate int Get(int i);

        public static event Get ProcessGet;
        Console.WriteLine("Hello, World!");
            ProcessGet += new Get(OnProcessGet);
            Processing += new EventHandler<EventArgs>(Program_Processing);

            Console.WriteLine("Hello, World!1");
            var input = Console.ReadLine();

            if (input == "22")
            {
                Console.WriteLine("Raise event");
                ProcessGet.Invoke(22);
                Processing.Invoke(null, EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Do not raise");
            }
        
        private static int OnProcessGet(int i)
        {
            Console.WriteLine(i);
            return i;
        }

        private static void Program_Processing(object? sender, EventArgs e)
        {
            Console.WriteLine("Second event processing");
        }
         */
    }
}
