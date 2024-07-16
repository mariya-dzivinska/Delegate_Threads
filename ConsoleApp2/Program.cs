using System.Collections.Immutable;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp2
{
    internal class Program
    {
        public delegate string SampleDelegate(int i1, int i2);

        


        

        static void Main(string[] args)
        {
            Action<int, int> printAction = Sample;
            
            void Sample(int i1, int i2)
            {
                Console.WriteLine(i1 + i2);
            }


            Func<string, string, bool> funcSample = SampleFunc;

            bool SampleFunc(string s1, string s2)
            {
                return s1 == s2;
            }

            //Console.WriteLine("Method");
            //GetValue(1, 2);

            SampleDelegate staticDelegate = new SampleDelegate(GetValue);
            //Console.WriteLine("Delegate");
            //staticDelegate(1, 4);


            MulticastDelegate d = null;

            var manager = new InputManager();
            var instanceDelegate = new SampleDelegate(manager.PrintMultiplyValue);
            //instanceDelegate(5, 3);

            SampleDelegate generalDelegate = null;
            //var a = Delegate.Combine(generalDelegate, staticDelegate);
            //var b = Delegate.Combine(a, instanceDelegate);
            //b.DynamicInvoke(7, 5);

            generalDelegate += staticDelegate;
            generalDelegate += instanceDelegate;

            //generalDelegate.Invoke(7, 5);


            generalDelegate -= instanceDelegate;
            //generalDelegate.Invoke(7, 5);


            var list = new List<string>();
            list.Add("Value1");
            list.Add("valUe2");
            list.Add("VAlue3");

            var element = list.Find(x => x.Id == @Id);
        }

        public static bool CheckIfExists(string a)
        {
            return a == "valUe2";
        }

        public static void Get(string a)
        {
            a = a.ToLower();
            Console.WriteLine(a);
        }

        public static string GetValue(int a, int b)
        {
            var sum = a + b;
            Console.WriteLine(sum);
            return sum.ToString();
        }
        









        /*

         public static bool IsChecked(object s)
        {
            return s == "2";
        }

        private static void Print(string obj)
        {
            Console.WriteLine(obj);
        }

         public delegate void PrintValue(string value);

        public static void WriteName(string name)
        {
            Console.WriteLine(name);
        }

        public delegate string StringDelegate(int s);

        public static string Get(int i)
        {
            Console.WriteLine(i.ToString() + " first method");
            return i.ToString();
        }

        public static string Get2(int i)
        { 
            Console.WriteLine(i.ToString() + " 2 method");
            return i.ToString();
        }

        public static string Get3(int i)
        {
            Console.WriteLine(i.ToString() + " 3 method");
            return i.ToString();
        } 
        
        PrintValue p3 = null;
            PrintValue p1 = new PrintValue(WriteName);
            PrintValue p2 = new PrintValue(new Class1().Write);
            p3 += p1;
            p3 += p2;

            p3("name");

            StringDelegate s = new StringDelegate(Get);
            StringDelegate s1 = Get2;
            StringDelegate s2 = new StringDelegate(Get3);
            StringDelegate s3 = new StringDelegate(new Class1().GetGeneral);

            var a = Delegate.Combine(s, s1);
            var b = Delegate.Combine(a, s2);
            var c = Delegate.Combine(b, s3);

            c.DynamicInvoke(4);

            //Console.WriteLine(s1(1));
            //Console.WriteLine("Hello, World!");

            void GetAll(StringDelegate s, int i)
            {
                i = i + 10;
                Console.WriteLine(s);
            }

            var list = new List<string>();
            list.Add("1");
            list.Add("2");

            Action<string> action = new Action<string>(Print);
            list.ForEach(action);

            var isA = list.Exists(x =>
            {
                if (x == "1")
                {
                    Console.WriteLine("no");
                    return false;
                }
                else if (x == "2")
                {
                    Console.WriteLine("yes");
                    return true;
                }
                else
                {
                    Console.WriteLine("no");
                    return true;
                }
            });*/
    }
}
